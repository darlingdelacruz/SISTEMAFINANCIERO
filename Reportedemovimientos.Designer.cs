namespace PRESTAMOS2
{
    partial class Reportedemovimientos
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
            this.movimientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Movimientocompleto = new PRESTAMOS2.Movimientocompleto();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tebo4 = new System.Windows.Forms.TextBox();
            this.tebo5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.movimientoTableAdapter = new PRESTAMOS2.MovimientocompletoTableAdapters.movimientoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.movimientoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Movimientocompleto)).BeginInit();
            this.SuspendLayout();
            // 
            // movimientoBindingSource
            // 
            this.movimientoBindingSource.DataMember = "movimiento";
            this.movimientoBindingSource.DataSource = this.Movimientocompleto;
            // 
            // Movimientocompleto
            // 
            this.Movimientocompleto.DataSetName = "Movimientocompleto";
            this.Movimientocompleto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.movimientoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PRESTAMOS2.Report8.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1370, 608);
            this.reportViewer1.TabIndex = 0;
            // 
            // tebo4
            // 
            this.tebo4.Enabled = false;
            this.tebo4.Location = new System.Drawing.Point(1109, 0);
            this.tebo4.Name = "tebo4";
            this.tebo4.Size = new System.Drawing.Size(100, 20);
            this.tebo4.TabIndex = 1;
            this.tebo4.Visible = false;
            // 
            // tebo5
            // 
            this.tebo5.Enabled = false;
            this.tebo5.Location = new System.Drawing.Point(1270, 0);
            this.tebo5.Name = "tebo5";
            this.tebo5.Size = new System.Drawing.Size(100, 20);
            this.tebo5.TabIndex = 2;
            this.tebo5.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1058, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Desde:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1226, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hasta:";
            this.label2.Visible = false;
            // 
            // movimientoTableAdapter
            // 
            this.movimientoTableAdapter.ClearBeforeFill = true;
            // 
            // Reportedemovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 608);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tebo5);
            this.Controls.Add(this.tebo4);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Reportedemovimientos";
            this.Text = "Reporte de movimientos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Reportedemovimientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movimientoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Movimientocompleto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        public System.Windows.Forms.TextBox tebo4;
        public System.Windows.Forms.TextBox tebo5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource movimientoBindingSource;
        private Movimientocompleto Movimientocompleto;
        private MovimientocompletoTableAdapters.movimientoTableAdapter movimientoTableAdapter;
    }
}