
namespace Broadway.Desktop.UI.Admin
{
    partial class SubjectManagement
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
            this.label1 = new System.Windows.Forms.Label();
            this.SubCodeText = new System.Windows.Forms.TextBox();
            this.SubNameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ClassCmb = new System.Windows.Forms.ComboBox();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.SubjectGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject Code";
            // 
            // SubCodeText
            // 
            this.SubCodeText.Location = new System.Drawing.Point(217, 53);
            this.SubCodeText.Name = "SubCodeText";
            this.SubCodeText.Size = new System.Drawing.Size(276, 30);
            this.SubCodeText.TabIndex = 1;
            // 
            // SubNameText
            // 
            this.SubNameText.Location = new System.Drawing.Point(723, 56);
            this.SubNameText.Name = "SubNameText";
            this.SubNameText.Size = new System.Drawing.Size(276, 30);
            this.SubNameText.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(547, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Subject Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Class";
            // 
            // ClassCmb
            // 
            this.ClassCmb.FormattingEnabled = true;
            this.ClassCmb.Location = new System.Drawing.Point(217, 114);
            this.ClassCmb.Name = "ClassCmb";
            this.ClassCmb.Size = new System.Drawing.Size(276, 33);
            this.ClassCmb.TabIndex = 5;
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(798, 185);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(200, 75);
            this.CreateBtn.TabIndex = 6;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(552, 185);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(200, 75);
            this.ClearBtn.TabIndex = 7;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            // 
            // SubjectGrid
            // 
            this.SubjectGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubjectGrid.Location = new System.Drawing.Point(42, 288);
            this.SubjectGrid.Name = "SubjectGrid";
            this.SubjectGrid.RowHeadersWidth = 62;
            this.SubjectGrid.RowTemplate.Height = 28;
            this.SubjectGrid.Size = new System.Drawing.Size(957, 332);
            this.SubjectGrid.TabIndex = 8;
            // 
            // SubjectManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 748);
            this.Controls.Add(this.SubjectGrid);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.ClassCmb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SubNameText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SubCodeText);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SubjectManagement";
            this.Text = "SubjectManagement";
            this.Load += new System.EventHandler(this.SubjectManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SubjectGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SubCodeText;
        private System.Windows.Forms.TextBox SubNameText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ClassCmb;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.DataGridView SubjectGrid;
    }
}