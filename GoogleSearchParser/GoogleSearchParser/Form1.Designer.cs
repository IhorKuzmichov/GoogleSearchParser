namespace GoogleSearchParser
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbWords = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSavePath = new System.Windows.Forms.TextBox();
            this.fbDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbUpdateDate = new System.Windows.Forms.ComboBox();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.gbParserWork = new System.Windows.Forms.GroupBox();
            this.lblReadyUrslCount = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbParserWork.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbWords
            // 
            this.tbWords.Location = new System.Drawing.Point(210, 16);
            this.tbWords.Name = "tbWords";
            this.tbWords.Size = new System.Drawing.Size(364, 20);
            this.tbWords.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Слова поиска:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Путь сохранения:";
            // 
            // tbSavePath
            // 
            this.tbSavePath.Location = new System.Drawing.Point(210, 45);
            this.tbSavePath.Name = "tbSavePath";
            this.tbSavePath.ReadOnly = true;
            this.tbSavePath.Size = new System.Drawing.Size(334, 20);
            this.tbSavePath.TabIndex = 4;
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(210, 74);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(311, 20);
            this.tbFileName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Имя файла:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12.75F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(527, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = ".xlsx";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Дата обновления:";
            // 
            // cbUpdateDate
            // 
            this.cbUpdateDate.BackColor = System.Drawing.SystemColors.Window;
            this.cbUpdateDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUpdateDate.Enabled = false;
            this.cbUpdateDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbUpdateDate.FormattingEnabled = true;
            this.cbUpdateDate.Items.AddRange(new object[] {
            "любая",
            "последнии 24 часа",
            "последняя неделя",
            "последний меяц",
            "последний год"});
            this.cbUpdateDate.Location = new System.Drawing.Point(210, 102);
            this.cbUpdateDate.Name = "cbUpdateDate";
            this.cbUpdateDate.Size = new System.Drawing.Size(147, 21);
            this.cbUpdateDate.TabIndex = 11;
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSelectFolder.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.btnSelectFolder.Location = new System.Drawing.Point(550, 45);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(24, 20);
            this.btnSelectFolder.TabIndex = 12;
            this.btnSelectFolder.Text = "...";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(214)))), ((int)(((byte)(96)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.btnStart.Location = new System.Drawing.Point(594, 16);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(194, 40);
            this.btnStart.TabIndex = 13;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbLog
            // 
            this.tbLog.Font = new System.Drawing.Font("Comic Sans MS", 8.75F);
            this.tbLog.Location = new System.Drawing.Point(19, 65);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ReadOnly = true;
            this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbLog.Size = new System.Drawing.Size(734, 203);
            this.tbLog.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(16, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "Кол-во ссылок:";
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnStop.Enabled = false;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.btnStop.Location = new System.Drawing.Point(594, 63);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(194, 40);
            this.btnStop.TabIndex = 16;
            this.btnStop.Text = "Стоп";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(596, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 29);
            this.label7.TabIndex = 16;
            this.label7.Text = "Ход парсинга:";
            // 
            // gbParserWork
            // 
            this.gbParserWork.Controls.Add(this.lblReadyUrslCount);
            this.gbParserWork.Controls.Add(this.label7);
            this.gbParserWork.Controls.Add(this.label6);
            this.gbParserWork.Controls.Add(this.tbLog);
            this.gbParserWork.Enabled = false;
            this.gbParserWork.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbParserWork.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.gbParserWork.Location = new System.Drawing.Point(17, 154);
            this.gbParserWork.Name = "gbParserWork";
            this.gbParserWork.Size = new System.Drawing.Size(771, 284);
            this.gbParserWork.TabIndex = 18;
            this.gbParserWork.TabStop = false;
            this.gbParserWork.Text = "Парсинг";
            // 
            // lblReadyUrslCount
            // 
            this.lblReadyUrslCount.AutoSize = true;
            this.lblReadyUrslCount.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReadyUrslCount.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lblReadyUrslCount.Location = new System.Drawing.Point(188, 33);
            this.lblReadyUrslCount.Name = "lblReadyUrslCount";
            this.lblReadyUrslCount.Size = new System.Drawing.Size(26, 29);
            this.lblReadyUrslCount.TabIndex = 17;
            this.lblReadyUrslCount.Text = "0";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(186)))), ((int)(((byte)(3)))));
            this.btnSave.Enabled = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.btnSave.Location = new System.Drawing.Point(594, 108);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(194, 40);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbParserWork);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.cbUpdateDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbFileName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSavePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbWords);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Парсер";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.gbParserWork.ResumeLayout(false);
            this.gbParserWork.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbWords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSavePath;
        private System.Windows.Forms.FolderBrowserDialog fbDialog;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbUpdateDate;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbParserWork;
        private System.Windows.Forms.Label lblReadyUrslCount;
        private System.Windows.Forms.Button btnSave;
    }
}

