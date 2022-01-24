using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String_Comparer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Validation_Result checker = new Validation_Result();
            if(checker.ValidateUserInput(txtStringX.Text))
            {
                lblResult.Text
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("enter 2 values into box 1 and box 2 then click calculate");
            Console.WriteLine("this code is meant to recieve two strings, x and y, then it will print the longest string a of letters such that there is a permutation of a that is a subsequence of x and there is a permutation of a that is a subsequence of y");
        }
    }
}
