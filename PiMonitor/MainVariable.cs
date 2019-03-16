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
    public partial class MainVariable : Form
    {
        private Variables _var;
        private int _selectedLineIndex = -1;
        private LineEditForm _lineEdit;
        private readonly List<string> _actions;

        public Variables Var => _var;

        public MainVariable()
        {
            _var = new Variables();
            _actions = new List<string>();
            InitializeComponent();
            PageLoad();
        }

        private void PageLoad()
        {
            initActionComboBox();
            loadContents();
            btnEdit.Enabled = false;
            btnUp.Enabled = false;
            btnDown.Enabled = false;
            btnDelete.Enabled = false;
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

        private void loadContents()
        {
            lvPreview.Clear();
            foreach (var line in _var.Contents)
            {
                lvPreview.Items.Add(line);
            }
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
                    pnInfo.Show();
                    break;
                case 1:
                    s = "\"SET !TIMEOUT_PAGE " + tbInfo.Text + " \" + " + pagedown;
                    lbInfo.Text = "Set timeout value";
                    pnInfo.Show();
                    break;
                case 2:
                    s = "\"TAB CLOSEALLOTHERS\" + " + pagedown;
                    pnInfo.Hide();
                    break;
                case 3:
                    s = "\"CLEAR\" + " + pagedown;
                    pnInfo.Hide();
                    break;
                case 4:
                    s = "\"WAIT SECONDS=" + tbInfo.Text + "\" + " + pagedown;
                    lbInfo.Text = "Set wait value";
                    pnInfo.Show();
                    break;
                case 5:
                    s = "\"URL GOTO=" + tbInfo.Text + "\" + " + pagedown;
                    lbInfo.Text = "Url Link";
                    pnInfo.Show();
                    break;
                case 6:
                    s = "\"TAB OPEN\" + " + pagedown;
                    pnInfo.Hide();
                    break;
                case 7:
                    s = "\"TAB T=" + tbInfo.Text + "\" + " + pagedown;
                    lbInfo.Text = "Tab value";
                    pnInfo.Show();
                    break;
                default:
                    break;
            }
            preview += s;
            rtbPreview.Text = preview;
        }

        private void tbInfo_TextChanged(object sender, EventArgs e)
        {
            comboBoxChanged();
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            _var.Name = tbName.Text;
            comboBoxChanged();
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
            tbInfo.Text = "";
            rtbPreview.Text = "";
            pnInfo.Hide();
            loadContents();
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
            if (_selectedLineIndex == (_var.Contents.Count - 1)) btnDown.Enabled = false;
            btnDelete.Enabled = lvPreview.SelectedItems.Count == 1;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            _var.ContentSwap(_selectedLineIndex, 0);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _var.Remove(_selectedLineIndex);
            lvPreview.SelectedItems.Clear();
            CheckSelectedPreview();
            loadContents();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
