namespace PRESTAMOS2
{
    partial class InteresesPagadoIndividual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InteresesPagadoIndividual));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfecha2 = new System.Windows.Forms.TextBox();
            this.txtfecha1 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.balanzanuevaera = new PRESTAMOS2.balanzanuevaera();
            this.EntradaDiarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EntradaDiarioTableAdapter = new PRESTAMOS2.balanzanuevaeraTableAdapters.EntradaDiarioTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CreditoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.InteresesIndividuales = new PRESTAMOS2.InteresesIndividuales();
            this.CreditoTableAdapter = new PRESTAMOS2.InteresesIndividualesTableAdapters.CreditoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.balanzanuevaera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntradaDiarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreditoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InteresesIndividuales)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(721, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(539, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Desde:";
            // 
            // txtfecha2
            // 
            this.txtfecha2.Enabled = false;
            this.txtfecha2.Location = new System.Drawing.Point(772, 0);
            this.txtfecha2.Name = "txtfecha2";
            this.txtfecha2.Size = new System.Drawing.Size(100, 20);
            this.txtfecha2.TabIndex = 10;
            // 
            // txtfecha1
            // 
            this.txtfecha1.Enabled = false;
            this.txtfecha1.Location = new System.Drawing.Point(602, 0);
            this.txtfecha1.Name = "txtfecha1";
            this.txtfecha1.Size = new System.Drawing.Size(100, 20);
            this.txtfecha1.TabIndex = 9;
            this.txtfecha1.Visible = false;
            // 
            // txt3
            // 
            this.txt3.Enabled = false;
            this.txt3.Location = new System.Drawing.Point(385, 3);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(148, 20);
            this.txt3.TabIndex = 13;
            this.txt3.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Cedula:";
            // 
            // txt4
            // 
            this.txt4.Enabled = false;
            this.txt4.Location = new System.Drawing.Point(584, 36);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(148, 20);
            this.txt4.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(551, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "No.:";
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
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.CreditoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PRESTAMOS2.Report21.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(877, 866);
            this.reportViewer1.TabIndex = 18;
            // 
            // CreditoBindingSource
            // 
            this.CreditoBindingSource.DataMember = "Credito";
            this.CreditoBindingSource.DataSource = this.InteresesIndividuales;
            // 
            // InteresesIndividuales
            // 
            this.InteresesIndividuales.DataSetName = "InteresesIndividuales";
            this.InteresesIndividuales.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CreditoTableAdapter
            // 
            this.CreditoTableAdapter.ClearBeforeFill = true;
            // 
            // InteresesPagadoIndividual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 866);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtfecha2);
            this.Controls.Add(this.txtfecha1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InteresesPagadoIndividual";
            this.Text = "Intereses Pagados Individual";
            this.Load += new System.EventHandler(this.InteresesPagadoIndividual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.balanzanuevaera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntradaDiarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreditoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InteresesIndividuales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtfecha2;
        public System.Windows.Forms.TextBox txtfecha1;
        public System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource CreditoBindingSource;
        private InteresesIndividuales InteresesIndividuales;
        private InteresesIndividualesTableAdapters.CreditoTableAdapter CreditoTableAdapter;
        public System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource EntradaDiarioBindingSource;
        private balanzanuevaera balanzanuevaera;
        private balanzanuevaeraTableAdapters.EntradaDiarioTableAdapter EntradaDiarioTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}