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
    public partial class LocalPhoneNumbersForm : Form
    {
        public LocalPhoneNumbersForm()
        {
            InitializeComponent();
        }

        private void phoneListBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.phoneListBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.localPhoneListDbDataSet);

        }

        private void LocalPhoneNumbersForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'localPhoneListDbDataSet.PhoneList' table. You can move, or remove it, as needed.
            this.phoneListTableAdapter.Fill(this.localPhoneListDbDataSet.PhoneList);

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            this.phoneListTableAdapter.FillByFirstNameSearch(this.localPhoneListDbDataSet.PhoneList, SearchTextBox.Text);
        }

        private void AverageAgeSortBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"The average age is : {this.phoneListTableAdapter.AverageAge(SearchTextBox.Text).Value.ToString("N2")}");
        }

        private void Over30SortBtn_Click(object sender, EventArgs e)
        {
            this.phoneListTableAdapter.FillByAgeOver30(this.localPhoneListDbDataSet.PhoneList, SearchTextBox.Text);
        }

        private void LastNameSortBtn_Click(object sender, EventArgs e)
        {
            this.phoneListTableAdapter.FillByLastNameSort(this.localPhoneListDbDataSet.PhoneList, SearchTextBox.Text);
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            LocalPhoneNumbersForm_Load(sender, e);
        }
    }
}
