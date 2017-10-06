using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Лучшая комбинация размера поля с вопросами 185; 354

namespace TestingCenter_TestCreator
{
    public partial class Form1 : Form
    {
        private static int CURRENT=0;//делаем так, как и в прошлый раз - отнимаем еденицу
        private static int QuestionsCount=0;
        private static List<string> Questions = new List<string>();
        private static List<int> AnswerCount = new List<int>();
        private static List<string[]> Answers = new List<string[]>();
        private static List<string> RightAnswers = new List<string>();

        TestEnding ending = new TestEnding();

        public Form1()
        {
            InitializeComponent();
            if(File.Exists("images\\save.png"))
            {
                but_End.Image = new Bitmap("images\\save.png");
            }
        }

        private void TextBoxEntering(object sender, EventArgs e)
        {
            (sender as TextBox).Width *= 4;
        }
        private void TextBoxLeaving(object sender, EventArgs e)
        {
            (sender as TextBox).Width /= 4;
        }

        private void PositionUpdating()//Можем запилить эвент по этому поводу)
        {
            lb_Position.Text = CURRENT + "/" + QuestionsCount;
        }

        private void num_AnswCount_ValueChanged(object sender, EventArgs e)
        {
            switch(num_AnswCount.Value)
            {
                case 1:
                    cb_1.Visible = true;
                    cb_2.Visible = false;
                    cb_3.Visible = false;
                    cb_4.Visible = false;
                    cb_5.Visible = false;
                    cb_6.Visible = false;

                    tb_1.Visible = true;
                    tb_2.Visible = false;
                    tb_3.Visible = false;
                    tb_4.Visible = false;
                    tb_5.Visible = false;
                    tb_6.Visible = false;
                    break;
                case 2:
                    cb_1.Visible = true;
                    cb_2.Visible = true;
                    cb_3.Visible = false;
                    cb_4.Visible = false;
                    cb_5.Visible = false;
                    cb_6.Visible = false;

                    tb_1.Visible = true;
                    tb_2.Visible = true;
                    tb_3.Visible = false;
                    tb_4.Visible = false;
                    tb_5.Visible = false;
                    tb_6.Visible = false;
                    break;
                case 3:
                    cb_1.Visible = true;
                    cb_2.Visible = true;
                    cb_3.Visible = true;
                    cb_4.Visible = false;
                    cb_5.Visible = false;
                    cb_6.Visible = false;

                    tb_1.Visible = true;
                    tb_2.Visible = true;
                    tb_3.Visible = true;
                    tb_4.Visible = false;
                    tb_5.Visible = false;
                    tb_6.Visible = false;
                    break;
                case 4:
                    cb_1.Visible = true;
                    cb_2.Visible = true;
                    cb_3.Visible = true;
                    cb_4.Visible = true;
                    cb_5.Visible = false;
                    cb_6.Visible = false;

                    tb_1.Visible = true;
                    tb_2.Visible = true;
                    tb_3.Visible = true;
                    tb_4.Visible = true;
                    tb_5.Visible = false;
                    tb_6.Visible = false;
                    break;
                case 5:
                    cb_1.Visible = true;
                    cb_2.Visible = true;
                    cb_3.Visible = true;
                    cb_4.Visible = true;
                    cb_5.Visible = true;
                    cb_6.Visible = false;

                    tb_1.Visible = true;
                    tb_2.Visible = true;
                    tb_3.Visible = true;
                    tb_4.Visible = true;
                    tb_5.Visible = true;
                    tb_6.Visible = false;
                    break;
                case 6:
                    cb_1.Visible = true;
                    cb_2.Visible = true;
                    cb_3.Visible = true;
                    cb_4.Visible = true;
                    cb_5.Visible = true;
                    cb_6.Visible = true;

                    tb_1.Visible = true;
                    tb_2.Visible = true;
                    tb_3.Visible = true;
                    tb_4.Visible = true;
                    tb_5.Visible = true;
                    tb_6.Visible = true;
                    break;
            }
        }

        private void FlowButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show((sender as Button).Text);
        }

        private void but_New_Click(object sender, EventArgs e)
        {
            flow_All.Controls.Add(new Button() { Text=(QuestionsCount+1).ToString()});//Дописать
            flow_All.Controls[flow_All.Controls.Count-1].Click += new EventHandler(FlowButtonClick);
            //Регистрация клика
            CURRENT = QuestionsCount;
            QuestionsCount++;

            Questions.Add(null);
            AnswerCount.Add(0);
            Answers.Add(null);
            RightAnswers.Add(null);

            PositionUpdating();
        }

        private void but_Del_Click(object sender, EventArgs e)
        {
            int x;
            if (CURRENT != 0)
            {
                x = CURRENT - 1;
                CURRENT--;
            }
            else
            {
                x = CURRENT;
            }

            flow_All.Controls.RemoveAt(x);
            Questions.RemoveAt(x);
            AnswerCount.RemoveAt(x);
            Answers.RemoveAt(x);
            RightAnswers.RemoveAt(x);

            
            QuestionsCount--;
            PositionUpdating();
            for(int i=0;i<flow_All.Controls.Count;i++)
            {
                flow_All.Controls[i].Text = (i + 1).ToString();
            }
        }

        private void but_Save_Click(object sender, EventArgs e)
        {
            int checkers = 0;
            foreach(var a in gb_Answers.Controls)//Посчитаем количество правильных галочек
            {
                if (a is CheckBox)
                {
                    if ((a as CheckBox).Checked)
                    {
                        checkers++;
                    }
                }
            }

        }

        private void but_End_Click(object sender, EventArgs e)
        {
            this.Hide();
            ending.Show();
        }
    }
}
