using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Justice.Questionary.Input
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool a = this.CheckNumericField(this.mskColumnT13C.Text);
        }

        private bool CheckNumericField(string numericFiled)
        {
            bool isValidNumeric;

            switch (Convert.ToInt32 (numericFiled))
            {
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
                case 666:
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
                    isValidNumeric = false;
                    break;
            }
            return isValidNumeric;
        }
    }
}
