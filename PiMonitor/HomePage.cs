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
        private int _check;
        public HomePage()
        {
            _script = new Script();
            InitializeComponent();
            btnInitEdit.Enabled = false;
        }

        private void btnInitNew_Click(object sender, EventArgs e)
        {
            _login = new LoginForm();
            _login.FormClosed += NewLoginClose;
            _login.Show();
        }
        private void NewLoginClose(object sender, FormClosedEventArgs e)
        {
            _script.Login = _login.Var;
            lbCreated.Text = "Created";
            btnInitEdit.Enabled = true;
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
            initListVar();
            lbVarCount.Text = "You have " + _script.MainVariables.Count + " variables";
        }

        private void initListVar()
        {
            lvDash.Clear();
            foreach (var variable in _script.MainVariables)
            {
                lvDash.Items.Add(variable.Name);
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            _script.CreateScript();
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
    }
}
