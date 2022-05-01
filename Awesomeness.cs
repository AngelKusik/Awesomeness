using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Awesomeness
{
    public partial class formAwesomeness : Form
    {
        public formAwesomeness()
        {
            InitializeComponent();
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yes, you are awesome.\r\n Enjoy your awesomeness.\r\n Have a good day.");
            Close();
        }

        private void buttonLeftNo_Click(object sender, EventArgs e)
        {
            buttonLeftNo.Hide();
            buttonRightNo.Show();
        }

        private void buttonRightNo_Click(object sender, EventArgs e)
        {
            buttonLeftNo.Show();
            buttonRightNo.Hide();
        }

        private void buttonLeftNo_Cck(object sender, EventArgs e)
        {

        }
    }
}
