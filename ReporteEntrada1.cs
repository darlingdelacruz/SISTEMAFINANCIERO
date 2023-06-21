using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRESTAMOS2
{
    public partial class ReporteEntrada1 : Form
    {
        public ReporteEntrada1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            verentrada ver = new verentrada();
            ver.textBox1.Text = textBox1.Text;
            ver.Show();
        }
    }
}
