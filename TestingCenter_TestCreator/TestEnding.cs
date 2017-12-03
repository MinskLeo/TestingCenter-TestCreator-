using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//накидал форму но её нужно пофиксить (не под 4к)

namespace TestingCenter_TestCreator
{
    public partial class TestEnding : Form
    {
        public TestEnding()
        {
            InitializeComponent();
            tb_QuestionsCount.Text = Form1.mas.Length.ToString();
        }

        private void but_Save_Click(object sender, EventArgs e)
        {
            try
            {
                string TEST_NAME = tb_Specialty.Text + "_" + num_Semester.Value.ToString() + "_" + tb_Subject.Text;
                saveFileDialog.FileName = TEST_NAME;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    List<string> TEST_BODY = new List<string>();
                    TEST_BODY.Add(tb_QuestionsCount.Text + ";" + num_Hours.Value + ":" + num_Minutes.Value + ":" + num_Seconds.Value);
                    for (int i = 0; i < Form1.mas.Length; i++)
                    {
                        TEST_BODY.Add(Form1.mas[i].QUESTION);
                        TEST_BODY.Add(Form1.mas[i].ANSW_COUNT.ToString());
                        for (int j = 0; j < Form1.mas[i].ANSW_COUNT; j++)
                        {
                            TEST_BODY.Add(Form1.mas[i].ANSWERS[j]);
                        }
                        TEST_BODY.Add(Form1.mas[i].CorrectANSW);
                    }
                    File.WriteAllLines(saveFileDialog.FileName, TEST_BODY);
                    MessageBox.Show("Успешно сохранено!", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Что то пошло не так!\n"+ex.Message+"\n"+ex.StackTrace);
            }
        }
    }
}
