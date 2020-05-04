using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Justice.Converter
{
    public partial class ReportForm2 : Form
    {
        public ReportForm2()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            this.vwSubQuestionT2TableAdapter.Fill(this.JusticeDB2DataSet.vwSubQuestionT2);
            this.reportViewer1.RefreshReport();
        }
    }
}
