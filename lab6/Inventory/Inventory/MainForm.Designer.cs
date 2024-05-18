
namespace Inventory
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addTovar = new System.Windows.Forms.Button();
            this.editTovar = new System.Windows.Forms.Button();
            this.tovars = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.menuLabel = new System.Windows.Forms.Label();
            this.chooseTovar = new System.Windows.Forms.ComboBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchResultsTextBox = new System.Windows.Forms.TextBox();
            this.exportToCSVButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addTovar
            // 
            this.addTovar.Location = new System.Drawing.Point(356, 105);
            this.addTovar.Name = "addTovar";
            this.addTovar.Size = new System.Drawing.Size(94, 29);
            this.addTovar.TabIndex = 0;
            this.addTovar.Text = "Додати товар";
            this.addTovar.UseVisualStyleBackColor = true;
            this.addTovar.Click += new System.EventHandler(this.addTovar_Click);
            // 
            // editTovar
            // 
            this.editTovar.Location = new System.Drawing.Point(356, 160);
            this.editTovar.Name = "editTovar";
            this.editTovar.Size = new System.Drawing.Size(94, 29);
            this.editTovar.TabIndex = 1;
            this.editTovar.Text = "Редагувати товар";
            this.editTovar.UseVisualStyleBackColor = true;
            this.editTovar.Click += new System.EventHandler(this.editTovar_Click);
            // 
            // tovars
            // 
            this.tovars.Location = new System.Drawing.Point(335, 209);
            this.tovars.Name = "tovars";
            this.tovars.Size = new System.Drawing.Size(157, 34);
            this.tovars.TabIndex = 2;
            this.tovars.Text = "Перегляд товарів";
            this.tovars.UseVisualStyleBackColor = true;
            this.tovars.Click += new System.EventHandler(this.tovars_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(375, 25);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(153, 20);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Облік складу товарів";
            // 
            // menuLabel
            // 
            this.menuLabel.AutoSize = true;
            this.menuLabel.Location = new System.Drawing.Point(375, 60);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(51, 20);
            this.menuLabel.TabIndex = 4;
            this.menuLabel.Text = "MENU";
            // 
            // chooseTovar
            // 
            this.chooseTovar.FormattingEnabled = true;
            this.chooseTovar.Location = new System.Drawing.Point(187, 161);
            this.chooseTovar.Name = "chooseTovar";
            this.chooseTovar.Size = new System.Drawing.Size(151, 28);
            this.chooseTovar.TabIndex = 5;
            this.chooseTovar.SelectedIndexChanged += new System.EventHandler(this.chooseTovar_SelectedIndexChanged);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(266, 317);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(125, 27);
            this.searchTextBox.TabIndex = 6;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(434, 317);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(94, 29);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "button1";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchResultsTextBox
            // 
            this.searchResultsTextBox.Location = new System.Drawing.Point(335, 384);
            this.searchResultsTextBox.Name = "searchResultsTextBox";
            this.searchResultsTextBox.Size = new System.Drawing.Size(125, 27);
            this.searchResultsTextBox.TabIndex = 8;
            // 
            // exportToCSVButton
            // 
            this.exportToCSVButton.Location = new System.Drawing.Point(356, 462);
            this.exportToCSVButton.Name = "exportToCSVButton";
            this.exportToCSVButton.Size = new System.Drawing.Size(94, 29);
            this.exportToCSVButton.TabIndex = 9;
            this.exportToCSVButton.Text = "button1";
            this.exportToCSVButton.UseVisualStyleBackColor = true;
            this.exportToCSVButton.Click += new System.EventHandler(this.exportToCSVButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.exportToCSVButton);
            this.Controls.Add(this.searchResultsTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.chooseTovar);
            this.Controls.Add(this.menuLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.tovars);
            this.Controls.Add(this.editTovar);
            this.Controls.Add(this.addTovar);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addTovar;
        private System.Windows.Forms.Button editTovar;
        private System.Windows.Forms.Button tovars;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.ComboBox chooseTovar;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchResultsTextBox;
        private System.Windows.Forms.Button exportToCSVButton;
    }
}

