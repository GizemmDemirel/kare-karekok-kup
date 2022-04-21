using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {     
            int sayi;
            sayi = Convert.ToInt32(textBox1.Text);       
            double kare, karekök, küp;

            if (radioButton1.Checked)
            {
                kare = sayi * sayi;
                label1.Text = kare.ToString();
            }

            else if (radioButton2.Checked)
            {
                karekök = Math.Sqrt(sayi);
                label1.Text = karekök.ToString();
            }
            else 
                {
                  küp=sayi*sayi*sayi;
                  label1.Text= küp.ToString();
                }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
          
        }

     }
}
