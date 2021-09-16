
namespace CIE206_DBproject_0
{
    partial class viewroom
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
            this.viewroomdataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.viewroomtextBox = new System.Windows.Forms.TextBox();
            this.viewroombutton = new System.Windows.Forms.Button();
            this.ViewAllRoombutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.viewroomdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // viewroomdataGridView
            // 
            this.viewroomdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewroomdataGridView.Location = new System.Drawing.Point(12, 73);
            this.viewroomdataGridView.Name = "viewroomdataGridView";
            this.viewroomdataGridView.ReadOnly = true;
            this.viewroomdataGridView.RowHeadersWidth = 51;
            this.viewroomdataGridView.RowTemplate.Height = 26;
            this.viewroomdataGridView.Size = new System.Drawing.Size(670, 452);
            this.viewroomdataGridView.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "room ID";
            // 
            // viewroomtextBox
            // 
            this.viewroomtextBox.Location = new System.Drawing.Point(120, 23);
            this.viewroomtextBox.Name = "viewroomtextBox";
            this.viewroomtextBox.Size = new System.Drawing.Size(100, 24);
            this.viewroomtextBox.TabIndex = 12;
            // 
            // viewroombutton
            // 
            this.viewroombutton.Location = new System.Drawing.Point(256, 12);
            this.viewroombutton.Name = "viewroombutton";
            this.viewroombutton.Size = new System.Drawing.Size(200, 44);
            this.viewroombutton.TabIndex = 11;
            this.viewroombutton.Text = "view room basic info";
            this.viewroombutton.UseVisualStyleBackColor = true;
            this.viewroombutton.Click += new System.EventHandler(this.viewroombutton_Click);
            // 
            // ViewAllRoombutton
            // 
            this.ViewAllRoombutton.Location = new System.Drawing.Point(514, 16);
            this.ViewAllRoombutton.Name = "ViewAllRoombutton";
            this.ViewAllRoombutton.Size = new System.Drawing.Size(157, 51);
            this.ViewAllRoombutton.TabIndex = 15;
            this.ViewAllRoombutton.Text = "View All Room";
            this.ViewAllRoombutton.UseVisualStyleBackColor = true;
            this.ViewAllRoombutton.Click += new System.EventHandler(this.ViewAllRoombutton_Click);
            // 
            // viewroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 532);
            this.Controls.Add(this.ViewAllRoombutton);
            this.Controls.Add(this.viewroomdataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewroomtextBox);
            this.Controls.Add(this.viewroombutton);
            this.Name = "viewroom";
            this.Text = "view room";
            ((System.ComponentModel.ISupportInitialize)(this.viewroomdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView viewroomdataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox viewroomtextBox;
        private System.Windows.Forms.Button viewroombutton;
        private System.Windows.Forms.Button ViewAllRoombutton;
    }
}