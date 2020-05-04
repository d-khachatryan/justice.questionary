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
using Telerik.WinControls.UI.Localization;

namespace Justice.Questionary.Input
{
    public partial class ctlQuestionT2 : UserControl
    {
        private readonly string language;

        string strLanguage;
        string strConnectionString;
        StoreDataContext db;
        //string s = "ctlQuestionT3Grid.xml";

        public ctlQuestionT2(string language, string connectionString)
        {
            this.language = language;
            RadGridLocalizationProvider.CurrentProvider = new AmRadGridLocalizationProvider();
            InitializeComponent();
            strLanguage = language;
            strConnectionString = connectionString;
            db = new StoreDataContext(strConnectionString);
            db.CommandTimeout = GlobalClass.IntCommandTimeout;


            File.Delete("ctlQuestionT3Grid.xml");
            File.Delete("ctlQuestionT2Grid.xml");
            File.Delete("ctlQuestionT1Grid.xml");

            //if (File.Exists(s))
            //{
                //this.radGridView1.LoadLayout(s);
            //}
            //else
            //{
            //    this.radGridView1.SaveLayout(s);
            //}
            TmerMain.Enabled = true;
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.ParentForm.FormClosing += new FormClosingEventHandler(ParentForm_FormClosing);
        }

        void ParentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.radGridView1.SaveLayout(s);
        }

        private void TmerMain_Tick(object sender, EventArgs e)
        {
            TmerMain.Enabled = false;
            this.vCourtBindingSource.DataSource = from p in db.vCourts where p.Court_ID == 2 || p.Court_ID == 3 || p.Court_ID == 4 select p;
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
                frmQuestionT2 frm = new frmQuestionT2(strLanguage, strConnectionString, 0);
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
                int intQuestionTiD = ((vQuestionT2)(this.vQuestionT2BindingSource.Current)).QuestionT2_ID;
                frmQuestionT2 frm = new frmQuestionT2(strLanguage, strConnectionString, intQuestionTiD);
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
                        vQuestionT2 obj = (vQuestionT2)item.DataBoundItem;
                        var q = (from p in db.QuestionT2s where p.QuestionT2_ID.Equals(obj.QuestionT2_ID) select p).Single();
                        db.QuestionT2s.DeleteOnSubmit(q);
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
            System.Linq.IQueryable<vQuestionT2> q = from p in db.vQuestionT2s select p;

            if (GlobalClass.checkUserStatus() != 1)
            {
                q = from p in db.vQuestionT2s where p.User_Name.Equals(GlobalClass.UserName) select p;
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

            this.vQuestionT2BindingSource.DataSource = q;
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
