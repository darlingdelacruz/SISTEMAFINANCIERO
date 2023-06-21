namespace PRESTAMOS2
{
    partial class ReporteTipoPendiente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteTipoPendiente));
            this.CreditoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maxima = new PRESTAMOS2.maxima();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.mmg2 = new System.Windows.Forms.TextBox();
            this.mmg1 = new System.Windows.Forms.TextBox();
            this.mmg3 = new System.Windows.Forms.TextBox();
            this.CreditoTableAdapter = new PRESTAMOS2.maximaTableAdapters.CreditoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CreditoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxima)).BeginInit();
            this.SuspendLayout();
            // 
            // CreditoBindingSource
            // 
            this.CreditoBindingSource.DataMember = "Credito";
            this.CreditoBindingSource.DataSource = this.maxima;
            // 
            // maxima
            // 
            this.maxima.DataSetName = "maxima";
            this.maxima.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CreditoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PRESTAMOS2.Report6.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(654, 453);
            this.reportViewer1.TabIndex = 0;
            // 
            // mmg2
            // 
            this.mmg2.Enabled = false;
            this.mmg2.Location = new System.Drawing.Point(396, 12);
            this.mmg2.Name = "mmg2";
            this.mmg2.Size = new System.Drawing.Size(100, 20);
            this.mmg2.TabIndex = 6;
            this.mmg2.Visible = false;
            // 
            // mmg1
            // 
            this.mmg1.Enabled = false;
            this.mmg1.Location = new System.Drawing.Point(263, 12);
            this.mmg1.Name = "mmg1";
            this.mmg1.Size = new System.Drawing.Size(100, 20);
            this.mmg1.TabIndex = 5;
            this.mmg1.Visible = false;
            // 
            // mmg3
            // 
            this.mmg3.Enabled = false;
            this.mmg3.Location = new System.Drawing.Point(536, 12);
            this.mmg3.Name = "mmg3";
            this.mmg3.Size = new System.Drawing.Size(100, 20);
            this.mmg3.TabIndex = 4;
            this.mmg3.Visible = false;
            // 
            // CreditoTableAdapter
            // 
            this.CreditoTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteTipoPendiente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 453);
            this.Controls.Add(this.mmg2);
            this.Controls.Add(this.mmg1);
            this.Controls.Add(this.mmg3);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReporteTipoPendiente";
            this.Text = "Reporte";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReporteTipoPendiente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CreditoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxima)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        public System.Windows.Forms.TextBox mmg2;
        public System.Windows.Forms.TextBox mmg1;
        public System.Windows.Forms.TextBox mmg3;
        private System.Windows.Forms.BindingSource CreditoBindingSource;
        private maxima maxima;
        private maximaTableAdapters.CreditoTableAdapter CreditoTableAdapter;
    }
}