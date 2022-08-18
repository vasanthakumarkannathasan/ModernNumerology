using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numerology
{
    public partial class Form1 : Form
    {
        int numerologicNumber = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numerologicNumber = 0;
            Image file;
            foreach (char ch in txtBox_Name.Text.ToUpperInvariant())
            {                
                numerologicNumber += letterValues(ch);                
            }

            if (numerologicNumber <= 108)
            {
                lbl_ResultValue.Text = "Your naming numerlogical number is :" + numerologicNumber;
                file = Image.FromFile(String.Format(@"Images\{0}.PNG", +numerologicNumber));
                pictureBox1.Image = file;
            }
            else
            {
                lbl_ResultValue.Text = "Your naming numerlogical number looks out of range :" + numerologicNumber;
                pictureBox1.InitialImage = null;
            }                                  
        }

        private int letterValues(char ch)
        {           
            switch (ch)
            {
                case 'A':
                case 'I':
                case 'J':
                case 'Q':
                case 'Y':
                    return 1;
                case 'B':
                case 'K':
                case 'R':
                    return 2;                
                case 'C':
                case 'G':
                case 'L':
                case 'S':
                    return 3;
                case 'D':
                case 'M':
                case 'T':
                    return 4;
                case 'E':
                case 'H':
                case 'N':
                case 'X':
                    return 5;
                case 'U':
                case 'V':
                case 'W':
                    return 6;
                case 'O':
                case 'Z':                
                    return 7;
                case 'F':
                case 'P':
                    return 8;
                default:
                    return 0;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtBox_Name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }
        }
    }
}
