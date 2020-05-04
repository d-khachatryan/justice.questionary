using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Justice.Questionary.Data;

namespace Justice.Questionary.Input
{
    public partial class frmQuestionT2 : Form
    {
        string strLanguage;
        string strConnectionString;
        public bool isTableChanged = true;
        bool isCommandClose;
        StoreDataContext db;

        public frmQuestionT2(string language, string connectionString, int questionT2ID)
        {
            strLanguage = language;
            strConnectionString = connectionString;
            InitializeComponent();
            db = new StoreDataContext(strConnectionString);
            db.CommandTimeout = GlobalClass.IntCommandTimeout;

            this.vCourtBS.DataSource = from p in db.vCourts where p.Court_ID == 2 || p.Court_ID == 3 || p.Court_ID == 4 select p;
            this.vGenderBS.DataSource = from p in db.vGenders select p;
            this.vDateIntervalBS.DataSource = from p in db.vDate_Intervals select p;
            this.vCatalogT3BS.DataSource = from p in db.vCatalogT3s select p;
            this.vCatalogT4BS.DataSource = from p in db.vCatalogT4s select p;
            this.vCatalogT5BS.DataSource = from p in db.vCatalogT5s select p;
            this.vCatalogT6BS.DataSource = from p in db.vCatalogT6s select p;
            this.vCatalogT7BS.DataSource = from p in db.vCatalogT7s select p;
            this.vCatalogT8BS.DataSource = from p in db.vCatalogT8s select p;
            this.vCatalogT9BS.DataSource = from p in db.vCatalogT9s select p;
            this.vCatalogT10BS.DataSource = from p in db.vCatalogT10s select p;
            this.vCatalogT10DetailBS.DataSource = from p in db.vCatalogT10_Details select p;
            this.vPublicLawyerServiceBS.DataSource = from p in db.vPublic_Lawyer_Services select p;
            this.vPublicLawyerServicePaymentBS.DataSource = from p in db.vPublic_Lawyer_Service_Payments select p;
            this.vLawyerServiceBS.DataSource = from p in db.vLawyer_Services select p;
            this.vCommunicationTypeBS.DataSource = from p in db.vCommunication_Types select p;
            this.vScanProvisionTypeBS.DataSource = from p in db.vScan_Provision_Types select p;
            this.vScanProvisionCostBS.DataSource = from p in db.vScan_Provision_Costs select p;
            this.vResourceEstimationTypeBS.DataSource = from p in db.vResource_Estimation_Types select p;
            this.vReviewerBS.DataSource = from p in db.vReviewers select p;
            this.vCatalogD1BS.DataSource = from p in db.vCatalogD1s select p;
            this.vRecordStatusBS.DataSource = from p in db.vRecord_Status select p;

            this.questionT2BS.DataSource = from p in db.QuestionT2s where p.QuestionT2_ID == questionT2ID select p;

            if (questionT2ID == 0)
            {
                this.questionT2BS.AddNew();
                this.questionT2BS.EndEdit();
            }
            this.ActiveControl = this.mskQuestionNumber;
        }

