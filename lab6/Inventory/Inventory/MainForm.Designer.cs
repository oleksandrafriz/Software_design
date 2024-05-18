
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
            this.headerPanel = new System.Windows.Forms.Panel();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.statusLabel = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.footerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addTovar
            // 
            this.addTovar.BackColor = System.Drawing.Color.LightGreen;
            this.addTovar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addTovar.Location = new System.Drawing.Point(20, 60);
            this.addTovar.Name = "addTovar";
            this.addTovar.Size = new System.Drawing.Size(150, 40);
            this.addTovar.TabIndex = 0;
            this.addTovar.Text = "Додати товар";
            this.addTovar.UseVisualStyleBackColor = false;
            this.addTovar.Click += new System.EventHandler(this.addTovar_Click);
            // 
            // editTovar
            // 
            this.editTovar.BackColor = System.Drawing.Color.LightYellow;
            this.editTovar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editTovar.Location = new System.Drawing.Point(20, 120);
            this.editTovar.Name = "editTovar";
            this.editTovar.Size = new System.Drawing.Size(150, 40);
            this.editTovar.TabIndex = 1;
            this.editTovar.Text = "Редагувати товар";
            this.editTovar.UseVisualStyleBackColor = false;
            this.editTovar.Click += new System.EventHandler(this.editTovar_Click);
            // 
            // tovars
            // 
            this.tovars.BackColor = System.Drawing.Color.LightCoral;
            this.tovars.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tovars.Location = new System.Drawing.Point(20, 180);
            this.tovars.Name = "tovars";
            this.tovars.Size = new System.Drawing.Size(150, 40);
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
            this.titleLabel.Location = new System.Drawing.Point(250, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(300, 37);
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
            this.menuLabel.Size = new System.Drawing.Size(83, 32);
            this.menuLabel.TabIndex = 4;
            this.menuLabel.Text = "Меню";
            // 
            // chooseTovar
            // 
            this.chooseTovar.FormattingEnabled = true;
            this.chooseTovar.Location = new System.Drawing.Point(250, 250);
            this.chooseTovar.Name = "chooseTovar";
            this.chooseTovar.Size = new System.Drawing.Size(300, 28);
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
            this.headerPanel.Size = new System.Drawing.Size(800, 80);
            this.headerPanel.TabIndex = 6;
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.menuPanel.Controls.Add(this.menuLabel);
            this.menuPanel.Controls.Add(this.addTovar);
            this.menuPanel.Controls.Add(this.editTovar);
            this.menuPanel.Controls.Add(this.tovars);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 80);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(200, 370);
            this.menuPanel.TabIndex = 7;
            // 
            // footerPanel
            // 
            this.footerPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.footerPanel.Controls.Add(this.statusLabel);
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.Location = new System.Drawing.Point(0, 450);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(800, 50);
            this.footerPanel.TabIndex = 8;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusLabel.ForeColor = System.Drawing.Color.White;
            this.statusLabel.Location = new System.Drawing.Point(10, 15);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(62, 23);
            this.statusLabel.TabIndex = 0;
            this.statusLabel.Text = "Статус";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
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
            this.footerPanel.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label statusLabel;
    }
}

