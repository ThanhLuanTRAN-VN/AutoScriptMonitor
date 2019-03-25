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
    public partial class MainVariableWaitForm : Form
    {
        public Variables Var { get; set; }

        public int Time { get; set; }

        public bool isClose { get; set; }

        private Script _script;

        public List<TextBox> _tbTimeList;
        public MainVariableWaitForm(Script script)
        {
            InitializeComponent();
            _script = script;
            _tbTimeList = new List<TextBox>();
            int i = 1;
            Label lbs = new Label();
            
            foreach (var Variable in _script.MainVariables)
            {
                Label lb = new Label();
                lb.Text = Variable.Name;
                lb.AutoSize = true;
                lb.Visible = true;
                Point p1 = new Point(15,30*i);
                lb.Location = p1;
                TextBox tb = new TextBox();
                _tbTimeList.Add(tb);
                Point p = new Point(200,30*i);
                tb.Location = p;
                this.pnMid.Controls.Add(lb);
                this.pnMid.Controls.Add(tb);
                i++;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (var variable in _script.MainVariables)
            {
                _script.WaitTime[i] = int.Parse(_tbTimeList[i].Text);
                i++;
            }
            isClose = false;
            _script.Contents.Add("check line;");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            isClose = true;
            this.Close();
        }
    }
}
