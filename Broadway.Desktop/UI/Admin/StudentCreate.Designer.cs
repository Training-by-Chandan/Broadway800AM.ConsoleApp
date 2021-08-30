
namespace Broadway.Desktop.UI.Admin
{
    partial class StudentCreate
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelid = new System.Windows.Forms.Label();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.ConfirmText = new System.Windows.Forms.TextBox();
            this.Confirmlbl = new System.Windows.Forms.Label();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.DOBDate = new System.Windows.Forms.DateTimePicker();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.EmailText = new System.Windows.Forms.TextBox();
            this.AddressText = new System.Windows.Forms.TextBox();
            this.NameText = new System.Windows.Forms.TextBox();
            this.Emaillbl = new System.Windows.Forms.Label();
            this.Passwordlbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.studentDataGrid = new System.Windows.Forms.DataGridView();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ResetBtn);
            this.groupBox1.Controls.Add(this.labelid);
            this.groupBox1.Controls.Add(this.DeleteBtn);
            this.groupBox1.Controls.Add(this.EditBtn);
            this.groupBox1.Controls.Add(this.ConfirmText);
            this.groupBox1.Controls.Add(this.Confirmlbl);
            this.groupBox1.Controls.Add(this.ClearBtn);
            this.groupBox1.Controls.Add(this.CreateBtn);
            this.groupBox1.Controls.Add(this.DOBDate);
            this.groupBox1.Controls.Add(this.PasswordText);
            this.groupBox1.Controls.Add(this.EmailText);
            this.groupBox1.Controls.Add(this.AddressText);
            this.groupBox1.Controls.Add(this.NameText);
            this.groupBox1.Controls.Add(this.Emaillbl);
            this.groupBox1.Controls.Add(this.Passwordlbl);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1419, 336);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student";
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(717, 88);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(0, 25);
            this.labelid.TabIndex = 17;
            this.labelid.Visible = false;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(1028, 268);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(155, 49);
            this.DeleteBtn.TabIndex = 16;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Visible = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(1226, 268);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(155, 49);
            this.EditBtn.TabIndex = 15;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Visible = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // ConfirmText
            // 
            this.ConfirmText.Location = new System.Drawing.Point(949, 206);
            this.ConfirmText.Name = "ConfirmText";
            this.ConfirmText.PasswordChar = '*';
            this.ConfirmText.Size = new System.Drawing.Size(431, 30);
            this.ConfirmText.TabIndex = 14;
            // 
            // Confirmlbl
            // 
            this.Confirmlbl.AutoSize = true;
            this.Confirmlbl.Location = new System.Drawing.Point(717, 209);
            this.Confirmlbl.Name = "Confirmlbl";
            this.Confirmlbl.Size = new System.Drawing.Size(171, 25);
            this.Confirmlbl.TabIndex = 13;
            this.Confirmlbl.Text = "Confirm Password";
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(1028, 268);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(155, 49);
            this.ClearBtn.TabIndex = 12;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(1226, 268);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(155, 49);
            this.CreateBtn.TabIndex = 11;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // DOBDate
            // 
            this.DOBDate.Location = new System.Drawing.Point(949, 37);
            this.DOBDate.Name = "DOBDate";
            this.DOBDate.Size = new System.Drawing.Size(431, 30);
            this.DOBDate.TabIndex = 10;
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(191, 203);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.PasswordChar = '*';
            this.PasswordText.Size = new System.Drawing.Size(493, 30);
            this.PasswordText.TabIndex = 9;
            // 
            // EmailText
            // 
            this.EmailText.Location = new System.Drawing.Point(191, 159);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(493, 30);
            this.EmailText.TabIndex = 8;
            // 
            // AddressText
            // 
            this.AddressText.Location = new System.Drawing.Point(191, 83);
            this.AddressText.Name = "AddressText";
            this.AddressText.Size = new System.Drawing.Size(493, 30);
            this.AddressText.TabIndex = 7;
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(191, 36);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(493, 30);
            this.NameText.TabIndex = 5;
            // 
            // Emaillbl
            // 
            this.Emaillbl.AutoSize = true;
            this.Emaillbl.Location = new System.Drawing.Point(21, 162);
            this.Emaillbl.Name = "Emaillbl";
            this.Emaillbl.Size = new System.Drawing.Size(60, 25);
            this.Emaillbl.TabIndex = 4;
            this.Emaillbl.Text = "Email";
            // 
            // Passwordlbl
            // 
            this.Passwordlbl.AutoSize = true;
            this.Passwordlbl.Location = new System.Drawing.Point(21, 206);
            this.Passwordlbl.Name = "Passwordlbl";
            this.Passwordlbl.Size = new System.Drawing.Size(98, 25);
            this.Passwordlbl.TabIndex = 3;
            this.Passwordlbl.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(717, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date of Birth";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // studentDataGrid
            // 
            this.studentDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDataGrid.Location = new System.Drawing.Point(12, 451);
            this.studentDataGrid.Name = "studentDataGrid";
            this.studentDataGrid.RowHeadersWidth = 62;
            this.studentDataGrid.RowTemplate.Height = 28;
            this.studentDataGrid.Size = new System.Drawing.Size(1197, 435);
            this.studentDataGrid.TabIndex = 1;
            this.studentDataGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.studentDataGrid_MouseClick);
            this.studentDataGrid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.studentDataGrid_MouseDoubleClick);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(961, 377);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(248, 58);
            this.SearchBtn.TabIndex = 2;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // SearchText
            // 
            this.SearchText.Location = new System.Drawing.Point(12, 391);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(920, 30);
            this.SearchText.TabIndex = 3;
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(722, 268);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(244, 49);
            this.ResetBtn.TabIndex = 18;
            this.ResetBtn.Text = "Reset Password";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Visible = false;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // StudentCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 905);
            this.Controls.Add(this.SearchText);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.studentDataGrid);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StudentCreate";
            this.Text = "Student Managment";
            this.Load += new System.EventHandler(this.StudentCreate_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Emaillbl;
        private System.Windows.Forms.Label Passwordlbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ConfirmText;
        private System.Windows.Forms.Label Confirmlbl;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.DateTimePicker DOBDate;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.TextBox AddressText;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.DataGridView studentDataGrid;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Button ResetBtn;
    }
}