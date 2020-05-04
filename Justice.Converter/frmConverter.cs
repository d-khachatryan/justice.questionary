using System;
using System.Linq;
using System.Windows.Forms;

namespace Justice.Converter
{
    public partial class frmConverter : Form
    {
        public frmConverter()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            StoreDataContext db = new StoreDataContext();

            foreach (var item in db.QuestionT1s)
            {
                String value = item.Question54;
                Char delimiter = ')';
                if (!String.IsNullOrEmpty(value))
                {
                    String[] substrings = value.Split(delimiter);
                    int intLimit = 0;
                    foreach (var substring in substrings)
                    {
                        if (intLimit <= 2)
                        {
                            SubQuestionT1 itm = new SubQuestionT1();
                            itm.QuestionT1ID = item.QuestionT1_ID;
                            itm.ContentText = substring.Trim();
                            if (!String.IsNullOrEmpty(substring))
                            {
                                db.SubQuestionT1s.InsertOnSubmit(itm);
                            }
                        }
                        intLimit = intLimit + 1;
                    }
                }
                db.SubmitChanges();
            }
        }

        private void btnConvert2_Click(object sender, EventArgs e)
        {
            StoreDataContext db = new StoreDataContext();

            foreach (var item in db.QuestionT2s)
            {
                String value = item.Question53;
                Char delimiter = ')';
                if (!String.IsNullOrEmpty(value))
                {
                    String[] substrings = value.Split(delimiter);
                    int intLimit = 0;
                    foreach (var substring in substrings)
                    {
                        if (intLimit <= 2)
                        {
                            SubQuestionT2 itm = new SubQuestionT2();
                            itm.QuestionT2ID = item.QuestionT2_ID;
                            itm.ContentText = substring.Trim();
                            if (!String.IsNullOrEmpty(substring))
                            {
                                db.SubQuestionT2s.InsertOnSubmit(itm);
                            }
                        }
                        intLimit = intLimit + 1;
                    }
                }
                db.SubmitChanges();
            }
        }

        private void btnConvert3_Click(object sender, EventArgs e)
        {
            StoreDataContext db = new StoreDataContext();

            foreach (var item in db.QuestionT3s)
            {
                String value = item.Question52;
                Char delimiter = ')';
                if (!String.IsNullOrEmpty(value))
                {
                    String[] substrings = value.Split(delimiter);
                    int intLimit = 0;
                    foreach (var substring in substrings)
                    {
                        if (intLimit <= 2)
                        {
                            SubQuestionT3 itm = new SubQuestionT3();
                            itm.QuestionT3ID = item.QuestionT3_ID;
                            itm.ContentText = substring.Trim();
                            if (!String.IsNullOrEmpty(substring))
                            {
                                db.SubQuestionT3s.InsertOnSubmit(itm);
                            }
                        }
                        intLimit = intLimit + 1;
                    }
                }
                db.SubmitChanges();
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ReportForm1 frm = new ReportForm1();
            frm.ShowDialog();
        }

        private void btnReport2_Click(object sender, EventArgs e)
        {
            ReportForm2 frm = new ReportForm2();
            frm.ShowDialog();
        }

        private void btnReport3_Click(object sender, EventArgs e)
        {
            ReportForm3 frm = new ReportForm3();
            frm.ShowDialog();
        }


    }
}
