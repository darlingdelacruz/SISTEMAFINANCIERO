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
    public partial class Loggin : Form
    { conexion c = new conexion();
        public Loggin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {




            if (textBox3.Text != "")
            {
                c.logins(textBox1.Text, textBox2.Text);
                Inicio admin = new Inicio();
                admin.txttipo.Text = textBox3.Text;
                admin.Show();
                Hide();

            }

            else
            {
                c.logins(textBox1.Text, textBox2.Text);

                Hide();

                iconPictureBox3.Visible = true;


            }
          
           


        }



        private void Loggin_Load(object sender, EventArgs e)
        {
            iconPictureBox2.Visible = false;
            iconPictureBox3.Visible = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
                            DialogResult r = MessageBox.Show("Quiere salir de sistema?", "ADVERTENCIA", MessageBoxButtons.YesNo);
                            if (r == DialogResult.Yes)
                            {
                                Application.Exit();
                            }
                            else {

                                Form loggin = new Loggin();
                                loggin.Show();
                                loggin.Hide();
                            
                            
                            
                            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = "";
            c.tipousuario(textBox1.Text, textBox2.Text, textBox3);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged_2(object sender, EventArgs e)
        {
            Inicio admin = new Inicio();
            admin.txttipo.Text = textBox3.Text;
            if (textBox3.Text == "ADMINISTRADOR")
            {

                iconPictureBox1.Visible = false;
                iconPictureBox2.Visible = true;

            }
            else if (textBox3.Text == "Empleado") {
                iconPictureBox1.Visible = false;
                iconPictureBox2.Visible = false;
                iconPictureBox3.Visible = true;

            }
        }

        private void Loggin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) 
            
            
            {

                try
                {



                    if (textBox2.Text == "")
                    {

                        DialogResult r = MessageBox.Show("No debe dejar campos vacios, Desea Intentarlo de nuevos?", "ADVERTENCIA", MessageBoxButtons.YesNo);
                        if (r == DialogResult.Yes)
                        {
                            Form DEVUELVELOG = new Loggin();
                            DEVUELVELOG.Show();
                            Hide();


                        }
                        if (r == DialogResult.No)
                        {

                            Application.Exit();

                        }


                    }
                    

                    else if (textBox3.Text == "")
                    {
                        c.logins(textBox1.Text, textBox2.Text);

                        Hide();

                    }

                    else
                    {

                        Inicio admin = new Inicio();
                        admin.txttipo.Text = textBox3.Text;
                        admin.Show();
                        Hide();



                    }









                }
                catch (Exception ex)
                {

                }
                        
            
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "") 
            
            {
                textBox3.Text = "tipos";
                textBox3.ForeColor = Color.LightGray;   
            
            
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "tipos")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.LightGray;


            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }
        }



    }

