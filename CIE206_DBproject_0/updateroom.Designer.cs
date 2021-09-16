
namespace CIE206_DBproject_0
{
    partial class updateroom
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
            this.updateroombutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.attributeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.roomidtextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // updateroombutton
            // 
            this.updateroombutton.Location = new System.Drawing.Point(231, 183);
            this.updateroombutton.Name = "updateroombutton";
            this.updateroombutton.Size = new System.Drawing.Size(118, 35);
            this.updateroombutton.TabIndex = 48;
            this.updateroombutton.Text = "Update";
            this.updateroombutton.UseVisualStyleBackColor = true;
            this.updateroombutton.Click += new System.EventHandler(this.updateroombutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 17);
            this.label3.TabIndex = 60;
            this.label3.Text = "choose an attribute to change";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 59;
            this.label2.Text = "enter the value";
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(147, 112);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(100, 24);
            this.valueTextBox.TabIndex = 58;
            // 
            // attributeComboBox
            // 
            this.attributeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.attributeComboBox.FormattingEnabled = true;
            this.attributeComboBox.Items.AddRange(new object[] {
            "room type",
            "capacity"});
            this.attributeComboBox.Location = new System.Drawing.Point(228, 63);
            this.attributeComboBox.Name = "attributeComboBox";
            this.attributeComboBox.Size = new System.Drawing.Size(121, 24);
            this.attributeComboBox.TabIndex = 57;
            this.attributeComboBox.SelectedIndexChanged += new System.EventHandler(this.casestatuscomboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 56;
            this.label1.Text = "room ID";
            // 
            // roomidtextBox
            // 
            this.roomidtextBox.Location = new System.Drawing.Point(85, 15);
            this.roomidtextBox.Name = "roomidtextBox";
            this.roomidtextBox.Size = new System.Drawing.Size(100, 24);
            this.roomidtextBox.TabIndex = 55;
            // 
            // updateroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 234);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.valueTextBox);
            this.Controls.Add(this.attributeComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roomidtextBox);
            this.Controls.Add(this.updateroombutton);
            this.Name = "updateroom";
            this.Text = "update room";
            this.Load += new System.EventHandler(this.updateroom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateroombutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.ComboBox attributeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox roomidtextBox;
    }
}