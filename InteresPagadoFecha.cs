﻿using System;
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
    public partial class InteresPagadoFecha : Form
    {
        conexion c = new conexion();
        public InteresPagadoFecha()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            InteresPagado rporte = new InteresPagado();
            rporte.txtfecha1.Text = dateTimePicker1.Value.ToString("yyyy/MM/dd");
            textBox1.Text = dateTimePicker1.Value.ToString("yyyy/MM/dd");
            rporte.txtfecha2.Text = dateTimePicker2.Value.ToString("yyyy/MM/dd");
            textBox2.Text = dateTimePicker2.Value.ToString("yyyy/MM/dd");
            c.reportefecha(textBox1.Text, textBox2.Text);
            rporte.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
