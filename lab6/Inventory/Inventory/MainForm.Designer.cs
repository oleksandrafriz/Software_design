
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.addTovar = new System.Windows.Forms.Button();
            this.editTovar = new System.Windows.Forms.Button();
            this.tovars = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.menuLabel = new System.Windows.Forms.Label();
            this.chooseTovar = new System.Windows.Forms.ComboBox();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.postachalniki = new System.Windows.Forms.Button();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.exportToCSVButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchResultsLabel = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.footerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addTovar
            // 
            this.addTovar.BackColor = System.Drawing.Color.LightGreen;
            this.addTovar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addTovar.Location = new System.Drawing.Point(12, 60);
            this.addTovar.Name = "addTovar";
            this.addTovar.Size = new System.Drawing.Size(180, 41);
            this.addTovar.TabIndex = 0;
            this.addTovar.Text = "Додати товар";
            this.addTovar.UseVisualStyleBackColor = false;
            this.addTovar.Click += new System.EventHandler(this.addTovar_Click);
            // 
            // editTovar
            // 
            this.editTovar.BackColor = System.Drawing.Color.LightYellow;
            this.editTovar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editTovar.Location = new System.Drawing.Point(12, 120);
            this.editTovar.Name = "editTovar";
            this.editTovar.Size = new System.Drawing.Size(180, 41);
            this.editTovar.TabIndex = 1;
            this.editTovar.Text = "Редагувати товар";
            this.editTovar.UseVisualStyleBackColor = false;
            this.editTovar.Click += new System.EventHandler(this.editTovar_Click);
            // 
            // tovars
            // 
            this.tovars.BackColor = System.Drawing.Color.LightCoral;
            this.tovars.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tovars.Location = new System.Drawing.Point(12, 180);
            this.tovars.Name = "tovars";
            this.tovars.Size = new System.Drawing.Size(180, 42);
            this.tovars.TabIndex = 2;
            this.tovars.Text = "Перегляд товарів";
            this.tovars.UseVisualStyleBackColor = false;
            this.tovars.Click += new System.EventHandler(this.tovars_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(201, 25);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(298, 37);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Облік складу товарів";
            // 
            // menuLabel
            // 
            this.menuLabel.AutoSize = true;
            this.menuLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuLabel.ForeColor = System.Drawing.Color.White;
            this.menuLabel.Location = new System.Drawing.Point(20, 10);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(86, 32);
            this.menuLabel.TabIndex = 4;
            this.menuLabel.Text = "Меню";
            // 
            // chooseTovar
            // 
            this.chooseTovar.FormattingEnabled = true;
            this.chooseTovar.Location = new System.Drawing.Point(488, 99);
            this.chooseTovar.Name = "chooseTovar";
            this.chooseTovar.Size = new System.Drawing.Size(152, 28);
            this.chooseTovar.TabIndex = 5;
            this.chooseTovar.SelectedIndexChanged += new System.EventHandler(this.chooseTovar_SelectedIndexChanged);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.headerPanel.Controls.Add(this.titleLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(693, 80);
            this.headerPanel.TabIndex = 6;
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.menuPanel.Controls.Add(this.postachalniki);
            this.menuPanel.Controls.Add(this.menuLabel);
            this.menuPanel.Controls.Add(this.addTovar);
            this.menuPanel.Controls.Add(this.editTovar);
            this.menuPanel.Controls.Add(this.tovars);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 80);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(200, 389);
            this.menuPanel.TabIndex = 7;
            // 
            // postachalniki
            // 
            this.postachalniki.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.postachalniki.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.postachalniki.Location = new System.Drawing.Point(12, 243);
            this.postachalniki.Name = "postachalniki";
            this.postachalniki.Size = new System.Drawing.Size(180, 72);
            this.postachalniki.TabIndex = 5;
            this.postachalniki.Text = "Перегляд постачальників";
            this.postachalniki.UseVisualStyleBackColor = false;
            this.postachalniki.Click += new System.EventHandler(this.postachalniki_Click);
            // 
            // footerPanel
            // 
            this.footerPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.footerPanel.Controls.Add(this.exportToCSVButton);
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.Location = new System.Drawing.Point(0, 469);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(693, 50);
            this.footerPanel.TabIndex = 8;
            // 
            // exportToCSVButton
            // 
            this.exportToCSVButton.BackColor = System.Drawing.Color.SteelBlue;
            this.exportToCSVButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exportToCSVButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exportToCSVButton.Location = new System.Drawing.Point(306, 3);
            this.exportToCSVButton.Name = "exportToCSVButton";
            this.exportToCSVButton.Size = new System.Drawing.Size(95, 44);
            this.exportToCSVButton.TabIndex = 9;
            this.exportToCSVButton.Text = "CSV";
            this.exportToCSVButton.UseVisualStyleBackColor = false;
            this.exportToCSVButton.Click += new System.EventHandler(this.exportToCSVButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(226, 186);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(204, 27);
            this.searchTextBox.TabIndex = 6;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.YellowGreen;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchButton.Location = new System.Drawing.Point(458, 180);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(127, 42);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "пошук";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(217, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Оберіть товар для редагування";
            // 
            // searchResultsLabel
            // 
            this.searchResultsLabel.AutoSize = true;
            this.searchResultsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchResultsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchResultsLabel.Location = new System.Drawing.Point(240, 260);
            this.searchResultsLabel.Name = "searchResultsLabel";
            this.searchResultsLabel.Size = new System.Drawing.Size(2, 30);
            this.searchResultsLabel.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(693, 519);
            this.Controls.Add(this.searchResultsLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.chooseTovar);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.footerPanel);
            this.Name = "MainForm";
            this.Text = "Inventory Management";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.footerPanel.ResumeLayout(false);
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
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button exportToCSVButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label searchResultsLabel;
        private System.Windows.Forms.Button postachalniki;
    }
}

