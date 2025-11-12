using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2200_AndersonK_Participation06
{
    public partial class landingForm : Form
    {
        SynchonousSocketClient ssc = new SynchonousSocketClient();
        public landingForm()
        {
            InitializeComponent();
        }

        private void landingForm_Load(object sender, EventArgs e)
        {

        }

        private void requestSubmitBtn_Click(object sender, EventArgs e)
        {
            responseTxtBox.Text = ssc.ContactServer(requestTxtBox.Text);
        }
    }
}
