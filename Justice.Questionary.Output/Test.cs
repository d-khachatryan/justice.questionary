using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Justice.Questionary.Output
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
            ctlQuestionT1 ctl = new ctlQuestionT1("hy-AM", Properties.Settings.Default.SqlConnectionString);
            ctl.Dock = DockStyle.Fill;
            this.Controls.Add(ctl);
        }
    }
}
