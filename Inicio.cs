using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRESTAMOS2
{
    public partial class Inicio : Form
    {
       
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public Inicio()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
          
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(249, 118, 176);
            public static Color color7 = Color.FromArgb(95, 77, 221);
            public static Color color8 = Color.FromArgb(95, 77, 221);
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
               // currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                //currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icon Current Child Form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
               // currentBtn.BackColor = Color.FromArgb(31, 30, 68);
               // currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                //currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
       
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            //iconCurrentChildForm.IconColor = Color.MediumPurple;
            lblTitleChildForm.Text = "Inicio";
        }
        private void reportePorClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FREPORTES = new Reporte_General();
            FREPORTES.Show();
        }

        private void reportePendientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

         
        }

        private void reportePagadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FREPORTES2 = new ReportePagadosF();
            FREPORTES2.Show();
        }

        private void reportePorTipoDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FREPORTES2 = new ReporteTipos2();
            FREPORTES2.Show();
        }

        private void rEPORTEGENERALToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form FREPORTESGENERAL = new ReporteGeneralizado();
            FREPORTESGENERAL.Show();
        }

        private void rEPORTEDEGANANCIASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Rganancias = new ReporteGanancias();
            Rganancias.Show();
        }

        private void cONSULTADECLIENTEREGISTRADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fconsulta = new Consulta();
            fconsulta.Show();
        }

        private void mOVIMIENTODECUENTASToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dETALLADAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form dreporte = new FECHASDETALLADAS();
            dreporte.Show();
        }

        private void cOMPLETAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form dreporte2 = new Reportedemovimientototal();
            dreporte2.Show();
        }

        private void cUENTASEXISTENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form DREPORTE3 = new FechaCuenta();
            DREPORTE3.Show();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            Loggin LOGGIN = new Loggin();
            LOGGIN.textBox3.Text = txttipo.Text;


            if (txttipo.Text != "ADMINISTRADOR")
            {
                cREARUSUARIOSToolStripMenuItem.Enabled = false;
                mOVIMIENTODECUENTASToolStripMenuItem.Enabled = false;

            }

            else
            {

                cREARUSUARIOSToolStripMenuItem.Enabled = true;
                mOVIMIENTODECUENTASToolStripMenuItem.Enabled = true;
                
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new CrearCredito());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            Pagos FPAGAR = new Pagos();
            FPAGAR.txttipopago.Text = txttipo.Text;
            FPAGAR.Show();
            Hide();
           
           
           
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new DEPOSITO());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new Retiro());
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new Transferencias());
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {

            ActivateButton(sender, RGBColors.color7);
            OpenChildForm(new  Entrada_de_diario());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                currentChildForm.Close();
                Reset();
            }catch(Exception ex){}
        }

        private void cONFIGURACIONDEUSUARIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearUsuarios FCREAR = new CrearUsuarios();
            FCREAR.txtcrearusuario.Text = txttipo.Text;
            FCREAR.Show();
            Hide();
        }

        private void eLIMINARCLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inicio FINICIO = new Inicio();
            FINICIO.txttipo.Text = txttipo.Text;
            FINICIO.Show();
            EliminarCliente elimin = new EliminarCliente();
            elimin.eliminar.Text = txttipo.Text;
            elimin.Show();
            Hide();

            
            
        }

        private void cREARCUENTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form CREARC = new CreacionCuentas();
            CREARC.Show();
        }

        private void Inicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void horafecha_Tick(object sender, EventArgs e)
        {
             lblhora.Text = DateTime.Now.ToLongTimeString();
            lblfecha.Text = DateTime.Now.ToLongDateString();
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color8);
            OpenChildForm(new CrearCatalogo());
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new Calculadora());
           
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {
            if (txttipo.Text == "ADMINISTRADOR")
            {
                iconButton7.Enabled = true;
            }
            else {

                iconButton7.Enabled = false;
            }

           
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
          
        }

        private void porNumeroDeEntradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteEntrada1 ver = new ReporteEntrada1();
            ver.Show();
        }

        private void porFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteFecha verentradafecha = new ReporteFecha();
            verentradafecha.Show();

        }

        private void reporteDeEntradaDeDiarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bALANZAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            balanzanew VERBALANZANEW = new balanzanew();
            VERBALANZANEW.Show();
        }

        private void iconCurrentChildForm_Click(object sender, EventArgs e)
        {

        }

        private void lblTitleChildForm_Click(object sender, EventArgs e)
        {

        }

        private void cATALOGODECUENTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CATALOGO_DE_CUENTA ct = new CATALOGO_DE_CUENTA();
            ct.Show();
        }

        private void cATALOGODECUENTAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Catalogo catalogo = new Catalogo();
            catalogo.Show();
        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Abono());
        }

        private void cUENTASToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eDITARCLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form CREARC = new EditarCliente();
            CREARC.Show();
        }

        private void cARTADESALDOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CartadeSaldo Carta = new CartadeSaldo();
            Carta.Show();
        }

        private void reporteDataCreditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VistaDataCredito DATACREDITO = new VistaDataCredito();
            DATACREDITO.Show();
        }

        private void cONCILIACIONPORCLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VistaConcicliacionFecha VISTACONCILIACION = new VistaConcicliacionFecha();
            VISTACONCILIACION.Show();

        }

        private void rEPORTEINTERESPAGADOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InteresPagadoFecha VISTACONCILIACION = new InteresPagadoFecha();
            VISTACONCILIACION.Show();
        }
    }
}
