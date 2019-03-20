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
    public partial class HomePage : Form
    {
        private Script _script;
        private MainVariable _mainvar;
        private LoginForm _login;
        private MainVariableWaitForm _wait;
        public HomePage()
        {
            _script = new Script();
            InitializeComponent();
            btnInitEdit.Enabled = false;
            pnErrorInfo.Visible = false;
        }

        private void btnInitNew_Click(object sender, EventArgs e)
        {
            _login = new LoginForm();
            _login.FormClosed += NewLoginClose;
            _login.Show();
        }
        private void NewLoginClose(object sender, FormClosedEventArgs e)
        {
            if (_login.Var != null)
            {
                _script.Login = _login.Var;
                lbCreated.Text = "Created";
                btnInitEdit.Enabled = true;
            }
        }

        private void btnDashNew_Click(object sender, EventArgs e)
        {
            _mainvar = new MainVariable();
            _mainvar.FormClosed += NewVariableFormClose;
            _mainvar.Show();
        }
        private void NewVariableFormClose(object sender, FormClosedEventArgs e)
        {
            _script.MainVariables.Add(_mainvar.Var);
            _script.MainVarDictionary.Add(_mainvar.Var,0);
            initListVar();
            lbVarCount.Text = "You have " + _script.MainVariables.Count + " variables";
        }

        private void initListVar()
        {
            lvDash.Clear();
            lvVariablesDashBoard.Items.Clear();
            foreach (var variable in _script.MainVariables)
            {
                lvDash.Items.Add(variable.Name);
            }

            foreach (var variable in _script.MainVarDictionary)
            {
                ListViewItem it = new ListViewItem(variable.Key.Name);
                it.SubItems.Add(variable.Value.ToString());
                lvVariablesDashBoard.Items.Add(it);
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            _script.CreateScript(tbxFileLocation.Text,tbxFileName.Text,Int32.Parse(tbxWaitTime.Text),Int32.Parse(tbxRepeat.Text) );
            LoadContent();
        }

        private void LoadContent()
        {
            lvPreview.Clear();
            lvPreview.Columns.Add("Contents");
            lvPreview.Columns[0].Width = 1000;
            foreach (var line in _script.Contents)
            {
                string s = line.Replace("\t", "    ");
                lvPreview.Items.Add(s);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            _script.TestSave();
        }

        private void Test()
        {
            lvPreview.Columns.Add("Contents");
            lvPreview.Items.Add("ok let see");
        }

        private void btnInitEdit_Click(object sender, EventArgs e)
        {
            _login = new LoginForm(_script.Login);
            _login.FormClosed += NewLoginClose;
            _login.Show();
        }

        private void btnAddtoMain_Click(object sender, EventArgs e)
        {
            int index = lvDash.SelectedIndices[0];
            if (index != -1)
            {
                //_wait = new MainVariableWaitForm();
                //_wait.FormClosed += NewMainVar;
                //_wait.Show();
            }
        }
        private void NewMainVar(object sender, FormClosedEventArgs e)
        {
            initListVar();
        }

        private void chbErrorCheck_CheckedChanged(object sender, EventArgs e)
        {
            pnErrorInfo.Visible = chbErrorCheck.Checked;
        }

        private void btnAddTime_Click(object sender, EventArgs e)
        {
            _wait = new MainVariableWaitForm(_script);
            _wait.FormClosed += NewMainVar;
            _wait.Show();
        }
    }
}
