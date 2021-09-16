
namespace CIE206_DBproject_0
{
    partial class addroom
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
            this.roomtypecomboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.capacitytextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.roomidtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addroombutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // roomtypecomboBox
            // 
            this.roomtypecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomtypecomboBox.FormattingEnabled = true;
            this.roomtypecomboBox.Items.AddRange(new object[] {
            "internal medicine",
            "surgery"});
            this.roomtypecomboBox.Location = new System.Drawing.Point(165, 8);
            this.roomtypecomboBox.Name = "roomtypecomboBox";
            this.roomtypecomboBox.Size = new System.Drawing.Size(121, 24);
            this.roomtypecomboBox.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 17);
            this.label9.TabIndex = 44;
            this.label9.Text = "room type";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // capacitytextBox
            // 
            this.capacitytextBox.Location = new System.Drawing.Point(186, 115);
            this.capacitytextBox.Name = "capacitytextBox";
            this.capacitytextBox.Size = new System.Drawing.Size(100, 24);
            this.capacitytextBox.TabIndex = 41;
            this.capacitytextBox.TextChanged += new System.EventHandler(this.capacitytextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "capacity";
            // 
            // roomidtextBox
            // 
            this.roomidtextBox.Location = new System.Drawing.Point(186, 48);
            this.roomidtextBox.Name = "roomidtextBox";
            this.roomidtextBox.Size = new System.Drawing.Size(100, 24);
            this.roomidtextBox.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "room ID";
            // 
            // addroombutton
            // 
            this.addroombutton.Location = new System.Drawing.Point(186, 176);
            this.addroombutton.Name = "addroombutton";
            this.addroombutton.Size = new System.Drawing.Size(100, 32);
            this.addroombutton.TabIndex = 46;
            this.addroombutton.Text = "Add";
            this.addroombutton.UseVisualStyleBackColor = true;
            this.addroombutton.Click += new System.EventHandler(this.addroombutton_Click);
            // 
            // addroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 227);
            this.Controls.Add(this.addroombutton);
            this.Controls.Add(this.roomtypecomboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.capacitytextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.roomidtextBox);
            this.Controls.Add(this.label1);
            this.Name = "addroom";
            this.Text = "add room";
            this.Load += new System.EventHandler(this.addroom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox roomtypecomboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox capacitytextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox roomidtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addroombutton;
    }
}