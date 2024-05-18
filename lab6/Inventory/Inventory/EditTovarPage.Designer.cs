
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
            this.chooseTovarLabel = new System.Windows.Forms.Label();
            this.tovarNameEditLabel = new System.Windows.Forms.Label();
            this.quantityEditTovarLabel = new System.Windows.Forms.Label();
            this.priceTovarEditLabel = new System.Windows.Forms.Label();
            this.postachTovarEditLabel = new System.Windows.Forms.Label();
            this.EditedPostachTovar = new System.Windows.Forms.TextBox();
            this.editedPriceTovar = new System.Windows.Forms.TextBox();
            this.editedQuantityTovar = new System.Windows.Forms.TextBox();
            this.editedTovarName = new System.Windows.Forms.TextBox();
            this.chooseTovar = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // saveEditedTovar
            // 
            this.saveEditedTovar.Location = new System.Drawing.Point(347, 375);
            this.saveEditedTovar.Name = "saveEditedTovar";
            this.saveEditedTovar.Size = new System.Drawing.Size(94, 29);
            this.saveEditedTovar.TabIndex = 0;
            this.saveEditedTovar.Text = "Зберегти";
            this.saveEditedTovar.UseVisualStyleBackColor = true;
            this.saveEditedTovar.Click += new System.EventHandler(this.saveEditedTovar_Click);
            // 
            // EditTovarLabel
            // 
            this.EditTovarLabel.AutoSize = true;
            this.EditTovarLabel.Location = new System.Drawing.Point(391, 35);
            this.EditTovarLabel.Name = "EditTovarLabel";
            this.EditTovarLabel.Size = new System.Drawing.Size(177, 20);
            this.EditTovarLabel.TabIndex = 1;
            this.EditTovarLabel.Text = "Редагувати новий товар";
            // 
            // chooseTovarLabel
            // 
            this.chooseTovarLabel.AutoSize = true;
            this.chooseTovarLabel.Location = new System.Drawing.Point(287, 109);
            this.chooseTovarLabel.Name = "chooseTovarLabel";
            this.chooseTovarLabel.Size = new System.Drawing.Size(134, 20);
            this.chooseTovarLabel.TabIndex = 2;
            this.chooseTovarLabel.Text = "Оберіть ID товару";
            // 
            // tovarNameEditLabel
            // 
            this.tovarNameEditLabel.AutoSize = true;
            this.tovarNameEditLabel.Location = new System.Drawing.Point(287, 164);
            this.tovarNameEditLabel.Name = "tovarNameEditLabel";
            this.tovarNameEditLabel.Size = new System.Drawing.Size(102, 20);
            this.tovarNameEditLabel.TabIndex = 3;
            this.tovarNameEditLabel.Text = "Назва товару";
            // 
            // quantityEditTovarLabel
            // 
            this.quantityEditTovarLabel.AutoSize = true;
            this.quantityEditTovarLabel.Location = new System.Drawing.Point(287, 212);
            this.quantityEditTovarLabel.Name = "quantityEditTovarLabel";
            this.quantityEditTovarLabel.Size = new System.Drawing.Size(121, 20);
            this.quantityEditTovarLabel.TabIndex = 4;
            this.quantityEditTovarLabel.Text = "Кількість товару";
            // 
            // priceTovarEditLabel
            // 
            this.priceTovarEditLabel.AutoSize = true;
            this.priceTovarEditLabel.Location = new System.Drawing.Point(287, 256);
            this.priceTovarEditLabel.Name = "priceTovarEditLabel";
            this.priceTovarEditLabel.Size = new System.Drawing.Size(41, 20);
            this.priceTovarEditLabel.TabIndex = 5;
            this.priceTovarEditLabel.Text = "Ціна";
            // 
            // postachTovarEditLabel
            // 
            this.postachTovarEditLabel.AutoSize = true;
            this.postachTovarEditLabel.Location = new System.Drawing.Point(287, 315);
            this.postachTovarEditLabel.Name = "postachTovarEditLabel";
            this.postachTovarEditLabel.Size = new System.Drawing.Size(107, 20);
            this.postachTovarEditLabel.TabIndex = 6;
            this.postachTovarEditLabel.Text = "Постачальник";
            // 
            // EditedPostachTovar
            // 
            this.EditedPostachTovar.Location = new System.Drawing.Point(417, 308);
            this.EditedPostachTovar.Name = "EditedPostachTovar";
            this.EditedPostachTovar.Size = new System.Drawing.Size(125, 27);
            this.EditedPostachTovar.TabIndex = 7;
            // 
            // editedPriceTovar
            // 
            this.editedPriceTovar.Location = new System.Drawing.Point(417, 253);
            this.editedPriceTovar.Name = "editedPriceTovar";
            this.editedPriceTovar.Size = new System.Drawing.Size(125, 27);
            this.editedPriceTovar.TabIndex = 8;
            // 
            // editedQuantityTovar
            // 
            this.editedQuantityTovar.Location = new System.Drawing.Point(417, 205);
            this.editedQuantityTovar.Name = "editedQuantityTovar";
            this.editedQuantityTovar.Size = new System.Drawing.Size(125, 27);
            this.editedQuantityTovar.TabIndex = 9;
            // 
            // editedTovarName
            // 
            this.editedTovarName.Location = new System.Drawing.Point(417, 161);
            this.editedTovarName.Name = "editedTovarName";
            this.editedTovarName.Size = new System.Drawing.Size(125, 27);
            this.editedTovarName.TabIndex = 10;
            // 
            // chooseTovar
            // 
            this.chooseTovar.FormattingEnabled = true;
            this.chooseTovar.Location = new System.Drawing.Point(427, 106);
            this.chooseTovar.Name = "chooseTovar";
            this.chooseTovar.Size = new System.Drawing.Size(151, 28);
            this.chooseTovar.TabIndex = 11;
            this.chooseTovar.SelectedIndexChanged += new System.EventHandler(this.chooseTovar_SelectedIndexChanged);
            // 
            // EditTovarPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chooseTovar);
            this.Controls.Add(this.editedTovarName);
            this.Controls.Add(this.editedQuantityTovar);
            this.Controls.Add(this.editedPriceTovar);
            this.Controls.Add(this.EditedPostachTovar);
            this.Controls.Add(this.postachTovarEditLabel);
            this.Controls.Add(this.priceTovarEditLabel);
            this.Controls.Add(this.quantityEditTovarLabel);
            this.Controls.Add(this.tovarNameEditLabel);
            this.Controls.Add(this.chooseTovarLabel);
            this.Controls.Add(this.EditTovarLabel);
            this.Controls.Add(this.saveEditedTovar);
            this.Name = "EditTovarPage";
            this.Text = "EditTovarPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveEditedTovar;
        private System.Windows.Forms.Label EditTovarLabel;
        private System.Windows.Forms.Label chooseTovarLabel;
        private System.Windows.Forms.Label tovarNameEditLabel;
        private System.Windows.Forms.Label quantityEditTovarLabel;
        private System.Windows.Forms.Label priceTovarEditLabel;
        private System.Windows.Forms.Label postachTovarEditLabel;
        private System.Windows.Forms.TextBox EditedPostachTovar;
        private System.Windows.Forms.TextBox editedPriceTovar;
        private System.Windows.Forms.TextBox editedQuantityTovar;
        private System.Windows.Forms.TextBox editedTovarName;
        private System.Windows.Forms.ComboBox chooseTovar;
    }
}