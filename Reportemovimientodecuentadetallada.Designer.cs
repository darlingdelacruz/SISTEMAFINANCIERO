namespace PRESTAMOS2
{
    partial class Reportemovimientodecuentadetallada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reportemovimientodecuentadetallada));
            this.movimientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TABLAMOVIMIENTOS = new PRESTAMOS2.TABLAMOVIMIENTOS();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tebo1 = new System.Windows.Forms.TextBox();
            this.tebo2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tebo3 = new System.Windows.Forms.TextBox();
            this.movimientoTableAdapter = new PRESTAMOS2.TABLAMOVIMIENTOSTableAdapters.movimientoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.movimientoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TABLAMOVIMIENTOS)).BeginInit();
            this.SuspendLayout();
            // 
            // movimientoBindingSource
            // 
            this.movimientoBindingSource.DataMember = "movimiento";
            this.movimientoBindingSource.DataSource = this.TABLAMOVIMIENTOS;
            // 
            // TABLAMOVIMIENTOS
            // 
            this.TABLAMOVIMIENTOS.DataSetName = "TABLAMOVIMIENTOS";
            this.TABLAMOVIMIENTOS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.movimientoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PRESTAMOS2.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1370, 521);
            this.reportViewer1.TabIndex = 0;
            // 
            // tebo1
            // 
            this.tebo1.Enabled = false;
            this.tebo1.Location = new System.Drawing.Point(1097, 0);
            this.tebo1.Name = "tebo1";
            this.tebo1.Size = new System.Drawing.Size(100, 20);
            this.tebo1.TabIndex = 1;
            this.tebo1.Visible = false;
            // 
            // tebo2
            // 
            this.tebo2.Enabled = false;
            this.tebo2.Location = new System.Drawing.Point(1258, 0);
            this.tebo2.Name = "tebo2";
            this.tebo2.Size = new System.Drawing.Size(100, 20);
            this.tebo2.TabIndex = 2;
            this.tebo2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1036, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Desde:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1214, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hasta:";
            this.label2.Visible = false;
            // 
            // tebo3
            // 
            this.tebo3.Enabled = false;
            this.tebo3.Location = new System.Drawing.Point(916, 0);
            this.tebo3.Name = "tebo3";
            this.tebo3.Size = new System.Drawing.Size(100, 20);
            this.tebo3.TabIndex = 5;
            this.tebo3.Visible = false;
            // 
            // movimientoTableAdapter
            // 
            this.movimientoTableAdapter.ClearBeforeFill = true;
            // 
            // Reportemovimientodecuentadetallada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 521);
            this.Controls.Add(this.tebo3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tebo2);
            this.Controls.Add(this.tebo1);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reportemovimientodecuentadetallada";
            this.Text = "Movimiento de cuenta detallada";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Reportemovimientodecuentadetallada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movimientoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TABLAMOVIMIENTOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource movimientoBindingSource;
        private TABLAMOVIMIENTOS TABLAMOVIMIENTOS;
        private TABLAMOVIMIENTOSTableAdapters.movimientoTableAdapter movimientoTableAdapter;
        public System.Windows.Forms.TextBox tebo1;
        public System.Windows.Forms.TextBox tebo2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tebo3;
    }
}