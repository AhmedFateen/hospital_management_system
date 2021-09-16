
namespace CIE206_DBproject_0
{
    partial class deleteemployee
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
            this.label9 = new System.Windows.Forms.Label();
            this.deleteemployeebutton = new System.Windows.Forms.Button();
            this.employeeidtextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 17);
            this.label9.TabIndex = 38;
            this.label9.Text = "employee ID";
            // 
            // deleteemployeebutton
            // 
            this.deleteemployeebutton.Location = new System.Drawing.Point(323, 16);
            this.deleteemployeebutton.Name = "deleteemployeebutton";
            this.deleteemployeebutton.Size = new System.Drawing.Size(229, 44);
            this.deleteemployeebutton.TabIndex = 40;
            this.deleteemployeebutton.Text = "delete employee basic info";
            this.deleteemployeebutton.UseVisualStyleBackColor = true;
            this.deleteemployeebutton.Click += new System.EventHandler(this.deleteemployeebutton_Click);
            // 
            // employeeidtextBox
            // 
            this.employeeidtextBox.Location = new System.Drawing.Point(153, 27);
            this.employeeidtextBox.Name = "employeeidtextBox";
            this.employeeidtextBox.Size = new System.Drawing.Size(135, 22);
            this.employeeidtextBox.TabIndex = 41;
            // 
            // deleteemployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 81);
            this.Controls.Add(this.employeeidtextBox);
            this.Controls.Add(this.deleteemployeebutton);
            this.Controls.Add(this.label9);
            this.Name = "deleteemployee";
            this.Text = "delete employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button deleteemployeebutton;
        private System.Windows.Forms.TextBox employeeidtextBox;
    }
}