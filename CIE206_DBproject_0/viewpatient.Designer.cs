
using System;
using System.Windows.Forms;

namespace CIE206_DBproject_0
{
    partial class viewpatient
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
            this.viewpatientbutton = new System.Windows.Forms.Button();
            this.viewpatientdataGridView = new System.Windows.Forms.DataGridView();
            this.ViewAllPatientsbutton = new System.Windows.Forms.Button();
            this.ViewMedicalRecordbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.viewpatientdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "patient ID";
            // 
            // patientidtextBox
            // 
            this.patientidtextBox.Location = new System.Drawing.Point(106, 32);
            this.patientidtextBox.Name = "patientidtextBox";
            this.patientidtextBox.Size = new System.Drawing.Size(100, 24);
            this.patientidtextBox.TabIndex = 4;
            // 
            // viewpatientbutton
            // 
            this.viewpatientbutton.Location = new System.Drawing.Point(242, 21);
            this.viewpatientbutton.Name = "viewpatientbutton";
            this.viewpatientbutton.Size = new System.Drawing.Size(200, 44);
            this.viewpatientbutton.TabIndex = 3;
            this.viewpatientbutton.Text = "view patient basic info";
            this.viewpatientbutton.UseVisualStyleBackColor = true;
            this.viewpatientbutton.Click += new System.EventHandler(this.viewpatientbutton_Click);
            // 
            // viewpatientdataGridView
            // 
            this.viewpatientdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewpatientdataGridView.Location = new System.Drawing.Point(-2, 82);
            this.viewpatientdataGridView.Name = "viewpatientdataGridView";
            this.viewpatientdataGridView.ReadOnly = true;
            this.viewpatientdataGridView.RowHeadersWidth = 51;
            this.viewpatientdataGridView.RowTemplate.Height = 26;
            this.viewpatientdataGridView.Size = new System.Drawing.Size(997, 507);
            this.viewpatientdataGridView.TabIndex = 6;
            this.viewpatientdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewpatientdataGridView_CellContentClick);
            // 
            // ViewAllPatientsbutton
            // 
            this.ViewAllPatientsbutton.Location = new System.Drawing.Point(544, 15);
            this.ViewAllPatientsbutton.Name = "ViewAllPatientsbutton";
            this.ViewAllPatientsbutton.Size = new System.Drawing.Size(137, 56);
            this.ViewAllPatientsbutton.TabIndex = 32;
            this.ViewAllPatientsbutton.Text = "View All Patients";
            this.ViewAllPatientsbutton.UseVisualStyleBackColor = true;
            this.ViewAllPatientsbutton.Click += new System.EventHandler(this.ViewAllPatientsbutton_Click);
            // 
            // ViewMedicalRecordbutton
            // 
            this.ViewMedicalRecordbutton.Location = new System.Drawing.Point(737, 15);
            this.ViewMedicalRecordbutton.Name = "ViewMedicalRecordbutton";
            this.ViewMedicalRecordbutton.Size = new System.Drawing.Size(159, 56);
            this.ViewMedicalRecordbutton.TabIndex = 33;
            this.ViewMedicalRecordbutton.Text = "View Medical Record";
            this.ViewMedicalRecordbutton.UseVisualStyleBackColor = true;
            this.ViewMedicalRecordbutton.Click += new System.EventHandler(this.ViewMedicalRecordbutton_Click);
            // 
            // viewpatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 591);
            this.Controls.Add(this.ViewMedicalRecordbutton);
            this.Controls.Add(this.ViewAllPatientsbutton);
            this.Controls.Add(this.viewpatientdataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.patientidtextBox);
            this.Controls.Add(this.viewpatientbutton);
            this.Name = "viewpatient";
            this.Text = "view patient basic info";
            ((System.ComponentModel.ISupportInitialize)(this.viewpatientdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void viewpatientdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox patientidtextBox;
        private System.Windows.Forms.Button viewpatientbutton;
        private System.Windows.Forms.DataGridView viewpatientdataGridView;
        private Button ViewAllPatientsbutton;
        private Button ViewMedicalRecordbutton;
    }
}