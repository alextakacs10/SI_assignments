using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace InputValidation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if(!EntryValidator.ValidName(NameBox.Text))
            {
                MessageBox.Show("Invalid name, please use only alphabetical characters.");
            }

            if(!EntryValidator.ValidPhone(PhoneBox.Text))
            {
                MessageBox.Show("Not a valid US number.");
            }

            if (!EntryValidator.ValidEmail(EmailBox.Text))
            {
                MessageBox.Show("The e-mail address is not valid.");
            }
        }

    }
}
