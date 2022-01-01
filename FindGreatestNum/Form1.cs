using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindGreatestNum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int num1, num2, num3;

        private void btnFind_Click_1(object sender, EventArgs e)
        {
            num1 = Int16.Parse(tboxNum1.Text);
            num2 = Int16.Parse(tboxNum2.Text);
            num3 = Int16.Parse(tboxNum3.Text);
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    MessageBox.Show("The Greatest Number: " + num1);
                }
                else
                {
                    MessageBox.Show("The Greatest Number: " + num3);
                }
            }
            else
            {
                if (num2 > num3)
                {
                    MessageBox.Show("The Greatest Number: " + num2);
                }
                else
                {
                    MessageBox.Show("The Greatest Number: " + num3);
                }
            }
        }
    }
}
