namespace PRESTAMOS2
{
    partial class balanzaklok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(balanzaklok));
            this.balanza1 = new System.Windows.Forms.TextBox();
            this.balanza2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.balanzanuevaera = new PRESTAMOS2.balanzanuevaera();
            this.EntradaDiarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EntradaDiarioTableAdapter = new PRESTAMOS2.balanzanuevaeraTableAdapters.EntradaDiarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.balanzanuevaera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntradaDiarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // balanza1
            // 
            this.balanza1.Enabled = false;
            this.balanza1.Location = new System.Drawing.Point(919, 6);
            this.balanza1.Name = "balanza1";
            this.balanza1.Size = new System.Drawing.Size(100, 20);
            this.balanza1.TabIndex = 5;
            this.balanza1.Visible = false;
            // 
            // balanza2
            // 
            this.balanza2.Enabled = false;
            this.balanza2.Location = new System.Drawing.Point(1089, 6);
            this.balanza2.Name = "balanza2";
            this.balanza2.Size = new System.Drawing.Size(100, 20);
            this.balanza2.TabIndex = 6;
            this.balanza2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(869, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Desde:";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1045, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hasta:";
            this.label4.Visible = false;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.EntradaDiarioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PRESTAMOS2.Report13.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1191, 602);
            this.reportViewer1.TabIndex = 9;
            // 
            // balanzanuevaera
            // 
            this.balanzanuevaera.DataSetName = "balanzanuevaera";
            this.balanzanuevaera.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EntradaDiarioBindingSource
            // 
            this.EntradaDiarioBindingSource.DataMember = "EntradaDiario";
            this.EntradaDiarioBindingSource.DataSource = this.balanzanuevaera;
            // 
            // EntradaDiarioTableAdapter
            // 
            this.EntradaDiarioTableAdapter.ClearBeforeFill = true;
            // 
            // balanzaklok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 602);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.balanza2);
            this.Controls.Add(this.balanza1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "balanzaklok";
            this.Text = "BALANZA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.balanzaklok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.balanzanuevaera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntradaDiarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox balanza1;
        public System.Windows.Forms.TextBox balanza2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EntradaDiarioBindingSource;
        private balanzanuevaera balanzanuevaera;
        private balanzanuevaeraTableAdapters.EntradaDiarioTableAdapter EntradaDiarioTableAdapter;
    }
}