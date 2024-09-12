using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabActivity1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            string wN1 = "";
            string wN2 = "";
            string wN3 = "";
            string wN4 = "";
            string wN5 = "";

            int hundredThousands = x / 100000;
            int thousands = (x - (hundredThousands * 100000)) / 1000;
            int hundreds = (x - (hundredThousands * 100000) - (thousands * 1000)) / 100;
            int tens = (x - (hundredThousands * 100000) - (thousands * 1000) - (hundreds * 100)) / 10;
            int ones = x - (hundredThousands * 100000) - (thousands * 1000) - (hundreds * 100) - (tens * 10);

            if (x >= 11 && x <= 19)
            {
                switch (x)
                {
                    case 11:
                        wN1 = "Eleven";
                        break;
                    case 12:
                        wN1 = "Twelve";
                        break;
                    case 13:
                        wN1 = "Thirteen";
                        break;
                    case 14:
                        wN1 = "Fourteen";
                        break;
                    case 15:
                        wN1 = "Fifteen";
                        break;
                    case 16:
                        wN1 = "Sixteen";
                        break;
                    case 17:
                        wN1 = "Seventeen";
                        break;
                    case 18:
                        wN1 = "Eighteen";
                        break;
                    case 19:
                        wN1 = "Nineteen";
                        break;
                }
            }
            else
            {
                switch (tens)
                {
                    case 1:
                        wN2 = "Ten";
                        break;
                    case 2:
                        wN2 = "Twenty";
                        break;
                    case 3:
                        wN2 = "Thirty";
                        break;
                    case 4:
                        wN2 = "Forty";
                        break;
                    case 5:
                        wN2 = "Fifty";
                        break;
                    case 6:
                        wN2 = "Sixty";
                        break;
                    case 7:
                        wN2 = "Seventy";
                        break;
                    case 8:
                        wN2 = "Eighty";
                        break;
                    case 9:
                        wN2 = "Ninety";
                        break;
                }

                switch (hundreds)
                {
                    case 1:
                        wN3 = "One Hundred";
                        break;
                    case 2:
                        wN3 = "Two Hundred";
                        break;
                    case 3:
                        wN3 = "Three Hundred";
                        break;
                    case 4:
                        wN3 = "Four Hundred";
                        break;
                    case 5:
                        wN3 = "Five Hundred";
                        break;
                    case 6:
                        wN3 = "Six Hundred";
                        break;
                    case 7:
                        wN3 = "Seven Hundred";
                        break;
                    case 8:
                        wN3 = "Eight Hundred";
                        break;
                    case 9:
                        wN3 = "Nine Hundred";
                        break;
                }

                switch (thousands)
                {
                    case 1:
                        wN4 = "One Thousand";
                        break;
                    case 2:
                        wN4 = "Two Thousand";
                        break;
                    case 3:
                        wN4 = "Three Thousand";
                        break;
                    case 4:
                        wN4 = "Four Thousand";
                        break;
                    case 5:
                        wN4 = "Five Thousand";
                        break;
                    case 6:
                        wN4 = "Six Thousand";
                        break;
                    case 7:
                        wN4 = "Seven Thousand";
                        break;
                    case 8:
                        wN4 = "Eight Thousand";
                        break;
                    case 9:
                        wN4 = "Nine Thousand";
                        break;
                }

                switch (hundredThousands)
                {
                    case 1:
                        wN5 = "One Hundred Thousand";
                        break;
                    case 2:
                        wN5 = "Two Hundred Thousand";
                        break;
                    case 3:
                        wN5 = "Three Hundred Thousand";
                        break;
                    case 4:
                        wN5 = "Four Hundred Thousand";
                        break;
                    case 5:
                        wN5 = "Five Hundred Thousand";
                        break;
                    case 6:
                        wN5 = "Six Hundred Thousand";
                        break;
                    case 7:
                        wN5 = "Seven Hundred Thousand";
                        break;
                    case 8:
                        wN5 = "Eight Hundred Thousand";
                        break;
                    case 9:
                        wN5 = "Nine Hundred Thousand";
                        break;
                }

                switch (ones)
                {
                    case 1:
                        wN1 = "One";
                        break;
                    case 2:
                        wN1 = "Two";
                        break;
                    case 3:
                        wN1 = "Three";
                        break;
                    case 4:
                        wN1 = "Four";
                        break;
                    case 5:
                        wN1 = "Five";
                        break;
                    case 6:
                        wN1 = "Six";
                        break;
                    case 7:
                        wN1 = "Seven";
                        break;
                    case 8:
                        wN1 = "Eight";
                        break;
                    case 9:
                        wN1 = "Nine";
                        break;
                }

                label2.Text = wN5 + " " + wN4 + " " + wN3 + " " + wN2 + " " + wN1;
            }
        }
    }
}
  