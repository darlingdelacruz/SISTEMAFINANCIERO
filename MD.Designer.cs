namespace PRESTAMOS2
{
    partial class MD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MD));
            this.CuentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportedecuentas = new PRESTAMOS2.reportedecuentas();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CuentaTableAdapter = new PRESTAMOS2.reportedecuentasTableAdapters.CuentaTableAdapter();
            this.textBox1fecha = new System.Windows.Forms.TextBox();
            this.textBox2fecha = new System.Windows.Forms.TextBox();
            this.EntradaDiarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.balancesnuevos = new PRESTAMOS2.balancesnuevos();
            this.EntradaDiarioTableAdapter = new PRESTAMOS2.balancesnuevosTableAdapters.EntradaDiarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CuentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportedecuentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntradaDiarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balancesnuevos)).BeginInit();
            this.SuspendLayout();
            // 
            // CuentaBindingSource
            // 
            this.CuentaBindingSource.DataMember = "Cuenta";
            this.CuentaBindingSource.DataSource = this.reportedecuentas;
            // 
            // reportedecuentas
            // 
            this.reportedecuentas.DataSetName = "reportedecuentas";
            this.reportedecuentas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.EntradaDiarioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PRESTAMOS2.Report22.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(721, 568);
            this.reportViewer1.TabIndex = 0;
            // 
            // CuentaTableAdapter
            // 
            this.CuentaTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1fecha
            // 
            this.textBox1fecha.Enabled = false;
            this.textBox1fecha.Location = new System.Drawing.Point(447, 31);
            this.textBox1fecha.Name = "textBox1fecha";
            this.textBox1fecha.Size = new System.Drawing.Size(100, 20);
            this.textBox1fecha.TabIndex = 1;
            this.textBox1fecha.Visible = false;
            // 
            // textBox2fecha
            // 
            this.textBox2fecha.Enabled = false;
            this.textBox2fecha.Location = new System.Drawing.Point(609, 31);
            this.textBox2fecha.Name = "textBox2fecha";
            this.textBox2fecha.Size = new System.Drawing.Size(100, 20);
            this.textBox2fecha.TabIndex = 2;
            this.textBox2fecha.Visible = false;
            // 
            // EntradaDiarioBindingSource
            // 
            this.EntradaDiarioBindingSource.DataMember = "EntradaDiario";
            this.EntradaDiarioBindingSource.DataSource = this.balancesnuevos;
            // 
            // balancesnuevos
            // 
            this.balancesnuevos.DataSetName = "balancesnuevos";
            this.balancesnuevos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EntradaDiarioTableAdapter
            // 
            this.EntradaDiarioTableAdapter.ClearBeforeFill = true;
            // 
            // MD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 568);
            this.Controls.Add(this.textBox2fecha);
            this.Controls.Add(this.textBox1fecha);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MD";
            this.Text = "Reporte de cuentas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CuentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportedecuentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntradaDiarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balancesnuevos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CuentaBindingSource;
        private reportedecuentas reportedecuentas;
        private reportedecuentasTableAdapters.CuentaTableAdapter CuentaTableAdapter;
        private System.Windows.Forms.BindingSource EntradaDiarioBindingSource;
        private balancesnuevos balancesnuevos;
        private balancesnuevosTableAdapters.EntradaDiarioTableAdapter EntradaDiarioTableAdapter;
        public System.Windows.Forms.TextBox textBox1fecha;
        public System.Windows.Forms.TextBox textBox2fecha;
    }
}