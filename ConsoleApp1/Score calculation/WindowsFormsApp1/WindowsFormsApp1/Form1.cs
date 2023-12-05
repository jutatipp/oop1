using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int arrayIndex = 0;
        string[] arrID = new string[1000];
        string[] arrName = new string[1000];
        string[] arrScore = new string[1000];

     

        private void button1_Click(object sender, EventArgs e)
        {
            string inputID = textBoxID.Text;
            string inputName = textBoxName.Text;
            string inputScore = textBoxScore.Text;
          
            arrID[arrayIndex] = inputID;
            arrName[arrayIndex] = inputName;
            arrScore[arrayIndex] = inputScore;
            arrayIndex++;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
