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
    public partial class frmQuestionX : Form
    {
        string strLanguage;
        string strConnectionString;
        public bool isTableChanged = true;
        bool isCommandClose;
        StoreDataContext db;

        public frmQuestionX(string language, string connectionString, int questionXID)
        {
            strLanguage = language;
            strConnectionString = connectionString;
            InitializeComponent();
            db = new StoreDataContext(strConnectionString);
            db.CommandTimeout = GlobalClass.IntCommandTimeout;

            this.vCourtBS.DataSource = from p in db.vCourts select p;
            this.vGenderBS.DataSource = from p in db.vGenders select p;
            this.vDateIntervalBS.DataSource = from p in db.vDate_Intervals select p;
            this.vCatalogX3BS.DataSource = from p in db.vCatalogX3s select p;

            this.vCatalogX43BS.DataSource = from p in db.vCatalogX43s select p;
            this.vCatalogX44BS.DataSource = from p in db.vCatalogX44s select p;
            this.vCatalogX45BS.DataSource = from p in db.vCatalogX45s select p;
            this.vCatalogX46BS.DataSource = from p in db.vCatalogX46s select p;
            this.vCatalogX47BS.DataSource = from p in db.vCatalogX47s select p;
            this.vCatalogD1BS.DataSource = from p in db.vCatalogD1s select p;
            this.vRecordStatusBS.DataSource = from p in db.vRecord_Status select p;
            this.vReviewerBindingSource.DataSource = from p in db.vReviewers select p;

            this.questionXBS.DataSource = from p in db.QuestionXes where p.QuestionX_ID == questionXID select p;

            if (questionXID == 0)
            {
                this.questionXBS.AddNew();
                this.questionXBS.EndEdit();
            }
            this.ActiveControl = this.mskQuestionNumber;
        }

        private void FrmQuestionXFormClosing(object sender, FormClosingEventArgs e)
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
            this.questionXBS.EndEdit();

            if (this.mskQuestionNumber.Text == "")
            {
                MessageBox.Show("Հարցաթերթի համարը դաշտը լրացված չէ", "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ActiveControl = this.mskQuestionNumber;
                return false;
            }

            if (((QuestionX)this.questionXBS.Current).Court_ID == null)
            {
                MessageBox.Show("Դատարանը ընտրված չէ", "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ActiveControl = this.cboCourt;
                return false;
            }

            ////// TabPage1
            if (((QuestionX)this.questionXBS.Current).Gender_ID == null)
            {
                MessageBox.Show("Սեռը ընտրված չէ", "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.MainTabControl.SelectedTab = this.tabPage1;
                ActiveControl = this.cboGender;
                return false;
            }

            if (((QuestionX)this.questionXBS.Current).Date_Interval_ID == null)
            {
                MessageBox.Show("Տարիքային խումբը ընտրված չէ", "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.MainTabControl.SelectedTab = this.tabPage1;
                ActiveControl = this.cboDateInterval;
                return false;
            }

            if (((QuestionX)this.questionXBS.Current).CatalogX3_ID == null)
            {
                MessageBox.Show("3-րդ հարցը լրացված չէ", "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.MainTabControl.SelectedTab = this.tabPage1;
                ActiveControl = this.cboCatalogX3;
                return false;
            }

            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question5C))
            {
                this.MainTabControl.SelectedTab = this.tabPage1;
                ActiveControl = this.mskColumnX5C;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question5D))
            {
                this.MainTabControl.SelectedTab = this.tabPage1;
                ActiveControl = this.mskColumnX5D;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question6C))
            {
                this.MainTabControl.SelectedTab = this.tabPage1;
                ActiveControl = this.mskColumnX6C;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question6D))
            {
                this.MainTabControl.SelectedTab = this.tabPage1;
                ActiveControl = this.mskColumnX6D;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question7C))
            {
                this.MainTabControl.SelectedTab = this.tabPage1;
                ActiveControl = this.mskColumnX7C;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question7D))
            {
                this.MainTabControl.SelectedTab = this.tabPage1;
                ActiveControl = this.mskColumnX7D;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question8C))
            {
                this.MainTabControl.SelectedTab = this.tabPage1;
                ActiveControl = this.mskColumnX8C;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question8D))
            {
                this.MainTabControl.SelectedTab = this.tabPage1;
                ActiveControl = this.mskColumnX8D;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question9C))
            {
                this.MainTabControl.SelectedTab = this.tabPage1;
                ActiveControl = this.mskColumnX9C;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question9D))
            {
                this.MainTabControl.SelectedTab = this.tabPage1;
                ActiveControl = this.mskColumnX9D;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question10C))
            {
                this.MainTabControl.SelectedTab = this.tabPage1;
                ActiveControl = this.mskColumnX10C;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question10D))
            {
                this.MainTabControl.SelectedTab = this.tabPage1;
                ActiveControl = this.mskColumnX10D;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question11C))
            {
                this.MainTabControl.SelectedTab = this.tabPage1;
                ActiveControl = this.mskColumnX11C;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question11D))
            {
                this.MainTabControl.SelectedTab = this.tabPage1;
                ActiveControl = this.mskColumnX11D;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question12C))
            {
                this.MainTabControl.SelectedTab = this.tabPage1;
                ActiveControl = this.mskColumnX12C;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question12D))
            {
                this.MainTabControl.SelectedTab = this.tabPage1;
                ActiveControl = this.mskColumnX12D;
                return false;
            }

            ////// TabPage2
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question13C))
            {
                this.MainTabControl.SelectedTab = this.tabPage2;
                ActiveControl = this.mskColumnX13C;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question13D))
            {
                this.MainTabControl.SelectedTab = this.tabPage2;
                ActiveControl = this.mskColumnX13D;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question14C))
            {
                this.MainTabControl.SelectedTab = this.tabPage2;
                ActiveControl = this.mskColumnX14C;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question14D))
            {
                this.MainTabControl.SelectedTab = this.tabPage2;
                ActiveControl = this.mskColumnX14D;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question15C))
            {
                this.MainTabControl.SelectedTab = this.tabPage2;
                ActiveControl = this.mskColumnX15C;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question15D))
            {
                this.MainTabControl.SelectedTab = this.tabPage2;
                ActiveControl = this.mskColumnX15D;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question16C))
            {
                this.MainTabControl.SelectedTab = this.tabPage2;
                ActiveControl = this.mskColumnX16C;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question16D))
            {
                this.MainTabControl.SelectedTab = this.tabPage2;
                ActiveControl = this.mskColumnX16D;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question17C))
            {
                this.MainTabControl.SelectedTab = this.tabPage2;
                ActiveControl = this.mskColumnX17C;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question17D))
            {
                this.MainTabControl.SelectedTab = this.tabPage2;
                ActiveControl = this.mskColumnX17D;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question18C))
            {
                this.MainTabControl.SelectedTab = this.tabPage2;
                ActiveControl = this.mskColumnX18C;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question18D))
            {
                this.MainTabControl.SelectedTab = this.tabPage2;
                ActiveControl = this.mskColumnX18D;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question19C))
            {
                this.MainTabControl.SelectedTab = this.tabPage2;
                ActiveControl = this.mskColumnX19C;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question19D))
            {
                this.MainTabControl.SelectedTab = this.tabPage2;
                ActiveControl = this.mskColumnX19D;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question20C))
            {
                this.MainTabControl.SelectedTab = this.tabPage2;
                ActiveControl = this.mskColumnX20C;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question20D))
            {
                this.MainTabControl.SelectedTab = this.tabPage2;
                ActiveControl = this.mskColumnX20D;
                return false;
            }

            ////// TabPage3
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question21C))
            {
                this.MainTabControl.SelectedTab = this.tabPage3;
                ActiveControl = this.mskColumnX21C;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question21D))
            {
                this.MainTabControl.SelectedTab = this.tabPage3;
                ActiveControl = this.mskColumnX21D;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question22C))
            {
                this.MainTabControl.SelectedTab = this.tabPage3;
                ActiveControl = this.mskColumnX22C;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question22D))
            {
                this.MainTabControl.SelectedTab = this.tabPage3;
                ActiveControl = this.mskColumnX22D;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question23C))
            {
                this.MainTabControl.SelectedTab = this.tabPage3;
                ActiveControl = this.mskColumnX23C;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question23D))
            {
                this.MainTabControl.SelectedTab = this.tabPage3;
                ActiveControl = this.mskColumnX23D;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question24C))
            {
                this.MainTabControl.SelectedTab = this.tabPage3;
                ActiveControl = this.mskColumnX24C;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question24D))
            {
                this.MainTabControl.SelectedTab = this.tabPage3;
                ActiveControl = this.mskColumnX24D;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question25C))
            {
                this.MainTabControl.SelectedTab = this.tabPage3;
                ActiveControl = this.mskColumnX25C;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question25D))
            {
                this.MainTabControl.SelectedTab = this.tabPage3;
                ActiveControl = this.mskColumnX25D;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question26C))
            {
                this.MainTabControl.SelectedTab = this.tabPage3;
                ActiveControl = this.mskColumnX26C;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question26D))
            {
                this.MainTabControl.SelectedTab = this.tabPage3;
                ActiveControl = this.mskColumnX26D;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question27C))
            {
                this.MainTabControl.SelectedTab = this.tabPage3;
                ActiveControl = this.mskColumnX27C;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question27D))
            {
                this.MainTabControl.SelectedTab = this.tabPage3;
                ActiveControl = this.mskColumnX27D;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question28C))
            {
                this.MainTabControl.SelectedTab = this.tabPage3;
                ActiveControl = this.mskColumnX28C;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question28D))
            {
                this.MainTabControl.SelectedTab = this.tabPage3;
                ActiveControl = this.mskColumnX28D;
                return false;
            }

            ////// TabPage4
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question29C))
            {
                this.MainTabControl.SelectedTab = this.tabPage4;
                ActiveControl = this.mskColumnX29C;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question29D))
            {
                this.MainTabControl.SelectedTab = this.tabPage4;
                ActiveControl = this.mskColumnX29D;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question30C))
            {
                this.MainTabControl.SelectedTab = this.tabPage4;
                ActiveControl = this.mskColumnX30C;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question30D))
            {
                this.MainTabControl.SelectedTab = this.tabPage4;
                ActiveControl = this.mskColumnX30D;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question31C))
            {
                this.MainTabControl.SelectedTab = this.tabPage4;
                ActiveControl = this.mskColumnX31C;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question31D))
            {
                this.MainTabControl.SelectedTab = this.tabPage4;
                ActiveControl = this.mskColumnX31D;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question32C))
            {
                this.MainTabControl.SelectedTab = this.tabPage4;
                ActiveControl = this.mskColumnX32C;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question32D))
            {
                this.MainTabControl.SelectedTab = this.tabPage4;
                ActiveControl = this.mskColumnX32D;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question33C))
            {
                this.MainTabControl.SelectedTab = this.tabPage4;
                ActiveControl = this.mskColumnX33C;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question33D))
            {
                this.MainTabControl.SelectedTab = this.tabPage4;
                ActiveControl = this.mskColumnX33D;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question34C))
            {
                this.MainTabControl.SelectedTab = this.tabPage4;
                ActiveControl = this.mskColumnX34C;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question34D))
            {
                this.MainTabControl.SelectedTab = this.tabPage4;
                ActiveControl = this.mskColumnX34D;
                return false;
            }

            ////// TabPage5
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question35C))
            {
                this.MainTabControl.SelectedTab = this.tabPage5;
                ActiveControl = this.mskColumnX35C;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question35D))
            {
                this.MainTabControl.SelectedTab = this.tabPage5;
                ActiveControl = this.mskColumnX35D;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question36C))
            {
                this.MainTabControl.SelectedTab = this.tabPage5;
                ActiveControl = this.mskColumnX36C;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question36D))
            {
                this.MainTabControl.SelectedTab = this.tabPage5;
                ActiveControl = this.mskColumnX36D;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question37C))
            {
                this.MainTabControl.SelectedTab = this.tabPage5;
                ActiveControl = this.mskColumnX37C;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question37D))
            {
                this.MainTabControl.SelectedTab = this.tabPage5;
                ActiveControl = this.mskColumnX37D;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question38C))
            {
                this.MainTabControl.SelectedTab = this.tabPage5;
                ActiveControl = this.mskColumnX38C;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question38D))
            {
                this.MainTabControl.SelectedTab = this.tabPage5;
                ActiveControl = this.mskColumnX38D;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question39C))
            {
                this.MainTabControl.SelectedTab = this.tabPage5;
                ActiveControl = this.mskColumnX39C;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question39D))
            {
                this.MainTabControl.SelectedTab = this.tabPage5;
                ActiveControl = this.mskColumnX39D;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question40C))
            {
                this.MainTabControl.SelectedTab = this.tabPage5;
                ActiveControl = this.mskColumnX40C;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question40D))
            {
                this.MainTabControl.SelectedTab = this.tabPage5;
                ActiveControl = this.mskColumnX40D;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question41C))
            {
                this.MainTabControl.SelectedTab = this.tabPage5;
                ActiveControl = this.mskColumnX41C;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question41D))
            {
                this.MainTabControl.SelectedTab = this.tabPage5;
                ActiveControl = this.mskColumnX41D;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question42C))
            {
                this.MainTabControl.SelectedTab = this.tabPage5;
                ActiveControl = this.mskColumnX42C;
                return false;
            }
            if (!this.CheckNumericField(((QuestionX)this.questionXBS.Current).Question42D))
            {
                this.MainTabControl.SelectedTab = this.tabPage5;
                ActiveControl = this.mskColumnX42D;
                return false;
            }

            ////// TabPage6
            if (((QuestionX)this.questionXBS.Current).CatalogX43_ID == null)
            {
                MessageBox.Show("43-րդ հարցը լրացված չէ", "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.MainTabControl.SelectedTab = this.tabPage6;
                ActiveControl = this.cboCatalogX43;
                return false;
            }
            if (((QuestionX)this.questionXBS.Current).CatalogX44_ID == null)
            {
                MessageBox.Show("44-րդ հարցը լրացված չէ", "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.MainTabControl.SelectedTab = this.tabPage6;
                ActiveControl = this.cboCatalogX44;
                return false;
            }
            if (((QuestionX)this.questionXBS.Current).CatalogX45_ID == null)
            {
                MessageBox.Show("45-րդ հարցը լրացված չէ", "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.MainTabControl.SelectedTab = this.tabPage6;
                ActiveControl = this.cboCatalogX45;
                return false;
            }
            if (((QuestionX)this.questionXBS.Current).CatalogX46_ID == null)
            {
                MessageBox.Show("46-րդ հարցը լրացված չէ", "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.MainTabControl.SelectedTab = this.tabPage6;
                ActiveControl = this.cboCatalogX46;
                return false;
            }
            if (((QuestionX)this.questionXBS.Current).CatalogX47_ID == null)
            {
                MessageBox.Show("47-րդ հարցը լրացված չէ", "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.MainTabControl.SelectedTab = this.tabPage6;
                ActiveControl = this.cboCatalogX47;
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
            this.questionXBS.EndEdit();

            var changes = db.GetChangeSet();
            if ((changes.Inserts.Count + changes.Updates.Count + changes.Deletes.Count) > 0)
            {
                ((QuestionX)this.questionXBS.Current).User_Name = GlobalClass.UserName;
                this.questionXBS.EndEdit();
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
                    this.questionXBS.AddNew();
                    this.questionXBS.EndEdit();
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
    }
}
