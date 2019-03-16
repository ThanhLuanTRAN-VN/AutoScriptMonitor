namespace PiMonitor
{
    partial class NewVariable
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
            this.cbxNormalChoix = new System.Windows.Forms.ComboBox();
            this.CbxTableauChoix = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LbName = new System.Windows.Forms.Label();
            this.btxNormalAdd = new System.Windows.Forms.Button();
            this.btxTableauAdd = new System.Windows.Forms.Button();
            this.tbxNormal = new System.Windows.Forms.TextBox();
            this.tbxTableau = new System.Windows.Forms.TextBox();
            this.lbNormalDescription = new System.Windows.Forms.Label();
            this.tbxPreview = new System.Windows.Forms.TextBox();
            this.lbTableauDesctiption = new System.Windows.Forms.Label();
            this.lvVarContents = new System.Windows.Forms.ListView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxNormalChoix
            // 
            this.cbxNormalChoix.FormattingEnabled = true;
            this.cbxNormalChoix.Location = new System.Drawing.Point(12, 86);
            this.cbxNormalChoix.Name = "cbxNormalChoix";
            this.cbxNormalChoix.Size = new System.Drawing.Size(121, 21);
            this.cbxNormalChoix.TabIndex = 0;
            this.cbxNormalChoix.SelectedIndexChanged += new System.EventHandler(this.cbxNormalChoix_SelectedIndexChanged);
            // 
            // CbxTableauChoix
            // 
            this.CbxTableauChoix.FormattingEnabled = true;
            this.CbxTableauChoix.Location = new System.Drawing.Point(12, 146);
            this.CbxTableauChoix.Name = "CbxTableauChoix";
            this.CbxTableauChoix.Size = new System.Drawing.Size(121, 21);
            this.CbxTableauChoix.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Normal Additional Choix";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tableau Additional Choix";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(263, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "New Variable :";
            // 
            // LbName
            // 
            this.LbName.AutoSize = true;
            this.LbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbName.Location = new System.Drawing.Point(420, 13);
            this.LbName.Name = "LbName";
            this.LbName.Size = new System.Drawing.Size(68, 25);
            this.LbName.TabIndex = 5;
            this.LbName.Text = "Name";
            // 
            // btxNormalAdd
            // 
            this.btxNormalAdd.Location = new System.Drawing.Point(859, 84);
            this.btxNormalAdd.Name = "btxNormalAdd";
            this.btxNormalAdd.Size = new System.Drawing.Size(75, 23);
            this.btxNormalAdd.TabIndex = 6;
            this.btxNormalAdd.Text = "Add";
            this.btxNormalAdd.UseVisualStyleBackColor = true;
            this.btxNormalAdd.Click += new System.EventHandler(this.btxNormalAdd_Click);
            // 
            // btxTableauAdd
            // 
            this.btxTableauAdd.Location = new System.Drawing.Point(859, 146);
            this.btxTableauAdd.Name = "btxTableauAdd";
            this.btxTableauAdd.Size = new System.Drawing.Size(75, 23);
            this.btxTableauAdd.TabIndex = 7;
            this.btxTableauAdd.Text = "Add";
            this.btxTableauAdd.UseVisualStyleBackColor = true;
            // 
            // tbxNormal
            // 
            this.tbxNormal.Location = new System.Drawing.Point(162, 87);
            this.tbxNormal.Name = "tbxNormal";
            this.tbxNormal.Size = new System.Drawing.Size(492, 20);
            this.tbxNormal.TabIndex = 8;
            this.tbxNormal.TextChanged += new System.EventHandler(this.tbxNormal_TextChanged);
            // 
            // tbxTableau
            // 
            this.tbxTableau.Location = new System.Drawing.Point(162, 147);
            this.tbxTableau.Name = "tbxTableau";
            this.tbxTableau.Size = new System.Drawing.Size(492, 20);
            this.tbxTableau.TabIndex = 9;
            // 
            // lbNormalDescription
            // 
            this.lbNormalDescription.AutoSize = true;
            this.lbNormalDescription.Location = new System.Drawing.Point(159, 71);
            this.lbNormalDescription.Name = "lbNormalDescription";
            this.lbNormalDescription.Size = new System.Drawing.Size(99, 13);
            this.lbNormalDescription.TabIndex = 10;
            this.lbNormalDescription.Text = "Normal Descritption";
            // 
            // tbxPreview
            // 
            this.tbxPreview.Location = new System.Drawing.Point(12, 206);
            this.tbxPreview.Name = "tbxPreview";
            this.tbxPreview.Size = new System.Drawing.Size(924, 20);
            this.tbxPreview.TabIndex = 11;
            // 
            // lbTableauDesctiption
            // 
            this.lbTableauDesctiption.AutoSize = true;
            this.lbTableauDesctiption.Location = new System.Drawing.Point(159, 131);
            this.lbTableauDesctiption.Name = "lbTableauDesctiption";
            this.lbTableauDesctiption.Size = new System.Drawing.Size(105, 13);
            this.lbTableauDesctiption.TabIndex = 15;
            this.lbTableauDesctiption.Text = "Tableau Descritption";
            // 
            // lvVarContents
            // 
            this.lvVarContents.FullRowSelect = true;
            this.lvVarContents.Location = new System.Drawing.Point(12, 265);
            this.lvVarContents.Name = "lvVarContents";
            this.lvVarContents.Size = new System.Drawing.Size(782, 284);
            this.lvVarContents.TabIndex = 16;
            this.lvVarContents.UseCompatibleStateImageBehavior = false;
            this.lvVarContents.View = System.Windows.Forms.View.List;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(800, 265);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(134, 46);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(800, 384);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(134, 46);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(800, 503);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(134, 46);
            this.btnCreate.TabIndex = 19;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // NewVariable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 605);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lvVarContents);
            this.Controls.Add(this.lbTableauDesctiption);
            this.Controls.Add(this.tbxPreview);
            this.Controls.Add(this.lbNormalDescription);
            this.Controls.Add(this.tbxTableau);
            this.Controls.Add(this.tbxNormal);
            this.Controls.Add(this.btxTableauAdd);
            this.Controls.Add(this.btxNormalAdd);
            this.Controls.Add(this.LbName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbxTableauChoix);
            this.Controls.Add(this.cbxNormalChoix);
            this.Name = "NewVariable";
            this.Text = "NewVariable";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxNormalChoix;
        private System.Windows.Forms.ComboBox CbxTableauChoix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LbName;
        private System.Windows.Forms.Button btxNormalAdd;
        private System.Windows.Forms.Button btxTableauAdd;
        private System.Windows.Forms.TextBox tbxNormal;
        private System.Windows.Forms.TextBox tbxTableau;
        private System.Windows.Forms.Label lbNormalDescription;
        private System.Windows.Forms.TextBox tbxPreview;
        private System.Windows.Forms.Label lbTableauDesctiption;
        private System.Windows.Forms.ListView lvVarContents;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCreate;
    }
}