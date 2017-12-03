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
        public static Question[] mas=new Question[1];
        public int CURRENT=0;//Текущий вопрос
        public Form1()
        {
            InitializeComponent();
            if(File.Exists("images\\save.png"))
            {
                but_End.Image = new Bitmap("images\\save.png");
            }
            flow_All.Controls.Add(new Button()
            {
                Text="1",
                Size=new Size(50,50),
                TabStop=false
            });
            flow_All.Controls[0].Click += new EventHandler(FlowButtonClick);
            mas[0] = new Question();
        }

        private void but_Save_Click(object sender, EventArgs e)//Сохранение текущего вопроса
        {
            string[] buf;
            mas[CURRENT] = new Question();
            mas[CURRENT].QUESTION = tb_Question.Text;
            mas[CURRENT].ANSW_COUNT = (int)num_AnswCount.Value;

            List<string> corrAnsw = new List<string>();
            
            foreach(var a in gb_Answers.Controls)
            {
                if (a is CheckBox)
                {
                    if ((a as CheckBox).Checked)
                    {
                        buf = (a as CheckBox).Name.Split('_');
                        corrAnsw.Add(buf[1]);
                    }
                }
            }
            mas[CURRENT].ANSWERS = new string[mas[CURRENT].ANSW_COUNT];
            for (int i=0;i<corrAnsw.Count;i++)
            {
                mas[CURRENT].CorrectANSW += corrAnsw[i];
                if(corrAnsw.Count>1 && i<corrAnsw.Count-1)
                {
                    mas[CURRENT].CorrectANSW += ",";
                }
            }

            //Сами ответы
            if(mas[CURRENT].ANSW_COUNT>=1)
            {
                mas[CURRENT].ANSWERS[0] = tb_1.Text;
            }
            if(mas[CURRENT].ANSW_COUNT >= 2)
            {
                mas[CURRENT].ANSWERS[1] = tb_2.Text;
            }
            if (mas[CURRENT].ANSW_COUNT >= 3)
            {
                mas[CURRENT].ANSWERS[2] = tb_3.Text;
            }
            if (mas[CURRENT].ANSW_COUNT >= 4)
            {
                mas[CURRENT].ANSWERS[3] = tb_4.Text;
            }
            if (mas[CURRENT].ANSW_COUNT >= 5)
            {
                mas[CURRENT].ANSWERS[4] = tb_5.Text;
            }
            if (mas[CURRENT].ANSW_COUNT >= 6)
            {
                mas[CURRENT].ANSWERS[5] = tb_6.Text;
            }
            MessageBox.Show("Сохранено!");
        }

        private void TextBoxEntering(object sender, EventArgs e)
        {
            (sender as TextBox).Width *= 4;
        }
        private void TextBoxLeaving(object sender, EventArgs e)
        {
            (sender as TextBox).Width /= 4;
        }

        private void PositionUpdating(int number)
        {
            lb_Position.Text = (number + 1) + "/" + mas.Length;
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
            CURRENT = Convert.ToInt32((sender as Button).Text) - 1;
            PositionUpdating(CURRENT);
            Uncheck();
            QuestionLoad(CURRENT,"flow");
        }
        private void Uncheck()//Убираем галочки, для загрузки вопроса в форму
        {
            foreach (var a in gb_Answers.Controls)
            {
                if (a is CheckBox)
                {
                    (a as CheckBox).Checked = false;
                }
            }
        }

        private void QuestionLoad(int number, string type)
        {
            if (mas[number].QUESTION != null)
            {
                tb_Question.Text = mas[number].QUESTION;
                num_AnswCount.Value = mas[number].ANSW_COUNT;
                string[] buf = mas[number].CorrectANSW.Split(',');
                for (int i = 0; i < buf.Length; i++)
                {
                    switch (Convert.ToInt32(buf[i]))
                    {
                        case 1:
                            cb_1.Checked = true;
                            break;
                        case 2:
                            cb_2.Checked = true;
                            break;
                        case 3:
                            cb_3.Checked = true;
                            break;
                        case 4:
                            cb_4.Checked = true;
                            break;
                        case 5:
                            cb_5.Checked = true;
                            break;
                        case 6:
                            cb_6.Checked = true;
                            break;
                    }
                }
                switch (mas[number].ANSWERS.Length)
                {
                    case 1:
                        tb_1.Text = mas[number].ANSWERS[0];
                        break;
                    case 2:
                        tb_1.Text = mas[number].ANSWERS[0];
                        tb_2.Text = mas[number].ANSWERS[1];
                        break;
                    case 3:
                        tb_1.Text = mas[number].ANSWERS[0];
                        tb_2.Text = mas[number].ANSWERS[1];
                        tb_3.Text = mas[number].ANSWERS[2];
                        break;
                    case 4:
                        tb_1.Text = mas[number].ANSWERS[0];
                        tb_2.Text = mas[number].ANSWERS[1];
                        tb_3.Text = mas[number].ANSWERS[2];
                        tb_4.Text = mas[number].ANSWERS[3];
                        break;
                    case 5:
                        tb_1.Text = mas[number].ANSWERS[0];
                        tb_2.Text = mas[number].ANSWERS[1];
                        tb_3.Text = mas[number].ANSWERS[2];
                        tb_4.Text = mas[number].ANSWERS[3];
                        tb_5.Text = mas[number].ANSWERS[4];
                        break;
                    case 6:
                        tb_1.Text = mas[number].ANSWERS[0];
                        tb_2.Text = mas[number].ANSWERS[1];
                        tb_3.Text = mas[number].ANSWERS[2];
                        tb_4.Text = mas[number].ANSWERS[3];
                        tb_5.Text = mas[number].ANSWERS[4];
                        tb_6.Text = mas[number].ANSWERS[5];
                        break;
                }
                PositionUpdating(CURRENT);
                return;
            }
                tb_Question.ResetText();

                foreach(var a in gb_Answers.Controls)
                {
                    if(a is TextBox)
                    {
                        (a as TextBox).ResetText();
                    }
                    if(a is CheckBox)
                    {
                        (a as CheckBox).Checked = false;
                    }
                }
        }

        private void but_New_Click(object sender, EventArgs e)//новый вопрос
        {
            int buf=mas.Length;
            Array.Resize(ref mas, mas.Length + 1);
            flow_All.Controls.Add(new Button()
            {
                Text = (buf+1).ToString(),
                Size=new Size(50,50),
                TabStop=false
            });
            flow_All.Controls[flow_All.Controls.Count - 1].Click += new EventHandler(FlowButtonClick);
            mas[mas.Length-1] = new Question();
            CURRENT = mas.Length - 1;
            Uncheck();
            QuestionLoad(mas.Length - 1,"new");
            PositionUpdating(mas.Length - 1);
        }

        private void but_Del_Click(object sender, EventArgs e)//Удаление текущего вопроса
        {
            
        }

        private void but_End_Click(object sender, EventArgs e)//Закончить создание
        {
            TestEnding end = new TestEnding();
            end.ShowDialog();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog()==DialogResult.OK)
            {
                FileStream f = new FileStream(openFileDialog.FileName,FileMode.Open,FileAccess.Read);
                StreamReader file = new StreamReader(f);

                string first=file.ReadLine();
                string[] buf = first.Split(';');
                int count = Convert.ToInt32(buf[0]);
                mas = null;
                mas = new Question[count];
                int answCount=0;
                flow_All.Controls.Clear();
                for(int i=0;i<count;i++)
                {
                    mas[i] = new Question();
                    mas[i].QUESTION = file.ReadLine();
                    answCount = Convert.ToInt32(file.ReadLine());
                    mas[i].ANSW_COUNT = answCount;
                    mas[i].ANSWERS = new string[answCount];
                    for(int j=0;j<answCount;j++)
                    {
                        mas[i].ANSWERS[j] = file.ReadLine();
                    }
                    mas[i].CorrectANSW = file.ReadLine();
                    flow_All.Controls.Add(new Button()
                    {
                        Text = (i+1).ToString(),
                        Size = new Size(50, 50),
                        TabStop = false
                    });
                    flow_All.Controls[i].Click += new EventHandler(FlowButtonClick);
                }
                file.Close();
                f.Close();
                MessageBox.Show("Данные из файла успешно загружены!\nКоличество вопросов: "+mas.Length,"Открыть тест",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Uncheck();
                QuestionLoad(0, "flow");
            }

        }
    }
    public class Question
    {
        public string QUESTION=null;
        public int ANSW_COUNT;
        public string CorrectANSW=null;
        public string[] ANSWERS=null;

        public Question()
        {

        }
    }
}
