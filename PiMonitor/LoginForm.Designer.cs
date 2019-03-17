namespace PiMonitor
{
    partial class LoginForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnInfo = new System.Windows.Forms.Panel();
            this.lbInfo = new System.Windows.Forms.Label();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.rtbPreview = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnUrl = new System.Windows.Forms.Panel();
            this.btnLink = new System.Windows.Forms.Button();
            this.cbEncryp = new System.Windows.Forms.CheckBox();
            this.cbUrlChoix = new System.Windows.Forms.ComboBox();
            this.lbPass = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbUrl = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.cbAction = new System.Windows.Forms.ComboBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTry = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lvPreview = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnInfo.SuspendLayout();
            this.pnUrl.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnInfo);
            this.panel1.Controls.Add(this.rtbPreview);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.pnUrl);
            this.panel1.Controls.Add(this.cbAction);
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnTry);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1177, 320);
            this.panel1.TabIndex = 0;
            // 
            // pnInfo
            // 
            this.pnInfo.Controls.Add(this.lbInfo);
            this.pnInfo.Controls.Add(this.tbInfo);
            this.pnInfo.Location = new System.Drawing.Point(355, 36);
            this.pnInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnInfo.Name = "pnInfo";
            this.pnInfo.Size = new System.Drawing.Size(777, 165);
            this.pnInfo.TabIndex = 9;
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Location = new System.Drawing.Point(4, 33);
            this.lbInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(31, 17);
            this.lbInfo.TabIndex = 6;
            this.lbInfo.Text = "Info";
            // 
            // tbInfo
            // 
            this.tbInfo.Location = new System.Drawing.Point(5, 53);
            this.tbInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.Size = new System.Drawing.Size(767, 22);
            this.tbInfo.TabIndex = 3;
            this.tbInfo.TextChanged += new System.EventHandler(this.tbInfo_TextChanged);
            // 
            // rtbPreview
            // 
            this.rtbPreview.Location = new System.Drawing.Point(13, 203);
            this.rtbPreview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbPreview.Name = "rtbPreview";
            this.rtbPreview.Size = new System.Drawing.Size(1147, 112);
            this.rtbPreview.TabIndex = 10;
            this.rtbPreview.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Preview";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(123, 130);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnUrl
            // 
            this.pnUrl.Controls.Add(this.btnLink);
            this.pnUrl.Controls.Add(this.cbEncryp);
            this.pnUrl.Controls.Add(this.cbUrlChoix);
            this.pnUrl.Controls.Add(this.lbPass);
            this.pnUrl.Controls.Add(this.lbUserName);
            this.pnUrl.Controls.Add(this.lbUrl);
            this.pnUrl.Controls.Add(this.tbPass);
            this.pnUrl.Controls.Add(this.tbUserName);
            this.pnUrl.Controls.Add(this.tbUrl);
            this.pnUrl.Location = new System.Drawing.Point(384, 31);
            this.pnUrl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnUrl.Name = "pnUrl";
            this.pnUrl.Size = new System.Drawing.Size(777, 165);
            this.pnUrl.TabIndex = 5;
            // 
            // btnLink
            // 
            this.btnLink.Location = new System.Drawing.Point(671, 132);
            this.btnLink.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLink.Name = "btnLink";
            this.btnLink.Size = new System.Drawing.Size(100, 28);
            this.btnLink.TabIndex = 11;
            this.btnLink.Text = "Link";
            this.btnLink.UseVisualStyleBackColor = true;
            this.btnLink.Click += new System.EventHandler(this.btnLink_Click);
            // 
            // cbEncryp
            // 
            this.cbEncryp.AutoSize = true;
            this.cbEncryp.Location = new System.Drawing.Point(671, 103);
            this.cbEncryp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbEncryp.Name = "cbEncryp";
            this.cbEncryp.Size = new System.Drawing.Size(97, 21);
            this.cbEncryp.TabIndex = 8;
            this.cbEncryp.Text = "Encryption";
            this.cbEncryp.UseVisualStyleBackColor = true;
            this.cbEncryp.CheckedChanged += new System.EventHandler(this.cbEncryp_CheckedChanged);
            // 
            // cbUrlChoix
            // 
            this.cbUrlChoix.FormattingEnabled = true;
            this.cbUrlChoix.Location = new System.Drawing.Point(15, 4);
            this.cbUrlChoix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbUrlChoix.Name = "cbUrlChoix";
            this.cbUrlChoix.Size = new System.Drawing.Size(160, 24);
            this.cbUrlChoix.TabIndex = 7;
            this.cbUrlChoix.SelectedIndexChanged += new System.EventHandler(this.cbUrlChoix_SelectedIndexChanged);
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Location = new System.Drawing.Point(203, 108);
            this.lbPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(69, 17);
            this.lbPass.TabIndex = 6;
            this.lbPass.Text = "Password";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Location = new System.Drawing.Point(203, 60);
            this.lbUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(111, 17);
            this.lbUserName.TabIndex = 5;
            this.lbUserName.Text = "Username/Email";
            // 
            // lbUrl
            // 
            this.lbUrl.AutoSize = true;
            this.lbUrl.Location = new System.Drawing.Point(203, 14);
            this.lbUrl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUrl.Name = "lbUrl";
            this.lbUrl.Size = new System.Drawing.Size(26, 17);
            this.lbUrl.TabIndex = 4;
            this.lbUrl.Text = "Url";
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(337, 100);
            this.tbPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(293, 22);
            this.tbPass.TabIndex = 3;
            this.tbPass.TextChanged += new System.EventHandler(this.tbPass_TextChanged);
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(337, 52);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(293, 22);
            this.tbUserName.TabIndex = 2;
            this.tbUserName.TextChanged += new System.EventHandler(this.tbUserName_TextChanged);
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(337, 5);
            this.tbUrl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(433, 22);
            this.tbUrl.TabIndex = 1;
            this.tbUrl.TextChanged += new System.EventHandler(this.tbUrl_TextChanged);
            // 
            // cbAction
            // 
            this.cbAction.FormattingEnabled = true;
            this.cbAction.Location = new System.Drawing.Point(123, 87);
            this.cbAction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbAction.Name = "cbAction";
            this.cbAction.Size = new System.Drawing.Size(160, 24);
            this.cbAction.TabIndex = 4;
            this.cbAction.SelectedIndexChanged += new System.EventHandler(this.cbAction_SelectedIndexChanged);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(123, 54);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(160, 22);
            this.tbName.TabIndex = 3;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Action";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // btnTry
            // 
            this.btnTry.Location = new System.Drawing.Point(16, 15);
            this.btnTry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTry.Name = "btnTry";
            this.btnTry.Size = new System.Drawing.Size(100, 28);
            this.btnTry.TabIndex = 0;
            this.btnTry.Text = "Try a sample";
            this.btnTry.UseVisualStyleBackColor = true;
            this.btnTry.Click += new System.EventHandler(this.btnTry_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lvPreview);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 328);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1177, 401);
            this.panel2.TabIndex = 1;
            // 
            // lvPreview
            // 
            this.lvPreview.BackColor = System.Drawing.SystemColors.Info;
            this.lvPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPreview.HideSelection = false;
            this.lvPreview.Location = new System.Drawing.Point(0, 0);
            this.lvPreview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvPreview.Name = "lvPreview";
            this.lvPreview.Size = new System.Drawing.Size(968, 401);
            this.lvPreview.TabIndex = 1;
            this.lvPreview.UseCompatibleStateImageBehavior = false;
            this.lvPreview.View = System.Windows.Forms.View.List;
            this.lvPreview.SelectedIndexChanged += new System.EventHandler(this.lvPreview_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDown);
            this.panel3.Controls.Add(this.btnUp);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnEdit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(968, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(209, 401);
            this.panel3.TabIndex = 0;
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(0, 251);
            this.btnDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(209, 62);
            this.btnDown.TabIndex = 8;
            this.btnDown.Text = "Move Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(0, 86);
            this.btnUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(209, 62);
            this.btnUp.TabIndex = 7;
            this.btnUp.Text = "Move Up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(0, 334);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(209, 62);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(0, 169);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(209, 62);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(0, 4);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(209, 62);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 729);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnInfo.ResumeLayout(false);
            this.pnInfo.PerformLayout();
            this.pnUrl.ResumeLayout(false);
            this.pnUrl.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnUrl;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.ComboBox cbAction;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTry;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbUrl;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.ListView lvPreview;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ComboBox cbUrlChoix;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnInfo;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.CheckBox cbEncryp;
        private System.Windows.Forms.RichTextBox rtbPreview;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnLink;
    }
}