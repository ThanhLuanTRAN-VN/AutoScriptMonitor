using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using PiMonitor.Objects;

namespace PiMonitor
{
    public partial class LoginForm : Form
    {
        private readonly List<string> _actions;
        private Variables _var;
        private string _name;
        private readonly List<string> _urls;
        private LineEditForm _lineEdit;
        private int _selectedLineIndex = -1;
        public Variables Var => _var;
        public bool isClosed = true;
        public bool isEdit = false;
        private Variables _beforeEdit;
        public LoginForm()
        {
            _actions = new List<string>();
            _var = new Variables();
            _urls = new List<string>();
            InitializeComponent();
            PageLoad();
        }
        public LoginForm(Variables var)
        {
            _actions = new List<string>();
            _var = var;
            _urls = new List<string>();
            InitializeComponent();
            PageLoad();
            _beforeEdit = var;
            //isEdit = true;
        }

        private void PageLoad()
        {
            initActionComboBox();
            initUrlChoixComboBox();
            switchPanel(2);
            loadContents();
            btnAdd.Hide();
            btnEdit.Enabled = false;
            btnUp.Enabled = false;
            btnDown.Enabled = false;
            btnDelete.Enabled = false;
            btnLink.Enabled = false;
            initUrl();
        }

        private void initUrl()
        {
            _urls.Add("https://sso.online.tableau.com/public/idp/SSO");
            _urls.Add("https://jira.talendforge.org/");
            _urls.Add("https://trello.com/login?returnUrl=%2F");
            _urls.Add("https://www.officetimeline.com/login?returnurl=https%3A%2F%2Fwww.officetimeline.com%2F\n");
        }

        private void loadContents()
        {
            lvPreview.Clear();
            foreach (var line in _var.Contents)
            {
                lvPreview.Items.Add(line);
            }
        }

        private void initActions()
        {
            _actions.Add("FILE_PROFILER");
            _actions.Add("TIMEOUT_PAGE");
            _actions.Add("CLOSE ALL OTHERS");
            _actions.Add("CLEAR");
            _actions.Add("WAIT");
            _actions.Add("URL");
            _actions.Add("TAB OPEN");
            _actions.Add("TAB T");
            _actions.Add("Custom");
        }

        private void initActionComboBox()
        {
            initActions();
            foreach (var item in _actions)
            {
                cbAction.Items.Add(item);
            }
        }
        private void initUrlChoixComboBox()
        {
            cbUrlChoix.Items.Add("Tableau");
            cbUrlChoix.Items.Add("Jira");
            cbUrlChoix.Items.Add("Trello");
            cbUrlChoix.Items.Add("Pincello");
            cbUrlChoix.Items.Add("Manual");
        }

        private void cbAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbInfo.Text = "";
            comboBoxChanged();
        }

        private void comboBoxChanged()
        {
            int index = cbAction.SelectedIndex;
            if (index == -1)
            {
                btnAdd.Hide();
            }
            else
            {
                btnAdd.Show();
            }
            string s = "";
            string preview = _var.Name + " += ";
            string pagedown = "\"" + @"\n" + "\";";
            switch (index)
            {
                case 0:
                    s = "\"SET !FILE_PROFILER " + tbInfo.Text + "_{{!NOW:dd-mm-yyyy}}.xml" + "\" + " + pagedown;
                    lbInfo.Text = "Profiler name";
                    switchPanel(0);
                    break;
                case 1:
                    s = "\"SET !TIMEOUT_PAGE " + tbInfo.Text + " \" + " + pagedown;
                    lbInfo.Text = "Set timeout value";
                    switchPanel(0);
                    break;
                case 2:
                    s = "\"TAB CLOSEALLOTHERS\" + " + pagedown;
                    switchPanel(2);
                    break;
                case 3:
                    s = "\"CLEAR\" + " + pagedown;
                    switchPanel(2);
                    break;
                case 4:
                    s = "\"WAIT SECONDS=" + tbInfo.Text + "\" + " + pagedown;
                    lbInfo.Text = "Set wait value";
                    switchPanel(0);
                    break;
                case 5:
                    s = urlLoadContent();
                    switchPanel(1);
                    break;
                case 6:
                    s = "\"TAB OPEN\" + " + pagedown;
                    switchPanel(2);
                    break;
                case 7:
                    s = "\"TAB T=" + tbInfo.Text + "\" + " + pagedown;
                    lbInfo.Text = "Tab value";
                    switchPanel(0);
                    break;
                default:
                    break;
            }
            preview += s;
            rtbPreview.Text = preview;
        }

