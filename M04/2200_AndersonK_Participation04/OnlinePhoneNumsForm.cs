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
    public partial class OnlinePhoneNumsForm : Form
    {
        public OnlinePhoneNumsForm()
        {
            InitializeComponent();
        }

        private void uVUPhoneNumsTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uVUPhoneNumsTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iNFO2200_CrandallSayDataSet);

        }

        private void OnlinePhoneNumsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iNFO2200_CrandallSayDataSet.UVUPhoneNumsTable' table. You can move, or remove it, as needed.
            this.uVUPhoneNumsTableTableAdapter.Fill(this.iNFO2200_CrandallSayDataSet.UVUPhoneNumsTable);

        }
    }
}
