namespace PiMonitor
{
    partial class MainVariable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnInfo = new System.Windows.Forms.Panel();
            this.lbInfo = new System.Windows.Forms.Label();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.rtbPreview = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbAction = new System.Windows.Forms.ComboBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lvPreview = new System.Windows.Forms.ListView();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnTry = new System.Windows.Forms.Button();
            this.pnInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnInfo
            // 
            this.pnInfo.Controls.Add(this.lbInfo);
            this.pnInfo.Controls.Add(this.tbInfo);
            this.pnInfo.Location = new System.Drawing.Point(288, 25);
            this.pnInfo.Name = "pnInfo";
            this.pnInfo.Size = new System.Drawing.Size(583, 134);
            this.pnInfo.TabIndex = 17;
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Location = new System.Drawing.Point(3, 27);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(25, 13);
            this.lbInfo.TabIndex = 6;
            this.lbInfo.Text = "Info";
            // 
            // tbInfo
            // 
            this.tbInfo.Location = new System.Drawing.Point(4, 43);
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.Size = new System.Drawing.Size(576, 20);
            this.tbInfo.TabIndex = 3;
            this.tbInfo.TextChanged += new System.EventHandler(this.tbInfo_TextChanged);
            // 
            // rtbPreview
            // 
            this.rtbPreview.Location = new System.Drawing.Point(10, 165);
            this.rtbPreview.Name = "rtbPreview";
            this.rtbPreview.Size = new System.Drawing.Size(861, 92);
            this.rtbPreview.TabIndex = 18;
            this.rtbPreview.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Preview";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(92, 106);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbAction
            // 
            this.cbAction.FormattingEnabled = true;
            this.cbAction.Location = new System.Drawing.Point(92, 71);
            this.cbAction.Name = "cbAction";
            this.cbAction.Size = new System.Drawing.Size(121, 21);
            this.cbAction.TabIndex = 14;
            this.cbAction.SelectedIndexChanged += new System.EventHandler(this.cbAction_SelectedIndexChanged);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(92, 44);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(121, 20);
            this.tbName.TabIndex = 13;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Action";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lvPreview);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 266);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 326);
            this.panel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDown);
            this.panel2.Controls.Add(this.btnUp);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(726, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(157, 326);
            this.panel2.TabIndex = 0;
            // 
            // lvPreview
            // 
            this.lvPreview.BackColor = System.Drawing.SystemColors.Info;
            this.lvPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPreview.HideSelection = false;
            this.lvPreview.Location = new System.Drawing.Point(0, 0);
            this.lvPreview.Name = "lvPreview";
            this.lvPreview.Size = new System.Drawing.Size(726, 326);
            this.lvPreview.TabIndex = 2;
            this.lvPreview.UseCompatibleStateImageBehavior = false;
            this.lvPreview.View = System.Windows.Forms.View.List;
            this.lvPreview.SelectedIndexChanged += new System.EventHandler(this.lvPreview_SelectedIndexChanged);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(0, 205);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(157, 50);
            this.btnDown.TabIndex = 13;
            this.btnDown.Text = "Move Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(0, 71);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(157, 50);
            this.btnUp.TabIndex = 12;
            this.btnUp.Text = "Move Up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(0, 272);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(157, 50);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(0, 138);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(157, 50);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(0, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(157, 50);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnTry
            // 
            this.btnTry.Location = new System.Drawing.Point(12, 12);
            this.btnTry.Name = "btnTry";
            this.btnTry.Size = new System.Drawing.Size(75, 23);
            this.btnTry.TabIndex = 20;
            this.btnTry.Text = "Try a sample";
            this.btnTry.UseVisualStyleBackColor = true;
            // 
            // MainVariable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 592);
            this.Controls.Add(this.btnTry);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnInfo);
            this.Controls.Add(this.rtbPreview);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbAction);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainVariable";
            this.Text = "MainVariable";
            this.pnInfo.ResumeLayout(false);
            this.pnInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnInfo;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.RichTextBox rtbPreview;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbAction;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lvPreview;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnTry;
    }
}