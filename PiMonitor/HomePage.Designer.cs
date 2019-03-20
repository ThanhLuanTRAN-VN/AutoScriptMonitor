namespace PiMonitor
{
    partial class HomePage
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbCreated = new System.Windows.Forms.Label();
            this.btnInitEdit = new System.Windows.Forms.Button();
            this.btnInitNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddtoMain = new System.Windows.Forms.Button();
            this.lbVarCount = new System.Windows.Forms.Label();
            this.lvDash = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDashEdit = new System.Windows.Forms.Button();
            this.btnDashNew = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnErrorInfo = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxFileName = new System.Windows.Forms.TextBox();
            this.tbxWaitTime = new System.Windows.Forms.TextBox();
            this.tbxRepeat = new System.Windows.Forms.TextBox();
            this.tbxFileLocation = new System.Windows.Forms.TextBox();
            this.chbErrorCheck = new System.Windows.Forms.CheckBox();
            this.lvVariablesDashBoard = new System.Windows.Forms.ListView();
            this.MainVar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WaitTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.lvPreview = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddTime = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnErrorInfo.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbCreated);
            this.panel1.Controls.Add(this.btnInitEdit);
            this.panel1.Controls.Add(this.btnInitNew);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1227, 107);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PiMonitor.Properties.Resources.Tick_Mark_512;
            this.pictureBox1.Location = new System.Drawing.Point(291, 42);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lbCreated
            // 
            this.lbCreated.AutoSize = true;
            this.lbCreated.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreated.Location = new System.Drawing.Point(60, 9);
            this.lbCreated.Name = "lbCreated";
            this.lbCreated.Size = new System.Drawing.Size(115, 20);
            this.lbCreated.TabIndex = 4;
            this.lbCreated.Text = "Variable name:";
            // 
            // btnInitEdit
            // 
            this.btnInitEdit.Location = new System.Drawing.Point(7, 72);
            this.btnInitEdit.Name = "btnInitEdit";
            this.btnInitEdit.Size = new System.Drawing.Size(75, 23);
            this.btnInitEdit.TabIndex = 2;
            this.btnInitEdit.Text = "Edit";
            this.btnInitEdit.UseVisualStyleBackColor = true;
            this.btnInitEdit.Click += new System.EventHandler(this.btnInitEdit_Click);
            // 
            // btnInitNew
            // 
            this.btnInitNew.Location = new System.Drawing.Point(7, 42);
            this.btnInitNew.Name = "btnInitNew";
            this.btnInitNew.Size = new System.Drawing.Size(75, 23);
            this.btnInitNew.TabIndex = 1;
            this.btnInitNew.Text = "New";
            this.btnInitNew.UseVisualStyleBackColor = true;
            this.btnInitNew.Click += new System.EventHandler(this.btnInitNew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Initial";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAddtoMain);
            this.panel2.Controls.Add(this.lbVarCount);
            this.panel2.Controls.Add(this.lvDash);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnDashEdit);
            this.panel2.Controls.Add(this.btnDashNew);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1227, 130);
            this.panel2.TabIndex = 1;
            // 
            // btnAddtoMain
            // 
            this.btnAddtoMain.Location = new System.Drawing.Point(466, 25);
            this.btnAddtoMain.Name = "btnAddtoMain";
            this.btnAddtoMain.Size = new System.Drawing.Size(130, 23);
            this.btnAddtoMain.TabIndex = 7;
            this.btnAddtoMain.Text = "Add To Main Variable";
            this.btnAddtoMain.UseVisualStyleBackColor = true;
            this.btnAddtoMain.Click += new System.EventHandler(this.btnAddtoMain_Click);
            // 
            // lbVarCount
            // 
            this.lbVarCount.AutoSize = true;
            this.lbVarCount.Location = new System.Drawing.Point(13, 71);
            this.lbVarCount.Name = "lbVarCount";
            this.lbVarCount.Size = new System.Drawing.Size(107, 13);
            this.lbVarCount.TabIndex = 6;
            this.lbVarCount.Text = "You have 0 variables";
            // 
            // lvDash
            // 
            this.lvDash.Location = new System.Drawing.Point(306, 7);
            this.lvDash.MultiSelect = false;
            this.lvDash.Name = "lvDash";
            this.lvDash.Size = new System.Drawing.Size(121, 102);
            this.lvDash.TabIndex = 5;
            this.lvDash.UseCompatibleStateImageBehavior = false;
            this.lvDash.View = System.Windows.Forms.View.List;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(174, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "not implement";
            // 
            // btnDashEdit
            // 
            this.btnDashEdit.Location = new System.Drawing.Point(171, 41);
            this.btnDashEdit.Name = "btnDashEdit";
            this.btnDashEdit.Size = new System.Drawing.Size(75, 23);
            this.btnDashEdit.TabIndex = 3;
            this.btnDashEdit.Text = "Edit";
            this.btnDashEdit.UseVisualStyleBackColor = true;
            // 
            // btnDashNew
            // 
            this.btnDashNew.Location = new System.Drawing.Point(12, 41);
            this.btnDashNew.Name = "btnDashNew";
            this.btnDashNew.Size = new System.Drawing.Size(75, 23);
            this.btnDashNew.TabIndex = 2;
            this.btnDashNew.Text = "New";
            this.btnDashNew.UseVisualStyleBackColor = true;
            this.btnDashNew.Click += new System.EventHandler(this.btnDashNew_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Dashboard";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAddTime);
            this.panel3.Controls.Add(this.pnErrorInfo);
            this.panel3.Controls.Add(this.chbErrorCheck);
            this.panel3.Controls.Add(this.lvVariablesDashBoard);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 237);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1227, 425);
            this.panel3.TabIndex = 2;
            // 
            // pnErrorInfo
            // 
            this.pnErrorInfo.Controls.Add(this.label9);
            this.pnErrorInfo.Controls.Add(this.label8);
            this.pnErrorInfo.Controls.Add(this.label7);
            this.pnErrorInfo.Controls.Add(this.label5);
            this.pnErrorInfo.Controls.Add(this.tbxFileName);
            this.pnErrorInfo.Controls.Add(this.tbxWaitTime);
            this.pnErrorInfo.Controls.Add(this.tbxRepeat);
            this.pnErrorInfo.Controls.Add(this.tbxFileLocation);
            this.pnErrorInfo.Location = new System.Drawing.Point(662, 0);
            this.pnErrorInfo.Margin = new System.Windows.Forms.Padding(2);
            this.pnErrorInfo.Name = "pnErrorInfo";
            this.pnErrorInfo.Size = new System.Drawing.Size(563, 106);
            this.pnErrorInfo.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(280, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Repeat";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Wait Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(280, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "File Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "File Location";
            // 
            // tbxFileName
            // 
            this.tbxFileName.Location = new System.Drawing.Point(383, 11);
            this.tbxFileName.Margin = new System.Windows.Forms.Padding(2);
            this.tbxFileName.Name = "tbxFileName";
            this.tbxFileName.Size = new System.Drawing.Size(171, 20);
            this.tbxFileName.TabIndex = 3;
            // 
            // tbxWaitTime
            // 
            this.tbxWaitTime.Location = new System.Drawing.Point(90, 62);
            this.tbxWaitTime.Margin = new System.Windows.Forms.Padding(2);
            this.tbxWaitTime.Name = "tbxWaitTime";
            this.tbxWaitTime.Size = new System.Drawing.Size(171, 20);
            this.tbxWaitTime.TabIndex = 2;
            // 
            // tbxRepeat
            // 
            this.tbxRepeat.Location = new System.Drawing.Point(383, 62);
            this.tbxRepeat.Margin = new System.Windows.Forms.Padding(2);
            this.tbxRepeat.Name = "tbxRepeat";
            this.tbxRepeat.Size = new System.Drawing.Size(171, 20);
            this.tbxRepeat.TabIndex = 1;
            // 
            // tbxFileLocation
            // 
            this.tbxFileLocation.Location = new System.Drawing.Point(90, 11);
            this.tbxFileLocation.Margin = new System.Windows.Forms.Padding(2);
            this.tbxFileLocation.Name = "tbxFileLocation";
            this.tbxFileLocation.Size = new System.Drawing.Size(171, 20);
            this.tbxFileLocation.TabIndex = 0;
            // 
            // chbErrorCheck
            // 
            this.chbErrorCheck.AutoSize = true;
            this.chbErrorCheck.Location = new System.Drawing.Point(385, 10);
            this.chbErrorCheck.Name = "chbErrorCheck";
            this.chbErrorCheck.Size = new System.Drawing.Size(123, 17);
            this.chbErrorCheck.TabIndex = 10;
            this.chbErrorCheck.Text = "Loading Error Check";
            this.chbErrorCheck.UseVisualStyleBackColor = true;
            this.chbErrorCheck.CheckedChanged += new System.EventHandler(this.chbErrorCheck_CheckedChanged);
            // 
            // lvVariablesDashBoard
            // 
            this.lvVariablesDashBoard.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MainVar,
            this.WaitTime});
            this.lvVariablesDashBoard.Location = new System.Drawing.Point(148, 3);
            this.lvVariablesDashBoard.Name = "lvVariablesDashBoard";
            this.lvVariablesDashBoard.Size = new System.Drawing.Size(218, 97);
            this.lvVariablesDashBoard.TabIndex = 9;
            this.lvVariablesDashBoard.UseCompatibleStateImageBehavior = false;
            this.lvVariablesDashBoard.View = System.Windows.Forms.View.Details;
            // 
            // MainVar
            // 
            this.MainVar.Text = "Name";
            this.MainVar.Width = 124;
            // 
            // WaitTime
            // 
            this.WaitTime.Text = "Wait Time";
            this.WaitTime.Width = 89;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Setting";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnCheck);
            this.panel4.Controls.Add(this.btnExport);
            this.panel4.Controls.Add(this.lvPreview);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 342);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1227, 320);
            this.panel4.TabIndex = 3;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(106, 7);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 8;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(796, 281);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 7;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lvPreview
            // 
            this.lvPreview.Location = new System.Drawing.Point(12, 30);
            this.lvPreview.Name = "lvPreview";
            this.lvPreview.Size = new System.Drawing.Size(768, 274);
            this.lvPreview.TabIndex = 6;
            this.lvPreview.UseCompatibleStateImageBehavior = false;
            this.lvPreview.View = System.Windows.Forms.View.Details;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Preview";
            // 
            // btnAddTime
            // 
            this.btnAddTime.Location = new System.Drawing.Point(16, 41);
            this.btnAddTime.Name = "btnAddTime";
            this.btnAddTime.Size = new System.Drawing.Size(75, 23);
            this.btnAddTime.TabIndex = 12;
            this.btnAddTime.Text = "Add Time";
            this.btnAddTime.UseVisualStyleBackColor = true;
            this.btnAddTime.Click += new System.EventHandler(this.btnAddTime_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 662);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnErrorInfo.ResumeLayout(false);
            this.pnErrorInfo.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbCreated;
        private System.Windows.Forms.Button btnInitEdit;
        private System.Windows.Forms.Button btnInitNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDashEdit;
        private System.Windows.Forms.Button btnDashNew;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.ListView lvPreview;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbVarCount;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnAddtoMain;
        private System.Windows.Forms.CheckBox chbErrorCheck;
        private System.Windows.Forms.ListView lvVariablesDashBoard;
        private System.Windows.Forms.ColumnHeader MainVar;
        private System.Windows.Forms.ColumnHeader WaitTime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnErrorInfo;
        private System.Windows.Forms.TextBox tbxWaitTime;
        private System.Windows.Forms.TextBox tbxRepeat;
        private System.Windows.Forms.TextBox tbxFileLocation;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxFileName;
        private System.Windows.Forms.ListView lvDash;
        private System.Windows.Forms.Button btnAddTime;
    }
}