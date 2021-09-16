
namespace CIE206_DBproject_0
{
    partial class addcase
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
            this.addcasebutton = new System.Windows.Forms.Button();
            this.addcaseidtextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.casestatuscomboBox = new System.Windows.Forms.ComboBox();
            this.adddoctoridtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addpatientidtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.diagnosistextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.treatmentCheckBox = new System.Windows.Forms.CheckBox();
            this.surgerynametextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.surgeryidtextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.surgerystatuscomboBox = new System.Windows.Forms.ComboBox();
            this.surgeryCheckBox = new System.Windows.Forms.CheckBox();
            this.labtestnametextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labtestidtextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labtestcomboBox = new System.Windows.Forms.ComboBox();
            this.labTestCheckBox = new System.Windows.Forms.CheckBox();
            this.treatmentnametextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.assignedCheckbox = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.roomidtextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.CheckinDatePicker = new System.Windows.Forms.DateTimePicker();
            this.CheckoutDatePicker = new System.Windows.Forms.DateTimePicker();
            this.casedateLabel = new System.Windows.Forms.Label();
            this.CaseDatePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // addcasebutton
            // 
            this.addcasebutton.Location = new System.Drawing.Point(584, 438);
            this.addcasebutton.Name = "addcasebutton";
            this.addcasebutton.Size = new System.Drawing.Size(171, 34);
            this.addcasebutton.TabIndex = 0;
            this.addcasebutton.Text = "Add";
            this.addcasebutton.UseVisualStyleBackColor = true;
            this.addcasebutton.Click += new System.EventHandler(this.addcasebutton_Click);
            // 
            // addcaseidtextBox
            // 
            this.addcaseidtextBox.Location = new System.Drawing.Point(615, 15);
            this.addcaseidtextBox.Name = "addcaseidtextBox";
            this.addcaseidtextBox.Size = new System.Drawing.Size(135, 22);
            this.addcaseidtextBox.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(526, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 17);
            this.label9.TabIndex = 48;
            this.label9.Text = "case ID";
            // 
            // casestatuscomboBox
            // 
            this.casestatuscomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.casestatuscomboBox.FormattingEnabled = true;
            this.casestatuscomboBox.Items.AddRange(new object[] {
            "completed",
            "pending"});
            this.casestatuscomboBox.Location = new System.Drawing.Point(104, 60);
            this.casestatuscomboBox.Name = "casestatuscomboBox";
            this.casestatuscomboBox.Size = new System.Drawing.Size(138, 24);
            this.casestatuscomboBox.TabIndex = 50;
            // 
            // adddoctoridtextBox
            // 
            this.adddoctoridtextBox.Location = new System.Drawing.Point(99, 15);
            this.adddoctoridtextBox.Name = "adddoctoridtextBox";
            this.adddoctoridtextBox.Size = new System.Drawing.Size(135, 22);
            this.adddoctoridtextBox.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 51;
            this.label1.Text = "doctor ID";
            // 
            // addpatientidtextBox
            // 
            this.addpatientidtextBox.Location = new System.Drawing.Point(353, 15);
            this.addpatientidtextBox.Name = "addpatientidtextBox";
            this.addpatientidtextBox.Size = new System.Drawing.Size(135, 22);
            this.addpatientidtextBox.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 53;
            this.label2.Text = "patient ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 55;
            this.label3.Text = "case status";
            // 
            // diagnosistextBox
            // 
            this.diagnosistextBox.Location = new System.Drawing.Point(353, 63);
            this.diagnosistextBox.Name = "diagnosistextBox";
            this.diagnosistextBox.Size = new System.Drawing.Size(397, 22);
            this.diagnosistextBox.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 56;
            this.label4.Text = "diagnosis";
            // 
            // treatmentCheckBox
            // 
            this.treatmentCheckBox.AutoSize = true;
            this.treatmentCheckBox.Location = new System.Drawing.Point(0, 150);
            this.treatmentCheckBox.Name = "treatmentCheckBox";
            this.treatmentCheckBox.Size = new System.Drawing.Size(90, 21);
            this.treatmentCheckBox.TabIndex = 72;
            this.treatmentCheckBox.Text = "treatment";
            this.treatmentCheckBox.UseVisualStyleBackColor = true;
            this.treatmentCheckBox.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // surgerynametextBox
            // 
            this.surgerynametextBox.Location = new System.Drawing.Point(630, 290);
            this.surgerynametextBox.Name = "surgerynametextBox";
            this.surgerynametextBox.Size = new System.Drawing.Size(135, 22);
            this.surgerynametextBox.TabIndex = 86;
            this.surgerynametextBox.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(517, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 17);
            this.label8.TabIndex = 85;
            this.label8.Text = "surgery name";
            this.label8.Visible = false;
            // 
            // surgeryidtextBox
            // 
            this.surgeryidtextBox.Location = new System.Drawing.Point(374, 289);
            this.surgeryidtextBox.Name = "surgeryidtextBox";
            this.surgeryidtextBox.Size = new System.Drawing.Size(135, 22);
            this.surgeryidtextBox.TabIndex = 84;
            this.surgeryidtextBox.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(283, 293);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 17);
            this.label10.TabIndex = 83;
            this.label10.Text = "surgery ID";
            this.label10.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 292);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 17);
            this.label11.TabIndex = 82;
            this.label11.Text = "surgery status";
            this.label11.Visible = false;
            // 
            // surgerystatuscomboBox
            // 
            this.surgerystatuscomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.surgerystatuscomboBox.FormattingEnabled = true;
            this.surgerystatuscomboBox.Items.AddRange(new object[] {
            "completed",
            "pending"});
            this.surgerystatuscomboBox.Location = new System.Drawing.Point(121, 290);
            this.surgerystatuscomboBox.Name = "surgerystatuscomboBox";
            this.surgerystatuscomboBox.Size = new System.Drawing.Size(138, 24);
            this.surgerystatuscomboBox.TabIndex = 81;
            this.surgerystatuscomboBox.Visible = false;
            // 
            // surgeryCheckBox
            // 
            this.surgeryCheckBox.AutoSize = true;
            this.surgeryCheckBox.Location = new System.Drawing.Point(10, 253);
            this.surgeryCheckBox.Name = "surgeryCheckBox";
            this.surgeryCheckBox.Size = new System.Drawing.Size(78, 21);
            this.surgeryCheckBox.TabIndex = 80;
            this.surgeryCheckBox.Text = "surgery";
            this.surgeryCheckBox.UseVisualStyleBackColor = true;
            this.surgeryCheckBox.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // labtestnametextBox
            // 
            this.labtestnametextBox.Location = new System.Drawing.Point(611, 216);
            this.labtestnametextBox.Name = "labtestnametextBox";
            this.labtestnametextBox.Size = new System.Drawing.Size(135, 22);
            this.labtestnametextBox.TabIndex = 79;
            this.labtestnametextBox.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(526, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 78;
            this.label7.Text = "lab name";
            this.label7.Visible = false;
            // 
            // labtestidtextBox
            // 
            this.labtestidtextBox.Location = new System.Drawing.Point(350, 213);
            this.labtestidtextBox.Name = "labtestidtextBox";
            this.labtestidtextBox.Size = new System.Drawing.Size(135, 22);
            this.labtestidtextBox.TabIndex = 77;
            this.labtestidtextBox.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 76;
            this.label5.Text = "Lab ID";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 75;
            this.label6.Text = "lab status";
            this.label6.Visible = false;
            // 
            // labtestcomboBox
            // 
            this.labtestcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.labtestcomboBox.FormattingEnabled = true;
            this.labtestcomboBox.Items.AddRange(new object[] {
            "completed",
            "pending"});
            this.labtestcomboBox.Location = new System.Drawing.Point(101, 213);
            this.labtestcomboBox.Name = "labtestcomboBox";
            this.labtestcomboBox.Size = new System.Drawing.Size(138, 24);
            this.labtestcomboBox.TabIndex = 74;
            this.labtestcomboBox.Visible = false;
            // 
            // labTestCheckBox
            // 
            this.labTestCheckBox.AutoSize = true;
            this.labTestCheckBox.Location = new System.Drawing.Point(10, 188);
            this.labTestCheckBox.Name = "labTestCheckBox";
            this.labTestCheckBox.Size = new System.Drawing.Size(81, 21);
            this.labTestCheckBox.TabIndex = 73;
            this.labTestCheckBox.Text = "Lab test";
            this.labTestCheckBox.UseVisualStyleBackColor = true;
            this.labTestCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // treatmentnametextBox
            // 
            this.treatmentnametextBox.Location = new System.Drawing.Point(299, 151);
            this.treatmentnametextBox.Name = "treatmentnametextBox";
            this.treatmentnametextBox.Size = new System.Drawing.Size(451, 22);
            this.treatmentnametextBox.TabIndex = 88;
            this.treatmentnametextBox.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(135, 154);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 17);
            this.label12.TabIndex = 87;
            this.label12.Text = "treatment name";
            this.label12.Visible = false;
            // 
            // assignedCheckbox
            // 
            this.assignedCheckbox.AutoSize = true;
            this.assignedCheckbox.Location = new System.Drawing.Point(10, 341);
            this.assignedCheckbox.Name = "assignedCheckbox";
            this.assignedCheckbox.Size = new System.Drawing.Size(139, 21);
            this.assignedCheckbox.TabIndex = 89;
            this.assignedCheckbox.Text = "assigned to room";
            this.assignedCheckbox.UseVisualStyleBackColor = true;
            this.assignedCheckbox.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(224, 390);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 17);
            this.label13.TabIndex = 94;
            this.label13.Text = "checkin time";
            this.label13.Visible = false;
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // roomidtextBox
            // 
            this.roomidtextBox.Location = new System.Drawing.Point(81, 387);
            this.roomidtextBox.Name = "roomidtextBox";
            this.roomidtextBox.Size = new System.Drawing.Size(135, 22);
            this.roomidtextBox.TabIndex = 93;
            this.roomidtextBox.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 390);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 17);
            this.label14.TabIndex = 92;
            this.label14.Text = "room ID";
            this.label14.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(485, 390);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 17);
            this.label15.TabIndex = 90;
            this.label15.Text = "checkout time";
            this.label15.Visible = false;
            // 
            // CheckinDatePicker
            // 
            this.CheckinDatePicker.CustomFormat = "yyyy-MM-dd";
            this.CheckinDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CheckinDatePicker.Location = new System.Drawing.Point(318, 387);
            this.CheckinDatePicker.Name = "CheckinDatePicker";
            this.CheckinDatePicker.Size = new System.Drawing.Size(160, 22);
            this.CheckinDatePicker.TabIndex = 96;
            this.CheckinDatePicker.Visible = false;
            this.CheckinDatePicker.ValueChanged += new System.EventHandler(this.CheckinDatePicker_ValueChanged);
            // 
            // CheckoutDatePicker
            // 
            this.CheckoutDatePicker.CustomFormat = "yyyy-MM-dd";
            this.CheckoutDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CheckoutDatePicker.Location = new System.Drawing.Point(588, 385);
            this.CheckoutDatePicker.Name = "CheckoutDatePicker";
            this.CheckoutDatePicker.Size = new System.Drawing.Size(167, 22);
            this.CheckoutDatePicker.TabIndex = 97;
            this.CheckoutDatePicker.Visible = false;
            this.CheckoutDatePicker.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // casedateLabel
            // 
            this.casedateLabel.AutoSize = true;
            this.casedateLabel.Location = new System.Drawing.Point(16, 106);
            this.casedateLabel.Name = "casedateLabel";
            this.casedateLabel.Size = new System.Drawing.Size(74, 17);
            this.casedateLabel.TabIndex = 98;
            this.casedateLabel.Text = "Case Date";
            // 
            // CaseDatePicker
            // 
            this.CaseDatePicker.CustomFormat = "yyyy-MM-dd";
            this.CaseDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CaseDatePicker.Location = new System.Drawing.Point(138, 106);
            this.CaseDatePicker.Name = "CaseDatePicker";
            this.CaseDatePicker.Size = new System.Drawing.Size(200, 22);
            this.CaseDatePicker.TabIndex = 99;
            // 
            // addcase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 547);
            this.Controls.Add(this.CaseDatePicker);
            this.Controls.Add(this.casedateLabel);
            this.Controls.Add(this.CheckoutDatePicker);
            this.Controls.Add(this.CheckinDatePicker);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.roomidtextBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.assignedCheckbox);
            this.Controls.Add(this.treatmentnametextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.surgerynametextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.surgeryidtextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.surgerystatuscomboBox);
            this.Controls.Add(this.surgeryCheckBox);
            this.Controls.Add(this.labtestnametextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labtestidtextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labtestcomboBox);
            this.Controls.Add(this.labTestCheckBox);
            this.Controls.Add(this.treatmentCheckBox);
            this.Controls.Add(this.diagnosistextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addpatientidtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.adddoctoridtextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.casestatuscomboBox);
            this.Controls.Add(this.addcaseidtextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.addcasebutton);
            this.Name = "addcase";
            this.Text = "add case";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addcasebutton;
        private System.Windows.Forms.TextBox addcaseidtextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox casestatuscomboBox;
        private System.Windows.Forms.TextBox adddoctoridtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addpatientidtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox diagnosistextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox treatmentCheckBox;
        private System.Windows.Forms.TextBox surgerynametextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox surgeryidtextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox surgerystatuscomboBox;
        private System.Windows.Forms.CheckBox surgeryCheckBox;
        private System.Windows.Forms.TextBox labtestnametextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox labtestidtextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox labtestcomboBox;
        private System.Windows.Forms.CheckBox labTestCheckBox;
        private System.Windows.Forms.TextBox treatmentnametextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox assignedCheckbox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox roomidtextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker CheckinDatePicker;
        private System.Windows.Forms.DateTimePicker CheckoutDatePicker;
        private System.Windows.Forms.Label casedateLabel;
        private System.Windows.Forms.DateTimePicker CaseDatePicker;
    }
}