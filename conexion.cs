using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using PRESTAMOS2.Properties;
using System.Configuration;

namespace PRESTAMOS2
{
    public class conexion
    {
        public static string ObtenerString()
        {
            return Settings.Default.PRESTAMOSConnectionString1;

        }
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt;
        SqlDataAdapter da;


        public conexion()
        {
            try
            {
                cn = new SqlConnection(ObtenerString());
                cn.Open();

            }

            catch (Exception ex)
            {
                MessageBox.Show("No se conecto con la base de datos" + ex.ToString());
            }


        }

        public void insertar(DataGridView dtgDesglose, string noentrada)
        {

            cmd = new SqlCommand("insert into credito values (@Cedula,@NombreCompleto,@Telefono,@Direccion,@Periodo,@FechaPago ,@SaldoInicial,@Cuota ,@Interes ,@Estado,@TIPOPAGO,@SaldoFinal,@MontoAlternativo,@fechapagada,@Reenganche,@fechareporte,@fechareporte2,@mora1,@RTipo,@NumeroCuenta,@Banco,@tipodecliente,'"+noentrada+"',@interesaplicado)", cn);
            try
            {
                foreach (DataGridViewRow row in dtgDesglose.Rows)
                {
                    cmd.Parameters.Clear();

                    cmd.Parameters.AddWithValue("@Cedula", Convert.ToString(row.Cells["Cedula"].Value));
                    cmd.Parameters.AddWithValue("@NombreCompleto", Convert.ToString(row.Cells["NombreCompleto"].Value));
                    cmd.Parameters.AddWithValue("@Telefono", Convert.ToString(row.Cells["Telefono"].Value));
                    cmd.Parameters.AddWithValue("@Direccion", Convert.ToString(row.Cells["Direccion"].Value));
                    cmd.Parameters.AddWithValue("@Periodo", Convert.ToString(row.Cells["Periodo"].Value));
                    cmd.Parameters.AddWithValue("@FechaPago", Convert.ToString(row.Cells["fechapago"].Value));
                    cmd.Parameters.AddWithValue("@SaldoInicial", Convert.ToString(row.Cells["SaldoInicial"].Value));
                    cmd.Parameters.AddWithValue("@Cuota", Convert.ToDouble(row.Cells["cuota"].Value));
                    cmd.Parameters.AddWithValue("@Interes", Convert.ToDouble(row.Cells["interes"].Value));
                    cmd.Parameters.AddWithValue("@Estado", Convert.ToString(row.Cells["Estado"].Value));
                    cmd.Parameters.AddWithValue("@TIPOPAGO", Convert.ToString(row.Cells["TIPOPAGO"].Value));
                    cmd.Parameters.AddWithValue("@Fechapagada", Convert.ToString(row.Cells["fechapagada"].Value));
                    cmd.Parameters.AddWithValue("@MontoAlternativo", Convert.ToString(row.Cells["capital"].Value));
                    cmd.Parameters.AddWithValue("@SaldoFinal", Convert.ToDouble(row.Cells["capital"].Value));
                    cmd.Parameters.AddWithValue("@Reenganche", Convert.ToString(row.Cells["Reenganche"].Value));
                    cmd.Parameters.AddWithValue("@fechareporte", Convert.ToString(row.Cells["fechapagada"].Value));
                    cmd.Parameters.AddWithValue("@fechareporte2", Convert.ToString(row.Cells["fechapagada"].Value));
                    cmd.Parameters.AddWithValue("@mora1", Convert.ToString(row.Cells["mora"].Value));
                    cmd.Parameters.AddWithValue("@RTipo", Convert.ToString(row.Cells["TIPOPAGO"].Value));
                    cmd.Parameters.AddWithValue("@NumeroCuenta", Convert.ToString(row.Cells["numero"].Value));
                    cmd.Parameters.AddWithValue("@Banco", Convert.ToString(row.Cells["banco"].Value));
                    cmd.Parameters.AddWithValue("@tipodecliente", Convert.ToString(row.Cells["tipodecliente"].Value));    
                    cmd.Parameters.AddWithValue("@interesaplicado ", Convert.ToDouble(row.Cells["interesaplicado"].Value));
                    cmd.ExecuteNonQuery();




                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

          
        }

        public void cargarPersonas(DataGridView dtgDesglose)
        {
            try
            {
                da = new SqlDataAdapter("Select * from credito", cn);
                dt = new DataTable();
                da.Fill(dt);
                dtgDesglose.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llanar el datagrieView: " + ex.ToString());
            }
        }

        public string insertarfecha(string fechapagada, string cedula, string periodo, string reenganche)
        {
            string salida = "Se se inserto";
            try
            {
                cmd = new SqlCommand("Update credito set fechapagada = '" + fechapagada + "' where cedula = '" + cedula + "'and Periodo = '" + periodo + "' and reenganche = '" + reenganche + "' ", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;

        }

        public string updatemora(string cedula, string periodo, string mora, string reenganche)
        {
            string salida = "Se se inserto";
            try
            {
                cmd = new SqlCommand("Update credito set mora1 = '" + mora + "' where cedula = '" + cedula + "'and periodo = '" + periodo + "' and reenganche = '" + reenganche + "'", cn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;

        }



        public string reportetipo(string tipo)
        {
            string salida = "Se se inserto";
            try
            {
                cmd = new SqlCommand("Update credito set Rtipo = '" + tipo + "' ", cn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;

        }
        public string eliminarmora(string cedula, string periodo, string mora, string reenganche)
        {
            string salida = "Se se inserto";
            try
            {
                cmd = new SqlCommand("Update credito set mora1 = '0.00' where cedula = '" + cedula + "'and periodo = '" + periodo + "' and reenganche = '" + reenganche + "'", cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se Actualizo.", "Mensaje:");
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;

        }

        public string eliminarInteres(string mora,string cedula, string periodo, string reenganche)
        {
            string salida = "Se actualizo";
            try
            {
                cmd = new SqlCommand("Update credito set interes = '0.00' where cedula = '" + cedula + "'and periodo = '" + periodo + "' and reenganche = '" + reenganche + "'", cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se Actualizo.", "Mensaje:");
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;

        }
        

        public string reportefecha(string reportefecha1, string reportefecha2)
        {
            string salida = "Se se inserto";
            try
            {
                cmd = new SqlCommand("Update credito set fechareporte = '" + reportefecha1 + "', fechareporte2 = '" + reportefecha2 + "' ", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }
        public string reportefecha1(string reportefecha1, string reportefecha2)
        {
            string salida = "Se se inserto";
            try
            {
                cmd = new SqlCommand("Update movimiento set fechareporte = '" + reportefecha1 + "', fechareporte2 = '" + reportefecha2 + "' ", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }
        public string reportefechaENTRADA(string reportefecha1, string reportefecha2)
        {
            string salida = "Se se inserto";
            try
            {
                cmd = new SqlCommand("Update ENTRADADIARIO set fechareporte1 = '" + reportefecha1 + "', fechareporte2 = '" + reportefecha2 + "' ", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }
        public string eliminarentrada(string reportefecha1)
        {
            string salida = "Se se inserto";
            try
            {
                cmd = new SqlCommand("delete entradadiario where noentrada= '" + reportefecha1 + "'", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }
        public string insertarfechatotal(string fechapagada, string cedula)
        {
            string salida = "Se se inserto";
            try
            {
                cmd = new SqlCommand("Update credito set fechapagada = '" + fechapagada + "' where cedula = '" + cedula + "' ", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }
        /*public int clienteRegistrado(string id)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from Datoscliente where cedula='" + id + "'", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }
            return contador;
        }*/

        public void llenarTextboxConsulta(string cedula, TextBox textBox2, TextBox textBox5)
        {
            try
            {
                cmd = new SqlCommand("Select * from  credito where cedula= '" + cedula + "' and Estado = 'Pendiente' order by periodo asc", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {


                    textBox2.Text = dr["NombreCompleto"].ToString();
                    textBox5.Text = dr["periodo"].ToString();


                }
                dr.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo encontar por : " + ex.ToString());
            }
        }

        public void llenarTextboxConsultawaow(string cedula, string textBox2, TextBox textBox5, TextBox textBox4, TextBox textBox6)
        {
            try
            {
                cmd = new SqlCommand("Select * from  credito where cedula= '" + cedula + "' and reenganche= '"+ textBox2+"' and estado= 'Pendiente' order by periodo asc", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {


                    textBox5.Text = dr["NombreCompleto"].ToString();
                    textBox4.Text = dr["Telefono"].ToString();
                    textBox6.Text = dr["Direccion"].ToString();
                    



                }
                dr.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo encontar por : " + ex.ToString());
            }
        }
        public void llenarTextboxConsulta1(string cedula, string reenganche, TextBox textBox2, TextBox textBox3, TextBox textBox6, TextBox textBox7, TextBox textBox5, TextBox textBox8, TextBox textBox9, TextBox textBox10, TextBox textBox11)
        {
            try
            {
                cmd = new SqlCommand("Select * from  credito where cedula= '" + cedula + "' and reenganche = '" + reenganche + "' and Estado <> 'Pagado' order by periodo asc", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {


                    textBox2.Text = dr["NombreCompleto"].ToString();
                    textBox3.Text = dr["periodo"].ToString();
                    textBox6.Text = dr["numerocuenta"].ToString();
                    textBox7.Text = dr["banco"].ToString();
                    textBox8.Text = dr["tipopago"].ToString();
                    textBox9.Text = dr["saldoinicial"].ToString();
                    textBox10.Text = dr["interes"].ToString();
                    textBox11.Text = dr["tipodecliente"].ToString();


                }
                dr.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo encontar por : " + ex.ToString());
            }
        }
        public void llenarTextboxConsultaabono(string cedula, string reenganche, TextBox textBox2, TextBox textBox6, TextBox textBox7, TextBox textBox8, TextBox textBox9, TextBox textBox10, TextBox textBox4, TextBox textBox5, TextBox textBoxcomplicacion, TextBox textBoxcomplicacion2, TextBox textBoxcomplicacion3)
        {
            try
            {
                cmd = new SqlCommand("Select * from  credito where cedula= '" + cedula + "' and reenganche = '" + reenganche + "' and Estado = 'Pendiente' order by periodo asc", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {


                    textBox2.Text = dr["NombreCompleto"].ToString();
                    textBox6.Text = dr["numerocuenta"].ToString();
                    textBox7.Text = dr["banco"].ToString();
                    textBox8.Text = dr["tipopago"].ToString();
                    textBox9.Text = dr["saldoinicial"].ToString();
                    textBox10.Text = dr["tipodecliente"].ToString();
                    textBox4.Text = dr["telefono"].ToString();
                    textBox5.Text = dr["direccion"].ToString();
                    textBoxcomplicacion.Text= dr["periodo"].ToString();
                    textBoxcomplicacion2.Text = dr["montoalternativo"].ToString();
                    textBoxcomplicacion3.Text = dr["interes"].ToString();


                }
                dr.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo encontar por : " + ex.ToString());
            }
        }
        public void llenarTextboxConsultaeditar(string cedula, string reenganche, TextBox textBox2, TextBox textBox4, TextBox textBox5, TextBox textBox6, TextBox textBox7, TextBox textBox8,TextBox textBox1)
        {
            try
            {
                cmd = new SqlCommand("Select * from  credito where cedula= '" + cedula + "' and reenganche = '" + reenganche + "'  order by periodo asc", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    textBox1.Text = dr["cedula"].ToString();
                    textBox2.Text = dr["NombreCompleto"].ToString();
                    textBox4.Text = dr["telefono"].ToString();
                    textBox5.Text = dr["direccion"].ToString();
                    textBox6.Text = dr["numerocuenta"].ToString();
                    textBox7.Text = dr["banco"].ToString();
                    textBox8.Text = dr["tipodecliente"].ToString();
                    



                }
                dr.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo encontar por : " + ex.ToString());
            }
        }
        public void llenarTextboxbobo(string cedula, string reenganche, TextBox textBox2)
        {
            try
            {
                cmd = new SqlCommand("Select * from  credito where cedula= '" + cedula + "' and reenganche = '" + reenganche + "' order by periodo asc", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {


                    textBox2.Text = dr["saldoinicial"].ToString();
                   


                }
                dr.Close();
            }


            catch (Exception ex)
            {
                MessageBox.Show("No se pudo encontar por : " + ex.ToString());
            }
        }

        public void llenarPeriododesc(string cedula, string reenganche, TextBox textBox2)
        {
            try
            {
                cmd = new SqlCommand("Select * from  credito where cedula= '" + cedula + "' and reenganche = '" + reenganche + "' order by periodo desc", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {


                    textBox2.Text = dr["periodo"].ToString();



                }
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo encontar por : " + ex.ToString());
            }
        }
        
       /* public void llenarTextboxConsulta12(string cedula, string reenganche, TextBox textBox2, TextBox textBox3, TextBox textBox4)
        {
            try
            {
                cmd = new SqlCommand("Select * from  credito where cedula= '" + cedula + "'and reenganche = '" + reenganche + "' and Estado = 'Pendiente' order by periodo desc", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {


                    textBox2.Text = dr["NombreCompleto"].ToString();
                    textBox3.Text = dr["periodo"].ToString();
                    textBox4.Text = dr["interes"].ToString();





                }
                dr.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo encontar por : " + ex.ToString());
            }
        }*/
        public void llenarTextboxConsulta123(string cedula, TextBox textBox2,ComboBox bolon)
        {

            try
            {
                cmd = new SqlCommand("Select  nombreCompleto, reenganche from  credito where cedula= '" + cedula + "' GROUP BY reenganche,nombreCompleto  order by REENGANCHE asc ", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    textBox2.Text = dr["NombreCompleto"].ToString();
                    bolon.Items.Add(dr["reenganche"]).ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Datos erroneos.", "ERROR!");


            }
        }


        public void llenarTextboxConsulta124(string cedula, TextBox textBox2,TextBox textBox3,string combobo)
        {
            try
            {
                cmd = new SqlCommand("Select * from  credito where cedula= '" + cedula + "' and reenganche = '"+combobo+"'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {


                    textBox2.Text = dr["NombreCompleto"].ToString();
                    textBox3.Text = dr["noentrada"].ToString();



                }
                dr.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo encontar por : " + ex.ToString());
            }
        }
         public void cartaselect(string cedula, string textBox2, TextBox textBox4,TextBox textBox5)
         {
             try
             {
                 cmd = new SqlCommand("Select * From credito where cedula ='"+cedula+"'and reenganche = '"+textBox2+"' order by periodo desc", cn);
                 dr = cmd.ExecuteReader();
                 if (dr.Read())
                 {


                     textBox4.Text= dr["NombreCompleto"].ToString();
                     textBox5.Text = dr["Estado"].ToString();
                    

                 }
                 dr.Close();
               
             }

             catch (Exception ex)
             {
                 MessageBox.Show("No se pudo encontar por : " + ex.ToString());
             }
         }
        public string buscar(DataGridView dataGridView1, string textBox1, string reenganche)
        {
            string salida = "Wtf";
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Periodo, FechaPago, SaldoInicial, Cuota, Interes, Mora,Estado, TIPOPAGO FROM credito where cedula = '" + textBox1 + "' and Reenganche ='" + reenganche + "' and estado <> 'Pagado' order by periodo asc", cn);
                DataTable data = new DataTable();

                sda.Fill(data);
                dataGridView1.DataSource = data;


                dr.Close();
            }




            catch (Exception ex)
            {

            }
            return salida;


        }
        public string buscarTODOS(DataGridView dataGridView1)
        {
            string salida = "Wtf";
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Cedula,nombrecompleto,Periodo, FechaPago, SaldoInicial, Cuota, Interes, Mora, SaldoFinal, Estado, TIPOPAGO FROM credito  order by periodo asc", cn);
                DataTable data = new DataTable();

                sda.Fill(data);
                dataGridView1.DataSource = data;


                dr.Close();
            }




            catch (Exception ex)
            {

            }
            return salida;


        }
        public string PAGO(string cedula, string periodo, string reenganche)
        {
            string salida = "Se actualizaron los datos";
            try
            {
                cmd = new SqlCommand("Update credito set Estado = 'Pagado' where cedula = '" + cedula + "'and Periodo = '" + periodo + "' and Reenganche = '" + reenganche + "'", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se actualizo" + ex.ToString();
            }
            return salida;
        }

        public string PAGOINTERES(string cedula, string periodo, string reenganche)
        {
            string salida = "Se actualizaron los datos";
            try
            {
                cmd = new SqlCommand("Update credito set Estado = 'Interes/P' where cedula = '" + cedula + "'and Periodo = '" + periodo + "' and Reenganche = '" + reenganche + "'", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se actualizo" + ex.ToString();
            }
            return salida;
        }
        /*public int PAGODUPLICADO(string cedula, string periodo)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from CREDITO where  periodo ='" + periodo + "' and  cedula = '" + cedula + "'", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }
            return contador;

        }*/
        public int VERIFICARTODO(string cedula, string reenganche, string periodo1, string periodo2, string saldofinal)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("update credito set  INTERES = '0.0', montoalternativo = '" + saldofinal + "' where cedula  = '" + cedula + "' and Reenganche = '" + reenganche + "' AND periodo BETWEEN  '" + periodo1 + "'and  '" + periodo2 + "'  ", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }
            return contador;
        }
        public int superlogica(string cedula, string reenganche, string periodo1, string saldofinal)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("update credito set montoalternativo = '" + saldofinal + "' where cedula  = '" + cedula + "' and Reenganche = '" + reenganche + "' and periodo ='" + periodo1 + "' ", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }
            return contador;
        }
        public int PAGARTODO(string cedula, string reenganche, string periodo1, string periodo2,string fecha)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("update credito set  estado = 'Pagado', fechaPagada = '" + fecha + "' where cedula  = '" + cedula + "' and Reenganche = '" + reenganche + "' ", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }
            return contador;
        }
        public string crearusuario(string nombre, string contraseña, string tipo)
        {
            string salida = "";
            try
            {
                cmd = new SqlCommand("Insert into USUARIO (nombre, contraseña,tipodeusuario) values('" + nombre + "','" + contraseña + "','" + tipo + "')", cn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;

        }
        public int verificacionusuario(string nombre)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from USUARIO where nombre ='" + nombre + "'", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }
            return contador;
        }

        public string eliminarusuario(string nombre)
        {
            string salida = "Se elimino la persona";
            try
            {
                cmd = new SqlCommand("Delete USUARIO where nombre ='" + nombre + "'", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se elimino" + ex.ToString();
            }
            return salida;
        }
        public int editar(string contrase, string nombre)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("update usuario set contraseña = '" + contrase + "' where nombre  = '" + nombre + "'", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }
            return contador;
        }


        public void contrase(string nombre, TextBox textBox2, TextBox textBox3, ComboBox comboBox1)
        {
            try
            {
                cmd = new SqlCommand("Select * from  usuario where nombre = '" + nombre + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBox2.Text = dr["contraseña"].ToString();
                    textBox3.Text = dr["contraseña"].ToString();
                    comboBox1.Text = dr["tipodeusuario"].ToString();

                }
                dr.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo encontar por : " + ex.ToString());
            }
        }

        public string logins(string nombre, string contraseña)
        {

            string salida = "";
            try
            {

                {

                    using (SqlCommand cmd = new SqlCommand("SELECT nombre, contraseña FROM USUARIO WHERE nombre='" + nombre + "' AND contraseña='" + contraseña + "' ", cn))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {


                            dr.Close();

                        }

                        else
                        {
                            DialogResult r = MessageBox.Show("Datos Incorrectos, Desea Intentarlo de nuevos?", "ADVERTENCIA", MessageBoxButtons.YesNo);
                            if (r == DialogResult.Yes)
                            {
                                Form DEVUELVELOG = new Loggin();
                                DEVUELVELOG.Show();




                            }

                            if (r == DialogResult.No)
                            {
                                Application.Exit();


                            }

                            dr.Close();


                        }
                    }
                }


            }

            catch (Exception ex)
            {

            }
            return salida;


        }

        public void tipousuario(string nombre, string contraseña, TextBox textBox3)
        {
            try
            {
                cmd = new SqlCommand("Select * from  usuario where nombre = '" + nombre + "' and contraseña ='" + contraseña + "' ", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {


                    textBox3.Text = dr["Tipodeusuario"].ToString();

                }

                dr.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo encontar por : " + ex.ToString());
            }
        }




        public string tipo(string nombre)
        {
            string salida = "Se elimino la persona";
            try
            {
                cmd = new SqlCommand("select * from  USUARIO where nombre ='" + nombre + "'", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se elimino" + ex.ToString();
            }
            return salida;
        }


        public void duplicidad(string cedula, string reenganche, TextBox textBox2, string textBox3, TextBox textBox6, TextBox textBox7, TextBox textBox8, TextBox textBox9, TextBox textBox10, TextBox textBox11, TextBox textBox12, TextBox textBox13)
        {
         
            try
            {
                cmd = new SqlCommand("Select * from  credito where cedula = '" + cedula + "'and Reenganche = '" + reenganche + "' and Estado <> 'Pagado'  and periodo = '"+textBox3+"' order by periodo asc", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {


                    textBox2.Text = dr["nombrecompleto"].ToString();
                    textBox6.Text = dr["mora"].ToString();
                    textBox7.Text = dr["numerocuenta"].ToString();
                    textBox8.Text = dr["Banco"].ToString();
                    textBox9.Text = dr["cuota"].ToString();
                    textBox10.Text = dr["tipodecliente"].ToString();
                    textBox11.Text = dr["mora"].ToString();
                    textBox12.Text = dr["interes"].ToString();
                    textBox13.Text = dr["estado"].ToString();
                    

                }
                else
                {


                }


                dr.Close();
               
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo encontar por : " + ex.ToString());
            }
        }
        public void traerPeriodo(string cedula, string reenganche, ComboBox textBox3)
        {
            try
            {
                cmd = new SqlCommand("Select * from  credito where cedula = '" + cedula + "'and Reenganche = '" + reenganche + "' and Estado <> 'Pagado'  order by periodo asc", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    textBox3.Items.Add(dr["periodo"]).ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Datos erroneos.", "ERROR!");


            }
        }
        public void MUJERINFIEL(string cedula, string reenganche, TextBox textBox2, TextBox textBox99)
        {
            try
            {
                cmd = new SqlCommand("Select * from  credito where cedula = '" + cedula + "'and Reenganche = '" + reenganche + "' and Estado <> 'PAGADO'  order by periodo desc", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {


                    textBox2.Text = dr["periodo"].ToString();
                    textBox99.Text = dr["interes"].ToString();


                }
                else
                {


                }

                dr.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo encontar por : " + ex.ToString());
            }
        }
        public void pagoInteres(string cedula, string reenganche, TextBox textBox30)
        {
            try
            {
                cmd = new SqlCommand("Select * from  credito where cedula = '" + cedula + "'and Reenganche = '" + reenganche + "' and Estado <> 'PAGADO'  order by periodo asc", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {



                    textBox30.Text = dr["estado"].ToString();

                }
                else
                {


                }

                dr.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo encontar por : " + ex.ToString());
            }
        }
        public void traerNombre(string cedula,TextBox textBox30, ComboBox textBox31)
        {
            try
            {
                cmd = new SqlCommand("Select nombrecompleto,reenganche from  credito where cedula = '" + cedula + "' and estado ='Interes/P' GROUP BY reenganche,nombrecompleto  order by REENGANCHE asc", cn);
                dr = cmd.ExecuteReader();


              
            
                    while (dr.Read())
                    {

                        textBox31.Items.Add(dr["reenganche"]).ToString();
                        textBox30.Text = dr["nombrecompleto"].ToString();
                    }
          

             

                dr.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo encontar por : " + ex.ToString());
            }
        }
        public void hombreINFIEL(string cedula, string reenganche, TextBox textBox2)
        {
            try
            {
                cmd = new SqlCommand("Select * from  credito where cedula = '" + cedula + "'and Reenganche = '" + reenganche + "'  order by periodo asc", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {


                    textBox2.Text = dr["saldoinicial"].ToString();



                }
                else
                {


                }

                dr.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo encontar por : " + ex.ToString());
            }
        }

        public string eliminarcliente(string cedula, string Reengan)
        {
            string salida = "Se elimino la persona";
            try
            {
                cmd = new SqlCommand("Delete credito where cedula ='" + cedula + "' and reenganche = '" + Reengan + "' ", cn);
                cmd.ExecuteNonQuery();
                

            }
            catch (Exception ex)
            {
                salida = "No se elimino" + ex.ToString();
            }
            return salida;

        }
        public string eliminarconentrada(string textBox1)
        {
            string salida = "Se elimino la entrada";
            try
            {
                cmd = new SqlCommand("Delete EntradaDiario where noentrada ='"+ textBox1 +"' ", cn);
                cmd.ExecuteNonQuery();
                

            }
            catch (Exception ex)
            {
                salida = "No se elimino" + ex.ToString();
            }
            return salida;

        }
        public string eliminarcliente1(string cedula, TextBox nombre, string Reengan)
        {
            string salida = "Se elimino la persona";
            try
            {
                cmd = new SqlCommand("Delete credito where cedula ='" + cedula + "' and reenganche = '" + Reengan + "' and estado = 'Pendiente' ", cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se elimino el cliente", "Mensaje!");

            }
            catch (Exception ex)
            {
                salida = "No se elimino" + ex.ToString();
            }
            return salida;

        }
        public string ordenar(string cedula, TextBox nombre, string Reengan)
        {
            string salida = "Se elimino la persona";
            try
            {
                cmd = new SqlCommand("Delete credito where cedula ='" + cedula + "' and reenganche = '" + Reengan + "' ", cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se elimino el cliente", "Mensaje!");

            }
            catch (Exception ex)
            {
                salida = "No se elimino" + ex.ToString();
            }
            return salida;

        }

        public void llenaritems(ComboBox cobragay)
        {
            try
            {
                cmd = new SqlCommand("Select Numero from cuenta order by Numero asc", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cobragay.Items.Add(dr["Numero"]).ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Datos erroneos.", "ERROR!");


            }
        }
        public void llenarcombo(ComboBox bolon,string cobrita)

        {
            try
            {
                cmd = new SqlCommand("select reenganche from credito where cedula ='"+cobrita+"' and estado <> 'Pagado'  GROUP BY reenganche  order by REENGANCHE asc ", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    bolon.Items.Add(dr["reenganche"]).ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Datos erroneos.", "ERROR!");


            }
        }
        public void llenarcombocarta(ComboBox bolon, string cobrita)
        {
            try
            {
                cmd = new SqlCommand("select reenganche from credito where cedula ='" + cobrita + "'  GROUP BY reenganche  order by REENGANCHE asc ", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    bolon.Items.Add(dr["reenganche"]).ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Datos erroneos.", "ERROR!");


            }
        }

        

        public string insertarcuenta(string nombre, string contraseña, string tipo, string fechada)
        {
            string salida = "Se inserto Correctamente";
            try
            {
                cmd = new SqlCommand("Insert into cuenta (numero, banco,balance,modificacion) values('" + nombre + "','" + contraseña + "','" + tipo + "','" + fechada + "')", cn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;

        }
        public int cuenta(string nombre)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from cuenta where numero ='" + nombre + "'order by numero asc", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }
            return contador;
        }
        public string UPDATECUENTA(string numero, string banco, string balance, string fecha)
        {
            string salida = "Se se inserto";
            try
            {
                cmd = new SqlCommand("Update CUENTA set  banco = '" + banco + "', modificacion = '" + fecha + "' where numero = '" + numero + "'", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }

        public void selectcuenta(string numero, TextBox textBox2, TextBox textBox3, TextBox textBox4)
        {
            try
            {
                cmd = new SqlCommand("Select * from  cuenta where numero = '" + numero + "'order by numero asc", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBox2.Text = dr["banco"].ToString();
                    textBox3.Text = dr["balance"].ToString();
                    textBox4.Text = dr["modificacion"].ToString();


                }

                dr.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo encontar por : " + ex.ToString());
            }
        }
        public void selectbancosolo(string numero, TextBox textBox2)
        {
            try
            {
                cmd = new SqlCommand("Select * from  catalogocuenta where numero = '" + numero + "'order by numero asc", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBox2.Text = dr["nombre"].ToString();
                  


                }

                dr.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo encontar por : " + ex.ToString());
            }
        }
        public void selectbanco(string numero, TextBox textBox5, TextBox textBox6)
        {
            try
            {
                cmd = new SqlCommand("Select * from  cuenta where numero = '" + numero + "' order by Numero asc", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBox5.Text = dr["banco"].ToString();
                    textBox6.Text = dr["balance"].ToString();



                }

                dr.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo encontar por : " + ex.ToString());
            }
        }
        public void selectbanco1(string numero, TextBox textBox5)
        {
            try
            {
                cmd = new SqlCommand("Select * from  cuenta where numero = '" + numero + "' order by Numero asc", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBox5.Text = dr["banco"].ToString();


                }

                dr.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo encontar por : " + ex.ToString());
            }
        }
        public void selectbancocatalogo(string numero, TextBox textBox5)
        {
            try
            {
                cmd = new SqlCommand("Select * from  catalogocuenta where numero = '" + numero + "' order by Numero asc", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBox5.Text = dr["nombre"].ToString();


                }

                dr.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo encontar por : " + ex.ToString());
            }
        }
        /*public string UPDATeemonto(string balance, string numero)
        {
            string salida = "Se se inserto";
            try
            {
                cmd = new SqlCommand("Update cuenta set  Balance = '" + balance + "' where Numero = '" + numero + "'", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }*/


        public string insertarcuenta1(string nombre, string contraseña, string tipo, string fechada, string entrada, string concepto, string fecha)
        {
            string salida = "Se inserto Correctamente";
            try
            {
                cmd = new SqlCommand("Insert into movimiento (numero, banco,balance,Salida,Entrada,concepto,fecha) values('" + nombre + "','" + contraseña + "','" + tipo + "','" + fechada + "','" + entrada + "','" + concepto + "','" + fecha + "')", cn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;

        }

        //CATALOGO DE CUENTA
        public int CATALOGO(string nombre)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from Catalogocuenta where numero ='" + nombre + "'order by numero asc", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }
            return contador;
        }

        public string insertarcatalogo(string nombre, string contraseña, string tipo, string lean, string fechada, string monto, string origen)
        {
            string salida = "Se inserto Correctamente";
            try
            {
                cmd = new SqlCommand("Insert into Catalogocuenta (numero, nombre,numerocuentapadre,nombrecuentapadre,Fecha,monto,origen) values('" + nombre + "','" + contraseña + "','" + lean + "','" + tipo + "','" + fechada + "','"+monto+"','"+origen+"')", cn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;

        }
        public string insertarentrada(string nombre, string contraseña, string tipo, string lean, string fechada, string monto, string origen)
        {
            string salida = "Se inserto Correctamente";
            try
            {
                cmd = new SqlCommand("Insert into entradadiario (numero, nombre,numerocuentapadre,nombrecuentapadre,origen) values('" + nombre + "','" + contraseña + "','" + lean + "','" + tipo + "','" + fechada + "','" + monto + "','" + origen + "')", cn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;

        }
        public string insertarentradaCREDITO(string nombre, string contraseña, string elchivo, string tipo, string lean, string fechada, string monto, string origen, string mami, string papi)
        {
            string salida = "Se inserto Correctamente";
            try
            {
                cmd = new SqlCommand("Insert into entradadiario (noentrada, fecha,concepto,nocuenta,nombre,debito,credito,numeropadre,nombrepadre,origen) values('" + nombre + "','" + contraseña + "','"+elchivo+"','" + lean + "','" + tipo + "','" + fechada + "','" + monto + "','" + origen + "','"+mami+"','"+papi+"')", cn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;

        }
        public string insertarentradaCREDITO2(string nombre, string contraseña, string elchivo, string tipo, string lean, string fechada, string monto, string origen, string mami, string papi)
        {
            string salida = "Se inserto Correctamente";
            try
            {
                cmd = new SqlCommand("Insert into entradadiario (noentrada, fecha,concepto,nocuenta,nombre,debito,credito,numeropadre,nombrepadre,origen) values('" + nombre + "','" + contraseña + "','" + elchivo + "','" + lean + "','" + tipo + "','" + fechada + "','" + monto + "','" + origen + "','" + mami + "','" + papi + "')", cn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;

        }
        public string updatecliente(string cedula1, string cedula, string reenganche, string nombre, string telefono, string direccion, string numerocuenta, string banco, string tipodecliente)
        {
            string salida = "Se se inserto";
            try
            {
                cmd = new SqlCommand("Update credito set cedula='" + cedula1 + "', nombrecompleto = '" + nombre + "', telefono='" + telefono + "',direccion='" + direccion + "',numerocuenta='" + numerocuenta + "',banco='" + banco + "', tipodecliente='" + tipodecliente + "' where cedula = '" + cedula + "' and reenganche='" + reenganche + "'", cn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }
        public string pagarsinafectar(string cedula, string reenganche, string periodo)
        {
            string salida = "Se se inserto";
            try
            {
                cmd = new SqlCommand("Update credito set  Estado = 'Pagado' where cedula = '" + cedula + "' and reenganche='" + reenganche + "' and periodo='" + periodo + "'", cn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }
        public string UpdateCatalogo(string numero, string banco, string numerocuentapadre, string nombrecuentapadre, string origen)
        {
            string salida = "Se se inserto";
            try
            {
                cmd = new SqlCommand("Update catalogocuenta set  nombre = '" + banco + "', numerocuentapadre='" + numerocuentapadre + " ',nombrecuentapadre='" + nombrecuentapadre + " ',origen='" + origen + "' where numero = '" + numero + "'", cn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }
        public string UpdateCatalogoconentrada(string numero, string banco, string fecha,string origen)
        {
            string salida = "Se se inserto";
            try
            {
                cmd = new SqlCommand("Update entradadiario set  numeropadre = '" + banco + "', nombrepadre = '" + fecha + "',origen='"+origen+"' where nocuenta = '"+numero+"'", cn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }
        public void selectcatalogo(string numero, TextBox textBox1, TextBox textBox2, TextBox textBox3, TextBox textBox4, ComboBox combo)
        {
            try
            {
                cmd = new SqlCommand("Select * from  catalogocuenta where numero = '" + numero + "'order by numero asc", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBox1.Text = dr["numero"].ToString();
                    textBox2.Text = dr["nombre"].ToString();
                    textBox3.Text = dr["numerocuentaPadre"].ToString();
                   combo.Text = dr["origen"].ToString();


                }

                dr.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo encontar por : " + ex.ToString());
            }
        }
        public void selectcatalogow(string numero, TextBox textBox1, TextBox textBox2, TextBox textBox3, TextBox textBox4)
        {
            try
            {
                cmd = new SqlCommand("Select * from  catalogocuenta where numero = '" + numero + "'order by numero asc", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                   
                    textBox1.Text = dr["nombre"].ToString();
                    textBox2.Text = dr["numerocuentaPadre"].ToString();
                    textBox3.Text = dr["nombrecuentaPadre"].ToString();
                    textBox4.Text = dr["origen"].ToString();


                }

                dr.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo encontar por : " + ex.ToString());
            }
        }
        public void selectcuentapadre(string numero, TextBox textBox4, TextBox textBox5)
        {
            try
            {
                cmd = new SqlCommand("Select * from  catalogocuenta where NUMERO = '" + numero + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    textBox4.Text = dr["numerocuentapadre"].ToString();
                    textBox5.Text = dr["NOMBREcuentapadre"].ToString();

                }

                dr.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo encontar por : " + ex.ToString());
            }
        }
        public void selectcatalogoentrada(string numero, TextBox textBox2, TextBox textBox3)
        {
            try
            {
                cmd = new SqlCommand("Select * from  catalogocuenta where numero = '" + numero + "'order by numero asc", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    textBox2.Text = dr["nombre"].ToString();
                    textBox3.Text = dr["monto"].ToString();



                }

                dr.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo encontar por : " + ex.ToString());
            }
        }
        public void llenaritemsentrada(ComboBox cobragay)
        {
            try
            {
                cmd = new SqlCommand("Select Numero from catalogocuenta order by Numero asc", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cobragay.Items.Add(dr["Numero"]).ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Datos erroneos.", "ERROR!");


            }
        }
        public string UPDATeemontocatalogo(string balance, string numero)
        {
            string salida = "Se se inserto";
            try
            {
                cmd = new SqlCommand("Update catalogocuenta set  monto = '" + balance + "' where Numero = '" + numero + "'", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }

        public string actualizacioonconcepto(string concepto, string numero)
        {
            string salida = "Se se inserto";
            try
            {
                cmd = new SqlCommand("Update entradadiario set  concepto = '" + concepto + "' where noentrada = '" + numero + "'", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }
        public void selectcatalogoentrada1(string numero, TextBox textBox2, TextBox textBox3, TextBox textBox4, TextBox textBox5, TextBox textBox6, TextBox textBox7)
        {
            try
            {
                cmd = new SqlCommand("Select * from  catalogocuenta where numero = '" + numero + "'order by numero asc", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    textBox2.Text = dr["nombre"].ToString();
                    textBox3.Text = dr["NumeroCuentaPadre"].ToString();
                    textBox4.Text = dr["NombreCuentaPadre"].ToString();
                    textBox5.Text = dr["monto"].ToString();
                    textBox6.Text = dr["monto"].ToString();
                    textBox7.Text = dr["origen"].ToString();




                }

                dr.Close();
            }


            catch (Exception ex)
            {
                MessageBox.Show("No se pudo encontar por : " + ex.ToString());
            }


        }
        public void selectcatalogoentrada12(string numero, TextBox textBox3, TextBox textBox4, TextBox textBox5)
        {
           
            try
            {
              
                cmd = new SqlCommand("Select * from  catalogocuenta where numero = '" + numero + "'order by numero asc", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                  //  textBox2.Text = dr["nombre"].ToString();
                    textBox3.Text = dr["NumeroCUENTApadre"].ToString();
                    textBox4.Text = dr["NombreCUENTApadre"].ToString();
                    textBox5.Text = dr["origen"].ToString();

                }

                dr.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo encontar por : " + ex.ToString());
            }


        }
        public void solucion(string numero, TextBox textBox3, TextBox textBox4)
        {

            try
            {

                cmd = new SqlCommand("SELECT nocuenta,sum(Debito) as totaldebito,sum(Credito) as totalcredito from   EntradaDiario  WHERE  nocuenta='"+numero+"' GROUP BY NoCuenta ORDER BY nocuenta", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    //  textBox2.Text = dr["nombre"].ToString();
                    textBox3.Text = dr["totaldebito"].ToString();
                    textBox4.Text = dr["totalcredito"].ToString();
                 

                }

                dr.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo encontar por : " + ex.ToString());
            }


        }
        public void selectcatalogoentradahuevo(string numero, TextBox textBox2,TextBox textBox3, TextBox textBox4, TextBox textBox5)
        {

            try
            {

                cmd = new SqlCommand("Select * from  catalogocuenta where numero = '" + numero + "'order by numero asc", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    textBox2.Text = dr["nombre"].ToString();
                    textBox3.Text = dr["NumeroCUENTApadre"].ToString();
                    textBox4.Text = dr["NombreCUENTApadre"].ToString();
                    textBox5.Text = dr["origen"].ToString();

                }

                dr.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo encontar por : " + ex.ToString());
            }


        }
        public void selectcatalogoentrada123( TextBox textBox1, TextBox textBox2, TextBox textBox3, TextBox textBox4, TextBox textBox5)
        {
            try
            {
                cmd = new SqlCommand("Select * from  catalogocuenta where numero = '11' order by numero asc", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBox1.Text=dr["nocuenta"].ToString();
                    textBox2.Text = dr["nombre"].ToString();
                    textBox3.Text = dr["NumeroCUENTApadre"].ToString();
                    textBox4.Text = dr["NombreCUENTApadre"].ToString();
                    textBox5.Text = dr["origen"].ToString();

                }

                dr.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo encontar por : " + ex.ToString());
            }


        }
        public void insertarentradaa(DataGridView dtgDesglose,string textbox1)
        {

            cmd = new SqlCommand("insert into EntradaDiario values ('" + textbox1 + "',@Fecha,@Concepto,@NoCuenta,@Nombre,@Debito ,@Credito,@NumeroPadre,@NombrePadre,@origen,@fechareporte1,@fechareporte2)", cn);
            try
            {
                foreach (DataGridViewRow row in dtgDesglose.Rows)
                {
                    cmd.Parameters.Clear();

                    
                    cmd.Parameters.AddWithValue("@Fecha", Convert.ToString(row.Cells["Fechada"].Value));
                    cmd.Parameters.AddWithValue("@Concepto", Convert.ToString(row.Cells["concepto"].Value));
                    cmd.Parameters.AddWithValue("@NoCuenta", Convert.ToString(row.Cells["numero"].Value));
                    cmd.Parameters.AddWithValue("@Nombre", Convert.ToString(row.Cells["nombredecuenta"].Value));
                    cmd.Parameters.AddWithValue("@Debito", Convert.ToDouble(row.Cells["Debito"].Value));
                    cmd.Parameters.AddWithValue("@Credito", Convert.ToDouble(row.Cells["Credito"].Value));
                    cmd.Parameters.AddWithValue("@NumeroPadre", Convert.ToString(row.Cells["numerodecuentapadre"].Value));
                    cmd.Parameters.AddWithValue("@NombrePadre", Convert.ToString(row.Cells["nombredecuentapadre"].Value));
                    cmd.Parameters.AddWithValue("@origen", Convert.ToString(row.Cells["origen"].Value));
                    cmd.Parameters.AddWithValue("@fechareporte1", Convert.ToString(row.Cells["fecha1"].Value));
                    cmd.Parameters.AddWithValue("@fechareporte2", Convert.ToString(row.Cells["fecha2"].Value));
                    cmd.ExecuteNonQuery();




                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            MessageBox.Show("Se inserto correctamente.", "Mensaje!");
        }
        public void insertarentradaaupdate(DataGridView dtgDesglose, string textbox1,string textbox2)
        {

            cmd = new SqlCommand("insert into EntradaDiario values ('" + textbox1 + "','" + textbox2 + "',@Concepto,@NoCuenta,@Nombre,@Debito ,@Credito,@NumeroPadre,@NombrePadre,@origen,@fechareporte1,@fechareporte2)", cn);
            try
            {
                foreach (DataGridViewRow row in dtgDesglose.Rows)
                {
                    cmd.Parameters.Clear();

                   
                    cmd.Parameters.AddWithValue("@Fecha", Convert.ToString(row.Cells["Fechada"].Value));
                    cmd.Parameters.AddWithValue("@Concepto", Convert.ToString(row.Cells["concepto"].Value));
                    cmd.Parameters.AddWithValue("@NoCuenta", Convert.ToString(row.Cells["numero"].Value));
                    cmd.Parameters.AddWithValue("@Nombre", Convert.ToString(row.Cells["nombredecuenta"].Value));
                    cmd.Parameters.AddWithValue("@Debito", Convert.ToDouble(row.Cells["Debito"].Value));
                    cmd.Parameters.AddWithValue("@Credito", Convert.ToDouble(row.Cells["Credito"].Value));
                    cmd.Parameters.AddWithValue("@NumeroPadre", Convert.ToString(row.Cells["numerodecuentapadre"].Value));
                    cmd.Parameters.AddWithValue("@NombrePadre", Convert.ToString(row.Cells["nombredecuentapadre"].Value));
                    cmd.Parameters.AddWithValue("@origen", Convert.ToString(row.Cells["origen"].Value));
                    cmd.Parameters.AddWithValue("@fechareporte1", Convert.ToString(row.Cells["fecha1"].Value));
                    cmd.Parameters.AddWithValue("@fechareporte2", Convert.ToString(row.Cells["fecha2"].Value));
                    cmd.ExecuteNonQuery();




                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            MessageBox.Show("Se actualizo correctamente.", "Mensaje!");
        }
        public string buscarentrada(DataGridView dataGridView1, string bombero)
        {
            string salida = "Wtf";
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT  noentrada,fecha,concepto,nocuenta,nombre,debito,credito,numeroPadre,Nombrepadre FROM entradadiario where noentrada= '"+bombero+"'  order by noentrada asc", cn);
                DataTable data = new DataTable();

                sda.Fill(data);
                dataGridView1.DataSource = data;


                dr.Close();
            }




            catch (Exception ex)
            {

            }
            return salida;


        }
        public void updateentrada(DataGridView dtgDesglose,string concepto,string noentrada)
        {

            cmd = new SqlCommand("update  EntradaDiario set concepto='"+concepto+"',nocuenta=@NoCuenta,nombre=@Nombre,debito=@Debito ,credito=@Credito,numeropadre=@NumeroPadre,nombrepadre=@NombrePadre where noentrada='"+noentrada+"'" , cn);
            try
            {
                foreach (DataGridViewRow row in dtgDesglose.Rows)
                {
                    cmd.Parameters.Clear();

                    cmd.Parameters.AddWithValue("@NoEntrada", Convert.ToString(row.Cells["numerodeentrada"].Value));
                   // cmd.Parameters.AddWithValue("@Fecha", Convert.ToString(row.Cells["Fechada"].Value));
                   // cmd.Parameters.AddWithValue("@Concepto", Convert.ToString(row.Cells["concepto"].Value));
                    cmd.Parameters.AddWithValue("@NoCuenta", Convert.ToString(row.Cells["numero"].Value));
                    cmd.Parameters.AddWithValue("@Nombre", Convert.ToString(row.Cells["nombredecuenta"].Value));
                    cmd.Parameters.AddWithValue("@Debito", Convert.ToDouble(row.Cells["Debito"].Value));
                    cmd.Parameters.AddWithValue("@Credito", Convert.ToDouble(row.Cells["Credito"].Value));
                    cmd.Parameters.AddWithValue("@NumeroPadre", Convert.ToString(row.Cells["numerodecuentapadre"].Value));
                    cmd.Parameters.AddWithValue("@NombrePadre", Convert.ToString(row.Cells["nombredecuentapadre"].Value));

                    cmd.ExecuteNonQuery();




                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            MessageBox.Show("Se actualizo correctamente.", "Mensaje!");
        }
        public string reportefechaentrada(string reportefecha1, string reportefecha2)
        {
            string salida = "Se se inserto";
            try
            {
                cmd = new SqlCommand("Update entradadiario set fechareporte1 = '" + reportefecha1 + "', fechareporte2 = '" + reportefecha2 + "' ", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }

        public void selectnumeroentrada(TextBox textBox2)
        {
            try
            {
                cmd = new SqlCommand("Select * from  entradadiario order by noentrada desc", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    textBox2.Text = dr["noentrada"].ToString();
                   

                }

                dr.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo encontar por : " + ex.ToString());
            }


        }
        public void selectreenganche(string textBox1, TextBox textBox2)
        {
            try
            {
                cmd = new SqlCommand("SELECT reenganche +1 AS REE FROM  Credito WHERE cedula ='"+textBox1+"'GROUP BY reenganche ORDER BY reenganche desc", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    textBox2.Text = dr["REE"].ToString();


                }

                dr.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo encontar por : " + ex.ToString());
            }


        }
        public void selectwow(string textBox1,string cedula, TextBox textBox2, TextBox textBox3, TextBox textBox4)
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM  Credito WHERE reenganche ='" + textBox1 + "'and cedula='"+cedula+"'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    textBox2.Text = dr["nombrecompleto"].ToString();
                    textBox3.Text = dr["telefono"].ToString();
                    textBox4.Text = dr["direccion"].ToString();
                    //textBox4.Text = dr["nombrecompleto"].ToString();

                }

                dr.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo encontar por : " + ex.ToString());
            }


        }
        public void llenaritems2(ComboBox cobragay)
        {
            try
            {
                cmd = new SqlCommand("Select Numero from catalogocuenta order by Numero asc", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cobragay.Items.Add(dr["Numero"]).ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Datos erroneos.", "ERROR!");


            }
        }
        public string observar(DataGridView dataGridView1, string textBox1)
        {
            string salida = "Wtf";
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("select NUMERO, NOMBRE from CATALOGOCUENTA where NOMBRE like ('" + textBox1 + "%')", cn);
                DataTable data = new DataTable();

                sda.Fill(data);
                dataGridView1.DataSource = data;


                dr.Close();
            }




            catch (Exception ex)
            {

            }
            return salida;


        }
        public string vaquear(DataGridView dataGridView1, string textBox1)
        {
            string salida = "Wtf";
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Cedula,nombrecompleto,Periodo, FechaPago, SaldoInicial, Cuota, Interes, Mora, SaldoFinal, Estado, TIPOPAGO FROM credito where NOMBREcompleto like ('" + textBox1 + "%')", cn);
                DataTable data = new DataTable();

                sda.Fill(data);
                dataGridView1.DataSource = data;


                dr.Close();
            }




            catch (Exception ex)
            {

            }
            return salida;


        }
       
        public string buscarcuenta(DataGridView dataGridView1, string textBox1)
        {
            string salida = "Wtf";
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT  Numero, Nombre FROM  catalogocuenta WHERE Numero=  '"+textBox1+"' ORDER BY Numero", cn);
                DataTable data = new DataTable();

                sda.Fill(data);
                dataGridView1.DataSource = data;


                dr.Close();
            }




            catch (Exception ex)
            {

            }
            return salida;


        }





    }

 }

                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        