using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiMonitor
{
    public partial class LineEditForm : Form
    {
        public LineEditForm(string s)
        {
            InitializeComponent();
            tbxLineText.Text = s;
        }

        public bool Changed { get; set; }

        public string TextChanged { get; set; }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Changed = false;
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Changed = true;
            TextChanged = tbxLineText.Text;
            this.Close();
        }
    }
}
