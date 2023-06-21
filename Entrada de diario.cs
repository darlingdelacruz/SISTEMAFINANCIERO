using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Collections;
using PRESTAMOS2.Properties;
using System.Configuration;
using FontAwesome.Sharp;


namespace PRESTAMOS2
{

    public partial class Entrada_de_diario : Form
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt;
        SqlDataAdapter da;

        conexion c = new conexion();
        DateTime FECHA = new DateTime();
        DateTime FECHAp = new DateTime();
        Solonumero S = new Solonumero();

        public static string ObtenerString()
        {
            return Settings.Default.PRESTAMOSConnectionString1;

        }
 
        
         


        public Entrada_de_diario()
        {
            InitializeComponent();
            //dateTimePicker1.ToString("yyyy/MM/dd");
            DateTime FFecha;
           // DateTime PFecha;
            FFecha = Convert.ToDateTime(this.dateTimePicker1.Value.ToString());
            //PFecha = Convert.ToDateTime(this.textBox6.ToString());
            //time.Text = FECHA.ToString("mm/dd/yyyy");
            FECHA = DateTime.Parse(FFecha.ToString());
            //FECHAp = DateTime.Parse(PFecha.ToString());
          
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Entrada_de_diario_Load(object sender, EventArgs e)
        {
            //comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            c.llenaritems2(comboBox1);
            iconPictureBox2.Enabled = false;
            iconPictureBox3.Enabled = false;
            textBox14.Enabled = false;
            button1.Enabled = false;
            panel2.Enabled = false;
            c.selectnumeroentrada(textBox1);
            iconPictureBox6.Enabled = false;
            //PROBANDO 

            int nocuenta = Convert.ToInt32(textBox1.Text);
            nocuenta++;
            textBox1.Text = nocuenta.ToString();
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
          

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dtgDesglose_TabIndexChanged(object sender, EventArgs e)
        {
           
           
        }

        private void dtgDesglose_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*double n1 = Convert.ToDouble(textBox4.Text);
            double n2 = Convert.ToDouble(textBox5.Text);
            double total = Convert.ToDouble(textBox2.Text);
            total = n1 - n2;
            textBox2.Text = total.ToString();*/
        }

        private void dtgDesglose_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

           
        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {
          
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void dtgDesglose_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                double n1 = Convert.ToDouble(textBox4.Text);
                double n2 = Convert.ToDouble(textBox5.Text);
                double total = Convert.ToDouble(textBox2.Text);
                total = n1 - n2;
                textBox2.Text = total.ToString();
                if (dtgDesglose.CurrentCell.ColumnIndex == 12)
                {

                    var row = dtgDesglose.CurrentRow;
                    frmEditar frm = new frmEditar();
                    var txt1 = frm.Controls["textBox1"];
                    var txt2 = frm.Controls["textBox2"];
                    var txt3 = frm.Controls["textBox3"];
                    var txt4 = frm.Controls["textBox4"];
                    var txt5 = frm.Controls["textBox5"];
                    txt1.Text = row.Cells[3].Value.ToString();
                    txt2.Text = row.Cells[4].Value.ToString();
                    txt3.Text = row.Cells[7].Value.ToString();
                     txt4.Text = row.Cells[8].Value.ToString();
                     txt5.Text = row.Cells[9].Value.ToString();


                    if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {

                        row.Cells[3].Value = txt1.Text;
                        row.Cells[4].Value = txt2.Text;
                        row.Cells[7].Value = txt3.Text;
                        row.Cells[8].Value = txt4.Text;
                        row.Cells[9].Value = txt5.Text;
                     
                    }
                }
                else if (dtgDesglose.CurrentCell.ColumnIndex == 13)
                {

                    var row = dtgDesglose.CurrentRow;
                    dtgDesglose.Rows.Remove(row);

                }
            }catch(Exception ex){}
        }

        private void textBox8_Enter(object sender, EventArgs e)
        {
            if (textBox8.Text == "0.00")
            {
                textBox8.Text = "";
                textBox8.ForeColor = Color.Black;

            }
        }

