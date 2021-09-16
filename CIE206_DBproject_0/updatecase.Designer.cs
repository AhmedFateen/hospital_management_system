
namespace CIE206_DBproject_0
{
    partial class updatecase
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
            this.viewcasetextBox = new System.Windows.Forms.TextBox();
            this.attributeComboBox = new System.Windows.Forms.ComboBox();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.updatecasebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "case ID";
            // 
            // viewcasetextBox
            // 
            this.viewcasetextBox.Location = new System.Drawing.Point(82, 12);
            this.viewcasetextBox.Name = "viewcasetextBox";
            this.viewcasetextBox.Size = new System.Drawing.Size(100, 24);
            this.viewcasetextBox.TabIndex = 18;
            this.viewcasetextBox.TextChanged += new System.EventHandler(this.viewcasetextBox_TextChanged);
            // 
            // attributeComboBox
            // 
            this.attributeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.attributeComboBox.FormattingEnabled = true;
            this.attributeComboBox.Items.AddRange(new object[] {
            "case status",
            "case date",
            "diagnosis",
            "treatment name",
            "lab status",
            "lab ID",
            "lab name",
            "surgery status",
            "surgery ID",
            "surgery name",
            "room ID",
            "checkin date",
            "checkout date"});
            this.attributeComboBox.Location = new System.Drawing.Point(225, 60);
            this.attributeComboBox.Name = "attributeComboBox";
            this.attributeComboBox.Size = new System.Drawing.Size(121, 24);
            this.attributeComboBox.TabIndex = 51;
            this.attributeComboBox.SelectedIndexChanged += new System.EventHandler(this.casestatuscomboBox_SelectedIndexChanged);
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(144, 109);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(100, 24);
            this.valueTextBox.TabIndex = 52;
            this.valueTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 53;
            this.label2.Text = "enter the value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 17);
            this.label3.TabIndex = 54;
            this.label3.Text = "choose an attribute to change";
            // 
            // updatecasebutton
            // 
            this.updatecasebutton.Location = new System.Drawing.Point(212, 175);
            this.updatecasebutton.Name = "updatecasebutton";
            this.updatecasebutton.Size = new System.Drawing.Size(134, 34);
            this.updatecasebutton.TabIndex = 97;
            this.updatecasebutton.Text = "update";
            this.updatecasebutton.UseVisualStyleBackColor = true;
            this.updatecasebutton.Click += new System.EventHandler(this.updatecasebutton_Click);
            // 
            // updatecase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 230);
            this.Controls.Add(this.updatecasebutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.valueTextBox);
            this.Controls.Add(this.attributeComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewcasetextBox);
            this.Name = "updatecase";
            this.Text = "update case";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox viewcasetextBox;
        private System.Windows.Forms.ComboBox attributeComboBox;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button updatecasebutton;
    }
}