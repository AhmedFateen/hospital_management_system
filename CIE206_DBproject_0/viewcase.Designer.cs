
namespace CIE206_DBproject_0
{
    partial class viewcase
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
            this.viewcasedataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.viewcasetextBox = new System.Windows.Forms.TextBox();
            this.viewcasebutton = new System.Windows.Forms.Button();
            this.ViewAllCasesbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.viewcasedataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // viewcasedataGridView
            // 
            this.viewcasedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewcasedataGridView.Location = new System.Drawing.Point(21, 71);
            this.viewcasedataGridView.Name = "viewcasedataGridView";
            this.viewcasedataGridView.ReadOnly = true;
            this.viewcasedataGridView.RowHeadersWidth = 51;
            this.viewcasedataGridView.RowTemplate.Height = 26;
            this.viewcasedataGridView.Size = new System.Drawing.Size(867, 434);
            this.viewcasedataGridView.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "case ID";
            // 
            // viewcasetextBox
            // 
            this.viewcasetextBox.Location = new System.Drawing.Point(100, 18);
            this.viewcasetextBox.Name = "viewcasetextBox";
            this.viewcasetextBox.Size = new System.Drawing.Size(100, 24);
            this.viewcasetextBox.TabIndex = 16;
            // 
            // viewcasebutton
            // 
            this.viewcasebutton.Location = new System.Drawing.Point(265, 10);
            this.viewcasebutton.Name = "viewcasebutton";
            this.viewcasebutton.Size = new System.Drawing.Size(200, 44);
            this.viewcasebutton.TabIndex = 15;
            this.viewcasebutton.Text = "view case";
            this.viewcasebutton.UseVisualStyleBackColor = true;
            this.viewcasebutton.Click += new System.EventHandler(this.viewcasebutton_Click);
            // 
            // ViewAllCasesbutton
            // 
            this.ViewAllCasesbutton.Location = new System.Drawing.Point(526, 10);
            this.ViewAllCasesbutton.Name = "ViewAllCasesbutton";
            this.ViewAllCasesbutton.Size = new System.Drawing.Size(166, 44);
            this.ViewAllCasesbutton.TabIndex = 19;
            this.ViewAllCasesbutton.Text = "View All Cases";
            this.ViewAllCasesbutton.UseVisualStyleBackColor = true;
            this.ViewAllCasesbutton.Click += new System.EventHandler(this.ViewAllCasesbutton_Click);
            // 
            // viewcase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 517);
            this.Controls.Add(this.ViewAllCasesbutton);
            this.Controls.Add(this.viewcasedataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewcasetextBox);
            this.Controls.Add(this.viewcasebutton);
            this.Name = "viewcase";
            this.Text = "view case";
            ((System.ComponentModel.ISupportInitialize)(this.viewcasedataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView viewcasedataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox viewcasetextBox;
        private System.Windows.Forms.Button viewcasebutton;
        private System.Windows.Forms.Button ViewAllCasesbutton;
    }
}