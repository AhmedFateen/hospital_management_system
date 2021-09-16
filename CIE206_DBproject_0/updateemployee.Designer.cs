
namespace CIE206_DBproject_0
{
    partial class updateemployee
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
            this.updatecasebutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.attributeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.viewcasetextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // updatecasebutton
            // 
            this.updatecasebutton.Location = new System.Drawing.Point(215, 175);
            this.updatecasebutton.Name = "updatecasebutton";
            this.updatecasebutton.Size = new System.Drawing.Size(134, 34);
            this.updatecasebutton.TabIndex = 104;
            this.updatecasebutton.Text = "update";
            this.updatecasebutton.UseVisualStyleBackColor = true;
            this.updatecasebutton.Click += new System.EventHandler(this.updatecasebutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 17);
            this.label3.TabIndex = 103;
            this.label3.Text = "choose an attribute to change";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 102;
            this.label2.Text = "enter the value";
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(147, 109);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(100, 24);
            this.valueTextBox.TabIndex = 101;
            // 
            // attributeComboBox
            // 
            this.attributeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.attributeComboBox.FormattingEnabled = true;
            this.attributeComboBox.Items.AddRange(new object[] {
            "employee type",
            "status",
            "First Name",
            "Last Name",
            "username",
            "password",
            "gender",
            "contact number",
            "address",
            "birthdate"});
            this.attributeComboBox.Location = new System.Drawing.Point(228, 60);
            this.attributeComboBox.Name = "attributeComboBox";
            this.attributeComboBox.Size = new System.Drawing.Size(121, 24);
            this.attributeComboBox.TabIndex = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 99;
            this.label1.Text = "employee ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // viewcasetextBox
            // 
            this.viewcasetextBox.Location = new System.Drawing.Point(120, 15);
            this.viewcasetextBox.Name = "viewcasetextBox";
            this.viewcasetextBox.Size = new System.Drawing.Size(100, 24);
            this.viewcasetextBox.TabIndex = 98;
            // 
            // updateemployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 222);
            this.Controls.Add(this.updatecasebutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.valueTextBox);
            this.Controls.Add(this.attributeComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewcasetextBox);
            this.Name = "updateemployee";
            this.Text = "updateemployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updatecasebutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.ComboBox attributeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox viewcasetextBox;
    }
}