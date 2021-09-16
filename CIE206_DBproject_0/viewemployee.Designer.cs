
namespace CIE206_DBproject_0
{
    partial class viewemployee
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
            this.viewemployeedataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.viewemployeetextBox = new System.Windows.Forms.TextBox();
            this.viewemployeebutton = new System.Windows.Forms.Button();
            this.ViewAllEmployeesbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.viewemployeedataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // viewemployeedataGridView
            // 
            this.viewemployeedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewemployeedataGridView.Location = new System.Drawing.Point(12, 82);
            this.viewemployeedataGridView.Name = "viewemployeedataGridView";
            this.viewemployeedataGridView.ReadOnly = true;
            this.viewemployeedataGridView.RowHeadersWidth = 51;
            this.viewemployeedataGridView.RowTemplate.Height = 26;
            this.viewemployeedataGridView.Size = new System.Drawing.Size(1044, 473);
            this.viewemployeedataGridView.TabIndex = 10;
            this.viewemployeedataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewemployeedataGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "employee ID";
            // 
            // viewemployeetextBox
            // 
            this.viewemployeetextBox.Location = new System.Drawing.Point(120, 32);
            this.viewemployeetextBox.Name = "viewemployeetextBox";
            this.viewemployeetextBox.Size = new System.Drawing.Size(100, 24);
            this.viewemployeetextBox.TabIndex = 8;
            // 
            // viewemployeebutton
            // 
            this.viewemployeebutton.Location = new System.Drawing.Point(256, 21);
            this.viewemployeebutton.Name = "viewemployeebutton";
            this.viewemployeebutton.Size = new System.Drawing.Size(200, 44);
            this.viewemployeebutton.TabIndex = 7;
            this.viewemployeebutton.Text = "view employee basic info";
            this.viewemployeebutton.UseVisualStyleBackColor = true;
            this.viewemployeebutton.Click += new System.EventHandler(this.viewemployeebutton_Click);
            // 
            // ViewAllEmployeesbutton
            // 
            this.ViewAllEmployeesbutton.Location = new System.Drawing.Point(586, 25);
            this.ViewAllEmployeesbutton.Name = "ViewAllEmployeesbutton";
            this.ViewAllEmployeesbutton.Size = new System.Drawing.Size(170, 40);
            this.ViewAllEmployeesbutton.TabIndex = 11;
            this.ViewAllEmployeesbutton.Text = "View All Employees";
            this.ViewAllEmployeesbutton.UseVisualStyleBackColor = true;
            this.ViewAllEmployeesbutton.Click += new System.EventHandler(this.ViewAllEmployeesbutton_Click);
            // 
            // viewemployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 567);
            this.Controls.Add(this.ViewAllEmployeesbutton);
            this.Controls.Add(this.viewemployeedataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewemployeetextBox);
            this.Controls.Add(this.viewemployeebutton);
            this.Name = "viewemployee";
            this.Text = "view employee";
            ((System.ComponentModel.ISupportInitialize)(this.viewemployeedataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView viewemployeedataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox viewemployeetextBox;
        private System.Windows.Forms.Button viewemployeebutton;
        private System.Windows.Forms.Button ViewAllEmployeesbutton;
    }
}