
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
            // 
            // tovars
            // 
            this.tovars.Location = new System.Drawing.Point(356, 216);
            this.tovars.Name = "tovars";
            this.tovars.Size = new System.Drawing.Size(94, 29);
            this.tovars.TabIndex = 2;
            this.tovars.Text = "Перегляд товарів";
            this.tovars.UseVisualStyleBackColor = true;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

