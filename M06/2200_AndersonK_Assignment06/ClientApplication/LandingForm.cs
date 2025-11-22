using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApplication
{
    public partial class landingForm : Form
    {
        SynchronousSocketClient client = new SynchronousSocketClient();
        public landingForm()
        {
            InitializeComponent();
        }

        private void requestBtn_Click(object sender, EventArgs e)
        {
            responseTxtBox.Text = client.ContactServer(requestTxtBox.Text);
        }
    }
}
