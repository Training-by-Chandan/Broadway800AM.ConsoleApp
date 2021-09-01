
namespace Broadway.Desktop.UI.Admin
{
    partial class ClassManagement
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
            this.ClassNameText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.classGrid = new System.Windows.Forms.DataGridView();
            this.studentGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.classGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Class";
            // 
            // ClassNameText
            // 
            this.ClassNameText.Location = new System.Drawing.Point(131, 48);
            this.ClassNameText.Name = "ClassNameText";
            this.ClassNameText.Size = new System.Drawing.Size(534, 26);
            this.ClassNameText.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(476, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(261, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 52);
            this.button2.TabIndex = 3;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // classGrid
            // 
            this.classGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classGrid.Location = new System.Drawing.Point(38, 280);
            this.classGrid.Name = "classGrid";
            this.classGrid.RowHeadersWidth = 51;
            this.classGrid.RowTemplate.Height = 24;
            this.classGrid.Size = new System.Drawing.Size(249, 240);
            this.classGrid.TabIndex = 4;
            this.classGrid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.classGrid_MouseDoubleClick);
            // 
            // studentGrid
            // 
            this.studentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentGrid.Location = new System.Drawing.Point(352, 280);
            this.studentGrid.Name = "studentGrid";
            this.studentGrid.RowHeadersWidth = 51;
            this.studentGrid.RowTemplate.Height = 24;
            this.studentGrid.Size = new System.Drawing.Size(731, 240);
            this.studentGrid.TabIndex = 5;
            // 
            // ClassManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 562);
            this.Controls.Add(this.studentGrid);
            this.Controls.Add(this.classGrid);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ClassNameText);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ClassManagement";
            this.Text = "ClassManagement";
            this.Load += new System.EventHandler(this.ClassManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ClassNameText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView classGrid;
        private System.Windows.Forms.DataGridView studentGrid;
    }
}