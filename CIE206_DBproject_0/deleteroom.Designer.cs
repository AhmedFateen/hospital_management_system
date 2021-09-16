
namespace CIE206_DBproject_0
{
    partial class deleteroom
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
            this.roomidtextBox = new System.Windows.Forms.TextBox();
            this.deleteroombutton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // roomidtextBox
            // 
            this.roomidtextBox.Location = new System.Drawing.Point(162, 21);
            this.roomidtextBox.Name = "roomidtextBox";
            this.roomidtextBox.Size = new System.Drawing.Size(135, 22);
            this.roomidtextBox.TabIndex = 44;
            // 
            // deleteroombutton
            // 
            this.deleteroombutton.Location = new System.Drawing.Point(333, 10);
            this.deleteroombutton.Name = "deleteroombutton";
            this.deleteroombutton.Size = new System.Drawing.Size(229, 44);
            this.deleteroombutton.TabIndex = 43;
            this.deleteroombutton.Text = "delete room";
            this.deleteroombutton.UseVisualStyleBackColor = true;
            this.deleteroombutton.Click += new System.EventHandler(this.deleteroombutton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 17);
            this.label9.TabIndex = 42;
            this.label9.Text = "room ID";
            // 
            // deleteroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 78);
            this.Controls.Add(this.roomidtextBox);
            this.Controls.Add(this.deleteroombutton);
            this.Controls.Add(this.label9);
            this.Name = "deleteroom";
            this.Text = "delete room";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox roomidtextBox;
        private System.Windows.Forms.Button deleteroombutton;
        private System.Windows.Forms.Label label9;
    }
}