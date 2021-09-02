
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.otherGender = new System.Windows.Forms.RadioButton();
            this.femaleGender = new System.Windows.Forms.RadioButton();
            this.maleGender = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.ResetBtn = new System.Windows.Forms.Button();
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
            this.label5 = new System.Windows.Forms.Label();
            this.ClassCmb = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ClassCmb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label4);
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
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1216, 354);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.otherGender);
            this.groupBox2.Controls.Add(this.femaleGender);
            this.groupBox2.Controls.Add(this.maleGender);
            this.groupBox2.Location = new System.Drawing.Point(813, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 60);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // otherGender
            // 
            this.otherGender.AutoSize = true;
            this.otherGender.Location = new System.Drawing.Point(270, 31);
            this.otherGender.Name = "otherGender";
            this.otherGender.Size = new System.Drawing.Size(96, 29);
            this.otherGender.TabIndex = 25;
            this.otherGender.TabStop = true;
            this.otherGender.Text = "Others";
            this.otherGender.UseVisualStyleBackColor = true;
            // 
            // femaleGender
            // 
            this.femaleGender.AutoSize = true;
            this.femaleGender.Location = new System.Drawing.Point(150, 31);
            this.femaleGender.Name = "femaleGender";
            this.femaleGender.Size = new System.Drawing.Size(102, 29);
            this.femaleGender.TabIndex = 24;
            this.femaleGender.TabStop = true;
            this.femaleGender.Text = "Female";
            this.femaleGender.UseVisualStyleBackColor = true;
            // 
            // maleGender
            // 
            this.maleGender.AutoSize = true;
            this.maleGender.Location = new System.Drawing.Point(22, 31);
            this.maleGender.Name = "maleGender";
            this.maleGender.Size = new System.Drawing.Size(80, 29);
            this.maleGender.TabIndex = 23;
            this.maleGender.TabStop = true;
            this.maleGender.Text = "Male";
            this.maleGender.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(615, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Gender";
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(619, 292);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(209, 42);
            this.ResetBtn.TabIndex = 18;
            this.ResetBtn.Text = "Reset Password";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Visible = false;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(615, 76);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(0, 25);
            this.labelid.TabIndex = 17;
            this.labelid.Visible = false;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(881, 292);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(133, 42);
            this.DeleteBtn.TabIndex = 16;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Visible = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(1051, 292);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(133, 42);
            this.EditBtn.TabIndex = 15;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Visible = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // ConfirmText
            // 
            this.ConfirmText.Location = new System.Drawing.Point(813, 239);
            this.ConfirmText.Name = "ConfirmText";
            this.ConfirmText.PasswordChar = '*';
            this.ConfirmText.Size = new System.Drawing.Size(370, 30);
            this.ConfirmText.TabIndex = 14;
            // 
            // Confirmlbl
            // 
            this.Confirmlbl.AutoSize = true;
            this.Confirmlbl.Location = new System.Drawing.Point(615, 241);
            this.Confirmlbl.Name = "Confirmlbl";
            this.Confirmlbl.Size = new System.Drawing.Size(171, 25);
            this.Confirmlbl.TabIndex = 13;
            this.Confirmlbl.Text = "Confirm Password";
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(881, 292);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(133, 42);
            this.ClearBtn.TabIndex = 12;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(1051, 292);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(133, 42);
            this.CreateBtn.TabIndex = 11;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // DOBDate
            // 
            this.DOBDate.Location = new System.Drawing.Point(813, 32);
            this.DOBDate.Name = "DOBDate";
            this.DOBDate.Size = new System.Drawing.Size(370, 30);
            this.DOBDate.TabIndex = 10;
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(164, 236);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.PasswordChar = '*';
            this.PasswordText.Size = new System.Drawing.Size(423, 30);
            this.PasswordText.TabIndex = 9;
            // 
            // EmailText
            // 
            this.EmailText.Location = new System.Drawing.Point(164, 198);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(423, 30);
            this.EmailText.TabIndex = 8;
            // 
            // AddressText
            // 
            this.AddressText.Location = new System.Drawing.Point(164, 90);
            this.AddressText.Name = "AddressText";
            this.AddressText.Size = new System.Drawing.Size(423, 30);
            this.AddressText.TabIndex = 7;
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(164, 31);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(423, 30);
            this.NameText.TabIndex = 5;
            // 
            // Emaillbl
            // 
            this.Emaillbl.AutoSize = true;
            this.Emaillbl.Location = new System.Drawing.Point(18, 201);
            this.Emaillbl.Name = "Emaillbl";
            this.Emaillbl.Size = new System.Drawing.Size(60, 25);
            this.Emaillbl.TabIndex = 4;
            this.Emaillbl.Text = "Email";
            // 
            // Passwordlbl
            // 
            this.Passwordlbl.AutoSize = true;
            this.Passwordlbl.Location = new System.Drawing.Point(18, 239);
            this.Passwordlbl.Name = "Passwordlbl";
            this.Passwordlbl.Size = new System.Drawing.Size(98, 25);
            this.Passwordlbl.TabIndex = 3;
            this.Passwordlbl.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(615, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date of Birth";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // studentDataGrid
            // 
            this.studentDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDataGrid.Location = new System.Drawing.Point(10, 464);
            this.studentDataGrid.Name = "studentDataGrid";
            this.studentDataGrid.RowHeadersWidth = 62;
            this.studentDataGrid.RowTemplate.Height = 28;
            this.studentDataGrid.Size = new System.Drawing.Size(1026, 300);
            this.studentDataGrid.TabIndex = 1;
            this.studentDataGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.studentDataGrid_MouseClick);
            this.studentDataGrid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.studentDataGrid_MouseDoubleClick);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(824, 389);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(213, 50);
            this.SearchBtn.TabIndex = 2;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // SearchText
            // 
            this.SearchText.Location = new System.Drawing.Point(10, 401);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(789, 30);
            this.SearchText.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Class";
            // 
            // ClassCmb
            // 
            this.ClassCmb.FormattingEnabled = true;
            this.ClassCmb.Location = new System.Drawing.Point(164, 147);
            this.ClassCmb.Name = "ClassCmb";
            this.ClassCmb.Size = new System.Drawing.Size(423, 33);
            this.ClassCmb.TabIndex = 22;
            // 
            // StudentCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 780);
            this.Controls.Add(this.SearchText);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.studentDataGrid);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StudentCreate";
            this.Text = "Student Managment";
            this.Load += new System.EventHandler(this.StudentCreate_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton otherGender;
        private System.Windows.Forms.RadioButton femaleGender;
        private System.Windows.Forms.RadioButton maleGender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ClassCmb;
        private System.Windows.Forms.Label label5;
    }
}