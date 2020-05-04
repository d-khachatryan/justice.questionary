using System;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls.UI.Localization;

namespace Justice.Questionary.Catalogs
{

    public partial class frmCatalogManager : Telerik.WinControls.UI.RadForm
    {
        string strConnectionString;
        CatalogStoreDataContext  db;
        DatabaseTable dbt;

        public frmCatalogManager(string ConnectionString)
        {
            InitializeComponent();
            strConnectionString = ConnectionString;
            db = new CatalogStoreDataContext(strConnectionString);
            dbt = new DatabaseTable();
            RadGridLocalizationProvider.CurrentProvider = new MyEnglishRadGridLocalizationProvider();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            this.bs.EndEdit();
            db.SubmitChanges();
        }

        private void FillGrid()
        {
            Application.UseWaitCursor = true;
            this.rgv.MasterTemplate.DataSource = null;
            this.rgv.MasterTemplate.Columns.Clear();
            dbt.columnCollection.Clear();
            this.rgv.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            switch (rlv.SelectedIndex)
            {
                case 0:
                    this.bs.DataSource = typeof(Justice.Questionary.Catalogs.Gender);
                    dbt.columnCollection.Add(new TableColumn("Gender_ID", "ID", "Int32", 4, true));
                    dbt.columnCollection.Add(new TableColumn("Gender_Name", "Անվանում", "String", 50, false));
                    dbt.columnCollection.Add(new TableColumn("Gender_EN_Name", "Անգլերեն անվանում", "String", 50, false));
                    foreach (TableColumn item in dbt.columnCollection)
                    {
                        this.rgv.MasterTemplate.Columns.Add(item.GridColumn);
                    }
                    this.bs.DataSource = from p in db.Genders select p;
                    break;
                case 1:
                    this.bs.DataSource = typeof(Justice.Questionary.Catalogs.Date_Interval);
                    dbt.columnCollection.Add(new TableColumn("Date_Interval_ID", "ID", "Int32", 4, true));
                    dbt.columnCollection.Add(new TableColumn("Date_Interval_Name", "Անվանում", "String", 50, false));
                    dbt.columnCollection.Add(new TableColumn("Date_Interval_EN_Name", "Անգլերեն անվանում", "String", 50, false));
                    foreach (TableColumn item in dbt.columnCollection)
                    {
                        this.rgv.MasterTemplate.Columns.Add(item.GridColumn);
                    }
                    this.bs.DataSource = from p in db.Date_Intervals select p;
                    break;
                case 2:
                    this.bs.DataSource = typeof(Justice.Questionary.Catalogs.Court);
                    dbt.columnCollection.Add(new TableColumn("Court_ID", "ID", "Int32", 4, true));
                    dbt.columnCollection.Add(new TableColumn("Court_Name", "Անվանում", "String", 350, false));
                    dbt.columnCollection.Add(new TableColumn("Court_EN_Name", "Անգլերեն անվանում", "String", 350, false));
                    foreach (TableColumn item in dbt.columnCollection)
                    {
                        this.rgv.MasterTemplate.Columns.Add(item.GridColumn);
                    }
                    this.bs.DataSource = from p in db.Courts select p;
                    break;                
                case 3:
                    this.bs.DataSource = typeof(Justice.Questionary.Catalogs.CatalogT3);
                    dbt.columnCollection.Add(new TableColumn("CatalogT3_ID", "ID", "Int32", 4, true));
                    dbt.columnCollection.Add(new TableColumn("CatalogT3_Name", "Անվանում", "String", 50, false));
                    dbt.columnCollection.Add(new TableColumn("CatalogT3_EN_Name", "Անգլերեն անվանում", "String", 50, false));
                    foreach (TableColumn item in dbt.columnCollection)
                    {
                        this.rgv.MasterTemplate.Columns.Add(item.GridColumn);
                    }
                    this.bs.DataSource = from p in db.CatalogT3s select p;
                    break;
                case 4:
                    this.bs.DataSource = typeof(Justice.Questionary.Catalogs.CatalogT4);
                    dbt.columnCollection.Add(new TableColumn("CatalogT4_ID", "ID", "Int32", 4, true));
                    dbt.columnCollection.Add(new TableColumn("CatalogT4_Name", "Անվանում", "String", 50, false));
                    dbt.columnCollection.Add(new TableColumn("CatalogT4_EN_Name", "Անգլերեն անվանում", "String", 50, false));
                    foreach (TableColumn item in dbt.columnCollection)
                    {
                        this.rgv.MasterTemplate.Columns.Add(item.GridColumn);
                    }
                    this.bs.DataSource = from p in db.CatalogT4s select p;
                    break;
                case 5:
                    this.bs.DataSource = typeof(Justice.Questionary.Catalogs.CatalogT5);
                    dbt.columnCollection.Add(new TableColumn("CatalogT5_ID", "ID", "Int32", 4, true));
                    dbt.columnCollection.Add(new TableColumn("CatalogT5_Name", "Անվանում", "String", 50, false));
                    dbt.columnCollection.Add(new TableColumn("CatalogT5_EN_Name", "Անգլերեն անվանում", "String", 50, false));
                    foreach (TableColumn item in dbt.columnCollection)
                    {
                        this.rgv.MasterTemplate.Columns.Add(item.GridColumn);
                    }
                    this.bs.DataSource = from p in db.CatalogT5s select p;
                    break;
                case 6:
                    this.bs.DataSource = typeof(Justice.Questionary.Catalogs.CatalogT6);
                    dbt.columnCollection.Add(new TableColumn("CatalogT6_ID", "ID", "Int32", 4, true));
                    dbt.columnCollection.Add(new TableColumn("CatalogT6_Name", "Անվանում", "String", 50, false));
                    dbt.columnCollection.Add(new TableColumn("CatalogT6_EN_Name", "Անգլերեն անվանում", "String", 50, false));
                    foreach (TableColumn item in dbt.columnCollection)
                    {
                        this.rgv.MasterTemplate.Columns.Add(item.GridColumn);
                    }
                    this.bs.DataSource = from p in db.CatalogT6s select p;
                    break;
                case 7:
                    this.bs.DataSource = typeof(Justice.Questionary.Catalogs.CatalogT7);
                    dbt.columnCollection.Add(new TableColumn("CatalogT7_ID", "ID", "Int32", 4, true));
                    dbt.columnCollection.Add(new TableColumn("CatalogT7_Name", "Անվանում", "String", 50, false));
                    dbt.columnCollection.Add(new TableColumn("CatalogT7_EN_Name", "Անգլերեն անվանում", "String", 50, false));
                    foreach (TableColumn item in dbt.columnCollection)
                    {
                        this.rgv.MasterTemplate.Columns.Add(item.GridColumn);
                    }
                    this.bs.DataSource = from p in db.CatalogT7s select p;
                    break;
                case 8:
                    this.bs.DataSource = typeof(Justice.Questionary.Catalogs.CatalogT8);
                    dbt.columnCollection.Add(new TableColumn("CatalogT8_ID", "ID", "Int32", 4, true));
                    dbt.columnCollection.Add(new TableColumn("CatalogT8_Name", "Անվանում", "String", 50, false));
                    dbt.columnCollection.Add(new TableColumn("CatalogT8_EN_Name", "Անգլերեն անվանում", "String", 50, false));
                    foreach (TableColumn item in dbt.columnCollection)
                    {
                        this.rgv.MasterTemplate.Columns.Add(item.GridColumn);
                    }
                    this.bs.DataSource = from p in db.CatalogT8s select p;
                    break;
                case 9:
                    this.bs.DataSource = typeof(Justice.Questionary.Catalogs.CatalogT9);
                    dbt.columnCollection.Add(new TableColumn("CatalogT9_ID", "ID", "Int32", 4, true));
                    dbt.columnCollection.Add(new TableColumn("CatalogT9_Name", "Անվանում", "String", 50, false));
                    dbt.columnCollection.Add(new TableColumn("CatalogT9_EN_Name", "Անգլերեն անվանում", "String", 50, false));
                    foreach (TableColumn item in dbt.columnCollection)
                    {
                        this.rgv.MasterTemplate.Columns.Add(item.GridColumn);
                    }
                    this.bs.DataSource = from p in db.CatalogT9s select p;
                    break;
                case 10:
                    this.bs.DataSource = typeof(Justice.Questionary.Catalogs.CatalogT10);
                    dbt.columnCollection.Add(new TableColumn("CatalogT10_ID", "ID", "Int32", 4, true));
                    dbt.columnCollection.Add(new TableColumn("CatalogT10_Name", "Անվանում", "String", 50, false));
                    dbt.columnCollection.Add(new TableColumn("CatalogT10_EN_Name", "Անգլերեն անվանում", "String", 50, false));
                    foreach (TableColumn item in dbt.columnCollection)
                    {
                        this.rgv.MasterTemplate.Columns.Add(item.GridColumn);
                    }
                    this.bs.DataSource = from p in db.CatalogT10s select p;
                    break;
                case 11:
                    this.bs.DataSource = typeof(Justice.Questionary.Catalogs.CatalogT10_Detail);
                    dbt.columnCollection.Add(new TableColumn("CatalogT10_Detail_ID", "ID", "Int32", 4, true));
                    dbt.columnCollection.Add(new TableColumn("CatalogT10_Detail_Name", "Անվանում", "String", 50, false));
                    dbt.columnCollection.Add(new TableColumn("CatalogT10_Detail_EN_Name", "Անգլերեն անվանում", "String", 50, false));
                    foreach (TableColumn item in dbt.columnCollection)
                    {
                        this.rgv.MasterTemplate.Columns.Add(item.GridColumn);
                    }
                    this.bs.DataSource = from p in db.CatalogT10_Details select p;
                    break;
                case 12:
                    this.bs.DataSource = typeof(Justice.Questionary.Catalogs.Public_Lawyer_Service);
                    dbt.columnCollection.Add(new TableColumn("Public_Lawyer_Service_ID", "ID", "Int32", 4, true));
                    dbt.columnCollection.Add(new TableColumn("Public_Lawyer_Service_Name", "Անվանում", "String", 50, false));
                    dbt.columnCollection.Add(new TableColumn("Public_Lawyer_Service_EN_Name", "Անգլերեն անվանում", "String", 50, false));
                    foreach (TableColumn item in dbt.columnCollection)
                    {
                        this.rgv.MasterTemplate.Columns.Add(item.GridColumn);
                    }
                    this.bs.DataSource = from p in db.Public_Lawyer_Services select p;
                    break;
                case 13:
                    this.bs.DataSource = typeof(Justice.Questionary.Catalogs.Public_Lawyer_Service_Payment);
                    dbt.columnCollection.Add(new TableColumn("Public_Lawyer_Service_Payment_ID", "ID", "Int32", 4, true));
                    dbt.columnCollection.Add(new TableColumn("Public_Lawyer_Service_Payment_Name", "Անվանում", "String", 50, false));
                    dbt.columnCollection.Add(new TableColumn("Public_Lawyer_Service_Payment_EN_Name", "Անգլերեն անվանում", "String", 50, false));
                    foreach (TableColumn item in dbt.columnCollection)
                    {
                        this.rgv.MasterTemplate.Columns.Add(item.GridColumn);
                    }
                    this.bs.DataSource = from p in db.Public_Lawyer_Service_Payments select p;
                    break;
                case 14:
                    this.bs.DataSource = typeof(Justice.Questionary.Catalogs.Lawyer_Service);
                    dbt.columnCollection.Add(new TableColumn("Lawyer_Service_ID", "ID", "Int32", 4, true));
                    dbt.columnCollection.Add(new TableColumn("Lawyer_Service_Name", "Անվանում", "String", 50, false));
                    dbt.columnCollection.Add(new TableColumn("Lawyer_Service_EN_Name", "Անգլերեն անվանում", "String", 50, false));
                    foreach (TableColumn item in dbt.columnCollection)
                    {
                        this.rgv.MasterTemplate.Columns.Add(item.GridColumn);
                    }
                    this.bs.DataSource = from p in db.Lawyer_Services select p;
                    break;
                case 15:
                    this.bs.DataSource = typeof(Justice.Questionary.Catalogs.CatalogT30);
                    dbt.columnCollection.Add(new TableColumn("CatalogT30_ID", "ID", "Int32", 4, true));
                    dbt.columnCollection.Add(new TableColumn("CatalogT30_Name", "Անվանում", "String", 50, false));
                    dbt.columnCollection.Add(new TableColumn("CatalogT30_EN_Name", "Անգլերեն անվանում", "String", 50, false));
                    foreach (TableColumn item in dbt.columnCollection)
                    {
                        this.rgv.MasterTemplate.Columns.Add(item.GridColumn);
                    }
                    this.bs.DataSource = from p in db.CatalogT30s select p;
                    break;
                case 16:
                    this.bs.DataSource = typeof(Justice.Questionary.Catalogs.Communication_Type);
                    dbt.columnCollection.Add(new TableColumn("Communication_Type_ID", "ID", "Int32", 4, true));
                    dbt.columnCollection.Add(new TableColumn("Communication_Type_Name", "Անվանում", "String", 50, false));
                    dbt.columnCollection.Add(new TableColumn("Communication_Type_EN_Name", "Անգլերեն անվանում", "String", 50, false));
                    foreach (TableColumn item in dbt.columnCollection)
                    {
                        this.rgv.MasterTemplate.Columns.Add(item.GridColumn);
                    }
                    this.bs.DataSource = from p in db.Communication_Types select p;
                    break;
                case 17:
                    this.bs.DataSource = typeof(Justice.Questionary.Catalogs.Scan_Provision_Type);
                    dbt.columnCollection.Add(new TableColumn("Scan_Provision_Type_ID", "ID", "Int32", 4, true));
                    dbt.columnCollection.Add(new TableColumn("Scan_Provision_Type_Name", "Անվանում", "String", 50, false));
                    dbt.columnCollection.Add(new TableColumn("Scan_Provision_Type_EN_Name", "Անգլերեն անվանում", "String", 50, false));
                    foreach (TableColumn item in dbt.columnCollection)
                    {
                        this.rgv.MasterTemplate.Columns.Add(item.GridColumn);
                    }
                    this.bs.DataSource = from p in db.Scan_Provision_Types select p;
                    break;
                case 18:
                    this.bs.DataSource = typeof(Justice.Questionary.Catalogs.Scan_Provision_Cost);
                    dbt.columnCollection.Add(new TableColumn("Scan_Provision_Cost_ID", "ID", "Int32", 4, true));
                    dbt.columnCollection.Add(new TableColumn("Scan_Provision_Cost_Name", "Անվանում", "String", 50, false));
                    dbt.columnCollection.Add(new TableColumn("Scan_Provision_Cost_EN_Name", "Անգլերեն անվանում", "String", 50, false));
                    foreach (TableColumn item in dbt.columnCollection)
                    {
                        this.rgv.MasterTemplate.Columns.Add(item.GridColumn);
                    }
                    this.bs.DataSource = from p in db.Scan_Provision_Costs select p;
                    break;
                case 19:
                    this.bs.DataSource = typeof(Justice.Questionary.Catalogs.Resource_Estimation_Type);
                    dbt.columnCollection.Add(new TableColumn("Resource_Estimation_Type_ID", "ID", "Int32", 4, true));
                    dbt.columnCollection.Add(new TableColumn("Resource_Estimation_Type_Name", "Անվանում", "String", 50, false));
                    dbt.columnCollection.Add(new TableColumn("Resource_Estimation_Type_EN_Name", "Անգլերեն անվանում", "String", 50, false));
                    foreach (TableColumn item in dbt.columnCollection)
                    {
                        this.rgv.MasterTemplate.Columns.Add(item.GridColumn);
                    }
                    this.bs.DataSource = from p in db.Resource_Estimation_Types select p;
                    break;  
                case 20:
                    this.bs.DataSource = typeof(Justice.Questionary.Catalogs.CatalogX3);
                    dbt.columnCollection.Add(new TableColumn("CatalogX3_ID", "ID", "Int32", 4, true));
                    dbt.columnCollection.Add(new TableColumn("CatalogX3_Name", "Անվանում", "String", 50, false));
                    dbt.columnCollection.Add(new TableColumn("CatalogX3_EN_Name", "Անգլերեն անվանում", "String", 50, false));
                    foreach (TableColumn item in dbt.columnCollection)
                    {
                        this.rgv.MasterTemplate.Columns.Add(item.GridColumn);
                    }
                    this.bs.DataSource = from p in db.CatalogX3s select p;
                    break;
                case 21:
                    this.bs.DataSource = typeof(Justice.Questionary.Catalogs.CatalogX43);
                    dbt.columnCollection.Add(new TableColumn("CatalogX43_ID", "ID", "Int32", 4, true));
                    dbt.columnCollection.Add(new TableColumn("CatalogX43_Name", "Անվանում", "String", 50, false));
                    dbt.columnCollection.Add(new TableColumn("CatalogX43_EN_Name", "Անգլերեն անվանում", "String", 50, false));
                    foreach (TableColumn item in dbt.columnCollection)
                    {
                        this.rgv.MasterTemplate.Columns.Add(item.GridColumn);
                    }
                    this.bs.DataSource = from p in db.CatalogX43s select p;
                    break;
                case 22:
                    this.bs.DataSource = typeof(Justice.Questionary.Catalogs.CatalogX44);
                    dbt.columnCollection.Add(new TableColumn("CatalogX44_ID", "ID", "Int32", 4, true));
                    dbt.columnCollection.Add(new TableColumn("CatalogX44_Name", "Անվանում", "String", 50, false));
                    dbt.columnCollection.Add(new TableColumn("CatalogX44_EN_Name", "Անգլերեն անվանում", "String", 50, false));
                    foreach (TableColumn item in dbt.columnCollection)
                    {
                        this.rgv.MasterTemplate.Columns.Add(item.GridColumn);
                    }
                    this.bs.DataSource = from p in db.CatalogX44s select p;
                    break;
                case 23:
                    this.bs.DataSource = typeof(Justice.Questionary.Catalogs.CatalogX45);
                    dbt.columnCollection.Add(new TableColumn("CatalogX45_ID", "ID", "Int32", 4, true));
                    dbt.columnCollection.Add(new TableColumn("CatalogX45_Name", "Անվանում", "String", 50, false));
                    dbt.columnCollection.Add(new TableColumn("CatalogX45_EN_Name", "Անգլերեն անվանում", "String", 50, false));
                    foreach (TableColumn item in dbt.columnCollection)
                    {
                        this.rgv.MasterTemplate.Columns.Add(item.GridColumn);
                    }
                    this.bs.DataSource = from p in db.CatalogX45s select p;
                    break;
                case 24:
                    this.bs.DataSource = typeof(Justice.Questionary.Catalogs.CatalogX46);
                    dbt.columnCollection.Add(new TableColumn("CatalogX46_ID", "ID", "Int32", 4, true));
                    dbt.columnCollection.Add(new TableColumn("CatalogX46_Name", "Անվանում", "String", 50, false));
                    dbt.columnCollection.Add(new TableColumn("CatalogX46_EN_Name", "Անգլերեն անվանում", "String", 50, false));
                    foreach (TableColumn item in dbt.columnCollection)
                    {
                        this.rgv.MasterTemplate.Columns.Add(item.GridColumn);
                    }
                    this.bs.DataSource = from p in db.CatalogX46s select p;
                    break;
                case 25:
                    this.bs.DataSource = typeof(Justice.Questionary.Catalogs.CatalogX47);
                    dbt.columnCollection.Add(new TableColumn("CatalogX47_ID", "ID", "Int32", 4, true));
                    dbt.columnCollection.Add(new TableColumn("CatalogX47_Name", "Անվանում", "String", 50, false));
                    dbt.columnCollection.Add(new TableColumn("CatalogX47_EN_Name", "Անգլերեն անվանում", "String", 50, false));
                    foreach (TableColumn item in dbt.columnCollection)
                    {
                        this.rgv.MasterTemplate.Columns.Add(item.GridColumn);
                    }
                    this.bs.DataSource = from p in db.CatalogX47s select p;
                    break;
                case 26:
                    this.bs.DataSource = typeof(Justice.Questionary.Catalogs.Reviewer);
                    dbt.columnCollection.Add(new TableColumn("Reviewer_ID", "ID", "Int32", 4, true));
                    dbt.columnCollection.Add(new TableColumn("Reviewer_Name", "Անվանում", "String", 50, false));
                    dbt.columnCollection.Add(new TableColumn("Reviewer_EN_Name", "Անգլերեն անվանում", "String", 50, false));
                    foreach (TableColumn item in dbt.columnCollection)
                    {
                        this.rgv.MasterTemplate.Columns.Add(item.GridColumn);
                    }
                    this.bs.DataSource = from p in db.Reviewers select p;
                    break;
                case 27:
                    this.bs.DataSource = typeof(Justice.Questionary.Catalogs.CatalogD1);
                    dbt.columnCollection.Add(new TableColumn("CatalogD1_ID", "ID", "Int32", 4, true));
                    dbt.columnCollection.Add(new TableColumn("CatalogD1_Name", "Անվանում", "String", 50, false));
                    dbt.columnCollection.Add(new TableColumn("CatalogD1_EN_Name", "Անգլերեն անվանում", "String", 50, false));
                    foreach (TableColumn item in dbt.columnCollection)
                    {
                        this.rgv.MasterTemplate.Columns.Add(item.GridColumn);
                    }
                    this.bs.DataSource = from p in db.CatalogD1s select p;
                    break;
                case 28:
                    this.bs.DataSource = typeof(Justice.Questionary.Catalogs.Record_Status);
                    dbt.columnCollection.Add(new TableColumn("Record_Status_ID", "ID", "Int32", 4, true));
                    dbt.columnCollection.Add(new TableColumn("Record_Status_Name", "Անվանում", "String", 50, false));
                    dbt.columnCollection.Add(new TableColumn("Record_Status_EN_Name", "Անգլերեն անվանում", "String", 50, false));
                    foreach (TableColumn item in dbt.columnCollection)
                    {
                        this.rgv.MasterTemplate.Columns.Add(item.GridColumn);
                    }
                    this.bs.DataSource = from p in db.Record_Status select p;
                    break;
                default:
                    break;
            }
            this.rgv.MasterTemplate.DataSource = this.bs;
            this.rgv.MasterTemplate.BestFitColumns();
            Application.UseWaitCursor = false;
        }
        
