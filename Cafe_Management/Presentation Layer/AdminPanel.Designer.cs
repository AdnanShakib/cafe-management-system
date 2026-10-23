
namespace Cafe_Management.Presentation_Layer
{
    partial class AdminPanel
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
            this.employeeInfoButton = new System.Windows.Forms.Button();
            this.customerInfoButton = new System.Windows.Forms.Button();
            this.productInfoButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // employeeInfoButton
            // 
            this.employeeInfoButton.Location = new System.Drawing.Point(150, 140);
            this.employeeInfoButton.Name = "employeeInfoButton";
            this.employeeInfoButton.Size = new System.Drawing.Size(260, 65);
            this.employeeInfoButton.TabIndex = 0;
            this.employeeInfoButton.Text = "Employee Info";
            this.employeeInfoButton.UseVisualStyleBackColor = true;
            this.employeeInfoButton.Click += new System.EventHandler(this.employeeInfoButton_Click);
            // 
            // customerInfoButton
            // 
            this.customerInfoButton.Location = new System.Drawing.Point(604, 140);
            this.customerInfoButton.Name = "customerInfoButton";
            this.customerInfoButton.Size = new System.Drawing.Size(260, 65);
            this.customerInfoButton.TabIndex = 1;
            this.customerInfoButton.Text = "Customer Info";
            this.customerInfoButton.UseVisualStyleBackColor = true;
            // 
            // productInfoButton
            // 
            this.productInfoButton.Location = new System.Drawing.Point(604, 315);
            this.productInfoButton.Name = "productInfoButton";
            this.productInfoButton.Size = new System.Drawing.Size(260, 75);
            this.productInfoButton.TabIndex = 2;
            this.productInfoButton.Text = "Product Info";
            this.productInfoButton.UseVisualStyleBackColor = true;
            this.productInfoButton.Click += new System.EventHandler(this.productInfoButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(838, 530);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(104, 31);
            this.logOutButton.TabIndex = 3;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 600);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.productInfoButton);
            this.Controls.Add(this.customerInfoButton);
            this.Controls.Add(this.employeeInfoButton);
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminPanel_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button employeeInfoButton;
        private System.Windows.Forms.Button customerInfoButton;
        private System.Windows.Forms.Button productInfoButton;
        private System.Windows.Forms.Button logOutButton;
    }
}