        private string urlLoadContent()
        {
            string s;
            string pagedown = "\"" + @"\n" + "\";";
            s = "\"URL GOTO=" + tbUrl.Text + "\" + " + pagedown + Environment.NewLine;
            switch (cbUrlChoix.SelectedIndex)
            {
                case 0:
                    urlFillShow();
                    s += _var.Name + " += " +
                         "\"TAG POS=1 TYPE=INPUT:EMAIL FORM=ID:prelogin-form ATTR=ID:email CONTENT=" +
                         tbUserName.Text + "\" + " + pagedown + Environment.NewLine;
                    if (cbEncryp.Checked == true)
                    {
                        s += _var.Name + " += " + "\"SET !ENCRYPTION STOREDKEY\" + " + pagedown +
                             Environment.NewLine;
                    }
                    s += _var.Name + " += " +
                         "\"TAG POS=1 TYPE=INPUT:PASSWORD FORM=ID:prelogin-form ATTR=ID:password CONTENT=" +
                         tbPass.Text + "\" + " + pagedown + Environment.NewLine;
                    s += _var.Name + " += " +
                         "\"TAG POS=1 TYPE=BUTTON FORM=ID:prelogin-form ATTR=ID:login-submit\" + " + pagedown;
                    break;
                case 1:
                    urlFillShow();
                    s += _var.Name + " += " +
                         "\"TAG POS=1 TYPE=INPUT:TEXT FORM=ID:loginform ATTR=ID:login-form-username CONTENT=" +
                         tbUserName.Text + "\" + " + pagedown + Environment.NewLine;
                    s += _var.Name + " += " +
                         "\"WAIT SECONDS=2\" + " + pagedown;
                    if (cbEncryp.Checked == true)
                    {
                        s += _var.Name + " += " + "\"SET !ENCRYPTION STOREDKEY\" + " + pagedown +
                             Environment.NewLine;
                    }
                    s += _var.Name + " += " +
                         "\"TAG POS=1 TYPE=INPUT:PASSWORD FORM=ID:loginform ATTR=ID:login-form-password CONTENT=" +
                         tbPass.Text + "\" + " + pagedown + Environment.NewLine;
                    s += _var.Name + " += " +
                         "\"WAIT SECONDS=2\" + " + pagedown;
                    s += _var.Name + " += " +
                         "\"TAG POS=1 TYPE=INPUT:SUBMIT FORM=ID:loginform ATTR=ID:login\" + " + pagedown;
                    break;
                case 2:
                    urlFillShow();
                    s += _var.Name + " += " +
                         "\"TAG POS=1 TYPE=INPUT:EMAIL FORM=ID:login-form ATTR=ID:user CONTENT=" +
                         tbUserName.Text + "\" + " + pagedown + Environment.NewLine;
                    if (cbEncryp.Checked == true)
                    {
                        s += _var.Name + " += " + "\"SET !ENCRYPTION STOREDKEY\" + " + pagedown +
                             Environment.NewLine;
                    }
                    s += _var.Name + " += " +
                         "\"TAG POS=1 TYPE=INPUT:PASSWORD FORM=ID:login-form ATTR=ID:password CONTENT" +
                         tbPass.Text + "\" + " + pagedown + Environment.NewLine;
                    s += _var.Name + " += " +
                         "\"TAG POS=1 TYPE=INPUT:SUBMIT FORM=ID:login-form ATTR=ID:login\" + " + pagedown;
                    break;
                case 3:
                    urlFillShow();
                    s += _var.Name + " += " +
                         "\"TAG POS=1 TYPE=INPUT:EMAIL FORM=ID:login-or-register-form ATTR=ID:email CONTENT=" +
                         tbUserName.Text + "\" + " + pagedown + Environment.NewLine;
                    if (cbEncryp.Checked == true)
                    {
                        s += _var.Name + " += " + "\"SET !ENCRYPTION STOREDKEY\" + " + pagedown +
                             Environment.NewLine;
                    }
                    s += _var.Name + " += " +
                         "\"TAG POS=1 TYPE=INPUT:PASSWORD FORM=ID:login-or-register-form ATTR=ID:password CONTENT=" +
                         tbPass.Text + "\" + " + pagedown + Environment.NewLine;
                    s += _var.Name + " += " +
                         "\"TAG POS=1 TYPE=BUTTON ATTR=ID:login-or-register-btn\" + " + pagedown;
                    break;
                case 4:
                    tbUrl.Enabled = true;
                    tbUserName.Hide();
                    tbPass.Hide();
                    lbPass.Hide();
                    lbUserName.Hide();
                    cbEncryp.Hide();
                    break;
            }
            return s;
        }

