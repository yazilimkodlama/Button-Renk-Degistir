using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Button_Renk_Degistir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKirmizi_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            MessageBox.Show("Form rengi Kırmızı olarak ayarlandı.","Bilgi",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
        }

        private void btnMavi_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
            MessageBox.Show("Form rengi Mavi olarak ayarlandı.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }
    }
}
