using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
//накидал форму но её нужно пофиксить (не под 4к)

namespace TestingCenter_TestCreator
{
    public partial class TestEnding : Form
    {
        string time;
        string hours = "0";
        string minutes = "0";
        string seconds = "0";
        string FileName = null;
        int QuestionCount = 0;
        public TestEnding(int count)
        {           
            InitializeComponent();
            QuestionCount = count;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            hours = Thours.Text;
            minutes = Tminutes.Text;
            seconds = Tseconds.Text;

            time = hours + ":" + minutes + ":" + seconds;

            
        }
    }
}
