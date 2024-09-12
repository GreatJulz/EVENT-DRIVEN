using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabActivityFibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int myNUm = Convert.ToInt32(textBox1.Text);
            int firstN = 1;
            int secondN = 1;
            int stored = 0;
            string output = "";
            for(int ctr = 0; ctr < myNUm; ctr++)
            {
                output += " " + stored;
                if(ctr > 1)
                {
                    stored = firstN + secondN;
                    secondN = firstN;
                    firstN = stored;
                }
                else
                {
                    stored = firstN;
                }

            }

            label2.Text = output;
        }
    }
}
