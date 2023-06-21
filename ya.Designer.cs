namespace PRESTAMOS2
{
    partial class ya
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ya));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ya1 = new PRESTAMOS2.ya1();
            this.EntradaDiarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EntradaDiarioTableAdapter = new PRESTAMOS2.ya1TableAdapters.EntradaDiarioTableAdapter();
            this.tebo3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tebo2 = new System.Windows.Forms.TextBox();
            this.tebo1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ya1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntradaDiarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.EntradaDiarioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PRESTAMOS2.Report14.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(755, 535);
            this.reportViewer1.TabIndex = 0;
            // 
            // ya1
            // 
            this.ya1.DataSetName = "ya1";
            this.ya1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EntradaDiarioBindingSource
            // 
            this.EntradaDiarioBindingSource.DataMember = "EntradaDiario";
            this.EntradaDiarioBindingSource.DataSource = this.ya1;
            // 
            // EntradaDiarioTableAdapter
            // 
            this.EntradaDiarioTableAdapter.ClearBeforeFill = true;
            // 
            // tebo3
            // 
            this.tebo3.Enabled = false;
            this.tebo3.Location = new System.Drawing.Point(314, 2);
            this.tebo3.Name = "tebo3";
            this.tebo3.Size = new System.Drawing.Size(100, 20);
            this.tebo3.TabIndex = 10;
            this.tebo3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(612, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Hasta:";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(434, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Desde:";
            this.label1.Visible = false;
            // 
            // tebo2
            // 
            this.tebo2.Enabled = false;
            this.tebo2.Location = new System.Drawing.Point(656, 2);
            this.tebo2.Name = "tebo2";
            this.tebo2.Size = new System.Drawing.Size(100, 20);
            this.tebo2.TabIndex = 7;
            this.tebo2.Visible = false;
            // 
            // tebo1
            // 
            this.tebo1.Enabled = false;
            this.tebo1.Location = new System.Drawing.Point(495, 2);
            this.tebo1.Name = "tebo1";
            this.tebo1.Size = new System.Drawing.Size(100, 20);
            this.tebo1.TabIndex = 6;
            this.tebo1.Visible = false;
            // 
            // ya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 535);
            this.Controls.Add(this.tebo3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tebo2);
            this.Controls.Add(this.tebo1);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ya";
            this.Text = "Reporte";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ya_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ya1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntradaDiarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EntradaDiarioBindingSource;
        private ya1 ya1;
        private ya1TableAdapters.EntradaDiarioTableAdapter EntradaDiarioTableAdapter;
        public System.Windows.Forms.TextBox tebo3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tebo2;
        public System.Windows.Forms.TextBox tebo1;
    }
}