        private void textBox8_Leave(object sender, EventArgs e)
        {

            if (textBox8.Text == "")
            {
                textBox8.Text = "0.00";
                textBox8.ForeColor = Color.Black;
            }
        }

        private void textBox9_Enter(object sender, EventArgs e)
        {
            if (textBox9.Text == "0.00")
            {
                textBox9.Text = "";
                textBox9.ForeColor = Color.Black;

            }
        }

        private void textBox9_Leave(object sender, EventArgs e)
        {
            if (textBox9.Text == "")
            {
                textBox9.Text = "0.00";
                textBox9.ForeColor = Color.Black;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
      
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (textBox9.Text == "")
            {
                textBox9.Text = "0.00";
                textBox9.ForeColor = Color.Black;
            }



        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox8.Text == "")
            {
                textBox8.Text = "0.00";
                textBox8.ForeColor = Color.Black;
            }
        }

        private void dtgDesglose_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            try
            {
                double total2020 = 0;
                double total2021 = 0;
                foreach (DataGridViewRow row in dtgDesglose.Rows)
                {

                    total2020 += Convert.ToDouble(row.Cells["debito"].Value);
                    total2021 += Convert.ToDouble(row.Cells["credito"].Value);
                    textBox4.Text = Convert.ToString(total2020);
                    textBox5.Text = Convert.ToString(total2021);


                }


            }
            catch (Exception ex)
            {



            }
            try
            {
                double n1 = Convert.ToDouble(textBox4.Text);
                double n2 = Convert.ToDouble(textBox5.Text);
                double total = Convert.ToDouble(textBox2.Text);
                double total2 = Convert.ToDouble(textBox12.Text);
                if (n1 > n2)
                {

                    total = n1 - n2;
                    textBox2.Text = total.ToString();
                    textBox12.Text = "0.00";
                    textBox2.ForeColor = Color.Red;
                }

                else if (n2 > n1)
                {

                    total2 = n2 - n1;
                    textBox12.Text = total2.ToString();
                    textBox12.ForeColor = Color.Red;
                    textBox2.Text = "0.00";

                }
            }
            catch (Exception) { }




        }

        private void iconButton1_Click(object sender, EventArgs e)
        {


        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            c.selectnumeroentrada(textBox1);
            //PROBANDO 

            int nocuenta = Convert.ToInt32(textBox1.Text);
            nocuenta++;
            textBox1.Text = nocuenta.ToString();
            try
            {

                //DIFERENCIA

                

              
                if (comboBox1.Text == "" | textBox7.Text == "")
                {

                    MessageBox.Show("Llene los campos correctamente.", "ADVERTENCIA!");
                    comboBox1.Text = "";
                    textBox7.Text = "";
                }
                else
                {
                    c.selectnumeroentrada(textBox1);
                    //PROBANDO 

                    int nocuentap = Convert.ToInt32(textBox1.Text);
                    nocuentap++;
                    textBox1.Text = nocuentap.ToString();
                    dtgDesglose.Rows.Add( textBox1.Text,FECHA.ToString("yyyy/MM/dd"), textBox3.Text, comboBox1.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text, textBox11.Text, textBox13.Text);
                    try
                    {
                        double total2020 = 0;
                        double total2021 = 0;
                        foreach (DataGridViewRow row in dtgDesglose.Rows)
                        {

                            total2020 += Convert.ToDouble(row.Cells["debito"].Value);
                            total2021 += Convert.ToDouble(row.Cells["credito"].Value);
                            textBox4.Text = Convert.ToString(total2020);
                            textBox5.Text = Convert.ToString(total2021);


                        }


                    }
                    catch (Exception ex)
                    {



                    }

                    try
                    {
                        double n1 = Convert.ToDouble(textBox4.Text);
                        double n2 = Convert.ToDouble(textBox5.Text);
                        double total = Convert.ToDouble(textBox2.Text);
                        double total2 = Convert.ToDouble(textBox12.Text);
                        if (n1 > n2)
                        {

                            total = n1 - n2;
                            textBox2.Text = total.ToString();
                            textBox12.Text = "0.00";
                           
                        }

                        else if (n2 > n1)
                        {

                            total2 = n2 - n1;
                            textBox12.Text = total2.ToString();
                            
                            textBox2.Text = "0.00";

                        }
                    }
                    catch (Exception) { }
                    comboBox1.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                    textBox9.Text = "";


                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Advertencia", "Llene los campos correctamente.");
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            iconPictureBox3.Enabled = true;
            button1.Enabled = true;
            iconPictureBox6.Enabled = true;
            textBox14.Enabled = true;
            //dtgDesglose.Visible = false;
           // textBox13.Visible = true;
            panel2.Enabled = true;
           
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            c.selectnumeroentrada(textBox1);
            //PROBANDO 

            
            try
            {
               
                double n1 = Convert.ToDouble(textBox4.Text);
                double n2 = Convert.ToDouble(textBox5.Text);
                if (n1 == n2 )
                {
                    c.selectnumeroentrada(textBox1);
                    int nocuentap = Convert.ToInt32(textBox1.Text);
                    nocuentap++;
                    textBox1.Text = nocuentap.ToString();
                    c.insertarentradaa(dtgDesglose,textBox1.Text);
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    comboBox1.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                    textBox9.Text = "";
                    textBox10.Text = "";
                    textBox11.Text = "";
                    textBox12.Text = "";
                    dtgDesglose.Rows.Clear();
                    verentrada ver = new verentrada();
                    ver.textBox1.Text = textBox1.Text;
                    ver.Show();
                    //ActivateButton(sender, RGBColors.color7);
                    Inicio inicio = new Inicio();
                    Hide();

                    
                }
                else if (textBox4.Text != "" | textBox4.Text != "0.00" | textBox4.Text != "0" | textBox5.Text == "" | textBox5.Text == "0.00" | textBox5.Text != "0")
                {

                    MessageBox.Show("Esta entrada no tiene monto.", "ADVERTENCIA!");
                
                }
                else if (n1 > n2)
                {

                    MessageBox.Show("El debito es mayor que el credito.", "ADVERTENCIA!");
                }
                else if (n2 > n1)
                {

                    MessageBox.Show("El credito es mayor que el debito.", "ADVERTENCIA!");
                }
            }
            catch (Exception ex) { 
            
                
            }
      
        }

        private void OpenChildForm(Entrada_de_diario entrada_de_diario)
        {
            throw new NotImplementedException();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            iconPictureBox2.Enabled=true;
            dtgDesglose.Visible = true;
            textBox14.Enabled = false;
            button1.Enabled = false;

            panel2.Enabled = true;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(textBox14.Text==""){
                MessageBox.Show("Debes insertar un numero de entrada.","ADVERTENCIA!");
            }
            else{
                textBox12.Text = "0.00";
                textBox2.Text = "0.00";
                textBox8.Text = "0.00";
                textBox9.Text = "0.00";
                textBox3.Text = "";
                dtgDesglose.Rows.Clear();

                cn = new SqlConnection(ObtenerString());
                cn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select * From entradadiario where noentrada = '" + textBox14.Text + "' ", cn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ArrayList StringList = new ArrayList();

           /* SqlDataAdapter sda1 = new SqlDataAdapter("Select * from entradadiario where noentrada = '"+textBox14.Text+"'", con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);

            foreach (DataRow item in dt1.Rows)
            {
                StringList.Add(item["noentrada"].ToString());
            }
            */
            foreach (DataRow item in dt.Rows)
            {
                int n = dtgDesglose.Rows.Add();

                var CellSample = new DataGridViewComboBoxCell();
                CellSample.DataSource = StringList;

                //dtgDesglose.Rows[n].Cells[0].Value = item[0].ToString();
                textBox1.Text = item["noentrada"].ToString();
                textBox6.Text = item["fecha"].ToString();
                //textBox6.ToString("yyyy/MM/dd");
               // textBox6.Text = Convert.ToString(textBox6.Text("yyyy/MM/dd"));
              
               // dtgDesglose.Rows[n].Cells[1].Value = item["Fecha"].ToString(); //FECHA.ToString("yyyy/MM/dd")
                dtgDesglose.Rows[n].Cells[2].Value = item["Concepto"].ToString();
                dtgDesglose.Rows[n].Cells[3].Value = item["NOCUENTA"].ToString();
                textBox3.Text = item["CONCEPTO"].ToString();
                dtgDesglose.Rows[n].Cells[4].Value = item["NOMBRE"].ToString();
                dtgDesglose.Rows[n].Cells[5].Value = item["DEBITO"].ToString();
                dtgDesglose.Rows[n].Cells[6].Value = item["CREDITO"].ToString();
                dtgDesglose.Rows[n].Cells[7].Value = item["NUMEROPADRE"].ToString();
                dtgDesglose.Rows[n].Cells[8].Value = item["NOMBREPADRE"].ToString();
                dtgDesglose.Rows[n].Cells[9].Value = item["Origen"].ToString();
                //dtgDesglose.Rows[n].Cells[7].Value = item["noentrada"].ToString();
            }}

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void iconPictureBox3_Click(object sender, EventArgs e)
        {
            
            try
            {
                double n1 = Convert.ToDouble(textBox4.Text);
                double n2 = Convert.ToDouble(textBox5.Text);
                if (n1 == n2)
                {
                   
                    c.eliminarentrada(textBox1.Text);
                    c.insertarentradaaupdate(dtgDesglose,textBox1.Text,textBox6.Text);
                    c.actualizacioonconcepto(textBox3.Text,textBox1.Text);
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    comboBox1.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                    textBox9.Text = "";
                    textBox10.Text = "";
                    textBox11.Text = "";
                    textBox12.Text = "";
                    dtgDesglose.Rows.Clear();
                    verentrada ver = new verentrada();
                    ver.textBox1.Text = textBox1.Text;
                    ver.Show();
                    //ActivateButton(sender, RGBColors.color7);
                    Inicio inicio = new Inicio();
                    Hide();


                }
                else if (textBox4.Text != "" | textBox4.Text != "0.00" | textBox4.Text != "0" | textBox5.Text == "" | textBox5.Text == "0.00" | textBox5.Text != "0")
                {

                    MessageBox.Show("Esta entrada no tiene monto.", "ADVERTENCIA!");

                }
                else if (n1 > n2)
                {

                    MessageBox.Show("El debito es mayor que el credito.", "ADVERTENCIA!");
                }
                else if (n2 > n1)
                {

                    MessageBox.Show("El credito es mayor que el debito.", "ADVERTENCIA!");
                }
            }
            catch (Exception ex)
            {


            }

        }

        private void iconPictureBox4_Click(object sender, EventArgs e)
        {
            verentrada ver = new verentrada();
            ver.textBox1.Text = textBox1.Text;
            ver.Show();
        }

        private void iconPictureBox5_Click(object sender, EventArgs e)
        {
            textBox12.Text = "0.00";
            textBox2.Text = "0.00";
             textBox4.Text = "0.00";
             textBox5.Text = "0.00";
            textBox8.Text = "0.00";
            textBox9.Text = "0.00";
            textBox3.Text = "";
            dtgDesglose.Rows.Clear();


        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            c.observar(dataGridView1,textBox15.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void iconPictureBox6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {

                MessageBox.Show("Selecciona una entrada.", "Error!");

            }


            else {


                c.eliminarentrada(textBox1.Text);
                MessageBox.Show("Se ha eliminado la entrada de diario.", "Mensaje!");
                textBox12.Text = "0.00";
                textBox2.Text = "0.00";
                textBox8.Text = "0.00";
                textBox9.Text = "0.00";
                textBox3.Text = "";
                dtgDesglose.Rows.Clear();

            }

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            textBox12.Text = "0.00";
            textBox2.Text = "0.00";
            textBox8.Text = "0.00";
            textBox9.Text = "0.00";
            textBox3.Text = "";
            dtgDesglose.Rows.Clear();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox7.Text = "";
                textBox10.Text = "";
                textBox11.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox13.Text = "";


                c.selectcatalogoentrada1(comboBox1.Text, textBox7, textBox10, textBox11, textBox8, textBox9, textBox13);

            }
            catch (Exception ex) { }

        }
    }
}
