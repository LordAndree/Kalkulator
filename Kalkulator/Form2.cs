using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            operasi();
        }

        public delegate void Form2ClickEventHandler(int nilai_a, int nilai_b, string operasi, int hasil, string symbol);
        public event Form2ClickEventHandler handler;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nilai_a = int.Parse(textBox1.Text);
            int nilai_b = int.Parse(textBox2.Text);
            int hasil = 0;
            string operasi = "";
            string symbol = "";
            if (comboBox1.SelectedIndex == 0)
            {
                hasil = nilai_a + nilai_b;
                operasi = "Penambahan";
                symbol = "+";
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                hasil = nilai_a - nilai_b;
                operasi = "Pengurangan";
                symbol = "-";
            }
            else if(comboBox1.SelectedIndex == 2)
            {
                hasil = nilai_a * nilai_b;
                operasi = "Perkalian";
                symbol = "*";
            }
            else if(comboBox1.SelectedIndex == 3)
            {
                hasil = nilai_a / nilai_b;
                operasi = "Pembagian";
                symbol = ":";
            }
            handler(nilai_a, nilai_b, operasi, hasil, symbol);
            
        }
        private void operasi()
        {
            comboBox1.Items.Add("Penambahan");
            comboBox1.Items.Add("Pengurangan");
            comboBox1.Items.Add("Perkalian");
            comboBox1.Items.Add("Pembagian");
            comboBox1.SelectedIndex = 0;

        }
    }
}
