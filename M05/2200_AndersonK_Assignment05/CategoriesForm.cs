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
    public partial class CategoriesForm : Form
    {
        //
        JellyBellyDB db = new JellyBellyDB();
        public CategoriesForm()
        {
            InitializeComponent();
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
        private void CategoriesForm_Load(object sender, EventArgs e)
        {
            //
            categoriesListView.Columns.Add("Category");
            categoriesListView.Columns.Add("Number");

            //
            var jbCat = from j in db.JellyBellies
                        group j by j.category into x
                        orderby x.Count() descending
                        select x;

            //
            foreach (IGrouping<String,JellyBelly> ct in jbCat)
            {
                //
                String[] listValues = { ct.Key, ct.Count().ToString() };
                ListViewItem lvi = new ListViewItem(listValues);
                categoriesListView.Items.Add(lvi);
            }

            //
            categoriesListView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            categoriesListView.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }
}
