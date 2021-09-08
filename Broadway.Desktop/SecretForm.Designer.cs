
namespace Broadway.Desktop
{
    partial class SecretForm
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
            this.NameText = new System.Windows.Forms.TextBox();
            this.EmailText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.ConnectionText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TestStringText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(125, 42);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(362, 26);
            this.NameText.TabIndex = 1;
            // 
            // EmailText
            // 
            this.EmailText.Location = new System.Drawing.Point(125, 90);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(362, 26);
            this.EmailText.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(364, 345);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(123, 42);
            this.UpdateBtn.TabIndex = 4;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // ConnectionText
            // 
            this.ConnectionText.Location = new System.Drawing.Point(125, 168);
            this.ConnectionText.Name = "ConnectionText";
            this.ConnectionText.Size = new System.Drawing.Size(835, 26);
            this.ConnectionText.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "ConnectionString";
            // 
            // TestStringText
            // 
            this.TestStringText.Location = new System.Drawing.Point(125, 247);
            this.TestStringText.Name = "TestStringText";
            this.TestStringText.Size = new System.Drawing.Size(362, 26);
            this.TestStringText.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "TestString";
            // 
            // SecretForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TestStringText);
            this.Controls.Add(this.ConnectionText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.EmailText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.label1);
            this.Name = "SecretForm";
            this.Text = "SecretForm";
            this.Load += new System.EventHandler(this.SecretForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.TextBox ConnectionText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TestStringText;
        private System.Windows.Forms.Label label4;
    }
}