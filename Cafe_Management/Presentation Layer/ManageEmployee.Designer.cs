
namespace Cafe_Management.Presentation_Layer
{
    partial class ManageEmployee
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
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.deleteEmployeeButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.showAllEmployeeDataButton = new System.Windows.Forms.Button();
            this.editInfoButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.Location = new System.Drawing.Point(30, 185);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(256, 80);
            this.addEmployeeButton.TabIndex = 0;
            this.addEmployeeButton.Text = "Add Employee";
            this.addEmployeeButton.UseVisualStyleBackColor = true;
            this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
            // 
            // deleteEmployeeButton
            // 
            this.deleteEmployeeButton.Location = new System.Drawing.Point(30, 307);
            this.deleteEmployeeButton.Name = "deleteEmployeeButton";
            this.deleteEmployeeButton.Size = new System.Drawing.Size(256, 76);
            this.deleteEmployeeButton.TabIndex = 1;
            this.deleteEmployeeButton.Text = "Delete Employee";
            this.deleteEmployeeButton.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(447, 47);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(700, 218);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // showAllEmployeeDataButton
            // 
            this.showAllEmployeeDataButton.Location = new System.Drawing.Point(30, 63);
            this.showAllEmployeeDataButton.Name = "showAllEmployeeDataButton";
            this.showAllEmployeeDataButton.Size = new System.Drawing.Size(256, 85);
            this.showAllEmployeeDataButton.TabIndex = 3;
            this.showAllEmployeeDataButton.Text = "Show all Employee Data";
            this.showAllEmployeeDataButton.UseVisualStyleBackColor = true;
            // 
            // editInfoButton
            // 
            this.editInfoButton.Location = new System.Drawing.Point(30, 424);
            this.editInfoButton.Name = "editInfoButton";
            this.editInfoButton.Size = new System.Drawing.Size(256, 80);
            this.editInfoButton.TabIndex = 4;
            this.editInfoButton.Text = "Edit Info";
            this.editInfoButton.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(996, 515);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(114, 39);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // ManageEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 597);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.editInfoButton);
            this.Controls.Add(this.showAllEmployeeDataButton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.deleteEmployeeButton);
            this.Controls.Add(this.addEmployeeButton);
            this.Name = "ManageEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Employee_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addEmployeeButton;
        private System.Windows.Forms.Button deleteEmployeeButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button showAllEmployeeDataButton;
        private System.Windows.Forms.Button editInfoButton;
        private System.Windows.Forms.Button backButton;
    }
}