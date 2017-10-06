using System;
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
        string time;
        string hours = "0";
        string minutes = "0";
        string seconds = "0";

        public TestEnding()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            hours = Convert.ToString(Thours.Text);
            minutes = Convert.ToString(Tminutes.Text);
            seconds = Convert.ToString(Tseconds.Text);



        }
    }
}
