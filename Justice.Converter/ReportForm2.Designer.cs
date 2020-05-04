namespace Justice.Converter
{
    partial class ReportForm2
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
            this.JusticeDB2DataSet = new Justice.Converter.JusticeDB2DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.vwSubQuestionT2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwSubQuestionT2TableAdapter = new Justice.Converter.JusticeDB2DataSetTableAdapters.vwSubQuestionT2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.JusticeDB2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwSubQuestionT2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // JusticeDB2DataSet
            // 
            this.JusticeDB2DataSet.DataSetName = "JusticeDB2DataSet";
            this.JusticeDB2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ReportDataSet";
            reportDataSource1.Value = this.vwSubQuestionT2BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Justice.Converter.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(619, 404);
            this.reportViewer1.TabIndex = 0;
            // 
            // vwSubQuestionT2BindingSource
            // 
            this.vwSubQuestionT2BindingSource.DataMember = "vwSubQuestionT2";
            this.vwSubQuestionT2BindingSource.DataSource = this.JusticeDB2DataSet;
            // 
            // vwSubQuestionT2TableAdapter
            // 
            this.vwSubQuestionT2TableAdapter.ClearBeforeFill = true;
            // 
            // ReportForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 404);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.JusticeDB2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwSubQuestionT2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private JusticeDB2DataSet JusticeDB2DataSet;
        private System.Windows.Forms.BindingSource vwSubQuestionT2BindingSource;
        private JusticeDB2DataSetTableAdapters.vwSubQuestionT2TableAdapter vwSubQuestionT2TableAdapter;
    }
}