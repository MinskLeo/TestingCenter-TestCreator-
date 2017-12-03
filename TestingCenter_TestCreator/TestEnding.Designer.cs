namespace TestingCenter_TestCreator
{
    partial class TestEnding
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
            this.gb_TimeSettings = new System.Windows.Forms.GroupBox();
            this.num_Seconds = new System.Windows.Forms.NumericUpDown();
            this.num_Minutes = new System.Windows.Forms.NumericUpDown();
            this.num_Hours = new System.Windows.Forms.NumericUpDown();
            this.lb_Seconds = new System.Windows.Forms.Label();
            this.lb_Minutes = new System.Windows.Forms.Label();
            this.lb_Hours = new System.Windows.Forms.Label();
            this.gb_General = new System.Windows.Forms.GroupBox();
            this.tb_QuestionsCount = new System.Windows.Forms.TextBox();
            this.lb_QuestionsCount = new System.Windows.Forms.Label();
            this.tb_Specialty = new System.Windows.Forms.TextBox();
            this.lb_Semester = new System.Windows.Forms.Label();
            this.lb_Specialty = new System.Windows.Forms.Label();
            this.num_Semester = new System.Windows.Forms.NumericUpDown();
            this.lb_Subject = new System.Windows.Forms.Label();
            this.tb_Subject = new System.Windows.Forms.TextBox();
            this.but_Save = new System.Windows.Forms.Button();
            this.but_Cancel = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.gb_TimeSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Seconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Minutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Hours)).BeginInit();
            this.gb_General.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Semester)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_TimeSettings
            // 
            this.gb_TimeSettings.Controls.Add(this.num_Seconds);
            this.gb_TimeSettings.Controls.Add(this.num_Minutes);
            this.gb_TimeSettings.Controls.Add(this.num_Hours);
            this.gb_TimeSettings.Controls.Add(this.lb_Seconds);
            this.gb_TimeSettings.Controls.Add(this.lb_Minutes);
            this.gb_TimeSettings.Controls.Add(this.lb_Hours);
            this.gb_TimeSettings.Location = new System.Drawing.Point(12, 190);
            this.gb_TimeSettings.Name = "gb_TimeSettings";
            this.gb_TimeSettings.Size = new System.Drawing.Size(356, 140);
            this.gb_TimeSettings.TabIndex = 6;
            this.gb_TimeSettings.TabStop = false;
            this.gb_TimeSettings.Text = "Время на тест";
            // 
            // num_Seconds
            // 
            this.num_Seconds.Location = new System.Drawing.Point(96, 91);
            this.num_Seconds.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.num_Seconds.Name = "num_Seconds";
            this.num_Seconds.Size = new System.Drawing.Size(77, 25);
            this.num_Seconds.TabIndex = 9;
            // 
            // num_Minutes
            // 
            this.num_Minutes.Location = new System.Drawing.Point(96, 62);
            this.num_Minutes.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.num_Minutes.Name = "num_Minutes";
            this.num_Minutes.Size = new System.Drawing.Size(77, 25);
            this.num_Minutes.TabIndex = 8;
            // 
            // num_Hours
            // 
            this.num_Hours.Location = new System.Drawing.Point(96, 33);
            this.num_Hours.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.num_Hours.Name = "num_Hours";
            this.num_Hours.Size = new System.Drawing.Size(77, 25);
            this.num_Hours.TabIndex = 7;
            // 
            // lb_Seconds
            // 
            this.lb_Seconds.Location = new System.Drawing.Point(6, 92);
            this.lb_Seconds.Name = "lb_Seconds";
            this.lb_Seconds.Size = new System.Drawing.Size(84, 25);
            this.lb_Seconds.TabIndex = 12;
            this.lb_Seconds.Text = "Секунды:";
            this.lb_Seconds.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_Minutes
            // 
            this.lb_Minutes.Location = new System.Drawing.Point(6, 62);
            this.lb_Minutes.Name = "lb_Minutes";
            this.lb_Minutes.Size = new System.Drawing.Size(84, 25);
            this.lb_Minutes.TabIndex = 11;
            this.lb_Minutes.Text = "Минуты:";
            this.lb_Minutes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_Hours
            // 
            this.lb_Hours.Location = new System.Drawing.Point(6, 32);
            this.lb_Hours.Name = "lb_Hours";
            this.lb_Hours.Size = new System.Drawing.Size(84, 25);
            this.lb_Hours.TabIndex = 10;
            this.lb_Hours.Text = "Часы:";
            this.lb_Hours.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gb_General
            // 
            this.gb_General.Controls.Add(this.tb_QuestionsCount);
            this.gb_General.Controls.Add(this.lb_QuestionsCount);
            this.gb_General.Controls.Add(this.tb_Specialty);
            this.gb_General.Controls.Add(this.lb_Semester);
            this.gb_General.Controls.Add(this.lb_Specialty);
            this.gb_General.Controls.Add(this.num_Semester);
            this.gb_General.Controls.Add(this.lb_Subject);
            this.gb_General.Controls.Add(this.tb_Subject);
            this.gb_General.Location = new System.Drawing.Point(12, 12);
            this.gb_General.Name = "gb_General";
            this.gb_General.Size = new System.Drawing.Size(356, 172);
            this.gb_General.TabIndex = 1;
            this.gb_General.TabStop = false;
            this.gb_General.Text = "Общее";
            // 
            // tb_QuestionsCount
            // 
            this.tb_QuestionsCount.Enabled = false;
            this.tb_QuestionsCount.Location = new System.Drawing.Point(179, 124);
            this.tb_QuestionsCount.Name = "tb_QuestionsCount";
            this.tb_QuestionsCount.Size = new System.Drawing.Size(141, 25);
            this.tb_QuestionsCount.TabIndex = 5;
            this.tb_QuestionsCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_QuestionsCount
            // 
            this.lb_QuestionsCount.Location = new System.Drawing.Point(6, 124);
            this.lb_QuestionsCount.Name = "lb_QuestionsCount";
            this.lb_QuestionsCount.Size = new System.Drawing.Size(167, 25);
            this.lb_QuestionsCount.TabIndex = 14;
            this.lb_QuestionsCount.Text = "Кол.-во вопросов:";
            this.lb_QuestionsCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_Specialty
            // 
            this.tb_Specialty.Location = new System.Drawing.Point(179, 62);
            this.tb_Specialty.Name = "tb_Specialty";
            this.tb_Specialty.Size = new System.Drawing.Size(141, 25);
            this.tb_Specialty.TabIndex = 3;
            // 
            // lb_Semester
            // 
            this.lb_Semester.Location = new System.Drawing.Point(6, 93);
            this.lb_Semester.Name = "lb_Semester";
            this.lb_Semester.Size = new System.Drawing.Size(167, 25);
            this.lb_Semester.TabIndex = 12;
            this.lb_Semester.Text = "Семестр:";
            this.lb_Semester.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_Specialty
            // 
            this.lb_Specialty.Location = new System.Drawing.Point(6, 62);
            this.lb_Specialty.Name = "lb_Specialty";
            this.lb_Specialty.Size = new System.Drawing.Size(167, 25);
            this.lb_Specialty.TabIndex = 11;
            this.lb_Specialty.Text = "Специальность:";
            this.lb_Specialty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // num_Semester
            // 
            this.num_Semester.Location = new System.Drawing.Point(179, 93);
            this.num_Semester.Name = "num_Semester";
            this.num_Semester.Size = new System.Drawing.Size(141, 25);
            this.num_Semester.TabIndex = 4;
            // 
            // lb_Subject
            // 
            this.lb_Subject.Location = new System.Drawing.Point(6, 31);
            this.lb_Subject.Name = "lb_Subject";
            this.lb_Subject.Size = new System.Drawing.Size(167, 25);
            this.lb_Subject.TabIndex = 9;
            this.lb_Subject.Text = "Предмет/дисциплина:";
            this.lb_Subject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_Subject
            // 
            this.tb_Subject.Location = new System.Drawing.Point(179, 31);
            this.tb_Subject.Name = "tb_Subject";
            this.tb_Subject.Size = new System.Drawing.Size(141, 25);
            this.tb_Subject.TabIndex = 2;
            // 
            // but_Save
            // 
            this.but_Save.Location = new System.Drawing.Point(200, 336);
            this.but_Save.Name = "but_Save";
            this.but_Save.Size = new System.Drawing.Size(100, 40);
            this.but_Save.TabIndex = 10;
            this.but_Save.Text = "Сохранить";
            this.but_Save.UseVisualStyleBackColor = true;
            this.but_Save.Click += new System.EventHandler(this.but_Save_Click);
            // 
            // but_Cancel
            // 
            this.but_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.but_Cancel.Location = new System.Drawing.Point(94, 336);
            this.but_Cancel.Name = "but_Cancel";
            this.but_Cancel.Size = new System.Drawing.Size(100, 40);
            this.but_Cancel.TabIndex = 12;
            this.but_Cancel.TabStop = false;
            this.but_Cancel.Text = "Отмена";
            this.but_Cancel.UseVisualStyleBackColor = true;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "NewTest.txt";
            this.saveFileDialog.Filter = "*.txt|*.txt|All|*.*";
            this.saveFileDialog.RestoreDirectory = true;
            // 
            // TestEnding
            // 
            this.AcceptButton = this.but_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.but_Cancel;
            this.ClientSize = new System.Drawing.Size(380, 395);
            this.Controls.Add(this.but_Cancel);
            this.Controls.Add(this.but_Save);
            this.Controls.Add(this.gb_General);
            this.Controls.Add(this.gb_TimeSettings);
            this.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "TestEnding";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Завершение";
            this.gb_TimeSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_Seconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Minutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Hours)).EndInit();
            this.gb_General.ResumeLayout(false);
            this.gb_General.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Semester)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_TimeSettings;
        private System.Windows.Forms.NumericUpDown num_Seconds;
        private System.Windows.Forms.NumericUpDown num_Minutes;
        private System.Windows.Forms.NumericUpDown num_Hours;
        private System.Windows.Forms.Label lb_Seconds;
        private System.Windows.Forms.Label lb_Minutes;
        private System.Windows.Forms.Label lb_Hours;
        private System.Windows.Forms.GroupBox gb_General;
        private System.Windows.Forms.TextBox tb_QuestionsCount;
        private System.Windows.Forms.Label lb_QuestionsCount;
        private System.Windows.Forms.TextBox tb_Specialty;
        private System.Windows.Forms.Label lb_Semester;
        private System.Windows.Forms.Label lb_Specialty;
        private System.Windows.Forms.NumericUpDown num_Semester;
        private System.Windows.Forms.Label lb_Subject;
        private System.Windows.Forms.TextBox tb_Subject;
        private System.Windows.Forms.Button but_Save;
        private System.Windows.Forms.Button but_Cancel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}