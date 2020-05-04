using System;
using System.Linq;
using System.Windows.Forms;
using Justice.Questionary.Data;
using System.IO;
using Telerik.WinControls.UI.Localization;

namespace Justice.Questionary.Input
{
    public partial class ctlQuestionT1 : UserControl
    {
        private readonly string language;

        string strLanguage;
        string strConnectionString;
        StoreDataContext db;
        string s = "ctlQuestionT1Grid.xml";

        public ctlQuestionT1(string language, string connectionString)
        {
            this.language = language;
            RadGridLocalizationProvider.CurrentProvider = new AmRadGridLocalizationProvider();
            InitializeComponent();
            strLanguage = language;
            strConnectionString = connectionString;
            db = new StoreDataContext(strConnectionString);
            db.CommandTimeout = GlobalClass.IntCommandTimeout;

            if (File.Exists(s))
            {
                this.radGridView1.LoadLayout(s);
            }
            else
            {
                this.radGridView1.SaveLayout(s);
            }
            TmerMain.Enabled = true;
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.ParentForm.FormClosing += new FormClosingEventHandler(ParentForm_FormClosing);
        }

        void ParentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.radGridView1.SaveLayout(s);
        }

        private void TmerMain_Tick(object sender, EventArgs e)
        {
            TmerMain.Enabled = false;
            this.vCourtBindingSource.DataSource = from p in db.vCourts select p;
            this.vRecordStatusBindingSource.DataSource = from p in db.vRecord_Status select p;
            this.vGenderBindingSource.DataSource = from p in db.vGenders select p;
            this.vDateIntervalBindingSource.DataSource = from p in db.vDate_Intervals select p;
            this.Clear();
            this.Filter();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                frmQuestionT1 frm = new frmQuestionT1(strLanguage, strConnectionString, 0);
                frm.ShowDialog();
                if (frm.isTableChanged)
                {
                    this.Filter();
                }
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show(ex.Message, "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                int intQuestionTiD = ((vQuestionT1)(this.vQuestionT1BindingSource.Current)).QuestionT1_ID;
                frmQuestionT1 frm = new frmQuestionT1(strLanguage, strConnectionString, intQuestionTiD);
                frm.ShowDialog();
                if (frm.isTableChanged)
                {
                    radGridView1.BeginUpdate();
                    this.Filter();
                    this.radGridView1.EndUpdate();
                }
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show(ex.Message, "Ուշադրություն", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (this.radGridView1.SelectedRows.Count > 0)
            {
                this.Cursor = Cursors.WaitCursor;
                this.Enabled = false;
                if (MessageBox.Show("Դուք համոզված էք, որ ցանկանում էք հեռացնել ընտրված գրառումները՞", "Ուշադրություն", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (var item in radGridView1.SelectedRows)
                    {
                        vQuestionT1 obj = (vQuestionT1)item.DataBoundItem;
                        var q = (from p in db.QuestionT1s where p.QuestionT1_ID.Equals(obj.QuestionT1_ID) select p).Single();
                        db.QuestionT1s.DeleteOnSubmit(q);
                    }
                    db.SubmitChanges();
                    this.Filter();
                }
                this.Cursor = Cursors.Default;
                this.Enabled = true;
            }
        }

        private void Filter()
        {            

            System.Linq.IQueryable<vQuestionT1> q = q = from p in db.vQuestionT1s select p;

            if (GlobalClass.checkUserStatus() != 1)
            {
                q = from p in db.vQuestionT1s where p.User_Name.Equals(GlobalClass.UserName) select p;
            }

            if (this.TxtQuestionNumber.Text != "")
            {
                q = from p in q where p.Question_Number.Equals(Convert.ToInt32(this.TxtQuestionNumber.Text)) select p;
            }
            if (this.cboCourt.SelectedIndex != -1)
            {
                q = from p in q where p.Court_ID.Equals(Convert.ToInt32(this.cboCourt.SelectedValue)) select p;
            }
            if (this.cboDateInterval.SelectedIndex != -1)
            {
                q = from p in q where p.Date_Interval_ID.Equals(Convert.ToInt32(this.cboDateInterval.SelectedValue)) select p;
            }
            if (this.cboGender.SelectedIndex != -1)
            {
                q = from p in q where p.Gender_ID.Equals(Convert.ToInt32(this.cboGender.SelectedValue)) select p;
            }
            if (this.cboRecordStatus.SelectedIndex != -1)
            {
                q = from p in q where p.Record_Status_ID.Equals(Convert.ToInt32(this.cboRecordStatus.SelectedValue)) select p;
            }

            this.vQuestionT1BindingSource.DataSource = q;
        }

        private void Clear()
        {
            this.TxtQuestionNumber.Text = "";
            this.cboCourt.SelectedIndex = -1;
            this.cboDateInterval.SelectedIndex = -1;
            this.cboGender.SelectedIndex = -1;
            this.cboRecordStatus.SelectedIndex = -1;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            this.Clear();
            this.Filter();
        }

        private void Filter_Click(object sender, EventArgs e)
        {
            this.Filter();
        }
    }
}
