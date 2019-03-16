namespace PiMonitor
{
    partial class MainPage
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
            this.cbxListVar = new System.Windows.Forms.ComboBox();
            this.btnNewVar = new System.Windows.Forms.Button();
            this.lbVariables = new System.Windows.Forms.Label();
            this.btnEditVariable = new System.Windows.Forms.Button();
            this.cbxListMainVar = new System.Windows.Forms.ComboBox();
            this.lbMainVariables = new System.Windows.Forms.Label();
            this.btnAddToMainVar = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.lvScript = new System.Windows.Forms.ListView();
            this.btnCheckScript = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxListVar
            // 
            this.cbxListVar.FormattingEnabled = true;
            this.cbxListVar.Location = new System.Drawing.Point(12, 25);
            this.cbxListVar.Name = "cbxListVar";
            this.cbxListVar.Size = new System.Drawing.Size(121, 21);
            this.cbxListVar.TabIndex = 1;
            // 
            // btnNewVar
            // 
            this.btnNewVar.Location = new System.Drawing.Point(170, 23);
            this.btnNewVar.Name = "btnNewVar";
            this.btnNewVar.Size = new System.Drawing.Size(188, 23);
            this.btnNewVar.TabIndex = 2;
            this.btnNewVar.Text = "Add New Variable";
            this.btnNewVar.UseVisualStyleBackColor = true;
            this.btnNewVar.Click += new System.EventHandler(this.btnNewVar_Click);
            // 
            // lbVariables
            // 
            this.lbVariables.AutoSize = true;
            this.lbVariables.Location = new System.Drawing.Point(12, 9);
            this.lbVariables.Name = "lbVariables";
            this.lbVariables.Size = new System.Drawing.Size(107, 13);
            this.lbVariables.TabIndex = 3;
            this.lbVariables.Text = "You have 0 variables";
            // 
            // btnEditVariable
            // 
            this.btnEditVariable.Location = new System.Drawing.Point(395, 25);
            this.btnEditVariable.Name = "btnEditVariable";
            this.btnEditVariable.Size = new System.Drawing.Size(188, 23);
            this.btnEditVariable.TabIndex = 4;
            this.btnEditVariable.Text = "Edit Variable";
            this.btnEditVariable.UseVisualStyleBackColor = true;
            // 
            // cbxListMainVar
            // 
            this.cbxListMainVar.FormattingEnabled = true;
            this.cbxListMainVar.Location = new System.Drawing.Point(15, 83);
            this.cbxListMainVar.Name = "cbxListMainVar";
            this.cbxListMainVar.Size = new System.Drawing.Size(121, 21);
            this.cbxListMainVar.TabIndex = 6;
            // 
            // lbMainVariables
            // 
            this.lbMainVariables.AutoSize = true;
            this.lbMainVariables.Location = new System.Drawing.Point(12, 67);
            this.lbMainVariables.Name = "lbMainVariables";
            this.lbMainVariables.Size = new System.Drawing.Size(132, 13);
            this.lbMainVariables.TabIndex = 7;
            this.lbMainVariables.Text = "You have 0 main variables";
            // 
            // btnAddToMainVar
            // 
            this.btnAddToMainVar.Location = new System.Drawing.Point(620, 22);
            this.btnAddToMainVar.Name = "btnAddToMainVar";
            this.btnAddToMainVar.Size = new System.Drawing.Size(188, 23);
            this.btnAddToMainVar.TabIndex = 8;
            this.btnAddToMainVar.Text = "Add To Main Variables";
            this.btnAddToMainVar.UseVisualStyleBackColor = true;
            this.btnAddToMainVar.Click += new System.EventHandler(this.btnAddToMainVar_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(965, 144);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(75, 23);
            this.btnSaveFile.TabIndex = 9;
            this.btnSaveFile.Text = "Save File";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // lvScript
            // 
            this.lvScript.FullRowSelect = true;
            this.lvScript.Location = new System.Drawing.Point(45, 241);
            this.lvScript.Name = "lvScript";
            this.lvScript.Size = new System.Drawing.Size(886, 306);
            this.lvScript.TabIndex = 10;
            this.lvScript.UseCompatibleStateImageBehavior = false;
            this.lvScript.View = System.Windows.Forms.View.Details;
            // 
            // btnCheckScript
            // 
            this.btnCheckScript.Location = new System.Drawing.Point(675, 196);
            this.btnCheckScript.Name = "btnCheckScript";
            this.btnCheckScript.Size = new System.Drawing.Size(109, 23);
            this.btnCheckScript.TabIndex = 11;
            this.btnCheckScript.Text = "Check Script";
            this.btnCheckScript.UseVisualStyleBackColor = true;
            this.btnCheckScript.Click += new System.EventHandler(this.btnCheckScript_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 627);
            this.Controls.Add(this.btnCheckScript);
            this.Controls.Add(this.lvScript);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.btnAddToMainVar);
            this.Controls.Add(this.lbMainVariables);
            this.Controls.Add(this.cbxListMainVar);
            this.Controls.Add(this.btnEditVariable);
            this.Controls.Add(this.lbVariables);
            this.Controls.Add(this.btnNewVar);
            this.Controls.Add(this.cbxListVar);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxListVar;
        private System.Windows.Forms.Button btnNewVar;
        private System.Windows.Forms.Label lbVariables;
        private System.Windows.Forms.Button btnEditVariable;
        private System.Windows.Forms.ComboBox cbxListMainVar;
        private System.Windows.Forms.Label lbMainVariables;
        private System.Windows.Forms.Button btnAddToMainVar;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.ListView lvScript;
        private System.Windows.Forms.Button btnCheckScript;
    }
}