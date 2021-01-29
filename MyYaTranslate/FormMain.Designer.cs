namespace MyYaTranslate
{
    partial class FormMain
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
            this.buttonGetWeather = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTemp = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelFeelsLike = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelCondition = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelWindSpeed = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureIcon = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelWindDir = new System.Windows.Forms.Label();
            this.labelPressureMM = new System.Windows.Forms.Label();
            this.labelLon = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelLat = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGetWeather
            // 
            this.buttonGetWeather.Location = new System.Drawing.Point(168, 392);
            this.buttonGetWeather.Name = "buttonGetWeather";
            this.buttonGetWeather.Size = new System.Drawing.Size(208, 40);
            this.buttonGetWeather.TabIndex = 1;
            this.buttonGetWeather.Text = "Получить прогноз";
            this.buttonGetWeather.UseVisualStyleBackColor = true;
            this.buttonGetWeather.Click += new System.EventHandler(this.buttonGetWeather_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Город";
            // 
            // labelTemp
            // 
            this.labelTemp.AutoSize = true;
            this.labelTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.labelTemp.Location = new System.Drawing.Point(240, 56);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(60, 26);
            this.labelTemp.TabIndex = 8;
            this.labelTemp.Text = "____";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label5.Location = new System.Drawing.Point(16, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "Температура(С)";
            // 
            // labelFeelsLike
            // 
            this.labelFeelsLike.AutoSize = true;
            this.labelFeelsLike.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.labelFeelsLike.Location = new System.Drawing.Point(240, 96);
            this.labelFeelsLike.Name = "labelFeelsLike";
            this.labelFeelsLike.Size = new System.Drawing.Size(60, 26);
            this.labelFeelsLike.TabIndex = 10;
            this.labelFeelsLike.Text = "____";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label7.Location = new System.Drawing.Point(16, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 26);
            this.label7.TabIndex = 9;
            this.label7.Text = "Ощущается как(С)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label9.Location = new System.Drawing.Point(16, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 26);
            this.label9.TabIndex = 11;
            this.label9.Text = "Иконка";
            // 
            // labelCondition
            // 
            this.labelCondition.AutoSize = true;
            this.labelCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.labelCondition.Location = new System.Drawing.Point(240, 200);
            this.labelCondition.Name = "labelCondition";
            this.labelCondition.Size = new System.Drawing.Size(60, 26);
            this.labelCondition.TabIndex = 14;
            this.labelCondition.Text = "____";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label11.Location = new System.Drawing.Point(16, 200);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(202, 26);
            this.label11.TabIndex = 13;
            this.label11.Text = "Погодные условия";
            // 
            // labelWindSpeed
            // 
            this.labelWindSpeed.AutoSize = true;
            this.labelWindSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.labelWindSpeed.Location = new System.Drawing.Point(240, 240);
            this.labelWindSpeed.Name = "labelWindSpeed";
            this.labelWindSpeed.Size = new System.Drawing.Size(60, 26);
            this.labelWindSpeed.TabIndex = 16;
            this.labelWindSpeed.Text = "____";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label13.Location = new System.Drawing.Point(16, 240);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(172, 26);
            this.label13.TabIndex = 15;
            this.label13.Text = "Скорость ветра";
            // 
            // pictureIcon
            // 
            this.pictureIcon.Location = new System.Drawing.Point(232, 136);
            this.pictureIcon.Name = "pictureIcon";
            this.pictureIcon.Size = new System.Drawing.Size(100, 50);
            this.pictureIcon.TabIndex = 17;
            this.pictureIcon.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label8.Location = new System.Drawing.Point(16, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(213, 26);
            this.label8.TabIndex = 18;
            this.label8.Text = "Направление ветра";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label3.Location = new System.Drawing.Point(16, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 26);
            this.label3.TabIndex = 19;
            this.label3.Text = "Давление(мм)";
            // 
            // labelWindDir
            // 
            this.labelWindDir.AutoSize = true;
            this.labelWindDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.labelWindDir.Location = new System.Drawing.Point(248, 288);
            this.labelWindDir.Name = "labelWindDir";
            this.labelWindDir.Size = new System.Drawing.Size(60, 26);
            this.labelWindDir.TabIndex = 20;
            this.labelWindDir.Text = "____";
            // 
            // labelPressureMM
            // 
            this.labelPressureMM.AutoSize = true;
            this.labelPressureMM.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.labelPressureMM.Location = new System.Drawing.Point(240, 336);
            this.labelPressureMM.Name = "labelPressureMM";
            this.labelPressureMM.Size = new System.Drawing.Size(60, 26);
            this.labelPressureMM.TabIndex = 21;
            this.labelPressureMM.Text = "____";
            // 
            // labelLon
            // 
            this.labelLon.AutoSize = true;
            this.labelLon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.labelLon.Location = new System.Drawing.Point(432, 72);
            this.labelLon.Name = "labelLon";
            this.labelLon.Size = new System.Drawing.Size(60, 26);
            this.labelLon.TabIndex = 26;
            this.labelLon.Text = "____";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(216, 16);
            this.textBoxCity.Multiline = true;
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(200, 32);
            this.textBoxCity.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Введите город";
            // 
            // labelLat
            // 
            this.labelLat.AutoSize = true;
            this.labelLat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.labelLat.Location = new System.Drawing.Point(432, 112);
            this.labelLat.Name = "labelLat";
            this.labelLat.Size = new System.Drawing.Size(60, 26);
            this.labelLat.TabIndex = 25;
            this.labelLat.Text = "____";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Долгота";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(368, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Широта";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 451);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.labelLon);
            this.Controls.Add(this.labelLat);
            this.Controls.Add(this.labelPressureMM);
            this.Controls.Add(this.labelWindDir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureIcon);
            this.Controls.Add(this.labelWindSpeed);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.labelCondition);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelFeelsLike);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelTemp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGetWeather);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Прогноз погоды";
            ((System.ComponentModel.ISupportInitialize)(this.pictureIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonGetWeather;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTemp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelFeelsLike;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelCondition;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelWindSpeed;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelWindDir;
        private System.Windows.Forms.Label labelPressureMM;
        public System.Windows.Forms.PictureBox pictureIcon;
        public System.Windows.Forms.TextBox textBoxCity;
        public System.Windows.Forms.Label labelLon;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label labelLat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}

