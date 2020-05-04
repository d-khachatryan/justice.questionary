namespace Justice.Questionary.Output
{
    partial class ctlQuestionT1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctlQuestionT1));
            this.TopToolStrip = new System.Windows.Forms.ToolStrip();
            this.TsbExportExcel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.radPivotFieldList1 = new Telerik.WinControls.UI.RadPivotFieldList();
            this.radPivotGrid1 = new Telerik.WinControls.UI.RadPivotGrid();
            this.vQuestionT1BindingSource = new System.Windows.Forms.BindingSource();
            this.storeDataSet = new Justice.Questionary.Data.StoreDataSet();
            this.TmerMain = new System.Windows.Forms.Timer();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.vQuestionT1TableAdapter = new Justice.Questionary.Data.StoreDataSetTableAdapters.vQuestionT1TableAdapter();
            this.TopToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPivotGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vQuestionT1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // TopToolStrip
            // 
            this.TopToolStrip.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsbExportExcel,
            this.toolStripSeparator1});
            this.TopToolStrip.Location = new System.Drawing.Point(0, 0);
            this.TopToolStrip.Name = "TopToolStrip";
            this.TopToolStrip.Size = new System.Drawing.Size(917, 25);
            this.TopToolStrip.TabIndex = 4;
            this.TopToolStrip.Text = "toolStrip1";
            // 
            // TsbExportExcel
            // 
            this.TsbExportExcel.Image = ((System.Drawing.Image)(resources.GetObject("TsbExportExcel.Image")));
            this.TsbExportExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbExportExcel.Name = "TsbExportExcel";
            this.TsbExportExcel.Size = new System.Drawing.Size(103, 22);
            this.TsbExportExcel.Text = "Արտահանել";
            this.TsbExportExcel.Click += new System.EventHandler(this.TsbExportExcel_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.radPivotFieldList1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.radPivotGrid1);
            this.splitContainer1.Size = new System.Drawing.Size(917, 577);
            this.splitContainer1.SplitterDistance = 304;
            this.splitContainer1.TabIndex = 5;
            // 
            // radPivotFieldList1
            // 
            this.radPivotFieldList1.AssociatedPivotGrid = this.radPivotGrid1;
            this.radPivotFieldList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPivotFieldList1.Location = new System.Drawing.Point(0, 0);
            this.radPivotFieldList1.MinimumSize = new System.Drawing.Size(225, 305);
            this.radPivotFieldList1.Name = "radPivotFieldList1";
            this.radPivotFieldList1.Size = new System.Drawing.Size(304, 577);
            this.radPivotFieldList1.TabIndex = 3;
            this.radPivotFieldList1.ThemeName = null;
            // 
            // radPivotGrid1
            // 
            this.radPivotGrid1.AllowContextMenu = false;
            this.radPivotGrid1.AllowGroupFiltering = false;
            this.radPivotGrid1.AutoScroll = true;
            this.radPivotGrid1.DataSource = this.vQuestionT1BindingSource;
            this.radPivotGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPivotGrid1.Location = new System.Drawing.Point(0, 0);
            this.radPivotGrid1.Name = "radPivotGrid1";
            this.radPivotGrid1.ShowFilterArea = true;
            this.radPivotGrid1.Size = new System.Drawing.Size(609, 577);
            this.radPivotGrid1.TabIndex = 0;
            this.radPivotGrid1.Text = "radPivotGrid1";
            // 
            // vQuestionT1BindingSource
            // 
            this.vQuestionT1BindingSource.DataMember = "vQuestionT1";
            this.vQuestionT1BindingSource.DataSource = this.storeDataSet;
            // 
            // storeDataSet
            // 
            this.storeDataSet.DataSetName = "StoreDataSet";
            this.storeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TmerMain
            // 
            this.TmerMain.Interval = 1000;
            this.TmerMain.Tick += new System.EventHandler(this.TmerMain_Tick);
            // 
            // sfd
            // 
            this.sfd.DefaultExt = "\"Excel (*.xlsx)|*.xlsx\"";
            this.sfd.Filter = "Excel Worksheets|*.xlsx";
            // 
            // vQuestionT1TableAdapter
            // 
            this.vQuestionT1TableAdapter.ClearBeforeFill = true;
            // 
            // ctlQuestionT1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.TopToolStrip);
            this.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ctlQuestionT1";
            this.Size = new System.Drawing.Size(917, 602);
            this.TopToolStrip.ResumeLayout(false);
            this.TopToolStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPivotGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vQuestionT1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip TopToolStrip;
        private System.Windows.Forms.ToolStripButton TsbExportExcel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Timer TmerMain;
        private System.Windows.Forms.SaveFileDialog sfd;
        private Telerik.WinControls.UI.RadPivotGrid radPivotGrid1;
        private Telerik.WinControls.UI.RadPivotFieldList radPivotFieldList1;
        private Data.StoreDataSet storeDataSet;
        private System.Windows.Forms.BindingSource vQuestionT1BindingSource;
        private Data.StoreDataSetTableAdapters.vQuestionT1TableAdapter vQuestionT1TableAdapter;
    }
}
