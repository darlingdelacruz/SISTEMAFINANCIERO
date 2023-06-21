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
    public partial class FECHASDETALLADAS : Form
    {
        conexion c = new conexion();
        public FECHASDETALLADAS()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Reportemovimientodecuentadetallada rporte = new Reportemovimientodecuentadetallada();
            rporte.tebo1.Text = dateTimePicker1.Value.ToString("yyyy/MM/dd");
            textBox1.Text = dateTimePicker1.Value.ToString("yyyy/MM/dd");
            rporte.tebo2.Text = dateTimePicker2.Value.ToString("yyyy/MM/dd");
            textBox2.Text = dateTimePicker2.Value.ToString("yyyy/MM/dd");
            rporte.tebo3.Text = textBox4.Text;
            c.reportefecha1(textBox1.Text, textBox2.Text);
            rporte.Show();
        }

       

        private void FECHASDETALLADAS_Load(object sender, EventArgs e)
        {
            iconPictureBox1.Visible = false;
            iconPictureBox2.Visible = false;
            pictureBox2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            iconPictureBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            textBox3.Text = "";
            textBox4.Text = "";


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           iconPictureBox2.Visible = true;
           pictureBox1.Visible = false;
           pictureBox2.Visible = true;
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            c.selectbanco1(textBox4.Text, textBox3);
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
           
            c.selectbancocatalogo(textBox4.Text, textBox3);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ya rporte = new ya();
            rporte.tebo1.Text = dateTimePicker1.Value.ToString("yyyy/MM/dd");
            textBox1.Text = dateTimePicker1.Value.ToString("yyyy/MM/dd");
            rporte.tebo2.Text = dateTimePicker2.Value.ToString("yyyy/MM/dd");
            textBox2.Text = dateTimePicker2.Value.ToString("yyyy/MM/dd");
            rporte.tebo3.Text = textBox4.Text;
            c.reportefecha1(textBox1.Text, textBox2.Text);
            rporte.Show();
        }
    }
}
