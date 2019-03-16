using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PiMonitor.Objects;

namespace PiMonitor
{
    public partial class VariableNameRequestForm : Form
    {
        public Variables Variable { get; set; }
        private NewVariable _newVariable;
        public VariableNameRequestForm()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            _newVariable = new NewVariable(tbxVarName.Text);
            _newVariable.FormClosed += NewVariableFormClose;
            _newVariable.Show();
        }
        private void NewVariableFormClose(object sender, FormClosedEventArgs e)
        {
            Variable = _newVariable.Varibale;
            this.Close();
        }
    }
}
