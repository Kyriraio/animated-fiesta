namespace WindowsFormsApp69
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.Time = new System.Windows.Forms.Panel();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AnswerCheck = new System.Windows.Forms.Panel();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.radioButtonYes = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.ExamplesNum = new System.Windows.Forms.Panel();
            this.radioButtonEN20 = new System.Windows.Forms.RadioButton();
            this.radioButtonEN10 = new System.Windows.Forms.RadioButton();
            this.radioButtonENinf = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Time.SuspendLayout();
            this.AnswerCheck.SuspendLayout();
            this.ExamplesNum.SuspendLayout();
            this.SuspendLayout();
            // 
            // Time
            // 
            this.Time.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Time.Controls.Add(this.radioButton5);
            this.Time.Controls.Add(this.radioButton6);
            this.Time.Controls.Add(this.radioButton3);
            this.Time.Controls.Add(this.radioButton2);
            this.Time.Controls.Add(this.radioButton4);
            this.Time.Controls.Add(this.radioButton1);
            this.Time.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Time.Location = new System.Drawing.Point(82, 149);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(354, 454);
            this.Time.TabIndex = 27;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton5.Location = new System.Drawing.Point(26, 291);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(175, 69);
            this.radioButton5.TabIndex = 28;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "30 сек";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton6.Location = new System.Drawing.Point(26, 366);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(175, 69);
            this.radioButton6.TabIndex = 27;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "60 сек";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton3.Location = new System.Drawing.Point(26, 141);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(175, 69);
            this.radioButton3.TabIndex = 26;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "10 сек";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(26, 66);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(148, 69);
            this.radioButton2.TabIndex = 23;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "5 сек";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton4.Location = new System.Drawing.Point(26, 216);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(175, 69);
            this.radioButton4.TabIndex = 25;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "20 сек";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(26, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(281, 69);
            this.radioButton1.TabIndex = 21;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Без времени";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(83, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 65);
            this.label1.TabIndex = 29;
            this.label1.Text = "Время";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(392, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 65);
            this.label2.TabIndex = 30;
            this.label2.Text = "Ответ";
            // 
            // AnswerCheck
            // 
            this.AnswerCheck.BackColor = System.Drawing.Color.PaleGreen;
            this.AnswerCheck.Controls.Add(this.radioButtonNo);
            this.AnswerCheck.Controls.Add(this.radioButtonYes);
            this.AnswerCheck.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnswerCheck.Location = new System.Drawing.Point(392, 149);
            this.AnswerCheck.Name = "AnswerCheck";
            this.AnswerCheck.Size = new System.Drawing.Size(363, 454);
            this.AnswerCheck.TabIndex = 29;
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonNo.Location = new System.Drawing.Point(25, 66);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(270, 69);
            this.radioButtonNo.TabIndex = 23;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "В тетради";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // radioButtonYes
            // 
            this.radioButtonYes.AutoSize = true;
            this.radioButtonYes.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonYes.Location = new System.Drawing.Point(25, 3);
            this.radioButtonYes.Name = "radioButtonYes";
            this.radioButtonYes.Size = new System.Drawing.Size(327, 69);
            this.radioButtonYes.TabIndex = 21;
            this.radioButtonYes.TabStop = true;
            this.radioButtonYes.Text = "С клавиатуры";
            this.radioButtonYes.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(82, 622);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(307, 66);
            this.button1.TabIndex = 31;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExamplesNum
            // 
            this.ExamplesNum.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ExamplesNum.Controls.Add(this.radioButtonEN20);
            this.ExamplesNum.Controls.Add(this.radioButtonEN10);
            this.ExamplesNum.Controls.Add(this.radioButtonENinf);
            this.ExamplesNum.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExamplesNum.Location = new System.Drawing.Point(750, 149);
            this.ExamplesNum.Name = "ExamplesNum";
            this.ExamplesNum.Size = new System.Drawing.Size(354, 454);
            this.ExamplesNum.TabIndex = 32;
            // 
            // radioButtonEN20
            // 
            this.radioButtonEN20.AutoSize = true;
            this.radioButtonEN20.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonEN20.Location = new System.Drawing.Point(11, 126);
            this.radioButtonEN20.Name = "radioButtonEN20";
            this.radioButtonEN20.Size = new System.Drawing.Size(100, 69);
            this.radioButtonEN20.TabIndex = 24;
            this.radioButtonEN20.TabStop = true;
            this.radioButtonEN20.Text = "20";
            this.radioButtonEN20.UseVisualStyleBackColor = true;
            // 
            // radioButtonEN10
            // 
            this.radioButtonEN10.AutoSize = true;
            this.radioButtonEN10.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonEN10.Location = new System.Drawing.Point(11, 66);
            this.radioButtonEN10.Name = "radioButtonEN10";
            this.radioButtonEN10.Size = new System.Drawing.Size(100, 69);
            this.radioButtonEN10.TabIndex = 23;
            this.radioButtonEN10.TabStop = true;
            this.radioButtonEN10.Text = "10";
            this.radioButtonEN10.UseVisualStyleBackColor = true;
            // 
            // radioButtonENinf
            // 
            this.radioButtonENinf.AutoSize = true;
            this.radioButtonENinf.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonENinf.Location = new System.Drawing.Point(11, 3);
            this.radioButtonENinf.Name = "radioButtonENinf";
            this.radioButtonENinf.Size = new System.Drawing.Size(322, 69);
            this.radioButtonENinf.TabIndex = 21;
            this.radioButtonENinf.TabStop = true;
            this.radioButtonENinf.Text = "Не ограничено";
            this.radioButtonENinf.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(750, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(466, 65);
            this.label3.TabIndex = 33;
            this.label3.Text = "Количество примеров";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(750, 622);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(354, 66);
            this.button2.TabIndex = 34;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 986);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ExamplesNum);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AnswerCheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Time);
            this.Name = "Settings";
            this.Text = "Настройки";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Settings_Load);
            this.Time.ResumeLayout(false);
            this.Time.PerformLayout();
            this.AnswerCheck.ResumeLayout(false);
            this.AnswerCheck.PerformLayout();
            this.ExamplesNum.ResumeLayout(false);
            this.ExamplesNum.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Time;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel AnswerCheck;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.RadioButton radioButtonYes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel ExamplesNum;
        private System.Windows.Forms.RadioButton radioButtonEN20;
        private System.Windows.Forms.RadioButton radioButtonEN10;
        private System.Windows.Forms.RadioButton radioButtonENinf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}