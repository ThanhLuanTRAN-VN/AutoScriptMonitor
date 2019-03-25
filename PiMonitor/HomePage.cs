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
            _script.WaitTime.Add(0);
            initListVar();
            lbVarCount.Text = "You have " + _script.MainVariables.Count + " variables";
        }

        private void initListVar()
        {
            lvDash.Clear();
            lvVariablesDashBoard.Items.Clear();
            int i = 0;
            foreach (var variable in _script.MainVariables)
            {
                lvDash.Items.Add(variable.Name);
                ListViewItem it = new ListViewItem(variable.Name);
                it.SubItems.Add(_script.WaitTime[i].ToString());
                lvVariablesDashBoard.Items.Add(it);
                i++;
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

        private void btnMoveUpVar_Click(object sender, EventArgs e)
        {
            int index = lvDash.Items.IndexOf(lvDash.SelectedItems[0]);
            VarSwap(index, 0);
            initListVar();
            if (index != 0)
            {
                lvDash.Items[index - 1].Selected = true;
                lvDash.Focus();
            }
        }

        private void btnMoveDownVar_Click(object sender, EventArgs e)
        {
            int index = lvDash.Items.IndexOf(lvDash.SelectedItems[0]);
            VarSwap(index, 1);
            initListVar();
            if (index != lvDash.Items.Count - 1) 
            {
                lvDash.Items[index + 1].Selected = true;
                lvDash.Focus();
            }
        }

        private void VarSwap(int index, int upDown)
        {
            Variables temps;
            int tempsWait;
            switch (upDown)
            {
                case 0:
                    if (index != 0)
                    {
                        temps = _script.MainVariables[index];
                        _script.MainVariables[index] = _script.MainVariables[index - 1];
                        _script.MainVariables[index - 1] = temps;
                        tempsWait = _script.WaitTime[index];
                        _script.WaitTime[index] = _script.WaitTime[index - 1];
                        _script.WaitTime[index - 1] = tempsWait;
                    }
                    break;
                case 1:
                    if (index != _script.MainVariables.Count - 1)
                    {
                        temps = _script.MainVariables[index];
                        _script.MainVariables[index] = _script.MainVariables[index + 1];
                        _script.MainVariables[index + 1] = temps;
                        tempsWait = _script.WaitTime[index];
                        _script.WaitTime[index] = _script.WaitTime[index + 1];
                        _script.WaitTime[index + 1] = tempsWait;
                    }
                    break;
            }
        }

    }
}
