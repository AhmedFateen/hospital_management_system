
namespace CIE206_DBproject_0
{
    partial class deletepatient
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
            this.patientidtextBox = new System.Windows.Forms.TextBox();
            this.deletepatientbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "patient ID";
            // 
            // patientidtextBox
            // 
            this.patientidtextBox.Location = new System.Drawing.Point(134, 23);
            this.patientidtextBox.Name = "patientidtextBox";
            this.patientidtextBox.Size = new System.Drawing.Size(114, 22);
            this.patientidtextBox.TabIndex = 7;
            // 
            // deletepatientbutton
            // 
            this.deletepatientbutton.Location = new System.Drawing.Point(289, 12);
            this.deletepatientbutton.Name = "deletepatientbutton";
            this.deletepatientbutton.Size = new System.Drawing.Size(229, 44);
            this.deletepatientbutton.TabIndex = 6;
            this.deletepatientbutton.Text = "delete patient basic info";
            this.deletepatientbutton.UseVisualStyleBackColor = true;
            this.deletepatientbutton.Click += new System.EventHandler(this.deletepatientbutton_Click);
            // 
            // deletepatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 70);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.patientidtextBox);
            this.Controls.Add(this.deletepatientbutton);
            this.Name = "deletepatient";
            this.Text = "delete patient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox patientidtextBox;
        private System.Windows.Forms.Button deletepatientbutton;
    }
}