
namespace Cafe_Management.Presentation_Layer
{
    partial class ProductDashboard
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
            this.manageProductButton = new System.Windows.Forms.Button();
            this.manageCategoryButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // manageProductButton
            // 
            this.manageProductButton.Location = new System.Drawing.Point(76, 152);
            this.manageProductButton.Name = "manageProductButton";
            this.manageProductButton.Size = new System.Drawing.Size(191, 54);
            this.manageProductButton.TabIndex = 0;
            this.manageProductButton.Text = "Manage Product";
            this.manageProductButton.UseVisualStyleBackColor = true;
            this.manageProductButton.Click += new System.EventHandler(this.manageProductButton_Click);
            // 
            // manageCategoryButton
            // 
            this.manageCategoryButton.Location = new System.Drawing.Point(413, 152);
            this.manageCategoryButton.Name = "manageCategoryButton";
            this.manageCategoryButton.Size = new System.Drawing.Size(191, 54);
            this.manageCategoryButton.TabIndex = 1;
            this.manageCategoryButton.Text = "Manage Category";
            this.manageCategoryButton.UseVisualStyleBackColor = true;
            this.manageCategoryButton.Click += new System.EventHandler(this.manageCategoryButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(563, 340);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(116, 46);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // ProductDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.manageCategoryButton);
            this.Controls.Add(this.manageProductButton);
            this.Name = "ProductDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductDashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductDashboard_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button manageProductButton;
        private System.Windows.Forms.Button manageCategoryButton;
        private System.Windows.Forms.Button backButton;
    }
}