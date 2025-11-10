using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2200_AndersonK_Assignment05
{
    public partial class JellyBellyForm : Form
    {
        //
        JellyBellyDB db = new JellyBellyDB();
        public JellyBellyForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchBtn_Click(object sender, EventArgs e)
        {
            //
            List<JellyBelly> filteredFlavors = db.JellyBellies.Where(flavor => flavor.jellyBellyFlavor.Contains(searchTxtBox.Text)).ToList();

            //
            jellyBellyFlavorsDGV.DataSource = filteredFlavors;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showAllBtn_Click(object sender, EventArgs e)
        {
            //
            LoadDataGridView();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeBtn_Click(object sender, EventArgs e)
        {
            //
            Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchTxtBox_TextChanged(object sender, EventArgs e)
        {
            //
            List<JellyBelly> filteredFlavors = db.JellyBellies.Where( flavor => flavor.jellyBellyFlavor.Contains(searchTxtBox.Text) ).ToList();

            //
            jellyBellyFlavorsDGV.DataSource = filteredFlavors;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void JellyBellyForm_Load(object sender, EventArgs e)
        {
            //
            LoadDataGridView();

        }

        /// <summary>
        /// 
        /// </summary>
        private void LoadDataGridView()
        {
            //
            List<JellyBelly> jellyBellies = db.JellyBellies.ToList();
            jellyBellyFlavorsDGV.DataSource = jellyBellies;

            //
            jellyBellyFlavorsDGV.Columns[0].Visible = false;
            jellyBellyFlavorsDGV.Columns[1].HeaderCell.Value = "Flavor";
            jellyBellyFlavorsDGV.Columns[2].Width = 200;
            jellyBellyFlavorsDGV.Columns[2].HeaderCell.Value = "Flavor Category";
        }
    }
}
