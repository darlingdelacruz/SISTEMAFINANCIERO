namespace PRESTAMOS2
{
    partial class ReportePorTipos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportePorTipos));
            this.CreditoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mamaguevo = new PRESTAMOS2.mamaguevo();
            this.txttipor = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CreditoTableAdapter = new PRESTAMOS2.mamaguevoTableAdapters.CreditoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CreditoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mamaguevo)).BeginInit();
            this.SuspendLayout();
            // 
            // CreditoBindingSource
            // 
            this.CreditoBindingSource.DataMember = "Credito";
            this.CreditoBindingSource.DataSource = this.mamaguevo;
            // 
            // mamaguevo
            // 
            this.mamaguevo.DataSetName = "mamaguevo";
            this.mamaguevo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txttipor
            // 
            this.txttipor.Enabled = false;
            this.txttipor.Location = new System.Drawing.Point(1262, 0);
            this.txttipor.Name = "txttipor";
            this.txttipor.Size = new System.Drawing.Size(100, 20);
            this.txttipor.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(989, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(1122, 0);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CreditoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PRESTAMOS2.Report16.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1362, 498);
            this.reportViewer1.TabIndex = 4;
            // 
            // CreditoTableAdapter
            // 
            this.CreditoTableAdapter.ClearBeforeFill = true;
            // 
            // ReportePorTipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 498);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txttipor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportePorTipos";
            this.Text = "Reporte Por Tipos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportePorTipos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CreditoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mamaguevo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        public System.Windows.Forms.TextBox txttipor;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBox2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CreditoBindingSource;
        private mamaguevo mamaguevo;
        private mamaguevoTableAdapters.CreditoTableAdapter CreditoTableAdapter;
    }
}