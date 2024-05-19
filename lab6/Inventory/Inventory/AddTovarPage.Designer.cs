
namespace Inventory
{
    partial class AddTovarPage
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
            this.saveNewTovar = new System.Windows.Forms.Button();
            this.AddTovarLabel = new System.Windows.Forms.Label();
            this.tovarNameLabel = new System.Windows.Forms.Label();
            this.quantityTovarLabel = new System.Windows.Forms.Label();
            this.priceTovarLabel = new System.Windows.Forms.Label();
            this.postachTovarLabel = new System.Windows.Forms.Label();
            this.tovarName = new System.Windows.Forms.TextBox();
            this.quantityTovar = new System.Windows.Forms.TextBox();
            this.priceTovar = new System.Windows.Forms.TextBox();
            this.postachTovar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // saveNewTovar
            // 
            this.saveNewTovar.BackColor = System.Drawing.Color.LightGreen;
            this.saveNewTovar.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveNewTovar.Location = new System.Drawing.Point(133, 315);
            this.saveNewTovar.Name = "saveNewTovar";
            this.saveNewTovar.Size = new System.Drawing.Size(160, 50);
            this.saveNewTovar.TabIndex = 0;
            this.saveNewTovar.Text = "Зберегти";
            this.saveNewTovar.UseVisualStyleBackColor = false;
            this.saveNewTovar.Click += new System.EventHandler(this.saveNewTovar_Click);
            // 
            // AddTovarLabel
            // 
            this.AddTovarLabel.AutoSize = true;
            this.AddTovarLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddTovarLabel.Location = new System.Drawing.Point(85, 37);
            this.AddTovarLabel.Name = "AddTovarLabel";
            this.AddTovarLabel.Size = new System.Drawing.Size(291, 37);
            this.AddTovarLabel.TabIndex = 1;
            this.AddTovarLabel.Text = "Додати новий товар";
            // 
            // tovarNameLabel
            // 
            this.tovarNameLabel.AutoSize = true;
            this.tovarNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tovarNameLabel.Location = new System.Drawing.Point(37, 127);
            this.tovarNameLabel.Name = "tovarNameLabel";
            this.tovarNameLabel.Size = new System.Drawing.Size(134, 28);
            this.tovarNameLabel.TabIndex = 2;
            this.tovarNameLabel.Text = "Назва товару";
            // 
            // quantityTovarLabel
            // 
            this.quantityTovarLabel.AutoSize = true;
            this.quantityTovarLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quantityTovarLabel.Location = new System.Drawing.Point(37, 167);
            this.quantityTovarLabel.Name = "quantityTovarLabel";
            this.quantityTovarLabel.Size = new System.Drawing.Size(160, 28);
            this.quantityTovarLabel.TabIndex = 3;
            this.quantityTovarLabel.Text = "Кількість товару";
            // 
            // priceTovarLabel
            // 
            this.priceTovarLabel.AutoSize = true;
            this.priceTovarLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceTovarLabel.Location = new System.Drawing.Point(37, 207);
            this.priceTovarLabel.Name = "priceTovarLabel";
            this.priceTovarLabel.Size = new System.Drawing.Size(54, 28);
            this.priceTovarLabel.TabIndex = 4;
            this.priceTovarLabel.Text = "Ціна";
            // 
            // postachTovarLabel
            // 
            this.postachTovarLabel.AutoSize = true;
            this.postachTovarLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.postachTovarLabel.Location = new System.Drawing.Point(37, 247);
            this.postachTovarLabel.Name = "postachTovarLabel";
            this.postachTovarLabel.Size = new System.Drawing.Size(141, 28);
            this.postachTovarLabel.TabIndex = 5;
            this.postachTovarLabel.Text = "Постачальник";
            // 
            // tovarName
            // 
            this.tovarName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tovarName.Location = new System.Drawing.Point(217, 124);
            this.tovarName.Name = "tovarName";
            this.tovarName.Size = new System.Drawing.Size(246, 34);
            this.tovarName.TabIndex = 6;
            // 
            // quantityTovar
            // 
            this.quantityTovar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quantityTovar.Location = new System.Drawing.Point(217, 164);
            this.quantityTovar.Name = "quantityTovar";
            this.quantityTovar.Size = new System.Drawing.Size(246, 34);
            this.quantityTovar.TabIndex = 7;
            // 
            // priceTovar
            // 
            this.priceTovar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceTovar.Location = new System.Drawing.Point(217, 204);
            this.priceTovar.Name = "priceTovar";
            this.priceTovar.Size = new System.Drawing.Size(246, 34);
            this.priceTovar.TabIndex = 8;
            // 
            // postachTovar
            // 
            this.postachTovar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.postachTovar.Location = new System.Drawing.Point(217, 244);
            this.postachTovar.Name = "postachTovar";
            this.postachTovar.Size = new System.Drawing.Size(246, 34);
            this.postachTovar.TabIndex = 9;
            // 
            // AddTovarPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(475, 429);
            this.Controls.Add(this.postachTovar);
            this.Controls.Add(this.priceTovar);
            this.Controls.Add(this.quantityTovar);
            this.Controls.Add(this.tovarName);
            this.Controls.Add(this.postachTovarLabel);
            this.Controls.Add(this.priceTovarLabel);
            this.Controls.Add(this.quantityTovarLabel);
            this.Controls.Add(this.tovarNameLabel);
            this.Controls.Add(this.AddTovarLabel);
            this.Controls.Add(this.saveNewTovar);
            this.Name = "AddTovarPage";
            this.Text = "Додати товар";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveNewTovar;
        private System.Windows.Forms.Label AddTovarLabel;
        private System.Windows.Forms.Label tovarNameLabel;
        private System.Windows.Forms.Label quantityTovarLabel;
        private System.Windows.Forms.Label priceTovarLabel;
        private System.Windows.Forms.Label postachTovarLabel;
        private System.Windows.Forms.TextBox tovarName;
        private System.Windows.Forms.TextBox quantityTovar;
        private System.Windows.Forms.TextBox priceTovar;
        private System.Windows.Forms.TextBox postachTovar;
    }
}