using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Justice.Questionary.Data;
using System.IO;
using Telerik.WinControls.UI.Export;
using Telerik.WinControls.UI.Export.ExcelML;
using Telerik.WinControls.UI.Localization;
using Telerik.WinControls.UI;
using Telerik.WinControls.Export;
using Telerik.Pivot.Core;
using System.Data.SqlClient;

namespace Justice.Questionary.Output
{
    

    public partial class ctlQuestionT1 : UserControl
    {
        private readonly string language;
        string strLanguage;
        string strConnectionString;
        StoreDataContext db;

        public ctlQuestionT1(string language, string connectionString)
        {
            RadGridLocalizationProvider.CurrentProvider = new AmRadGridLocalizationProvider();
            PivotGridLocalizationProvider.CurrentProvider = new AmPivotGridLoclizationProvider();
            this.language = language;
            InitializeComponent();
            strLanguage = language;
            strConnectionString = connectionString;
            db = new StoreDataContext(strConnectionString);
            db.CommandTimeout = GlobalClass.IntCommandTimeout;
            TmerMain.Enabled = true;
            this.radPivotGrid1.DataProvider.PrepareDescriptionForField += DataProvider_PrepareDescriptionForField;
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.ParentForm.FormClosing += new FormClosingEventHandler(ParentForm_FormClosing);
        }

        void ParentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void TmerMain_Tick(object sender, EventArgs e)
        {
            TmerMain.Enabled = false;
            this.vQuestionT1TableAdapter.SetConnection(new SqlConnection(strConnectionString));
            this.vQuestionT1TableAdapter.Fill(this.storeDataSet.vQuestionT1);
        }

        private void TsbExportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                PivotGridSpreadExport spreadExport = new PivotGridSpreadExport(this.radPivotGrid1);
                spreadExport.ExportVisualSettings = true;
                spreadExport.ExportFlatData = false;
                if (this.sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string fileName = this.sfd.FileName;
                    spreadExport.RunExport(fileName, new SpreadExportRenderer());
                    MessageBox.Show("Արտահանումը ավարտված է:", "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void exporter_PivotExcelCellFormatting(object sender, Telerik.WinControls.UI.Export.ExcelPivotCellExportingEventArgs e)
        {
            e.Cell.BorderColor  = Color.Black;
            e.Cell.DrawBorder = true;
        }


        private void DataProvider_PrepareDescriptionForField(object sender, PrepareDescriptionForFieldEventArgs e)
        {
            if (e.Description is DoubleGroupDescription)
            {
                e.Description = new PropertyGroupDescription() { PropertyName = e.Description.DisplayName, GroupComparer = new GrandTotalComparer() };
            }
        }


    }
}