        private void FrmQuestionT2FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (!isCommandClose)
                {
                    var changes = db.GetChangeSet();
                    if ((changes.Inserts.Count + changes.Updates.Count + changes.Deletes.Count) > 0)
                    {
                        var dlgResult = MessageBox.Show("Ցանկանում էք հիշել կատարված փոփոխությունները", "Ուշադրություն", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                        switch (dlgResult)
                        {
                            case DialogResult.Yes:
                                if (this.CheckCells())
                                {
                                    if (this.CommitChanges() == 1)
                                    {
                                        isCommandClose = true;
                                        this.DialogResult = DialogResult.Yes;
                                    }
                                    else
                                    {
                                        return;
                                    }
                                }
                                else
                                {
                                    e.Cancel = true;
                                }
                                break;
                            case DialogResult.No:
                                e.Cancel = false;
                                this.DialogResult = DialogResult.No;
                                break;
                            case DialogResult.Cancel:
                                e.Cancel = true;
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckCells()
        {
            if (this.mskQuestionNumber.Text == "")
            {
                MessageBox.Show("Հարցաթերթի համարը դաշտը լրացված չէ", "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ActiveControl = this.mskQuestionNumber;
                return false;
            }

            if (((QuestionT2)this.questionT2BS.Current).Court_ID == null)
            {
                MessageBox.Show("Դատարանը ընտրված չէ", "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ActiveControl = this.cboCourt;
                return false;
            }

            ////// TabPage1
            if (((QuestionT2)this.questionT2BS.Current).Gender_ID == null)
            {
                MessageBox.Show("Սեռը ընտրված չէ", "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.MainTabControl.SelectedTab = this.tabPage1;
                ActiveControl = this.cboGender;
                return false;
            }

            if (((QuestionT2)this.questionT2BS.Current).Date_Interval_ID == null)
            {
                MessageBox.Show("Տարիքային խումբը ընտրված չէ", "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.MainTabControl.SelectedTab = this.tabPage1;
                ActiveControl = this.cboDateInterval;
                return false;
            }

            if (((QuestionT2)this.questionT2BS.Current).CatalogT3_ID == null)
            {
                MessageBox.Show("3-րդ հարցը լրացված չէ", "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.MainTabControl.SelectedTab = this.tabPage1;
                ActiveControl = this.cboCatalogT3;
                return false;
            }

            if (((QuestionT2)this.questionT2BS.Current).CatalogT4_ID == null)
            {
                MessageBox.Show("4-րդ հարցը լրացված չէ", "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.MainTabControl.SelectedTab = this.tabPage1;
                ActiveControl = this.cboCatalogT4;
                return false;
            }

            if (((QuestionT2)this.questionT2BS.Current).CatalogT5_ID == null)
            {
                MessageBox.Show("5-րդ հարցը լրացված չէ", "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.MainTabControl.SelectedTab = this.tabPage1;
                ActiveControl = this.cboCatalogT5;
                return false;
            }

            if (((QuestionT2)this.questionT2BS.Current).CatalogT6_ID == null)
            {
                MessageBox.Show("6-րդ հարցը լրացված չէ", "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.MainTabControl.SelectedTab = this.tabPage1;
                ActiveControl = this.cboCatalogT6;
                return false;
            }

            if (!this.CheckNumericField(((QuestionT2)this.questionT2BS.Current).Question14))
            {
                this.MainTabControl.SelectedTab = this.tabPage4;
                this.MainTabControl.SelectedTab = this.tabPage1;
                ActiveControl = this.mskQuestion15;
                return false;
            }

            if (((QuestionT2)this.questionT2BS.Current).CatalogT7_ID == null)
            {
                MessageBox.Show("7-րդ հարցը լրացված չէ", "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.MainTabControl.SelectedTab = this.tabPage1;
                ActiveControl = this.cboCatalogT7;
                return false;
            }

            ////// TabPage2
            if (((QuestionT2)this.questionT2BS.Current).CatalogT8_ID == null)
            {
                MessageBox.Show("8-րդ հարցը լրացված չէ", "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.MainTabControl.SelectedTab = this.tabPage2;
                ActiveControl = this.cboCatalogT8;
                return false;
            }

            if (((QuestionT2)this.questionT2BS.Current).CatalogT9_ID == null)
            {
                MessageBox.Show("9-րդ հարցը լրացված չէ", "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.MainTabControl.SelectedTab = this.tabPage2;
                ActiveControl = this.cboCatalogT9;
                return false;
            }

            if (((QuestionT2)this.questionT2BS.Current).CatalogT10_ID == null)
            {
                MessageBox.Show("10-րդ հարցը լրացված չէ", "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.MainTabControl.SelectedTab = this.tabPage2;
                ActiveControl = this.cboCatalogT10;
                return false;
            }

            if (((QuestionT2)this.questionT2BS.Current).Public_Lawyer_Service_ID == null)
            {
                MessageBox.Show("11-րդ հարցը լրացված չէ", "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.MainTabControl.SelectedTab = this.tabPage2;
                ActiveControl = this.cboPublicLawyerService;
                return false;
            }

            if (((QuestionT2)this.questionT2BS.Current).Public_Lawyer_Service_Payment_ID == null)
            {
                MessageBox.Show("12-րդ հարցը լրացված չէ", "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.MainTabControl.SelectedTab = this.tabPage2;
                ActiveControl = this.cboPublicLawyerServicePayment;
                return false;
            }

            if (((QuestionT2)this.questionT2BS.Current).Lawyer_Service_ID == null)
            {
                MessageBox.Show("13-րդ հարցը լրացված չէ", "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.MainTabControl.SelectedTab = this.tabPage2;
                ActiveControl = this.cboLawyerService;
                return false;
            }

            ////// TabPage3
            if (!this.CheckNumericField(((QuestionT2)this.questionT2BS.Current).Question14))
            {
                this.MainTabControl.SelectedTab = this.tabPage3;
                ActiveControl = this.mskQuestion14;
                return false;
            }

            if (!this.CheckNumericField(((QuestionT2)this.questionT2BS.Current).Question15))
            {
                this.MainTabControl.SelectedTab = this.tabPage3;
                ActiveControl = this.mskQuestion15;
                return false;
            }

            if (!this.CheckNumericField(((QuestionT2)this.questionT2BS.Current).Question16))
            {
                this.MainTabControl.SelectedTab = this.tabPage3;
                ActiveControl = this.mskQuestion16;
                return false;
            }

            if (!this.CheckNumericField(((QuestionT2)this.questionT2BS.Current).Question17))
            {
                this.MainTabControl.SelectedTab = this.tabPage3;
                ActiveControl = this.mskQuestion17;
                return false;
            }

            if (!this.CheckNumericField(((QuestionT2)this.questionT2BS.Current).Question18))
            {
                this.MainTabControl.SelectedTab = this.tabPage3;
                ActiveControl = this.mskQuestion18;
                return false;
            }

            if (!this.CheckNumericField(((QuestionT2)this.questionT2BS.Current).Question19))
            {
                this.MainTabControl.SelectedTab = this.tabPage3;
                ActiveControl = this.mskQuestion19;
                return false;
            }

            if (!this.CheckNumericField(((QuestionT2)this.questionT2BS.Current).Question20))
            {
                this.MainTabControl.SelectedTab = this.tabPage3;
                ActiveControl = this.mskQuestion20;
                return false;
            }

            ////// TabPage4
            if (!this.CheckNumericField(((QuestionT2)this.questionT2BS.Current).Question23))
            {
                this.MainTabControl.SelectedTab = this.tabPage4;
                ActiveControl = this.mskQuestion23;
                return false;
            }

            if (!this.CheckNumericField(((QuestionT2)this.questionT2BS.Current).Question24))
            {
                this.MainTabControl.SelectedTab = this.tabPage4;
                ActiveControl = this.mskQuestion24;
                return false;
            }

            if (!this.CheckNumericField(((QuestionT2)this.questionT2BS.Current).Question25))
            {
                this.MainTabControl.SelectedTab = this.tabPage4;
                ActiveControl = this.mskQuestion25;
                return false;
            }

            if (!this.CheckNumericField(((QuestionT2)this.questionT2BS.Current).Question26))
            {
                this.MainTabControl.SelectedTab = this.tabPage4;
                ActiveControl = this.mskQuestion26;
                return false;
            }

            if (!this.CheckNumericField(((QuestionT2)this.questionT2BS.Current).Question27))
            {
                this.MainTabControl.SelectedTab = this.tabPage4;
                ActiveControl = this.mskQuestion27;
                return false;
            }

            if (!this.CheckNumericField(((QuestionT2)this.questionT2BS.Current).Question28))
            {
                this.MainTabControl.SelectedTab = this.tabPage4;
                ActiveControl = this.mskQuestion28;
                return false;
            }

            if (!this.CheckNumericField(((QuestionT2)this.questionT2BS.Current).Question29))
            {
                this.MainTabControl.SelectedTab = this.tabPage4;
                ActiveControl = this.mskQuestion29;
                return false;
            }


            ////// TabPage5
            if (!this.CheckNumericField(((QuestionT2)this.questionT2BS.Current).Question30))
            {
                this.MainTabControl.SelectedTab = this.tabPage5;
                ActiveControl = this.mskQuestion30;
                return false;
            }
            if (!this.CheckNumericField(((QuestionT2)this.questionT2BS.Current).Question30_2))
            {
                this.MainTabControl.SelectedTab = this.tabPage5;
                ActiveControl = this.mskQuestion30_2;
                return false;
            }
            if (!this.CheckNumericField(((QuestionT2)this.questionT2BS.Current).Question30_3))
            {
                this.MainTabControl.SelectedTab = this.tabPage5;
                ActiveControl = this.mskQuestion30_3;
                return false;
            }

            if (!this.CheckNumericField(((QuestionT2)this.questionT2BS.Current).Question31))
            {
                this.MainTabControl.SelectedTab = this.tabPage5;
                ActiveControl = this.mskQuestion31;
                return false;
            }
            if (!this.CheckNumericField(((QuestionT2)this.questionT2BS.Current).Question31_2))
            {
                this.MainTabControl.SelectedTab = this.tabPage5;
                ActiveControl = this.mskQuestion31_2;
                return false;
            }
            if (!this.CheckNumericField(((QuestionT2)this.questionT2BS.Current).Question31_3))
            {
                this.MainTabControl.SelectedTab = this.tabPage5;
                ActiveControl = this.mskQuestion31_3;
                return false;
            }

            if (!this.CheckNumericField(((QuestionT2)this.questionT2BS.Current).Question32))
            {
                this.MainTabControl.SelectedTab = this.tabPage5;
                ActiveControl = this.mskQuestion32;
                return false;
            }

            if (!this.CheckNumericField(((QuestionT2)this.questionT2BS.Current).Question33))
            {
                this.MainTabControl.SelectedTab = this.tabPage5;
                ActiveControl = this.mskQuestion33;
                return false;
            }

            if (!this.CheckNumericField(((QuestionT2)this.questionT2BS.Current).Question34))
            {
                this.MainTabControl.SelectedTab = this.tabPage5;
                ActiveControl = this.mskQuestion34;
                return false;
            }

            if (!this.CheckNumericField(((QuestionT2)this.questionT2BS.Current).Question35))
            {
                this.MainTabControl.SelectedTab = this.tabPage5;
                ActiveControl = this.mskQuestion35;
                return false;
            }

            if (!this.CheckNumericField(((QuestionT2)this.questionT2BS.Current).Question36))
            {
                this.MainTabControl.SelectedTab = this.tabPage5;
                ActiveControl = this.mskQuestion36;
                return false;
            }

            if (!this.CheckNumericField(((QuestionT2)this.questionT2BS.Current).Question37))
            {
                this.MainTabControl.SelectedTab = this.tabPage5;
                ActiveControl = this.mskQuestion37;
                return false;
            }


            ////// TabPage6
            if (!this.CheckNumericField(((QuestionT2)this.questionT2BS.Current).Question38))
            {
                this.MainTabControl.SelectedTab = this.tabPage5;
                ActiveControl = this.mskQuestion38;
                return false;
            }

            if (!this.CheckNumericField(((QuestionT2)this.questionT2BS.Current).Question39))
            {
                this.MainTabControl.SelectedTab = this.tabPage6;
                ActiveControl = this.mskQuestion39;
                return false;
            }

            if (!this.CheckNumericField(((QuestionT2)this.questionT2BS.Current).Question40))
            {
                this.MainTabControl.SelectedTab = this.tabPage6;
                ActiveControl = this.mskQuestion40;
                return false;
            }

            if (!this.CheckNumericField(((QuestionT2)this.questionT2BS.Current).Question41))
            {
                this.MainTabControl.SelectedTab = this.tabPage6;
                ActiveControl = this.mskQuestion41;
                return false;
            }

            if (!this.CheckNumericField(((QuestionT2)this.questionT2BS.Current).Question42))
            {
                this.MainTabControl.SelectedTab = this.tabPage6;
                ActiveControl = this.mskQuestion42;
                return false;
            }

            if (!this.CheckNumericField(((QuestionT2)this.questionT2BS.Current).Question43))
            {
                this.MainTabControl.SelectedTab = this.tabPage6;
                ActiveControl = this.mskQuestion43;
                return false;
            }

            if (!this.CheckNumericField(((QuestionT2)this.questionT2BS.Current).Question44))
            {
                this.MainTabControl.SelectedTab = this.tabPage6;
                ActiveControl = this.mskQuestion44;
                return false;
            }

            if (!this.CheckNumericField(((QuestionT2)this.questionT2BS.Current).Question45))
            {
                this.MainTabControl.SelectedTab = this.tabPage6;
                ActiveControl = this.mskQuestion45;
                return false;
            }

            if (!this.CheckNumericField(((QuestionT2)this.questionT2BS.Current).Question46))
            {
                this.MainTabControl.SelectedTab = this.tabPage6;
                ActiveControl = this.mskQuestion46;
                return false;
            }

            if (!this.CheckNumericField(((QuestionT2)this.questionT2BS.Current).Question47))
            {
                this.MainTabControl.SelectedTab = this.tabPage6;
                ActiveControl = this.mskQuestion47;
                return false;
            }

            ////// TabPage7
            if (!this.CheckNumericField(((QuestionT2)this.questionT2BS.Current).Question48))
            {
                this.MainTabControl.SelectedTab = this.tabPage6;
                ActiveControl = this.mskQuestion48;
                return false;
            }

            //if (((QuestionT2)this.questionT2BS.Current).Communication_Type_ID == null)
            //{
            //    MessageBox.Show("49-րդ հարցը լրացված չէ", "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    this.MainTabControl.SelectedTab = this.tabPage7;
            //    ActiveControl = this.cboCommunicationType;
            //    return false;
            //}

            if (((QuestionT2)this.questionT2BS.Current).Scan_Provision_Type_ID == null)
            {
                MessageBox.Show("50-րդ հարցը լրացված չէ", "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.MainTabControl.SelectedTab = this.tabPage7;
                ActiveControl = this.cboScanProvisionType;
                return false;
            }

            if (((QuestionT2)this.questionT2BS.Current).Scan_Provision_Cost_ID == null)
            {
                MessageBox.Show("51-րդ հարցը լրացված չէ", "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.MainTabControl.SelectedTab = this.tabPage7;
                ActiveControl = this.cboScanProvisionCost;
                return false;
            }

            if (((QuestionT2)this.questionT2BS.Current).Resource_Estimation_Type_ID == null)
            {
                MessageBox.Show("52-րդ հարցը լրացված չէ", "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.MainTabControl.SelectedTab = this.tabPage7;
                ActiveControl = this.cboResourceEstimationType;
                return false;
            }

            return true;
        }

        private bool CheckNumericField(int? numericFiled)
        {
            bool isValidNumeric;

            switch (numericFiled)
            {
                case 0:
                    isValidNumeric = true;
                    break;
                case 1:
                    isValidNumeric = true;
                    break;
                case 2:
                    isValidNumeric = true;
                    break;
                case 3:
                    isValidNumeric = true;
                    break;
                case 4:
                    isValidNumeric = true;
                    break;
                case 5:
                    isValidNumeric = true;
                    break;
                case 6:
                    isValidNumeric = true;
                    break;
                case 444:
                    isValidNumeric = true;
                    break;
                case 555:
                    isValidNumeric = true;
                    break;
                case 777:
                    isValidNumeric = true;
                    break;
                case 888:
                    isValidNumeric = true;
                    break;
                case 999:
                    isValidNumeric = true;
                    break;
                default:
                    MessageBox.Show("Լրացված արժեքը սխալ է: Թույլատրվում է լրացնել միայն հետևյալ արժեքները - 0,1,2,3,4,5,6,444,555,777,888,999:", "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    isValidNumeric = false;
                    break;
            }
            return isValidNumeric;
        }

        private int CommitChanges()
        {
            this.questionT2BS.EndEdit();

            var changes = db.GetChangeSet();
            if ((changes.Inserts.Count + changes.Updates.Count + changes.Deletes.Count) > 0)
            {
                ((QuestionT2)this.questionT2BS.Current).User_Name = GlobalClass.UserName;
                this.questionT2BS.EndEdit();
            }
            db.SubmitChanges();
            isTableChanged = true;
            return 1;
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                this.Enabled = false;
                if (this.CheckCells())
                {
                    this.CommitChanges();
                    isTableChanged = true;
                    this.questionT2BS.AddNew();
                    this.questionT2BS.EndEdit();
                    this.MainTabControl.SelectedIndex = 0;
                }
                this.Cursor = Cursors.Default;
                this.Enabled = true;
                this.mskQuestionNumber.Focus();
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                this.Enabled = true;
                MessageBox.Show(ex.Message, "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                this.Enabled = false;
                if (this.CheckCells())
                {
                    this.CommitChanges();
                    isCommandClose = true;
                    this.Close();
                }
                this.Cursor = Cursors.Default;
                this.Enabled = true;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                this.Enabled = true;
                MessageBox.Show(ex.Message, "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext1_Click(object sender, EventArgs e)
        {
            this.MainTabControl.SelectTab(1);
        }

        private void btnNext2_Click(object sender, EventArgs e)
        {
            this.MainTabControl.SelectTab(2);
        }

        private void btnNext3_Click(object sender, EventArgs e)
        {
            this.MainTabControl.SelectTab(3);
        }

        private void btnNext4_Click(object sender, EventArgs e)
        {
            this.MainTabControl.SelectTab(4);
        }

        private void btnNext5_Click(object sender, EventArgs e)
        {
            this.MainTabControl.SelectTab(5);
        }

        private void btnNext6_Click(object sender, EventArgs e)
        {
            this.MainTabControl.SelectTab(6);
        }

        private void btnNext7_Click(object sender, EventArgs e)
        {
            this.MainTabControl.SelectTab(7);
        }


        private void Tsm4QuestionGroup444_Click(object sender, EventArgs e)
        {
            this.mskQuestion30.Text = "444";
            this.mskQuestion30_2.Text = "444";
            this.mskQuestion30_3.Text = "444";
            this.mskQuestion31.Text = "444";
            this.mskQuestion31_2.Text = "444";
            this.mskQuestion31_3.Text = "444";
            this.mskQuestion32.Text = "444";
            this.mskQuestion33.Text = "444";
            this.mskQuestion34.Text = "444";
            this.mskQuestion35.Text = "444";
            this.mskQuestion36.Text = "444";
            this.mskQuestion37.Text = "444";
            this.questionT2BS.EndEdit();
        }
        private void Tsm4QuestionGroup555_Click(object sender, EventArgs e)
        {
            this.mskQuestion30.Text = "555";
            this.mskQuestion30_2.Text = "555";
            this.mskQuestion30_3.Text = "555";
            this.mskQuestion31.Text = "555";
            this.mskQuestion31_2.Text = "555";
            this.mskQuestion31_3.Text = "555";
            this.mskQuestion32.Text = "555";
            this.mskQuestion33.Text = "555";
            this.mskQuestion34.Text = "555";
            this.mskQuestion35.Text = "555";
            this.mskQuestion36.Text = "555";
            this.mskQuestion37.Text = "555";
            this.questionT2BS.EndEdit();
        }
        private void Tsm4QuestionGroup777_Click(object sender, EventArgs e)
        {
            this.mskQuestion30.Text = "777";
            this.mskQuestion30_2.Text = "777";
            this.mskQuestion30_3.Text = "777";
            this.mskQuestion31.Text = "777";
            this.mskQuestion31_2.Text = "777";
            this.mskQuestion31_3.Text = "777";
            this.mskQuestion32.Text = "777";
            this.mskQuestion33.Text = "777";
            this.mskQuestion34.Text = "777";
            this.mskQuestion35.Text = "777";
            this.mskQuestion36.Text = "777";
            this.mskQuestion37.Text = "777";
            this.questionT2BS.EndEdit();
        }
        private void Tsm4QuestionGroup888_Click(object sender, EventArgs e)
        {
            this.mskQuestion30.Text = "888";
            this.mskQuestion30_2.Text = "888";
            this.mskQuestion30_3.Text = "888";
            this.mskQuestion31.Text = "888";
            this.mskQuestion31_2.Text = "888";
            this.mskQuestion31_3.Text = "888";
            this.mskQuestion32.Text = "888";
            this.mskQuestion33.Text = "888";
            this.mskQuestion34.Text = "888";
            this.mskQuestion35.Text = "888";
            this.mskQuestion36.Text = "888";
            this.mskQuestion37.Text = "888";
            this.questionT2BS.EndEdit();
        }
        private void Tsm4QuestionGroup999_Click(object sender, EventArgs e)
        {
            this.mskQuestion30.Text = "999";
            this.mskQuestion30_2.Text = "999";
            this.mskQuestion30_3.Text = "999";
            this.mskQuestion31.Text = "999";
            this.mskQuestion31_2.Text = "999";
            this.mskQuestion31_3.Text = "999";
            this.mskQuestion32.Text = "999";
            this.mskQuestion33.Text = "999";
            this.mskQuestion34.Text = "999";
            this.mskQuestion35.Text = "999";
            this.mskQuestion36.Text = "999";
            this.mskQuestion37.Text = "999";
            this.questionT2BS.EndEdit();
        }


        private void Tsm5QuestionGroup444_Click(object sender, EventArgs e)
        {
            this.mskQuestion38.Text = "444";
            this.mskQuestion39.Text = "444";
            this.mskQuestion40.Text = "444";
            this.questionT2BS.EndEdit();
        }
        private void Tsm5QuestionGroup555_Click(object sender, EventArgs e)
        {
            this.mskQuestion38.Text = "555";
            this.mskQuestion39.Text = "555";
            this.mskQuestion40.Text = "555";
            this.questionT2BS.EndEdit();
        }
        private void Tsm5QuestionGroup777_Click(object sender, EventArgs e)
        {
            this.mskQuestion38.Text = "777";
            this.mskQuestion39.Text = "777";
            this.mskQuestion40.Text = "777";
            this.questionT2BS.EndEdit();
        }
        private void Tsm5QuestionGroup888_Click(object sender, EventArgs e)
        {
            this.mskQuestion38.Text = "888";
            this.mskQuestion39.Text = "888";
            this.mskQuestion40.Text = "888";
            this.questionT2BS.EndEdit();
        }
        private void Tsm5QuestionGroup999_Click(object sender, EventArgs e)
        {
            this.mskQuestion38.Text = "999";
            this.mskQuestion39.Text = "999";
            this.mskQuestion40.Text = "999";
            this.questionT2BS.EndEdit();
        }


        private void Tsm6QuestionGroup444_Click(object sender, EventArgs e)
        {
            this.mskQuestion41.Text = "444";
            this.mskQuestion42.Text = "444";
            this.mskQuestion43.Text = "444";
            this.mskQuestion44.Text = "444";
            this.questionT2BS.EndEdit();
        }
        private void Tsm6QuestionGroup555_Click(object sender, EventArgs e)
        {
            this.mskQuestion41.Text = "555";
            this.mskQuestion42.Text = "555";
            this.mskQuestion43.Text = "555";
            this.mskQuestion44.Text = "555";
            this.questionT2BS.EndEdit();
        }
        private void Tsm6QuestionGroup777_Click(object sender, EventArgs e)
        {
            this.mskQuestion41.Text = "777";
            this.mskQuestion42.Text = "777";
            this.mskQuestion43.Text = "777";
            this.mskQuestion44.Text = "777";
            this.questionT2BS.EndEdit();
        }
        private void Tsm6QuestionGroup888_Click(object sender, EventArgs e)
        {
            this.mskQuestion41.Text = "888";
            this.mskQuestion42.Text = "888";
            this.mskQuestion43.Text = "888";
            this.mskQuestion44.Text = "888";
            this.questionT2BS.EndEdit();
        }
        private void Tsm6QuestionGroup999_Click(object sender, EventArgs e)
        {
            this.mskQuestion41.Text = "999";
            this.mskQuestion42.Text = "999";
            this.mskQuestion43.Text = "999";
            this.mskQuestion44.Text = "999";
            this.questionT2BS.EndEdit();
        }


        private void Tsm7QuestionGroup444_Click(object sender, EventArgs e)
        {
            this.mskQuestion45.Text = "444";
            this.mskQuestion46.Text = "444";
            this.mskQuestion47.Text = "444";
            this.questionT2BS.EndEdit();
        }
        private void Tsm7QuestionGroup555_Click(object sender, EventArgs e)
        {
            this.mskQuestion45.Text = "555";
            this.mskQuestion46.Text = "555";
            this.mskQuestion47.Text = "555";
            this.questionT2BS.EndEdit();
        }
        private void Tsm7QuestionGroup777_Click(object sender, EventArgs e)
        {
            this.mskQuestion45.Text = "777";
            this.mskQuestion46.Text = "777";
            this.mskQuestion47.Text = "777";
            this.questionT2BS.EndEdit();
        }
        private void Tsm7QuestionGroup888_Click(object sender, EventArgs e)
        {
            this.mskQuestion45.Text = "888";
            this.mskQuestion46.Text = "888";
            this.mskQuestion47.Text = "888";
            this.questionT2BS.EndEdit();
        }
        private void Tsm7QuestionGroup999_Click(object sender, EventArgs e)
        {
            this.mskQuestion45.Text = "999";
            this.mskQuestion46.Text = "999";
            this.mskQuestion47.Text = "999";
            this.questionT2BS.EndEdit();
        }


    }
}
