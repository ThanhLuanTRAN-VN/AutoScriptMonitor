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
    public partial class MainPage : Form
    {
        private Script _script;
        private VariableNameRequestForm _variableNameRequest;
        public MainPage()
        {
            _script = new Script();
            InitializeComponent();
            initListVarComboBox();
            initListMainVarComboBox();
        }

        private void loadScriptListView()
        {
            lvScript.Clear();
            foreach (var line in _script.Contents)
            {
                lvScript.Items.Add(line);
            }
        }

        private void initListMainVarComboBox()
        {
            cbxListMainVar.Items.Clear();
            if (_script.MainVariables.Count != 0)
            {
                foreach (var var in _script.MainVariables)
                {
                    cbxListMainVar.Items.Add(var);
                }
            }
        }

        private void initListVarComboBox()
        {
            cbxListVar.Items.Clear();
            if (_script.Variables.Count != 0)
            {
                foreach (var var in _script.Variables)
                {
                    cbxListVar.Items.Add(var);
                }
            }
        }

        private void btnNewVar_Click(object sender, EventArgs e)
        {
            _variableNameRequest = new VariableNameRequestForm();
            _variableNameRequest.FormClosed += NewVariableFormClose;
            _variableNameRequest.Show();
        }

        private void NewVariableFormClose(object sender, FormClosedEventArgs e)
        {
            _script.AddVariable(_variableNameRequest.Variable);
            initListVarComboBox();
            lbVariables.Text = "You have " + _script.Variables.Count + " variables";
        }

        private void btnAddToMainVar_Click(object sender, EventArgs e)
        {
            int index = cbxListVar.SelectedIndex;
            _script.MainVariables.Add(_script.Variables[index]);
            initListMainVarComboBox();
            lbMainVariables.Text = "You have " + _script.MainVariables.Count + " main variables";
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            _script.TestSave();
        }

        private void btnCheckScript_Click(object sender, EventArgs e)
        {
            _script.CreateScript();
            loadScriptListView();
        }
    }
}
