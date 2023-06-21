namespace PRESTAMOS2
{
    partial class vistafecha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vistafecha));
            this.EntradaDiarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EntradaPorfecha = new PRESTAMOS2.EntradaPorfecha();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtfechaf1 = new System.Windows.Forms.TextBox();
            this.txtfechaf2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EntradaDiarioTableAdapter = new PRESTAMOS2.EntradaPorfechaTableAdapters.EntradaDiarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.EntradaDiarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntradaPorfecha)).BeginInit();
            this.SuspendLayout();
            // 
            // EntradaDiarioBindingSource
            // 
            this.EntradaDiarioBindingSource.DataMember = "EntradaDiario";
            this.EntradaDiarioBindingSource.DataSource = this.EntradaPorfecha;
            // 
            // EntradaPorfecha
            // 
            this.EntradaPorfecha.DataSetName = "EntradaPorfecha";
            this.EntradaPorfecha.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.EntradaDiarioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PRESTAMOS2.Report12.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1370, 492);
            this.reportViewer1.TabIndex = 0;
            // 
            // txtfechaf1
            // 
            this.txtfechaf1.Enabled = false;
            this.txtfechaf1.Location = new System.Drawing.Point(1117, 0);
            this.txtfechaf1.Name = "txtfechaf1";
            this.txtfechaf1.Size = new System.Drawing.Size(100, 20);
            this.txtfechaf1.TabIndex = 1;
            // 
            // txtfechaf2
            // 
            this.txtfechaf2.Enabled = false;
            this.txtfechaf2.Location = new System.Drawing.Point(1287, 0);
            this.txtfechaf2.Name = "txtfechaf2";
            this.txtfechaf2.Size = new System.Drawing.Size(100, 20);
            this.txtfechaf2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1067, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Desde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1243, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hasta:";
            // 
            // EntradaDiarioTableAdapter
            // 
            this.EntradaDiarioTableAdapter.ClearBeforeFill = true;
            // 
            // vistafecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 492);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtfechaf2);
            this.Controls.Add(this.txtfechaf1);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "vistafecha";
            this.Text = "vistafecha";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.vistafecha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EntradaDiarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntradaPorfecha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EntradaDiarioBindingSource;
        private EntradaPorfecha EntradaPorfecha;
        private EntradaPorfechaTableAdapters.EntradaDiarioTableAdapter EntradaDiarioTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtfechaf1;
        public System.Windows.Forms.TextBox txtfechaf2;
    }
}