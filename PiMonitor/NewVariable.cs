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
    public partial class NewVariable : Form
    {
        private readonly List<string> _normalChoix;
        private readonly List<string> _tableauChoix;
        private string _name;
        private Variables _var;
        private LineEditForm _lineEdit;
        private int _selectedIndex = -1;
        private bool _isEdit = false;
        public NewVariable(string name)
        {
            _name = name;
            _normalChoix = new List<string>();
            _tableauChoix = new List<string>();
            _var = new Variables(_name);
            LoadForm();
        }

        public NewVariable(Variables var)
        {
            _name = var.Name;
            _normalChoix = new List<string>();
            _tableauChoix = new List<string>();
            _var = var;
            LoadForm();
            _isEdit = true;
        }

        private void LoadForm()
        {
            initNormalChoix();
            initTableauChoix();
            InitializeComponent();
            initNormalChoixComboBox();
            initTableauChoixComboBox();
            AdditionalInfoHide();
            lbTableauDesctiption.Hide();
            tbxTableau.Hide();
            LbName.Text = _name;
            loadListViewVariable();
            btxNormalAdd.Hide();
            btxTableauAdd.Hide();
        }

        private void loadListViewVariable()
        {
            lvVarContents.Clear();
            foreach (var line in _var.Contents)
            {
                lvVarContents.Items.Add(line);
            }
        }

        private void initTableauChoix()
        {
            _tableauChoix.Add("TAG");
            _tableauChoix.Add("FRAME");
            _tableauChoix.Add("EVENT CLICK");
        }

        private void initNormalChoix()
        {
            _normalChoix.Add("FILE_PROFILER");
            _normalChoix.Add("TIMEOUT_PAGE");
            _normalChoix.Add("CLOSE ALL OTHERS");
            _normalChoix.Add("CLEAR");
            _normalChoix.Add("WAIT");
            _normalChoix.Add("ENCRYPTION KEY");
            _normalChoix.Add("URL");
            _normalChoix.Add("TAB OPEN");
            _normalChoix.Add("TAB T");
        }

        private void initNormalChoixComboBox()
        {
            foreach (var item in _normalChoix)
            {
                cbxNormalChoix.Items.Add(item);
            }
        }

        private void initTableauChoixComboBox()
        {
            foreach (var item in _tableauChoix)
            {
                CbxTableauChoix.Items.Add(item);
            }
        }

        private void cbxNormalChoix_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbxNormalChoix.SelectedIndex;
            if (index != -1)
            {
                CbxTableauChoix.SelectedIndex = -1;
                btxNormalAdd.Show();
            }
            else
            {
                btxNormalAdd.Hide();
            }
            string s = "";
            string preview = _name + " += ";
            string pagedown = "\"" + @"\n" + "\";";
            switch (index)
            {
                case 0:
                    s = "\"SET !FILE_PROFILER " + tbxNormal.Text + "_{{!NOW:dd-mm-yyyy}}.xml" + "\" + " + pagedown;
                    lbNormalDescription.Text = "Profiler name";
                    AdditionalInfoShow();
                    break;
                case 1:
                    s = "\"SET !TIMEOUT_PAGE " + tbxNormal.Text + " \" + " + pagedown;
                    lbNormalDescription.Text = "Set timeout value";
                    AdditionalInfoShow();
                    break;
                case 2:
                    s = "\"TAB CLOSEALLOTHERS\" + " + pagedown;
                    AdditionalInfoHide();
                    break;
                case 3:
                    s = "\"CLEAR\" + " + pagedown;
                    AdditionalInfoHide();
                    break;
                case 4:
                    s = "\"WAIT SECONDS=" + tbxNormal.Text + "\" + " + pagedown;
                    lbNormalDescription.Text = "Set wait value";
                    AdditionalInfoShow();
                    break;
                case 5:
                    s = "\"SET !ENCRYPTION STOREDKEY\" + " + pagedown;
                    AdditionalInfoHide();
                    break;
                case 6:
                    s = "\"URL GOTO=" + tbxNormal.Text + "\" + " + pagedown;
                    lbNormalDescription.Text = "Url link";
                    AdditionalInfoShow();
                    break;
                case 7:
                    s = "\"TAB OPEN\" + " + pagedown;
                    AdditionalInfoHide();
                    break;
                case 8:
                    s = "\"TAB T=" + tbxNormal.Text + "\" + " + pagedown;
                    lbNormalDescription.Text = "Tab value";
                    AdditionalInfoShow();
                    break;
                default:
                    break;
            }
            preview += s;
            tbxPreview.Text = preview;
        }

        

        private void btxNormalAdd_Click(object sender, EventArgs e)
        {
            _var.Contents.Add(tbxPreview.Text);
            cbxNormalChoix.SelectedIndex = -1;
            tbxNormal.Text = "";
            tbxPreview.Text = "";
            loadListViewVariable();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvVarContents.SelectedItems.Count > 0)
            {
                _selectedIndex = lvVarContents.Items.IndexOf(lvVarContents.SelectedItems[0]);
            }
            if (lvVarContents.SelectedItems.Count > 1) MessageBox.Show("Just select 1 row");
            _lineEdit = new LineEditForm(lvVarContents.SelectedItems[0].Text);
            _lineEdit.FormClosed += EditFormClose;
            _lineEdit.Show();
            this.Enabled = false;
        }

        private void EditFormClose(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
            if (_lineEdit.Changed)
            {
                _var.Contents[_selectedIndex] = _lineEdit.TextChanged;
            }
            loadListViewVariable();
        }

        private void tbxNormal_TextChanged(object sender, EventArgs e)
        {
            int index = cbxNormalChoix.SelectedIndex;
            string s = "";
            string preview = _name + " += ";
            string pagedown = "\"" + @"\n" + "\";";
            switch (index)
            {
                case 0:
                    s = "\"SET !FILE_PROFILER " + tbxNormal.Text + "_{{!NOW:dd-mm-yyyy}}.xml" + "\" + " + pagedown;

                    break;
                case 1:
                    s = "\"SET !TIMEOUT_PAGE " + tbxNormal.Text + " \" + " + pagedown;
                    break;
                    ;
                case 2:
                    s = "\"TAB CLOSEALLOTHERS\" + " + pagedown;
                    break;
                case 3:
                    s = "\"CLEAR\" + " + pagedown;
                    break;
                case 4:
                    s = "\"WAIT SECONDS=" + tbxNormal.Text + "\" + " + pagedown;
                    break;
                case 5:
                    s = "\"SET !ENCRYPTION STOREDKEY\" + " + pagedown;
                    break;
                case 6:
                    s = "\"URL GOTO=" + tbxNormal.Text + "\" + " + pagedown;
                    break;
                case 7:
                    s = "\"TAB OPEN\" + " + pagedown;
                    break;
                case 8:
                    s = "\"TAB T=" + tbxNormal.Text + "\" + " + pagedown;
                    break;
            }

            preview += s;
            tbxPreview.Text = preview;
        }

        private void AdditionalInfoHide()
        {
            lbNormalDescription.Hide();
            tbxNormal.Hide();
        }

        private void AdditionalInfoShow()
        {
            lbNormalDescription.Show();
            tbxNormal.Show();
        }

        public Variables Varibale => _var;

        private void btnCreate_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
