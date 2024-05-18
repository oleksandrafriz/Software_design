
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
            this.saveNewTovar.Location = new System.Drawing.Point(296, 373);
            this.saveNewTovar.Name = "saveNewTovar";
            this.saveNewTovar.Size = new System.Drawing.Size(94, 29);
            this.saveNewTovar.TabIndex = 0;
            this.saveNewTovar.Text = "Зберегти";
            this.saveNewTovar.UseVisualStyleBackColor = true;
            this.saveNewTovar.Click += new System.EventHandler(this.saveNewTovar_Click);
            // 
            // AddTovarLabel
            // 
            this.AddTovarLabel.AutoSize = true;
            this.AddTovarLabel.Location = new System.Drawing.Point(313, 66);
            this.AddTovarLabel.Name = "AddTovarLabel";
            this.AddTovarLabel.Size = new System.Drawing.Size(151, 20);
            this.AddTovarLabel.TabIndex = 1;
            this.AddTovarLabel.Text = "Додати новий товар";
            // 
            // tovarNameLabel
            // 
            this.tovarNameLabel.AutoSize = true;
            this.tovarNameLabel.Location = new System.Drawing.Point(222, 160);
            this.tovarNameLabel.Name = "tovarNameLabel";
            this.tovarNameLabel.Size = new System.Drawing.Size(102, 20);
            this.tovarNameLabel.TabIndex = 2;
            this.tovarNameLabel.Text = "Назва товару";
            // 
            // quantityTovarLabel
            // 
            this.quantityTovarLabel.AutoSize = true;
            this.quantityTovarLabel.Location = new System.Drawing.Point(222, 204);
            this.quantityTovarLabel.Name = "quantityTovarLabel";
            this.quantityTovarLabel.Size = new System.Drawing.Size(121, 20);
            this.quantityTovarLabel.TabIndex = 3;
            this.quantityTovarLabel.Text = "Кількість товару";
            // 
            // priceTovarLabel
            // 
            this.priceTovarLabel.AutoSize = true;
            this.priceTovarLabel.Location = new System.Drawing.Point(222, 251);
            this.priceTovarLabel.Name = "priceTovarLabel";
            this.priceTovarLabel.Size = new System.Drawing.Size(41, 20);
            this.priceTovarLabel.TabIndex = 4;
            this.priceTovarLabel.Text = "Ціна";
            // 
            // postachTovarLabel
            // 
            this.postachTovarLabel.AutoSize = true;
            this.postachTovarLabel.Location = new System.Drawing.Point(222, 306);
            this.postachTovarLabel.Name = "postachTovarLabel";
            this.postachTovarLabel.Size = new System.Drawing.Size(107, 20);
            this.postachTovarLabel.TabIndex = 5;
            this.postachTovarLabel.Text = "Постачальник";
            // 
            // tovarName
            // 
            this.tovarName.Location = new System.Drawing.Point(356, 153);
            this.tovarName.Name = "tovarName";
            this.tovarName.Size = new System.Drawing.Size(125, 27);
            this.tovarName.TabIndex = 6;
            // 
            // quantityTovar
            // 
            this.quantityTovar.Location = new System.Drawing.Point(356, 201);
            this.quantityTovar.Name = "quantityTovar";
            this.quantityTovar.Size = new System.Drawing.Size(125, 27);
            this.quantityTovar.TabIndex = 7;
            // 
            // priceTovar
            // 
            this.priceTovar.Location = new System.Drawing.Point(356, 251);
            this.priceTovar.Name = "priceTovar";
            this.priceTovar.Size = new System.Drawing.Size(125, 27);
            this.priceTovar.TabIndex = 8;
            // 
            // postachTovar
            // 
            this.postachTovar.Location = new System.Drawing.Point(356, 299);
            this.postachTovar.Name = "postachTovar";
            this.postachTovar.Size = new System.Drawing.Size(125, 27);
            this.postachTovar.TabIndex = 9;
            // 
            // AddTovarPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Text = "AddTovarPage";
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