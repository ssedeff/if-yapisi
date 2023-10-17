using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace if_yapısı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2;
            sayi1=Convert.ToInt32(textBox1.Text);
            sayi2=Convert.ToInt32(textBox2.Text);
            if(sayi1 > sayi2) 
            {
                MessageBox.Show("1.Sayı Büyük");
            }

            else if(sayi1 < sayi2) 
            {
                MessageBox.Show("2.Sayı Büyük");
            }

            else 
            {
                MessageBox.Show("İki Sayıda Eşittir");
            }
        }
    }
}
