
namespace Tiểu_Luận
{
    partial class bcl
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
            this.TblCongKhoiDieuHanhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLNSDataSet1 = new Tiểu_Luận.QLNSDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TblCongKhoiDieuHanhTableAdapter = new Tiểu_Luận.QLNSDataSet1TableAdapters.TblCongKhoiDieuHanhTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TblCongKhoiDieuHanhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLNSDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // TblCongKhoiDieuHanhBindingSource
            // 
            this.TblCongKhoiDieuHanhBindingSource.DataMember = "TblCongKhoiDieuHanh";
            this.TblCongKhoiDieuHanhBindingSource.DataSource = this.QLNSDataSet1;
            // 
            // QLNSDataSet1
            // 
            this.QLNSDataSet1.DataSetName = "QLNSDataSet1";
            this.QLNSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TblCongKhoiDieuHanhBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Tiểu_Luận.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1184, 611);
            this.reportViewer1.TabIndex = 0;
            // 
            // TblCongKhoiDieuHanhTableAdapter
            // 
            this.TblCongKhoiDieuHanhTableAdapter.ClearBeforeFill = true;
            // 
            // bcl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.reportViewer1);
            this.Name = "bcl";
            this.Text = "bcl";
            this.Load += new System.EventHandler(this.bcl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TblCongKhoiDieuHanhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLNSDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TblCongKhoiDieuHanhBindingSource;
        private QLNSDataSet1 QLNSDataSet1;
        private QLNSDataSet1TableAdapters.TblCongKhoiDieuHanhTableAdapter TblCongKhoiDieuHanhTableAdapter;
    }
}