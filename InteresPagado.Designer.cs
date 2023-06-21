namespace PRESTAMOS2
{
    partial class InteresPagado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InteresPagado));
            this.CreditoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.InteresesPagados = new PRESTAMOS2.InteresesPagados();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfecha2 = new System.Windows.Forms.TextBox();
            this.txtfecha1 = new System.Windows.Forms.TextBox();
            this.CreditoTableAdapter = new PRESTAMOS2.InteresesPagadosTableAdapters.CreditoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CreditoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InteresesPagados)).BeginInit();
            this.SuspendLayout();
            // 
            // CreditoBindingSource
            // 
            this.CreditoBindingSource.DataMember = "Credito";
            this.CreditoBindingSource.DataSource = this.InteresesPagados;
            // 
            // InteresesPagados
            // 
            this.InteresesPagados.DataSetName = "InteresesPagados";
            this.InteresesPagados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CreditoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PRESTAMOS2.Report19.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(991, 1235);
            this.reportViewer1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(840, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(658, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Desde:";
            // 
            // txtfecha2
            // 
            this.txtfecha2.Enabled = false;
            this.txtfecha2.Location = new System.Drawing.Point(891, 1);
            this.txtfecha2.Name = "txtfecha2";
            this.txtfecha2.Size = new System.Drawing.Size(100, 20);
            this.txtfecha2.TabIndex = 6;
            // 
            // txtfecha1
            // 
            this.txtfecha1.Enabled = false;
            this.txtfecha1.Location = new System.Drawing.Point(721, 1);
            this.txtfecha1.Name = "txtfecha1";
            this.txtfecha1.Size = new System.Drawing.Size(100, 20);
            this.txtfecha1.TabIndex = 5;
            // 
            // CreditoTableAdapter
            // 
            this.CreditoTableAdapter.ClearBeforeFill = true;
            // 
            // InteresPagado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 1235);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtfecha2);
            this.Controls.Add(this.txtfecha1);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InteresPagado";
            this.Text = "Interes Pagado Por Fecha";
            this.Load += new System.EventHandler(this.InteresPagado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CreditoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InteresesPagados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtfecha2;
        public System.Windows.Forms.TextBox txtfecha1;
        private System.Windows.Forms.BindingSource CreditoBindingSource;
        private InteresesPagados InteresesPagados;
        private InteresesPagadosTableAdapters.CreditoTableAdapter CreditoTableAdapter;
    }
}