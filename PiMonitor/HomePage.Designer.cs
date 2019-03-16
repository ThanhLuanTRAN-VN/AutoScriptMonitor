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
            this.chbErrorCheck = new System.Windows.Forms.CheckBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.MainVar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WaitTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.lvPreview = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbCreated);
            this.panel1.Controls.Add(this.btnInitEdit);
            this.panel1.Controls.Add(this.btnInitNew);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1636, 132);
            this.panel1.TabIndex = 0;
            // 
            // lbCreated
            // 
            this.lbCreated.AutoSize = true;
            this.lbCreated.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreated.Location = new System.Drawing.Point(80, 11);
            this.lbCreated.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCreated.Name = "lbCreated";
            this.lbCreated.Size = new System.Drawing.Size(144, 25);
            this.lbCreated.TabIndex = 4;
            this.lbCreated.Text = "Variable name:";
            // 
            // btnInitEdit
            // 
            this.btnInitEdit.Location = new System.Drawing.Point(9, 88);
            this.btnInitEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInitEdit.Name = "btnInitEdit";
            this.btnInitEdit.Size = new System.Drawing.Size(100, 28);
            this.btnInitEdit.TabIndex = 2;
            this.btnInitEdit.Text = "Edit";
            this.btnInitEdit.UseVisualStyleBackColor = true;
            this.btnInitEdit.Click += new System.EventHandler(this.btnInitEdit_Click);
            // 
            // btnInitNew
            // 
            this.btnInitNew.Location = new System.Drawing.Point(9, 52);
            this.btnInitNew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInitNew.Name = "btnInitNew";
            this.btnInitNew.Size = new System.Drawing.Size(100, 28);
            this.btnInitNew.TabIndex = 1;
            this.btnInitNew.Text = "New";
            this.btnInitNew.UseVisualStyleBackColor = true;
            this.btnInitNew.Click += new System.EventHandler(this.btnInitNew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
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
            this.panel2.Location = new System.Drawing.Point(0, 132);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1636, 160);
            this.panel2.TabIndex = 1;
            // 
            // btnAddtoMain
            // 
            this.btnAddtoMain.Location = new System.Drawing.Point(621, 31);
            this.btnAddtoMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddtoMain.Name = "btnAddtoMain";
            this.btnAddtoMain.Size = new System.Drawing.Size(173, 28);
            this.btnAddtoMain.TabIndex = 7;
            this.btnAddtoMain.Text = "Add To Main Variable";
            this.btnAddtoMain.UseVisualStyleBackColor = true;
            // 
            // lbVarCount
            // 
            this.lbVarCount.AutoSize = true;
            this.lbVarCount.Location = new System.Drawing.Point(17, 87);
            this.lbVarCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbVarCount.Name = "lbVarCount";
            this.lbVarCount.Size = new System.Drawing.Size(141, 17);
            this.lbVarCount.TabIndex = 6;
            this.lbVarCount.Text = "You have 0 variables";
            // 
            // lvDash
            // 
            this.lvDash.Location = new System.Drawing.Point(417, 9);
            this.lvDash.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvDash.Name = "lvDash";
            this.lvDash.Size = new System.Drawing.Size(160, 125);
            this.lvDash.TabIndex = 5;
            this.lvDash.UseCompatibleStateImageBehavior = false;
            this.lvDash.View = System.Windows.Forms.View.List;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(232, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "not implement";
            // 
            // btnDashEdit
            // 
            this.btnDashEdit.Location = new System.Drawing.Point(228, 50);
            this.btnDashEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDashEdit.Name = "btnDashEdit";
            this.btnDashEdit.Size = new System.Drawing.Size(100, 28);
            this.btnDashEdit.TabIndex = 3;
            this.btnDashEdit.Text = "Edit";
            this.btnDashEdit.UseVisualStyleBackColor = true;
            // 
            // btnDashNew
            // 
            this.btnDashNew.Location = new System.Drawing.Point(16, 50);
            this.btnDashNew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDashNew.Name = "btnDashNew";
            this.btnDashNew.Size = new System.Drawing.Size(100, 28);
            this.btnDashNew.TabIndex = 2;
            this.btnDashNew.Text = "New";
            this.btnDashNew.UseVisualStyleBackColor = true;
            this.btnDashNew.Click += new System.EventHandler(this.btnDashNew_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Dashboard";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chbErrorCheck);
            this.panel3.Controls.Add(this.listView1);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 292);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1636, 523);
            this.panel3.TabIndex = 2;
            // 
            // chbErrorCheck
            // 
            this.chbErrorCheck.AutoSize = true;
            this.chbErrorCheck.Location = new System.Drawing.Point(756, 7);
            this.chbErrorCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chbErrorCheck.Name = "chbErrorCheck";
            this.chbErrorCheck.Size = new System.Drawing.Size(160, 21);
            this.chbErrorCheck.TabIndex = 10;
            this.chbErrorCheck.Text = "Loading Error Check";
            this.chbErrorCheck.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MainVar,
            this.WaitTime});
            this.listView1.Location = new System.Drawing.Point(443, 4);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(289, 118);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // MainVar
            // 
            this.MainVar.Text = "Name";
            this.MainVar.Width = 109;
            // 
            // WaitTime
            // 
            this.WaitTime.Text = "Wait Time";
            this.WaitTime.Width = 104;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(232, 28);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "not implement";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
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
            this.panel4.Location = new System.Drawing.Point(0, 421);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1636, 394);
            this.panel4.TabIndex = 3;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(141, 9);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(100, 28);
            this.btnCheck.TabIndex = 8;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(1061, 346);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(100, 28);
            this.btnExport.TabIndex = 7;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lvPreview
            // 
            this.lvPreview.Location = new System.Drawing.Point(16, 37);
            this.lvPreview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvPreview.Name = "lvPreview";
            this.lvPreview.Size = new System.Drawing.Size(1023, 336);
            this.lvPreview.TabIndex = 6;
            this.lvPreview.UseCompatibleStateImageBehavior = false;
            this.lvPreview.View = System.Windows.Forms.View.Details;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Preview";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1636, 815);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.ListView lvDash;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDashEdit;
        private System.Windows.Forms.Button btnDashNew;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.ListView lvPreview;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbVarCount;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnAddtoMain;
        private System.Windows.Forms.CheckBox chbErrorCheck;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader MainVar;
        private System.Windows.Forms.ColumnHeader WaitTime;
    }
}