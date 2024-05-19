
namespace Inventory
{
    partial class EditTovarPage
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
            this.saveEditedTovar = new System.Windows.Forms.Button();
            this.EditTovarLabel = new System.Windows.Forms.Label();
            this.tovarNameEditLabel = new System.Windows.Forms.Label();
            this.quantityEditTovarLabel = new System.Windows.Forms.Label();
            this.priceTovarEditLabel = new System.Windows.Forms.Label();
            this.postachTovarEditLabel = new System.Windows.Forms.Label();
            this.EditedPostachTovar = new System.Windows.Forms.TextBox();
            this.editedPriceTovar = new System.Windows.Forms.TextBox();
            this.editedQuantityTovar = new System.Windows.Forms.TextBox();
            this.editedTovarName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // saveEditedTovar
            // 
            this.saveEditedTovar.BackColor = System.Drawing.Color.LightGreen;
            this.saveEditedTovar.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveEditedTovar.Location = new System.Drawing.Point(124, 332);
            this.saveEditedTovar.Name = "saveEditedTovar";
            this.saveEditedTovar.Size = new System.Drawing.Size(156, 46);
            this.saveEditedTovar.TabIndex = 0;
            this.saveEditedTovar.Text = "Зберегти";
            this.saveEditedTovar.UseVisualStyleBackColor = false;
            this.saveEditedTovar.Click += new System.EventHandler(this.saveEditedTovar_Click);
            // 
            // EditTovarLabel
            // 
            this.EditTovarLabel.AutoSize = true;
            this.EditTovarLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditTovarLabel.Location = new System.Drawing.Point(66, 42);
            this.EditTovarLabel.Name = "EditTovarLabel";
            this.EditTovarLabel.Size = new System.Drawing.Size(341, 37);
            this.EditTovarLabel.TabIndex = 1;
            this.EditTovarLabel.Text = "Редагувати новий товар";
            // 
            // tovarNameEditLabel
            // 
            this.tovarNameEditLabel.AutoSize = true;
            this.tovarNameEditLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tovarNameEditLabel.Location = new System.Drawing.Point(18, 132);
            this.tovarNameEditLabel.Name = "tovarNameEditLabel";
            this.tovarNameEditLabel.Size = new System.Drawing.Size(134, 28);
            this.tovarNameEditLabel.TabIndex = 3;
            this.tovarNameEditLabel.Text = "Назва товару";
            // 
            // quantityEditTovarLabel
            // 
            this.quantityEditTovarLabel.AutoSize = true;
            this.quantityEditTovarLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quantityEditTovarLabel.Location = new System.Drawing.Point(18, 172);
            this.quantityEditTovarLabel.Name = "quantityEditTovarLabel";
            this.quantityEditTovarLabel.Size = new System.Drawing.Size(160, 28);
            this.quantityEditTovarLabel.TabIndex = 4;
            this.quantityEditTovarLabel.Text = "Кількість товару";
            // 
            // priceTovarEditLabel
            // 
            this.priceTovarEditLabel.AutoSize = true;
            this.priceTovarEditLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceTovarEditLabel.Location = new System.Drawing.Point(18, 212);
            this.priceTovarEditLabel.Name = "priceTovarEditLabel";
            this.priceTovarEditLabel.Size = new System.Drawing.Size(54, 28);
            this.priceTovarEditLabel.TabIndex = 5;
            this.priceTovarEditLabel.Text = "Ціна";
            // 
            // postachTovarEditLabel
            // 
            this.postachTovarEditLabel.AutoSize = true;
            this.postachTovarEditLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.postachTovarEditLabel.Location = new System.Drawing.Point(18, 252);
            this.postachTovarEditLabel.Name = "postachTovarEditLabel";
            this.postachTovarEditLabel.Size = new System.Drawing.Size(141, 28);
            this.postachTovarEditLabel.TabIndex = 6;
            this.postachTovarEditLabel.Text = "Постачальник";
            // 
            // EditedPostachTovar
            // 
            this.EditedPostachTovar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditedPostachTovar.Location = new System.Drawing.Point(190, 252);
            this.EditedPostachTovar.Name = "EditedPostachTovar";
            this.EditedPostachTovar.Size = new System.Drawing.Size(270, 34);
            this.EditedPostachTovar.TabIndex = 7;
            // 
            // editedPriceTovar
            // 
            this.editedPriceTovar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editedPriceTovar.Location = new System.Drawing.Point(190, 212);
            this.editedPriceTovar.Name = "editedPriceTovar";
            this.editedPriceTovar.Size = new System.Drawing.Size(270, 34);
            this.editedPriceTovar.TabIndex = 8;
            // 
            // editedQuantityTovar
            // 
            this.editedQuantityTovar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editedQuantityTovar.Location = new System.Drawing.Point(190, 172);
            this.editedQuantityTovar.Name = "editedQuantityTovar";
            this.editedQuantityTovar.Size = new System.Drawing.Size(270, 34);
            this.editedQuantityTovar.TabIndex = 9;
            // 
            // editedTovarName
            // 
            this.editedTovarName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editedTovarName.Location = new System.Drawing.Point(190, 132);
            this.editedTovarName.Name = "editedTovarName";
            this.editedTovarName.Size = new System.Drawing.Size(270, 34);
            this.editedTovarName.TabIndex = 10;
            // 
            // EditTovarPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(489, 445);
            this.Controls.Add(this.editedTovarName);
            this.Controls.Add(this.editedQuantityTovar);
            this.Controls.Add(this.editedPriceTovar);
            this.Controls.Add(this.EditedPostachTovar);
            this.Controls.Add(this.postachTovarEditLabel);
            this.Controls.Add(this.priceTovarEditLabel);
            this.Controls.Add(this.quantityEditTovarLabel);
            this.Controls.Add(this.tovarNameEditLabel);
            this.Controls.Add(this.EditTovarLabel);
            this.Controls.Add(this.saveEditedTovar);
            this.Name = "EditTovarPage";
            this.Text = "Редагувати товар";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveEditedTovar;
        private System.Windows.Forms.Label EditTovarLabel;
        private System.Windows.Forms.Label tovarNameEditLabel;
        private System.Windows.Forms.Label quantityEditTovarLabel;
        private System.Windows.Forms.Label priceTovarEditLabel;
        private System.Windows.Forms.Label postachTovarEditLabel;
        private System.Windows.Forms.TextBox EditedPostachTovar;
        private System.Windows.Forms.TextBox editedPriceTovar;
        private System.Windows.Forms.TextBox editedQuantityTovar;
        private System.Windows.Forms.TextBox editedTovarName;
    }
}