namespace TestingCenter_TestCreator
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
            this.lb_Question = new System.Windows.Forms.Label();
            this.num_AnswCount = new System.Windows.Forms.NumericUpDown();
            this.lb_AnwCount = new System.Windows.Forms.Label();
            this.gb_Answers = new System.Windows.Forms.GroupBox();
            this.tb_6 = new System.Windows.Forms.TextBox();
            this.tb_5 = new System.Windows.Forms.TextBox();
            this.tb_4 = new System.Windows.Forms.TextBox();
            this.tb_3 = new System.Windows.Forms.TextBox();
            this.tb_2 = new System.Windows.Forms.TextBox();
            this.tb_1 = new System.Windows.Forms.TextBox();
            this.cb_6 = new System.Windows.Forms.CheckBox();
            this.cb_5 = new System.Windows.Forms.CheckBox();
            this.cb_4 = new System.Windows.Forms.CheckBox();
            this.cb_3 = new System.Windows.Forms.CheckBox();
            this.cb_2 = new System.Windows.Forms.CheckBox();
            this.cb_1 = new System.Windows.Forms.CheckBox();
            this.flow_All = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tb_Question = new System.Windows.Forms.TextBox();
            this.lb_Position = new System.Windows.Forms.Label();
            this.but_New = new System.Windows.Forms.Button();
            this.but_Del = new System.Windows.Forms.Button();
            this.but_Save = new System.Windows.Forms.Button();
            this.but_End = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_AnswCount)).BeginInit();
            this.gb_Answers.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Question
            // 
            this.lb_Question.AutoSize = true;
            this.lb_Question.Location = new System.Drawing.Point(12, 40);
            this.lb_Question.Name = "lb_Question";
            this.lb_Question.Size = new System.Drawing.Size(64, 18);
            this.lb_Question.TabIndex = 0;
            this.lb_Question.Text = "Вопрос:";
            // 
            // num_AnswCount
            // 
            this.num_AnswCount.Location = new System.Drawing.Point(178, 87);
            this.num_AnswCount.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.num_AnswCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_AnswCount.Name = "num_AnswCount";
            this.num_AnswCount.Size = new System.Drawing.Size(55, 25);
            this.num_AnswCount.TabIndex = 1;
            this.num_AnswCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_AnswCount.ValueChanged += new System.EventHandler(this.num_AnswCount_ValueChanged);
            // 
            // lb_AnwCount
            // 
            this.lb_AnwCount.AutoSize = true;
            this.lb_AnwCount.Location = new System.Drawing.Point(12, 89);
            this.lb_AnwCount.Name = "lb_AnwCount";
            this.lb_AnwCount.Size = new System.Drawing.Size(160, 18);
            this.lb_AnwCount.TabIndex = 2;
            this.lb_AnwCount.Text = "Количество ответов:";
            // 
            // gb_Answers
            // 
            this.gb_Answers.Controls.Add(this.tb_6);
            this.gb_Answers.Controls.Add(this.tb_5);
            this.gb_Answers.Controls.Add(this.tb_4);
            this.gb_Answers.Controls.Add(this.tb_3);
            this.gb_Answers.Controls.Add(this.tb_2);
            this.gb_Answers.Controls.Add(this.tb_1);
            this.gb_Answers.Controls.Add(this.cb_6);
            this.gb_Answers.Controls.Add(this.cb_5);
            this.gb_Answers.Controls.Add(this.cb_4);
            this.gb_Answers.Controls.Add(this.cb_3);
            this.gb_Answers.Controls.Add(this.cb_2);
            this.gb_Answers.Controls.Add(this.cb_1);
            this.gb_Answers.Location = new System.Drawing.Point(15, 140);
            this.gb_Answers.Name = "gb_Answers";
            this.gb_Answers.Size = new System.Drawing.Size(914, 354);
            this.gb_Answers.TabIndex = 3;
            this.gb_Answers.TabStop = false;
            this.gb_Answers.Text = "Варианты ответов:";
            // 
            // tb_6
            // 
            this.tb_6.Location = new System.Drawing.Point(67, 291);
            this.tb_6.Name = "tb_6";
            this.tb_6.Size = new System.Drawing.Size(151, 25);
            this.tb_6.TabIndex = 11;
            this.tb_6.Visible = false;
            this.tb_6.Enter += new System.EventHandler(this.TextBoxEntering);
            this.tb_6.Leave += new System.EventHandler(this.TextBoxLeaving);
            // 
            // tb_5
            // 
            this.tb_5.Location = new System.Drawing.Point(67, 240);
            this.tb_5.Name = "tb_5";
            this.tb_5.Size = new System.Drawing.Size(151, 25);
            this.tb_5.TabIndex = 10;
            this.tb_5.Visible = false;
            this.tb_5.Enter += new System.EventHandler(this.TextBoxEntering);
            this.tb_5.Leave += new System.EventHandler(this.TextBoxLeaving);
            // 
            // tb_4
            // 
            this.tb_4.Location = new System.Drawing.Point(67, 189);
            this.tb_4.Name = "tb_4";
            this.tb_4.Size = new System.Drawing.Size(151, 25);
            this.tb_4.TabIndex = 9;
            this.tb_4.Visible = false;
            this.tb_4.Enter += new System.EventHandler(this.TextBoxEntering);
            this.tb_4.Leave += new System.EventHandler(this.TextBoxLeaving);
            // 
            // tb_3
            // 
            this.tb_3.Location = new System.Drawing.Point(67, 138);
            this.tb_3.Name = "tb_3";
            this.tb_3.Size = new System.Drawing.Size(151, 25);
            this.tb_3.TabIndex = 8;
            this.tb_3.Visible = false;
            this.tb_3.Enter += new System.EventHandler(this.TextBoxEntering);
            this.tb_3.Leave += new System.EventHandler(this.TextBoxLeaving);
            // 
            // tb_2
            // 
            this.tb_2.Location = new System.Drawing.Point(67, 87);
            this.tb_2.Name = "tb_2";
            this.tb_2.Size = new System.Drawing.Size(151, 25);
            this.tb_2.TabIndex = 7;
            this.tb_2.Visible = false;
            this.tb_2.Enter += new System.EventHandler(this.TextBoxEntering);
            this.tb_2.Leave += new System.EventHandler(this.TextBoxLeaving);
            // 
            // tb_1
            // 
            this.tb_1.Location = new System.Drawing.Point(67, 36);
            this.tb_1.Name = "tb_1";
            this.tb_1.Size = new System.Drawing.Size(151, 25);
            this.tb_1.TabIndex = 6;
            this.tb_1.Enter += new System.EventHandler(this.TextBoxEntering);
            this.tb_1.Leave += new System.EventHandler(this.TextBoxLeaving);
            // 
            // cb_6
            // 
            this.cb_6.AutoSize = true;
            this.cb_6.Location = new System.Drawing.Point(26, 297);
            this.cb_6.Name = "cb_6";
            this.cb_6.Size = new System.Drawing.Size(15, 14);
            this.cb_6.TabIndex = 5;
            this.cb_6.UseVisualStyleBackColor = true;
            this.cb_6.Visible = false;
            // 
            // cb_5
            // 
            this.cb_5.AutoSize = true;
            this.cb_5.Location = new System.Drawing.Point(26, 246);
            this.cb_5.Name = "cb_5";
            this.cb_5.Size = new System.Drawing.Size(15, 14);
            this.cb_5.TabIndex = 4;
            this.cb_5.UseVisualStyleBackColor = true;
            this.cb_5.Visible = false;
            // 
            // cb_4
            // 
            this.cb_4.AutoSize = true;
            this.cb_4.Location = new System.Drawing.Point(26, 195);
            this.cb_4.Name = "cb_4";
            this.cb_4.Size = new System.Drawing.Size(15, 14);
            this.cb_4.TabIndex = 3;
            this.cb_4.UseVisualStyleBackColor = true;
            this.cb_4.Visible = false;
            // 
            // cb_3
            // 
            this.cb_3.AutoSize = true;
            this.cb_3.Location = new System.Drawing.Point(26, 144);
            this.cb_3.Name = "cb_3";
            this.cb_3.Size = new System.Drawing.Size(15, 14);
            this.cb_3.TabIndex = 2;
            this.cb_3.UseVisualStyleBackColor = true;
            this.cb_3.Visible = false;
            // 
            // cb_2
            // 
            this.cb_2.AutoSize = true;
            this.cb_2.Location = new System.Drawing.Point(26, 93);
            this.cb_2.Name = "cb_2";
            this.cb_2.Size = new System.Drawing.Size(15, 14);
            this.cb_2.TabIndex = 1;
            this.cb_2.UseVisualStyleBackColor = true;
            this.cb_2.Visible = false;
            // 
            // cb_1
            // 
            this.cb_1.AutoSize = true;
            this.cb_1.Location = new System.Drawing.Point(26, 42);
            this.cb_1.Name = "cb_1";
            this.cb_1.Size = new System.Drawing.Size(15, 14);
            this.cb_1.TabIndex = 0;
            this.cb_1.UseVisualStyleBackColor = true;
            // 
            // flow_All
            // 
            this.flow_All.AutoScroll = true;
            this.flow_All.Location = new System.Drawing.Point(935, 140);
            this.flow_All.Name = "flow_All";
            this.flow_All.Size = new System.Drawing.Size(185, 354);
            this.flow_All.TabIndex = 4;
            // 
            // menuStrip
            // 
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1133, 24);
            this.menuStrip.TabIndex = 5;
            this.menuStrip.Text = "menuStrip1";
            // 
            // tb_Question
            // 
            this.tb_Question.Location = new System.Drawing.Point(82, 40);
            this.tb_Question.Name = "tb_Question";
            this.tb_Question.Size = new System.Drawing.Size(151, 25);
            this.tb_Question.TabIndex = 6;
            this.tb_Question.Enter += new System.EventHandler(this.TextBoxEntering);
            this.tb_Question.Leave += new System.EventHandler(this.TextBoxLeaving);
            // 
            // lb_Position
            // 
            this.lb_Position.Location = new System.Drawing.Point(935, 108);
            this.lb_Position.Name = "lb_Position";
            this.lb_Position.Size = new System.Drawing.Size(185, 29);
            this.lb_Position.TabIndex = 7;
            this.lb_Position.Text = "[Position\\All]";
            this.lb_Position.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // but_New
            // 
            this.but_New.Location = new System.Drawing.Point(935, 501);
            this.but_New.Name = "but_New";
            this.but_New.Size = new System.Drawing.Size(75, 28);
            this.but_New.TabIndex = 8;
            this.but_New.Text = "Новый";
            this.but_New.UseVisualStyleBackColor = true;
            this.but_New.Click += new System.EventHandler(this.but_New_Click);
            // 
            // but_Del
            // 
            this.but_Del.Location = new System.Drawing.Point(1046, 501);
            this.but_Del.Name = "but_Del";
            this.but_Del.Size = new System.Drawing.Size(75, 28);
            this.but_Del.TabIndex = 9;
            this.but_Del.Text = "Удалить";
            this.but_Del.UseVisualStyleBackColor = true;
            this.but_Del.Click += new System.EventHandler(this.but_Del_Click);
            // 
            // but_Save
            // 
            this.but_Save.Location = new System.Drawing.Point(184, 500);
            this.but_Save.Name = "but_Save";
            this.but_Save.Size = new System.Drawing.Size(577, 28);
            this.but_Save.TabIndex = 10;
            this.but_Save.Text = "Сохранить вопрос";
            this.but_Save.UseVisualStyleBackColor = true;
            this.but_Save.Click += new System.EventHandler(this.but_Save_Click);
            // 
            // but_End
            // 
            this.but_End.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.but_End.Location = new System.Drawing.Point(969, 29);
            this.but_End.Name = "but_End";
            this.but_End.Size = new System.Drawing.Size(116, 78);
            this.but_End.TabIndex = 11;
            this.but_End.Text = "Завершить";
            this.but_End.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_End.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 582);
            this.Controls.Add(this.but_End);
            this.Controls.Add(this.but_Save);
            this.Controls.Add(this.but_Del);
            this.Controls.Add(this.but_New);
            this.Controls.Add(this.lb_Position);
            this.Controls.Add(this.tb_Question);
            this.Controls.Add(this.flow_All);
            this.Controls.Add(this.gb_Answers);
            this.Controls.Add(this.lb_AnwCount);
            this.Controls.Add(this.num_AnswCount);
            this.Controls.Add(this.lb_Question);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "TestCreator";
            ((System.ComponentModel.ISupportInitialize)(this.num_AnswCount)).EndInit();
            this.gb_Answers.ResumeLayout(false);
            this.gb_Answers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Question;
        private System.Windows.Forms.NumericUpDown num_AnswCount;
        private System.Windows.Forms.Label lb_AnwCount;
        private System.Windows.Forms.GroupBox gb_Answers;
        private System.Windows.Forms.FlowLayoutPanel flow_All;
        private System.Windows.Forms.TextBox tb_6;
        private System.Windows.Forms.TextBox tb_5;
        private System.Windows.Forms.TextBox tb_4;
        private System.Windows.Forms.TextBox tb_3;
        private System.Windows.Forms.TextBox tb_2;
        private System.Windows.Forms.TextBox tb_1;
        private System.Windows.Forms.CheckBox cb_6;
        private System.Windows.Forms.CheckBox cb_5;
        private System.Windows.Forms.CheckBox cb_4;
        private System.Windows.Forms.CheckBox cb_3;
        private System.Windows.Forms.CheckBox cb_2;
        private System.Windows.Forms.CheckBox cb_1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.TextBox tb_Question;
        private System.Windows.Forms.Label lb_Position;
        private System.Windows.Forms.Button but_New;
        private System.Windows.Forms.Button but_Del;
        private System.Windows.Forms.Button but_Save;
        private System.Windows.Forms.Button but_End;
    }
}

