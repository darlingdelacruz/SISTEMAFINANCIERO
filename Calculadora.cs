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
    public partial class Calculadora : Form
    { 
        DateTime FECHA = new DateTime();
        public Calculadora()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textMonto.Text == "" | textTasa.Text == "" | textTiempo.Text == "" | comboBox1.Text == "")
            {

                MessageBox.Show("Debe llenar todos los campos correctamente.", "AVISO");
               
            }

            else
            {
              
                try
                {
                    string op = comboBox1.Text;
                    double strMonto = Convert.ToDouble(this.textMonto.Text);
                    Int32 MESES = Convert.ToInt32(this.textTiempo.Text);
                    double Interemensual = Convert.ToDouble(this.textTasa.Text);

                    Interemensual = Interemensual / 100;


                    double Resultado = strMonto * Interemensual;



                    this.lblinteres_mensual.Text = Interemensual.ToString();


                    int INTERES = 0;
                    //int TINTERES = 0;
                    double CAPITAL = 0;
                    //double TAMORTIZADO = 0;
                    double TCUOTA = 0;
                    double SALDOINICIAL = strMonto;
                    double ACUMULADO = 0;
                    double SALDOFINAL = 0;
                    string Estado = "Pendiente";





                    for (int I = 1; I < MESES + 1; I = I + 1)
                    {
                        double CUOTA = Convert.ToDouble(strMonto / MESES);
                        this.textCuota.Text = SALDOFINAL.ToString();
                        //TINTERES += INTERES; // ACUMULA LOS INTERES
                        SALDOINICIAL += Convert.ToInt32(CAPITAL);// LE RESTA EL CAPITAL 

                        CAPITAL = Convert.ToDouble((INTERES - CUOTA));//DIFERENCIA LA CUOTA DE LOS INTERES DEL MES
                        //TAMORTIZADO += CAPITAL; //ACUMULA TODA LA CUOTA
                        SALDOFINAL = Convert.ToDouble(CUOTA + Resultado);

                        //TCUOTA += CUOTA;
                        DateTime FFecha;
                        FFecha = Convert.ToDateTime(this.time.Value.ToString());
                        //time.Text = FECHA.ToString("mm/dd/yyyy");
                        FECHA = DateTime.Parse(FFecha.ToString());
                        FECHA.AddMonths(I - 1).ToShortDateString();//'(I-1) PARA QUE EMPIECE A CONTAR EN EL MISMO M




                        switch (op)
                        {
                            case "MENSUAL":

                                this.textCuota.Text = SALDOFINAL.ToString();

                                dtgDesglose.Rows.Add (I.ToString(), FECHA.AddMonths(I + 0).ToString("yyyy/MM/dd"), SALDOINICIAL, CUOTA, Resultado, Estado.ToString(), comboBox1.Text, SALDOFINAL);
                                comboBox1.BackColor = Color.White;
                                break;
                            case "QUINCENAL":

                                this.textCuota.Text = SALDOFINAL.ToString();

                                dtgDesglose.Rows.Add(I.ToString(), FECHA.AddDays(I * 15).ToString("yyyy/MM/dd"), SALDOINICIAL, CUOTA, Resultado, Estado.ToString(), comboBox1.Text, SALDOFINAL);
                                comboBox1.BackColor = Color.White;

                                break;


                            case "":
                                comboBox1.BackColor = Color.Red;
                                break;
               
                   

                }


                        }
                    }

                
                catch (Exception ex)
                {
                    MessageBox.Show("Ha introducido datos erroneos.","Advertencia!");
                }
             double total2020 = 0;
                double LEONEL = 0;
                double GONZALO= 0;
               
                
                for (int i = 0; i < dtgDesglose.Rows.Count - 0; i++)
                {
                  
                    GONZALO+= double.Parse(dtgDesglose.Rows[i].Cells[3].Value.ToString());
                    LEONEL+= double.Parse(dtgDesglose.Rows[i].Cells[4].Value.ToString());
                    
                    textBox1.Text = GONZALO.ToString();
                    textBox2.Text = LEONEL.ToString();
                   
                    total2020 = LEONEL + GONZALO;

                    textBox3.Text = total2020.ToString();

               
            }
           
        }

        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void pAGOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pagos FPAGO = new Pagos();
            FPAGO.txttipopago.Text = calculadortext.Text;
            FPAGO.Show();
            Hide();
        }

        private void rEPOTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FREPORTE = new Reporte_General();
            FREPORTE.Show();
            
        }

        private void sALIRToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            DialogResult r = MessageBox.Show("Quiere salir de sistema?", "ADVERTENCIA", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                Close();
            }
        }

        private void cREARCREDITOToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CrearCredito FCREDITO = new CrearCredito();
            FCREDITO.txttipocredito.Text = calculadortext.Text;

            FCREDITO.Show();
            Hide();
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            textCuota.Text = "";
            textMonto.Text = "";
            textTasa.Text = "";
            textTiempo.Text = "";
            comboBox1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            lblinteres_mensual.Text = "";
            time.Text = "";
            dtgDesglose.Rows.Clear();

        }

        private void Calculadora_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

     }
  }

