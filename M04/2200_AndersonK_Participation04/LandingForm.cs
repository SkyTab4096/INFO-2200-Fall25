using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2200_AndersonK_Participation04
{
    public partial class LandingForm : Form
    {
        public LandingForm()
        {
            InitializeComponent();
        }

        private void LocalBtn_Click(object sender, EventArgs e)
        {
            LocalPhoneNumbersForm lpnf = new LocalPhoneNumbersForm();
            lpnf.Show();
        }

        private void ImportedBtn_Click(object sender, EventArgs e)
        {
            UVUPhoneListForm uplf = new UVUPhoneListForm();
            uplf.ShowDialog();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
