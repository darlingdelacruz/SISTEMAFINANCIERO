namespace PRESTAMOS2
{
    partial class verentrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(verentrada));
            this.EntradaDiarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entradadatos = new PRESTAMOS2.entradadatos();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.EntradaDiarioTableAdapter = new PRESTAMOS2.entradadatosTableAdapters.EntradaDiarioTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.EntradaDiarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradadatos)).BeginInit();
            this.SuspendLayout();
            // 
            // EntradaDiarioBindingSource
            // 
            this.EntradaDiarioBindingSource.DataMember = "EntradaDiario";
            this.EntradaDiarioBindingSource.DataSource = this.entradadatos;
            // 
            // entradadatos
            // 
            this.entradadatos.DataSetName = "entradadatos";
            this.entradadatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.EntradaDiarioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PRESTAMOS2.Report11.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(869, 604);
            this.reportViewer1.TabIndex = 0;
            // 
            // EntradaDiarioTableAdapter
            // 
            this.EntradaDiarioTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(822, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Visible = false;
            // 
            // verentrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 604);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "verentrada";
            this.Text = "Reporte";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.verentrada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EntradaDiarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradadatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EntradaDiarioBindingSource;
        private entradadatos entradadatos;
        private entradadatosTableAdapters.EntradaDiarioTableAdapter EntradaDiarioTableAdapter;
        public System.Windows.Forms.TextBox textBox1;
    }
}