        private void cmdLoad_Click(object sender, EventArgs e)
        {
            db = new CatalogStoreDataContext(strConnectionString);
            dbt = new DatabaseTable();
            RadGridLocalizationProvider.CurrentProvider = new MyEnglishRadGridLocalizationProvider();
            this.FillGrid();
        }

        private void rlv_SelectedItemChanged(object sender, EventArgs e)
        {
            this.FillGrid();
        }

        public class MyEnglishRadGridLocalizationProvider : RadGridLocalizationProvider
        {
            public override string GetLocalizedString(string id)
            {
                switch (id)
                {
                    case RadGridStringId.ConditionalFormattingPleaseSelectValidCellValue: return "Please select valid cell value";
                    case RadGridStringId.ConditionalFormattingPleaseSetValidCellValue: return "Please set a valid cell value";
                    case RadGridStringId.ConditionalFormattingPleaseSetValidCellValues: return "Please set a valid cell values";
                    case RadGridStringId.ConditionalFormattingPleaseSetValidExpression: return "Please set a valid expression";
                    case RadGridStringId.ConditionalFormattingItem: return "Item";

                    case RadGridStringId.ConditionalFormattingInvalidParameters: return "Invalid parameters";
                    case RadGridStringId.FilterFunctionBetween: return "Between";
                    case RadGridStringId.FilterFunctionContains: return "Contains";
                    case RadGridStringId.FilterFunctionDoesNotContain: return "Does not contain";
                    case RadGridStringId.FilterFunctionEndsWith: return "Ends with";
                    case RadGridStringId.FilterFunctionEqualTo: return "Equals";
                    case RadGridStringId.FilterFunctionGreaterThan: return "Greater than";
                    case RadGridStringId.FilterFunctionGreaterThanOrEqualTo: return "Greater than or equal to";
                    case RadGridStringId.FilterFunctionIsEmpty: return "Is empty";
                    case RadGridStringId.FilterFunctionIsNull: return "Is null";
                    case RadGridStringId.FilterFunctionLessThan: return "Less than";
                    case RadGridStringId.FilterFunctionLessThanOrEqualTo: return "Less than or equal to";
                    case RadGridStringId.FilterFunctionNoFilter: return "No filter";
                    case RadGridStringId.FilterFunctionNotBetween: return "Not between";
                    case RadGridStringId.FilterFunctionNotEqualTo: return "Not equal to";
                    case RadGridStringId.FilterFunctionNotIsEmpty: return "Is not empty";
                    case RadGridStringId.FilterFunctionNotIsNull: return "Is not null";
                    case RadGridStringId.FilterFunctionStartsWith: return "Starts with";
                    case RadGridStringId.FilterFunctionCustom: return "Custom";

                    case RadGridStringId.FilterOperatorBetween: return "Between";
                    case RadGridStringId.FilterOperatorContains: return "Contains";
                    case RadGridStringId.FilterOperatorDoesNotContain: return "NotContains";
                    case RadGridStringId.FilterOperatorEndsWith: return "EndsWith";
                    case RadGridStringId.FilterOperatorEqualTo: return "Equals";
                    case RadGridStringId.FilterOperatorGreaterThan: return "GreaterThan";
                    case RadGridStringId.FilterOperatorGreaterThanOrEqualTo: return "GreaterThanOrEquals";
                    case RadGridStringId.FilterOperatorIsEmpty: return "IsEmpty";
                    case RadGridStringId.FilterOperatorIsNull: return "IsNull";
                    case RadGridStringId.FilterOperatorLessThan: return "LessThan";
                    case RadGridStringId.FilterOperatorLessThanOrEqualTo: return "LessThanOrEquals";
                    case RadGridStringId.FilterOperatorNoFilter: return "No filter";
                    case RadGridStringId.FilterOperatorNotBetween: return "NotBetween";
                    case RadGridStringId.FilterOperatorNotEqualTo: return "NotEquals";
                    case RadGridStringId.FilterOperatorNotIsEmpty: return "NotEmpty";
                    case RadGridStringId.FilterOperatorNotIsNull: return "NotNull";
                    case RadGridStringId.FilterOperatorStartsWith: return "StartsWith";
                    case RadGridStringId.FilterOperatorIsLike: return "Like";
                    case RadGridStringId.FilterOperatorNotIsLike: return "NotLike";
                    case RadGridStringId.FilterOperatorIsContainedIn: return "ContainedIn";
                    case RadGridStringId.FilterOperatorNotIsContainedIn: return "NotContainedIn";
                    case RadGridStringId.FilterOperatorCustom: return "Custom";

                    case RadGridStringId.CustomFilterMenuItem: return "Custom";
                    case RadGridStringId.CustomFilterDialogCaption: return "RadGridView Filter Dialog [{0}]";
                    case RadGridStringId.CustomFilterDialogLabel: return "Show rows where:";
                    case RadGridStringId.CustomFilterDialogRbAnd: return "And";
                    case RadGridStringId.CustomFilterDialogRbOr: return "Or";
                    case RadGridStringId.CustomFilterDialogBtnOk: return "OK";
                    case RadGridStringId.CustomFilterDialogBtnCancel: return "Cancel";
                    case RadGridStringId.CustomFilterDialogCheckBoxNot: return "Not";
                    case RadGridStringId.CustomFilterDialogTrue: return "True";
                    case RadGridStringId.CustomFilterDialogFalse: return "False";

                    case RadGridStringId.FilterMenuBlanks: return "Empty";
                    case RadGridStringId.FilterMenuAvailableFilters: return "Available Filters";
                    case RadGridStringId.FilterMenuSearchBoxText: return "Search...";
                    case RadGridStringId.FilterMenuClearFilters: return "Clear Filter";
                    case RadGridStringId.FilterMenuButtonOK: return "OK";
                    case RadGridStringId.FilterMenuButtonCancel: return "Cancel";
                    case RadGridStringId.FilterMenuSelectionAll: return "All";
                    case RadGridStringId.FilterMenuSelectionAllSearched: return "All Search Result";
                    case RadGridStringId.FilterMenuSelectionNull: return "Null";
                    case RadGridStringId.FilterMenuSelectionNotNull: return "Not Null";

                    case RadGridStringId.FilterFunctionSelectedDates: return "Filter by specific dates:";
                    case RadGridStringId.FilterFunctionToday: return "Today";
                    case RadGridStringId.FilterFunctionYesterday: return "Yesterday";
                    case RadGridStringId.FilterFunctionDuringLast7days: return "During last 7 days";

                    case RadGridStringId.FilterLogicalOperatorAnd: return "AND";
                    case RadGridStringId.FilterLogicalOperatorOr: return "OR";
                    case RadGridStringId.FilterCompositeNotOperator: return "NOT";

                    case RadGridStringId.DeleteRowMenuItem: return "Delete Row";
                    case RadGridStringId.SortAscendingMenuItem: return "Sort Ascending";
                    case RadGridStringId.SortDescendingMenuItem: return "Sort Descending";
                    case RadGridStringId.ClearSortingMenuItem: return "Clear Sorting";
                    case RadGridStringId.ConditionalFormattingMenuItem: return "Conditional Formatting";
                    case RadGridStringId.GroupByThisColumnMenuItem: return "Group by this column";
                    case RadGridStringId.UngroupThisColumn: return "Ungroup this column";
                    case RadGridStringId.ColumnChooserMenuItem: return "Column Chooser";
                    case RadGridStringId.HideMenuItem: return "Hide Column";
                    case RadGridStringId.HideGroupMenuItem: return "Hide Group";
                    case RadGridStringId.UnpinMenuItem: return "Unpin Column";
                    case RadGridStringId.UnpinRowMenuItem: return "Unpin Row";
                    case RadGridStringId.PinMenuItem: return "Pinned state";
                    case RadGridStringId.PinAtLeftMenuItem: return "Pin at left";
                    case RadGridStringId.PinAtRightMenuItem: return "Pin at right";
                    case RadGridStringId.PinAtBottomMenuItem: return "Pin at bottom";
                    case RadGridStringId.PinAtTopMenuItem: return "Pin at top";
                    case RadGridStringId.BestFitMenuItem: return "Best Fit";
                    case RadGridStringId.PasteMenuItem: return "Paste";
                    case RadGridStringId.EditMenuItem: return "Edit";
                    case RadGridStringId.ClearValueMenuItem: return "Clear Value";
                    case RadGridStringId.CopyMenuItem: return "Copy";
                    case RadGridStringId.CutMenuItem: return "Cut";
                    case RadGridStringId.AddNewRowString: return "Սեղմել աստեղ նոր տղ ավելացնելու համար";
                    case RadGridStringId.SearchRowResultsOfLabel: return "of";
                    case RadGridStringId.SearchRowMatchCase: return "Match case";
                    case RadGridStringId.ConditionalFormattingSortAlphabetically: return "Sort columns alphabetically";
                    case RadGridStringId.ConditionalFormattingCaption: return "Conditional Formatting Rules Manager";
                    case RadGridStringId.ConditionalFormattingLblColumn: return "Format only cells with";
                    case RadGridStringId.ConditionalFormattingLblName: return "Rule name";
                    case RadGridStringId.ConditionalFormattingLblType: return "Cell value";
                    case RadGridStringId.ConditionalFormattingLblValue1: return "Value 1";
                    case RadGridStringId.ConditionalFormattingLblValue2: return "Value 2";
                    case RadGridStringId.ConditionalFormattingGrpConditions: return "Rules";
                    case RadGridStringId.ConditionalFormattingGrpProperties: return "Rule Properties";
                    case RadGridStringId.ConditionalFormattingChkApplyToRow: return "Apply this formatting to entire row";
                    case RadGridStringId.ConditionalFormattingChkApplyOnSelectedRows: return "Apply this formatting if the row is selected";
                    case RadGridStringId.ConditionalFormattingBtnAdd: return "Add new rule";
                    case RadGridStringId.ConditionalFormattingBtnRemove: return "Remove";
                    case RadGridStringId.ConditionalFormattingBtnOK: return "OK";
                    case RadGridStringId.ConditionalFormattingBtnCancel: return "Cancel";
                    case RadGridStringId.ConditionalFormattingBtnApply: return "Apply";
                    case RadGridStringId.ConditionalFormattingRuleAppliesOn: return "Rule applies to";
                    case RadGridStringId.ConditionalFormattingCondition: return "Condition";
                    case RadGridStringId.ConditionalFormattingExpression: return "Expression";
                    case RadGridStringId.ConditionalFormattingChooseOne: return "[Choose one]";
                    case RadGridStringId.ConditionalFormattingEqualsTo: return "equals to [Value1]";
                    case RadGridStringId.ConditionalFormattingIsNotEqualTo: return "is not equal to [Value1]";
                    case RadGridStringId.ConditionalFormattingStartsWith: return "starts with [Value1]";
                    case RadGridStringId.ConditionalFormattingEndsWith: return "ends with [Value1]";
                    case RadGridStringId.ConditionalFormattingContains: return "contains [Value1]";
                    case RadGridStringId.ConditionalFormattingDoesNotContain: return "does not contain [Value1]";
                    case RadGridStringId.ConditionalFormattingIsGreaterThan: return "is greater than [Value1]";
                    case RadGridStringId.ConditionalFormattingIsGreaterThanOrEqual: return "is greater than or equal [Value1]";
                    case RadGridStringId.ConditionalFormattingIsLessThan: return "is less than [Value1]";
                    case RadGridStringId.ConditionalFormattingIsLessThanOrEqual: return "is less than or equal to [Value1]";
                    case RadGridStringId.ConditionalFormattingIsBetween: return "is between [Value1] and [Value2]";
                    case RadGridStringId.ConditionalFormattingIsNotBetween: return "is not between [Value1] and [Value1]";
                    case RadGridStringId.ConditionalFormattingLblFormat: return "Format";

                    case RadGridStringId.ConditionalFormattingBtnExpression: return "Expression editor";
                    case RadGridStringId.ConditionalFormattingTextBoxExpression: return "Expression";

                    case RadGridStringId.ConditionalFormattingPropertyGridCaseSensitive: return "CaseSensitive";
                    case RadGridStringId.ConditionalFormattingPropertyGridCellBackColor: return "CellBackColor";
                    case RadGridStringId.ConditionalFormattingPropertyGridCellForeColor: return "CellForeColor";
                    case RadGridStringId.ConditionalFormattingPropertyGridEnabled: return "Enabled";
                    case RadGridStringId.ConditionalFormattingPropertyGridRowBackColor: return "RowBackColor";
                    case RadGridStringId.ConditionalFormattingPropertyGridRowForeColor: return "RowForeColor";
                    case RadGridStringId.ConditionalFormattingPropertyGridRowTextAlignment: return "RowTextAlignment";
                    case RadGridStringId.ConditionalFormattingPropertyGridTextAlignment: return "TextAlignment";

                    case RadGridStringId.ConditionalFormattingPropertyGridCaseSensitiveDescription: return "Determines whether case-sensitive comparisons will be made when evaluating string values.";
                    case RadGridStringId.ConditionalFormattingPropertyGridCellBackColorDescription: return "Enter the background color to be used for the cell.";
                    case RadGridStringId.ConditionalFormattingPropertyGridCellForeColorDescription: return "Enter the foreground color to be used for the cell.";
                    case RadGridStringId.ConditionalFormattingPropertyGridEnabledDescription: return "Determines whether the condition is enabled (can be evaluated and applied).";
                    case RadGridStringId.ConditionalFormattingPropertyGridRowBackColorDescription: return "Enter the background color to be used for the entire row.";
                    case RadGridStringId.ConditionalFormattingPropertyGridRowForeColorDescription: return "Enter the foreground color to be used for the entire row.";
                    case RadGridStringId.ConditionalFormattingPropertyGridRowTextAlignmentDescription: return "Enter the alignment to be used for the cell values, when ApplyToRow is true.";
                    case RadGridStringId.ConditionalFormattingPropertyGridTextAlignmentDescription: return "Enter the alignment to be used for the cell values.";

                    case RadGridStringId.ColumnChooserFormCaption: return "Column Chooser";
                    case RadGridStringId.ColumnChooserFormMessage: return "Drag a column header from the\ngrid here to remove it from\nthe current view.";
                    case RadGridStringId.GroupingPanelDefaultMessage: return "Drag a column here to group by this column.";
                    case RadGridStringId.GroupingPanelHeader: return "Group by:";
                    case RadGridStringId.PagingPanelPagesLabel: return "Page";
                    case RadGridStringId.PagingPanelOfPagesLabel: return "of";
                    case RadGridStringId.NoDataText: return "No data to display";
                    case RadGridStringId.CompositeFilterFormErrorCaption: return "Filter Error";
                    case RadGridStringId.CompositeFilterFormInvalidFilter: return "The composite filter descriptor is not valid.";

                    case RadGridStringId.ExpressionMenuItem: return "Expression";
                    case RadGridStringId.ExpressionFormTitle: return "Expression Builder";
                    case RadGridStringId.ExpressionFormFunctions: return "Functions";
                    case RadGridStringId.ExpressionFormFunctionsText: return "Text";
                    case RadGridStringId.ExpressionFormFunctionsAggregate: return "Aggregate";
                    case RadGridStringId.ExpressionFormFunctionsDateTime: return "Date-Time";
                    case RadGridStringId.ExpressionFormFunctionsLogical: return "Logical";
                    case RadGridStringId.ExpressionFormFunctionsMath: return "Math";
                    case RadGridStringId.ExpressionFormFunctionsOther: return "Other";
                    case RadGridStringId.ExpressionFormOperators: return "Operators";
                    case RadGridStringId.ExpressionFormConstants: return "Constants";
                    case RadGridStringId.ExpressionFormFields: return "Fields";
                    case RadGridStringId.ExpressionFormDescription: return "Description";
                    case RadGridStringId.ExpressionFormResultPreview: return "Result preview";
                    case RadGridStringId.ExpressionFormTooltipPlus: return "Plus";
                    case RadGridStringId.ExpressionFormTooltipMinus: return "Minus";
                    case RadGridStringId.ExpressionFormTooltipMultiply: return "Multiply";
                    case RadGridStringId.ExpressionFormTooltipDivide: return "Divide";
                    case RadGridStringId.ExpressionFormTooltipModulo: return "Modulo";
                    case RadGridStringId.ExpressionFormTooltipEqual: return "Equal";
                    case RadGridStringId.ExpressionFormTooltipNotEqual: return "Not Equal";
                    case RadGridStringId.ExpressionFormTooltipLess: return "Less";
                    case RadGridStringId.ExpressionFormTooltipLessOrEqual: return "Less Or Equal";
                    case RadGridStringId.ExpressionFormTooltipGreaterOrEqual: return "Greater Or Equal";
                    case RadGridStringId.ExpressionFormTooltipGreater: return "Greater";
                    case RadGridStringId.ExpressionFormTooltipAnd: return "Logical \"AND\"";
                    case RadGridStringId.ExpressionFormTooltipOr: return "Logical \"OR\"";
                    case RadGridStringId.ExpressionFormTooltipNot: return "Logical \"NOT\"";
                    case RadGridStringId.ExpressionFormAndButton: return string.Empty; //if empty, default button image is used
                    case RadGridStringId.ExpressionFormOrButton: return string.Empty; //if empty, default button image is used
                    case RadGridStringId.ExpressionFormNotButton: return string.Empty; //if empty, default button image is used
                    case RadGridStringId.ExpressionFormOKButton: return "OK";
                    case RadGridStringId.ExpressionFormCancelButton: return "Cancel";
                }

                return string.Empty;
            }
        }
    }
}
