namespace PRESTAMOS2
{
    partial class ReportepagosPendiente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportepagosPendiente));
            this.CreditoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TraerPendiente = new PRESTAMOS2.TraerPendiente();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CreditoTableAdapter = new PRESTAMOS2.TraerPendienteTableAdapters.CreditoTableAdapter();
            this.vamos = new System.Windows.Forms.TextBox();
            this.hacerlo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CreditoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TraerPendiente)).BeginInit();
            this.SuspendLayout();
            // 
            // CreditoBindingSource
            // 
            this.CreditoBindingSource.DataMember = "Credito";
            this.CreditoBindingSource.DataSource = this.TraerPendiente;
            // 
            // TraerPendiente
            // 
            this.TraerPendiente.DataSetName = "TraerPendiente";
            this.TraerPendiente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CreditoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PRESTAMOS2.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(809, 499);
            this.reportViewer1.TabIndex = 0;
            // 
            // CreditoTableAdapter
            // 
            this.CreditoTableAdapter.ClearBeforeFill = true;
            // 
            // vamos
            // 
            this.vamos.Location = new System.Drawing.Point(548, 26);
            this.vamos.Name = "vamos";
            this.vamos.Size = new System.Drawing.Size(100, 20);
            this.vamos.TabIndex = 1;
            this.vamos.Visible = false;
            // 
            // hacerlo
            // 
            this.hacerlo.Location = new System.Drawing.Point(709, 26);
            this.hacerlo.Name = "hacerlo";
            this.hacerlo.Size = new System.Drawing.Size(100, 20);
            this.hacerlo.TabIndex = 2;
            this.hacerlo.Visible = false;
            // 
            // ReportepagosPendiente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 499);
            this.Controls.Add(this.hacerlo);
            this.Controls.Add(this.vamos);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportepagosPendiente";
            this.Text = "ReportepagosPendiente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportepagosPendiente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CreditoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TraerPendiente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CreditoBindingSource;
        private TraerPendiente TraerPendiente;
        private TraerPendienteTableAdapters.CreditoTableAdapter CreditoTableAdapter;
        public System.Windows.Forms.TextBox vamos;
        public System.Windows.Forms.TextBox hacerlo;
    }
}