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
    public partial class CrearUsuarios : Form
    {
        conexion c = new conexion();
        public CrearUsuarios()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

              if (textBox1.Text == "" | comboBox1.Text == "" | textBox2.Text == "" | textBox3.Text == "")
                    
                    
                    {

                        MessageBox.Show("No debes de dejar campos vacios.", "Mensaje");
                    
                    }
           else if (c.verificacionusuario(textBox1.Text) == 0)
            {
               
                    if (textBox2.Text == textBox3.Text)
                    { c.crearusuario(textBox1.Text, textBox2.Text, comboBox1.Text);
                    MessageBox.Show("Usuario registrado.","Mensaje");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    
                    
                    }

                  
                }
            else
            {
                MessageBox.Show("EL nombre del usuario ya existe");


            }

            }
          


        private void button2_Click(object sender, EventArgs e)
        {
            c.eliminarusuario(textBox1.Text);
           MessageBox.Show("Usuario Eliminado.", "Mensaje");
           textBox1.Text = "";
           comboBox1.Text = "";
           textBox2.Text = "";
           textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            comboBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

        }

        private void CrearUsuarios_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inicio FINICIO = new Inicio();
            FINICIO.txttipo.Text = txtcrearusuario.Text;
            FINICIO.Show();
            Hide();
        }

        private void pAGOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pagos FPAGOS = new Pagos();
            FPAGOS.txttipopago.Text = txtcrearusuario.Text;
            FPAGOS.Show();
            Hide();
        }

        private void rEPOTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FREPORTE = new Reporte_General();
            FREPORTE.Show();
           
        }

        private void CrearUsuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == textBox3.Text)
            {
                c.editar(textBox2.Text, textBox1.Text);
                MessageBox.Show("La contraseña fue modificada con exito.", "Mensaje");
            }

            else 
            {

                MessageBox.Show("Las contraseñas no coinciden.", "Mensaje");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            c.contrase(textBox1.Text, textBox2, textBox3,comboBox1);
        }

        private void cALCULADORAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculadora FCALCULADORA = new Calculadora();
            FCALCULADORA.calculadortext.Text = txtcrearusuario.Text;
            FCALCULADORA.Show();
            Hide();
        }

        private void sALIRToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Quiere salir de sistema?", "Mensaje", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                Application.Exit();
            }
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