        private void urlFillShow()
        {
            tbUserName.Show();
            tbPass.Show();
            lbPass.Show();
            lbUserName.Show();
        }
        private void switchPanel(int cas)
        {
            switch (cas)
            {
                case 0:
                    pnInfo.Visible = true;
                    pnUrl.Visible = false;
                    break;
                case 1:
                    pnInfo.Visible = false;
                    pnUrl.Visible = true;
                    break;
                case 2:
                    pnInfo.Visible = false;
                    pnUrl.Visible = false;
                    break;
                default:
                    break;
            }
        }

        private void tbInfo_TextChanged(object sender, EventArgs e)
        {
            infoChange();
        }

        private void infoChange()
        {
            int index = cbAction.SelectedIndex;
            string s = "";
            string preview = _var.Name + " += ";
            string pagedown = "\"" + @"\n" + "\";";
            switch (index)
            {
                case 0:
                    s = "\"SET !FILE_PROFILER " + tbInfo.Text + "_{{!NOW:dd-mm-yyyy}}.xml" + "\" + " + pagedown;
                    break;
                case 1:
                    s = "\"SET !TIMEOUT_PAGE " + tbInfo.Text + " \" + " + pagedown;
                    break;
                case 2:
                    s = "\"TAB CLOSEALLOTHERS\" + " + pagedown;
                    break;
                case 3:
                    s = "\"CLEAR\" + " + pagedown;
                    break;
                case 4:
                    s = "\"WAIT SECONDS=" + tbInfo.Text + "\" + " + pagedown;
                    break;
                case 5:
                    s = urlLoadContent();
                    switchPanel(1);
                    break;
                case 6:
                    s = "\"TAB OPEN\" + " + pagedown;
                    break;
                case 7:
                    s = "\"TAB T=" + tbInfo.Text + "\" + " + pagedown;
                    break;
                case 8:
                    break;
                default:
                    preview = "";
                    break;
            }
            preview += s;
            rtbPreview.Text = preview;
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            _var.Name = tbName.Text;
            infoChange();
            loadContents();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < rtbPreview.Lines.Length; i++)
            {
                string t = rtbPreview.Lines[i];
                _var.Contents.Add(t);
            }
            cbAction.SelectedIndex = -1;
            cbUrlChoix.SelectedIndex = -1;
            tbUrl.Enabled = true;
            tbUrl.Text = "";
            tbUserName.Text = "";
            tbPass.Text = "";
            cbEncryp.Checked = false;
            tbInfo.Text = "";
            rtbPreview.Text = "";
            switchPanel(2);
            loadContents();
        }

        private void cbUrlChoix_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbUrlChoix.SelectedIndex;
            switch (index)
            {
                //case -1:
                //    tbUrl.Hide();
                //    tbUserName.Hide();
                //    tbPass.Hide();
                //    lbPass.Hide();
                //    lbUserName.Hide();
                //    break;
                case 0:
                    tbUrl.Text = _urls[0];
                    tbUrl.Enabled = false;
                    cbEncryp.Show();
                    comboBoxChanged();
                    break;
                case 1:
                    tbUrl.Text = _urls[1];
                    tbUrl.Enabled = false;
                    cbEncryp.Show();
                    comboBoxChanged();
                    break;
                case 2:
                    tbUrl.Text = _urls[2];
                    tbUrl.Enabled = false;
                    cbEncryp.Show();
                    comboBoxChanged();
                    break;
                case 3:
                    tbUrl.Text = _urls[3];
                    tbUrl.Enabled = false;
                    cbEncryp.Show();
                    comboBoxChanged();
                    break;
                case 4:
                    tbUrl.Enabled = true;
                    tbUrl.Text = "";
                    comboBoxChanged();
                    break;
            }
        }

        private void tbUrl_TextChanged(object sender, EventArgs e)
        {
            comboBoxChanged();
        }

        private void tbUserName_TextChanged(object sender, EventArgs e)
        {
            comboBoxChanged();
        }

        private void tbPass_TextChanged(object sender, EventArgs e)
        {
            comboBoxChanged();
        }

        private void cbEncryp_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxChanged();
            btnLink.Enabled = cbEncryp.Checked;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvPreview.SelectedItems.Count > 0)
            {
                _selectedLineIndex = lvPreview.Items.IndexOf(lvPreview.SelectedItems[0]);
            }
            if (lvPreview.SelectedItems.Count > 1) MessageBox.Show("Just select 1 row");
            _lineEdit = new LineEditForm(lvPreview.SelectedItems[0].Text);
            _lineEdit.FormClosed += EditFormClose;
            _lineEdit.Show();
            this.Enabled = false;
        }
        private void EditFormClose(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
            if (_lineEdit.Changed)
            {
                _var.Contents[_selectedLineIndex] = _lineEdit.TextChanged;
            }
            loadContents();
        }

        private void lvPreview_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckSelectedPreview();
        }

        private void CheckSelectedPreview()
        {
            if (lvPreview.SelectedItems.Count > 0)
            {
                _selectedLineIndex = lvPreview.Items.IndexOf(lvPreview.SelectedItems[0]);
            }
            btnEdit.Enabled = lvPreview.SelectedItems.Count > 0;
            btnUp.Enabled = lvPreview.SelectedItems.Count == 1;
            if (_selectedLineIndex == 0) btnUp.Enabled = false;
            btnDown.Enabled = lvPreview.SelectedItems.Count == 1;
            if (_selectedLineIndex == (_var.Contents.Count-1)) btnDown.Enabled = false;
            btnDelete.Enabled = lvPreview.SelectedItems.Count == 1;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            
            _var.ContentSwap(_selectedLineIndex,0);
            CheckSelectedPreview();
            loadContents();
            if (lvPreview.SelectedItems.Count == 0)
            {
                if (_selectedLineIndex != 0)
                {
                    lvPreview.Items[_selectedLineIndex - 1].Selected = true;
                    lvPreview.Focus();
                }
                else
                {
                    lvPreview.Items[0].Selected = true;
                }
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            _var.ContentSwap(_selectedLineIndex, 1);
            CheckSelectedPreview();
            loadContents();
            if (lvPreview.SelectedItems.Count == 0)
            {
                if (_selectedLineIndex != lvPreview.Items.Count - 1) 
                {
                    lvPreview.Items[_selectedLineIndex + 1].Selected = true;
                    lvPreview.Focus();
                }
                else
                {
                    lvPreview.Items[lvPreview.Items.Count - 1].Selected = true;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _var.Remove(_selectedLineIndex);
            lvPreview.SelectedItems.Clear();
            CheckSelectedPreview();
            loadContents();
        }

        //TO DO
        private void btnTry_Click(object sender, EventArgs e)
        {
            _var.Contents.Add("You are fucking noob");
            loadContents();
        }

        private void btnLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://demo.imacros.net/PasswordTool.aspx");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.isClosed = false;
            this.Close();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.isClosed)
            {
                if (!this.isEdit) _var = null;
                else _var = _beforeEdit;
            }
        }
    }
    
}
