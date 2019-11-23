using GoogleSearchParser.Core;
using GoogleSearchParser.Core.Google;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Collections.Generic;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace GoogleSearchParser
{
    public partial class Form1 : Form
    {
        private ParserWorker<List<string>> parser = null;
        private IWebDriver driver = null;
        private List<string> urls = null;
        private Excel.Workbook excelWorkBook = null;
        private string filename = null;

        public Form1()
        {
            InitializeComponent();

            cbUpdateDate.SelectedIndex = 1; // 24 часа

            var driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;
            driver = new ChromeDriver(driverService, new ChromeOptions(), TimeSpan.FromMinutes(5));
            var googleParser = new GoogleParser();
            parser = new ParserWorker<List<string>>(googleParser, driver);
            
            googleParser.OnCaptchaContinue += Parser_OnCaptchaContinue;
            parser.OnCompleted += Parser_OnCompleted;
            parser.OnNewData += Parser_OnNewData;

            Excel.Application ex = new Excel.Application();
            ex.SheetsInNewWorkbook = 1;
            ex.DisplayAlerts = false;
            excelWorkBook = ex.Workbooks.Add();
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            if (fbDialog.ShowDialog() == DialogResult.OK)
            {
                tbSavePath.Text = fbDialog.SelectedPath;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbWords.Text) || string.IsNullOrWhiteSpace(tbFileName.Text))
            {
                MessageBox.Show("Все поля ввода должны быть заполненны", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if ((tbFileName.Text + ".xlsx").IndexOfAny(Path.GetInvalidFileNameChars()) != -1)
            {
                MessageBox.Show("Недопустимое имя файла", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newFilename = tbSavePath.Text + "\\" + tbFileName.Text + ".xlsx";

            if (File.Exists(newFilename))
            {
                MessageBox.Show("Файл с таким именем уже существует", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnStart.Enabled = false;
            btnSave.Enabled = false;
            gbParserWork.Enabled = true;
            btnStop.Enabled = true;

            // ui
            tbLog.AppendText("Парсер начал работу" + Environment.NewLine);
            lblReadyUrslCount.Text = "0";
            // end ui            

            if (filename != newFilename)
            {
                if (!string.IsNullOrWhiteSpace(filename))
                {
                    excelWorkBook.SaveAs(filename);
                }

                filename = newFilename;

                var application = excelWorkBook.Application;
                excelWorkBook.Close();
                excelWorkBook = application.Workbooks.Add();
            }

            urls = new List<string>();            
            parser.Settings = new GoogleSettings(
                tbWords.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries),
                GetUpdateDateFromCB());
            parser.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = false;

            parser.Abort();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string newFilename = tbSavePath.Text + "\\" + tbFileName.Text + ".xlsx";

            if (File.Exists(newFilename))
            {
                MessageBox.Show("Файл с таким именем уже существует", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            filename = newFilename;
            string warningText = "Внимание! Сохранение происходит автоматически при закрытие программы и изменении файла сохранения. Хотите продолжить?";

            if (MessageBox.Show(warningText, "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                // ui
                tbLog.AppendText("Сохранение в Excel" + Environment.NewLine);
                // end ui

                excelWorkBook.SaveAs(filename);

                btnSave.Enabled = false;
            }
        }

        private void Parser_OnCompleted(object currentParser)
        {
            if (urls.Count > 0)
            {
                SaveToExcelWorksheet((Excel.Worksheet)excelWorkBook.Sheets.Add());
            }

            // ui
            tbLog.AppendText("Парсер закончил работу" + Environment.NewLine + Environment.NewLine);
            MessageBox.Show("Парсер закончил работу", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // end ui

            btnStop.Enabled = false;
            gbParserWork.Enabled = false;
            btnSave.Enabled = true;
            btnStart.Enabled = true;
        }

        private void Parser_OnNewData(object currentParser, List<string> parsedUrls, string currentUrl)
        {
            urls.AddRange(parsedUrls);

            foreach (var url in urls)
            {
                tbLog.AppendText(url + Environment.NewLine);
            }

            lblReadyUrslCount.Text = urls.Count.ToString();
        }

        private bool Parser_OnCaptchaContinue()
        {
            MessageBox.Show("Необходимо ввести капчу. После ввода нажмите 'Ок'", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (parser.IsActive)
            {
                string warningText = "Внимание! Парсер ещё не закончил работу! Вы уверены, что хотите закрыть программу?";

                if (MessageBox.Show(warningText, "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    parser.Abort();
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (excelWorkBook != null)
            {
                excelWorkBook.SaveAs(filename);
                excelWorkBook.Application.Quit();
            }

            if (driver != null)
            {
                driver.Quit();
            }
        }

        private void SaveToExcelWorksheet(Excel.Worksheet worksheet)
        {
            worksheet.Name = tbWords.Text;

            for (int i = 0; i < urls.Count; i++)
            {
                worksheet.Cells[i + 1, 1] = urls[i];
            }
            
        }

        private UrlsUpdateDate GetUpdateDateFromCB()
        {
            switch (cbUpdateDate.SelectedIndex)
            {
                case 0: return UrlsUpdateDate.AllTime;
                case 1: return UrlsUpdateDate.Last24Hours;
                case 2: return UrlsUpdateDate.LastWeek;
                case 3: return UrlsUpdateDate.LastMonth;
                case 4: return UrlsUpdateDate.LastYear;
                default: throw new ArgumentOutOfRangeException(cbUpdateDate.SelectedIndex.ToString());
            }
        }
    }
}
