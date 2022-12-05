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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Hasil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.handler += display;
            form2.ShowDialog();
        }

        private void display(int nilai_a, int nilai_b, string operasi, int hasil, string symbol)
        {
            Hasil.Items.Add(string.Format("Hasil dari operasi {0} {1} {2} {3} = {4}", operasi, nilai_a, symbol, nilai_b, hasil));
        }
    }
}
