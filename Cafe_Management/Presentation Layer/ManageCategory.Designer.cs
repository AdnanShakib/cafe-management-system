
namespace Cafe_Management.Presentation_Layer
{
    partial class ManageCategory
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
            this.addNewCategoryGroupBox = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.addCategoryNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.updateCategoryGroupBox = new System.Windows.Forms.GroupBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.updateCategoryIdTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.updateCategoryNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.deleteCategoryIdTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listOfCategoriesGridView = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.categoryWiseProductSearcgComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.categoryWiseProductGridView = new System.Windows.Forms.DataGridView();
            this.backButton = new System.Windows.Forms.Button();
            this.addNewCategoryGroupBox.SuspendLayout();
            this.updateCategoryGroupBox.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listOfCategoriesGridView)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryWiseProductGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addNewCategoryGroupBox
            // 
            this.addNewCategoryGroupBox.Controls.Add(this.addButton);
            this.addNewCategoryGroupBox.Controls.Add(this.addCategoryNameTextBox);
            this.addNewCategoryGroupBox.Controls.Add(this.label1);
            this.addNewCategoryGroupBox.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewCategoryGroupBox.Location = new System.Drawing.Point(13, 25);
            this.addNewCategoryGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addNewCategoryGroupBox.Name = "addNewCategoryGroupBox";
            this.addNewCategoryGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addNewCategoryGroupBox.Size = new System.Drawing.Size(404, 154);
            this.addNewCategoryGroupBox.TabIndex = 2;
            this.addNewCategoryGroupBox.TabStop = false;
            this.addNewCategoryGroupBox.Text = "Add New Category";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(135, 104);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(119, 36);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addCategoryNameTextBox
            // 
            this.addCategoryNameTextBox.Location = new System.Drawing.Point(194, 44);
            this.addCategoryNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addCategoryNameTextBox.Name = "addCategoryNameTextBox";
            this.addCategoryNameTextBox.Size = new System.Drawing.Size(196, 31);
            this.addCategoryNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category Name";
            // 
            // updateCategoryGroupBox
            // 
            this.updateCategoryGroupBox.Controls.Add(this.loadButton);
            this.updateCategoryGroupBox.Controls.Add(this.updateCategoryIdTextBox);
            this.updateCategoryGroupBox.Controls.Add(this.label3);
            this.updateCategoryGroupBox.Controls.Add(this.updateButton);
            this.updateCategoryGroupBox.Controls.Add(this.updateCategoryNameTextBox);
            this.updateCategoryGroupBox.Controls.Add(this.label2);
            this.updateCategoryGroupBox.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCategoryGroupBox.Location = new System.Drawing.Point(13, 205);
            this.updateCategoryGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateCategoryGroupBox.Name = "updateCategoryGroupBox";
            this.updateCategoryGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateCategoryGroupBox.Size = new System.Drawing.Size(404, 202);
            this.updateCategoryGroupBox.TabIndex = 4;
            this.updateCategoryGroupBox.TabStop = false;
            this.updateCategoryGroupBox.Text = "Update Category";
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(284, 48);
            this.loadButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(107, 31);
            this.loadButton.TabIndex = 5;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // updateCategoryIdTextBox
            // 
            this.updateCategoryIdTextBox.Location = new System.Drawing.Point(180, 48);
            this.updateCategoryIdTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateCategoryIdTextBox.Name = "updateCategoryIdTextBox";
            this.updateCategoryIdTextBox.Size = new System.Drawing.Size(96, 31);
            this.updateCategoryIdTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Category ID";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(135, 157);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(119, 32);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // updateCategoryNameTextBox
            // 
            this.updateCategoryNameTextBox.Location = new System.Drawing.Point(180, 100);
            this.updateCategoryNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateCategoryNameTextBox.Name = "updateCategoryNameTextBox";
            this.updateCategoryNameTextBox.Size = new System.Drawing.Size(210, 31);
            this.updateCategoryNameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Category Name";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.deleteButton);
            this.groupBox4.Controls.Add(this.deleteCategoryIdTextBox);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(11, 432);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(406, 181);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Delete Category";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(137, 132);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(119, 35);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // deleteCategoryIdTextBox
            // 
            this.deleteCategoryIdTextBox.Location = new System.Drawing.Point(180, 59);
            this.deleteCategoryIdTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteCategoryIdTextBox.Name = "deleteCategoryIdTextBox";
            this.deleteCategoryIdTextBox.Size = new System.Drawing.Size(210, 31);
            this.deleteCategoryIdTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Category ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listOfCategoriesGridView);
            this.groupBox1.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(448, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(485, 208);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List of Categories";
            // 
            // listOfCategoriesGridView
            // 
            this.listOfCategoriesGridView.AllowUserToAddRows = false;
            this.listOfCategoriesGridView.AllowUserToDeleteRows = false;
            this.listOfCategoriesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listOfCategoriesGridView.Location = new System.Drawing.Point(33, 37);
            this.listOfCategoriesGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listOfCategoriesGridView.Name = "listOfCategoriesGridView";
            this.listOfCategoriesGridView.ReadOnly = true;
            this.listOfCategoriesGridView.RowHeadersWidth = 62;
            this.listOfCategoriesGridView.Size = new System.Drawing.Size(441, 134);
            this.listOfCategoriesGridView.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.categoryWiseProductSearcgComboBox);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.categoryWiseProductGridView);
            this.groupBox5.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(448, 298);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Size = new System.Drawing.Size(676, 301);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Category-Wise Product List";
            // 
            // categoryWiseProductSearcgComboBox
            // 
            this.categoryWiseProductSearcgComboBox.FormattingEnabled = true;
            this.categoryWiseProductSearcgComboBox.Location = new System.Drawing.Point(272, 61);
            this.categoryWiseProductSearcgComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.categoryWiseProductSearcgComboBox.Name = "categoryWiseProductSearcgComboBox";
            this.categoryWiseProductSearcgComboBox.Size = new System.Drawing.Size(268, 29);
            this.categoryWiseProductSearcgComboBox.TabIndex = 2;
            this.categoryWiseProductSearcgComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryWiseProductSearcgComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 61);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Category";
            // 
            // categoryWiseProductGridView
            // 
            this.categoryWiseProductGridView.AllowUserToAddRows = false;
            this.categoryWiseProductGridView.AllowUserToDeleteRows = false;
            this.categoryWiseProductGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryWiseProductGridView.Location = new System.Drawing.Point(8, 103);
            this.categoryWiseProductGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.categoryWiseProductGridView.Name = "categoryWiseProductGridView";
            this.categoryWiseProductGridView.ReadOnly = true;
            this.categoryWiseProductGridView.RowHeadersWidth = 62;
            this.categoryWiseProductGridView.Size = new System.Drawing.Size(660, 121);
            this.categoryWiseProductGridView.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(996, 617);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(86, 33);
            this.backButton.TabIndex = 8;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // ManageCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 818);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.updateCategoryGroupBox);
            this.Controls.Add(this.addNewCategoryGroupBox);
            this.Name = "ManageCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageCategory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageCategory_FormClosing);
            this.Load += new System.EventHandler(this.ManageCategory_Load);
            this.addNewCategoryGroupBox.ResumeLayout(false);
            this.addNewCategoryGroupBox.PerformLayout();
            this.updateCategoryGroupBox.ResumeLayout(false);
            this.updateCategoryGroupBox.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listOfCategoriesGridView)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryWiseProductGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox addNewCategoryGroupBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox addCategoryNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox updateCategoryGroupBox;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.TextBox updateCategoryIdTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox updateCategoryNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox deleteCategoryIdTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView listOfCategoriesGridView;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox categoryWiseProductSearcgComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView categoryWiseProductGridView;
        private System.Windows.Forms.Button backButton;
    }
}