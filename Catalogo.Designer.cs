namespace PRESTAMOS2
{
    partial class Catalogo
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Catalogo));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Loyal = new PRESTAMOS2.Loyal();
            this.CatalogoCuentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CatalogoCuentaTableAdapter = new PRESTAMOS2.LoyalTableAdapters.CatalogoCuentaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Loyal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CatalogoCuentaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.CatalogoCuentaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PRESTAMOS2.Report15.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(639, 537);
            this.reportViewer1.TabIndex = 0;
            // 
            // Loyal
            // 
            this.Loyal.DataSetName = "Loyal";
            this.Loyal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CatalogoCuentaBindingSource
            // 
            this.CatalogoCuentaBindingSource.DataMember = "CatalogoCuenta";
            this.CatalogoCuentaBindingSource.DataSource = this.Loyal;
            // 
            // CatalogoCuentaTableAdapter
            // 
            this.CatalogoCuentaTableAdapter.ClearBeforeFill = true;
            // 
            // Catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 537);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Catalogo";
            this.Text = "Catalogo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Catalogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Loyal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CatalogoCuentaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CatalogoCuentaBindingSource;
        private Loyal Loyal;
        private LoyalTableAdapters.CatalogoCuentaTableAdapter CatalogoCuentaTableAdapter;
    }
}