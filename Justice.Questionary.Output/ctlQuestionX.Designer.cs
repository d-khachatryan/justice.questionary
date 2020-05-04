namespace Justice.Questionary.Output
{
    partial class ctlQuestionX
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctlQuestionX));
            this.radPivotGrid1 = new Telerik.WinControls.UI.RadPivotGrid();
            this.specializationExperienceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TopToolStrip = new System.Windows.Forms.ToolStrip();
            this.TsbExportExcel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.residentPatronymicNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.radPivotFieldList1 = new Telerik.WinControls.UI.RadPivotFieldList();
            this.residentLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residentFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TmerMain = new System.Windows.Forms.Timer(this.components);
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.storeDataSet = new Justice.Questionary.Data.StoreDataSet();
            this.vQuestionXBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vQuestionXTableAdapter = new Justice.Questionary.Data.StoreDataSetTableAdapters.vQuestionXTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.radPivotGrid1)).BeginInit();
            this.TopToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vQuestionXBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // radPivotGrid1
            // 
            this.radPivotGrid1.AllowContextMenu = false;
            this.radPivotGrid1.AutoScroll = true;
            this.radPivotGrid1.DataSource = this.vQuestionXBindingSource;
            this.radPivotGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPivotGrid1.Location = new System.Drawing.Point(0, 0);
            this.radPivotGrid1.Name = "radPivotGrid1";
            this.radPivotGrid1.ShowFilterArea = true;
            this.radPivotGrid1.Size = new System.Drawing.Size(609, 577);
            this.radPivotGrid1.TabIndex = 0;
            this.radPivotGrid1.Text = "radPivotGrid1";
            // 
            // specializationExperienceDataGridViewTextBoxColumn
            // 
            this.specializationExperienceDataGridViewTextBoxColumn.DataPropertyName = "Specialization_Experience";
            this.specializationExperienceDataGridViewTextBoxColumn.HeaderText = "Մասնագիտական";
            this.specializationExperienceDataGridViewTextBoxColumn.Name = "specializationExperienceDataGridViewTextBoxColumn";
            this.specializationExperienceDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.TopToolStrip.TabIndex = 8;
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
            // residentPatronymicNameDataGridViewTextBoxColumn
            // 
            this.residentPatronymicNameDataGridViewTextBoxColumn.DataPropertyName = "Resident_Patronymic_Name";
            this.residentPatronymicNameDataGridViewTextBoxColumn.HeaderText = "Հայրանուն";
            this.residentPatronymicNameDataGridViewTextBoxColumn.Name = "residentPatronymicNameDataGridViewTextBoxColumn";
            this.residentPatronymicNameDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.splitContainer1.TabIndex = 9;
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
            // residentLastNameDataGridViewTextBoxColumn
            // 
            this.residentLastNameDataGridViewTextBoxColumn.DataPropertyName = "Resident_Last_Name";
            this.residentLastNameDataGridViewTextBoxColumn.HeaderText = "Ազգանուն";
            this.residentLastNameDataGridViewTextBoxColumn.Name = "residentLastNameDataGridViewTextBoxColumn";
            this.residentLastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // residentFirstNameDataGridViewTextBoxColumn
            // 
            this.residentFirstNameDataGridViewTextBoxColumn.DataPropertyName = "Resident_First_Name";
            this.residentFirstNameDataGridViewTextBoxColumn.HeaderText = "Անուն";
            this.residentFirstNameDataGridViewTextBoxColumn.Name = "residentFirstNameDataGridViewTextBoxColumn";
            this.residentFirstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // residentIDDataGridViewTextBoxColumn
            // 
            this.residentIDDataGridViewTextBoxColumn.DataPropertyName = "Resident_ID";
            this.residentIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.residentIDDataGridViewTextBoxColumn.Name = "residentIDDataGridViewTextBoxColumn";
            this.residentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.residentIDDataGridViewTextBoxColumn.Visible = false;
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
            // storeDataSet
            // 
            this.storeDataSet.DataSetName = "StoreDataSet";
            this.storeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vQuestionXBindingSource
            // 
            this.vQuestionXBindingSource.DataMember = "vQuestionX";
            this.vQuestionXBindingSource.DataSource = this.storeDataSet;
            // 
            // vQuestionXTableAdapter
            // 
            this.vQuestionXTableAdapter.ClearBeforeFill = true;
            // 
            // ctlQuestionX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.TopToolStrip);
            this.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ctlQuestionX";
            this.Size = new System.Drawing.Size(917, 602);
            ((System.ComponentModel.ISupportInitialize)(this.radPivotGrid1)).EndInit();
            this.TopToolStrip.ResumeLayout(false);
            this.TopToolStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vQuestionXBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadPivotGrid radPivotGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn specializationExperienceDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip TopToolStrip;
        private System.Windows.Forms.ToolStripButton TsbExportExcel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn residentPatronymicNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Telerik.WinControls.UI.RadPivotFieldList radPivotFieldList1;
        private System.Windows.Forms.DataGridViewTextBoxColumn residentLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn residentFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn residentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Timer TmerMain;
        private System.Windows.Forms.SaveFileDialog sfd;
        private Data.StoreDataSet storeDataSet;
        private System.Windows.Forms.BindingSource vQuestionXBindingSource;
        private Data.StoreDataSetTableAdapters.vQuestionXTableAdapter vQuestionXTableAdapter;
    }
}
