
namespace CIE206_DBproject_0
{
    partial class deletecase
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
            this.deletecasetextBox = new System.Windows.Forms.TextBox();
            this.deletecasebutton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // deletecasetextBox
            // 
            this.deletecasetextBox.Location = new System.Drawing.Point(105, 20);
            this.deletecasetextBox.Name = "deletecasetextBox";
            this.deletecasetextBox.Size = new System.Drawing.Size(135, 22);
            this.deletecasetextBox.TabIndex = 47;
            this.deletecasetextBox.TextChanged += new System.EventHandler(this.deletecasetextBox_TextChanged);
            // 
            // deletecasebutton
            // 
            this.deletecasebutton.Location = new System.Drawing.Point(325, 12);
            this.deletecasebutton.Name = "deletecasebutton";
            this.deletecasebutton.Size = new System.Drawing.Size(157, 44);
            this.deletecasebutton.TabIndex = 46;
            this.deletecasebutton.Text = "delete case";
            this.deletecasebutton.UseVisualStyleBackColor = true;
            this.deletecasebutton.Click += new System.EventHandler(this.deletecasebutton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 17);
            this.label9.TabIndex = 45;
            this.label9.Text = "case ID";
            // 
            // deletecase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 73);
            this.Controls.Add(this.deletecasetextBox);
            this.Controls.Add(this.deletecasebutton);
            this.Controls.Add(this.label9);
            this.Name = "deletecase";
            this.Text = "delete case";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox deletecasetextBox;
        private System.Windows.Forms.Button deletecasebutton;
        private System.Windows.Forms.Label label9;
    }
}