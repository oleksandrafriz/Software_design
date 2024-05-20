
namespace Inventory
{
    partial class ShowTovar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowTovar));
            this.searchButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.sortByIdButton = new System.Windows.Forms.Button();
            this.sortByNameButton = new System.Windows.Forms.Button();
            this.sortByQuantityButton = new System.Windows.Forms.Button();
            this.sortByPriceButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchButton.Location = new System.Drawing.Point(339, 40);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 35);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Пошук";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.LightCoral;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.Location = new System.Drawing.Point(99, 419);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(100, 35);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Видалити";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.LightGreen;
            this.updateButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.updateButton.Location = new System.Drawing.Point(649, 419);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(100, 35);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Оновити";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchTextBox.Location = new System.Drawing.Point(60, 45);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(253, 30);
            this.searchTextBox.TabIndex = 3;
            // 
            // dgvProducts
            // 
            this.dgvProducts.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.GridColor = System.Drawing.Color.Bisque;
            this.dgvProducts.Location = new System.Drawing.Point(12, 100);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 29;
            this.dgvProducts.Size = new System.Drawing.Size(814, 301);
            this.dgvProducts.TabIndex = 4;
            this.dgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellContentClick);
            // 
            // sortByIdButton
            // 
            this.sortByIdButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.sortByIdButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sortByIdButton.Location = new System.Drawing.Point(832, 100);
            this.sortByIdButton.Name = "sortByIdButton";
            this.sortByIdButton.Size = new System.Drawing.Size(236, 35);
            this.sortByIdButton.TabIndex = 5;
            this.sortByIdButton.Text = "Сортувати за ID";
            this.sortByIdButton.UseVisualStyleBackColor = false;
            this.sortByIdButton.Click += new System.EventHandler(this.sortByIdButton_Click);
            // 
            // sortByNameButton
            // 
            this.sortByNameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sortByNameButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sortByNameButton.Location = new System.Drawing.Point(832, 160);
            this.sortByNameButton.Name = "sortByNameButton";
            this.sortByNameButton.Size = new System.Drawing.Size(236, 35);
            this.sortByNameButton.TabIndex = 6;
            this.sortByNameButton.Text = "Сортувати за назвою";
            this.sortByNameButton.UseVisualStyleBackColor = false;
            this.sortByNameButton.Click += new System.EventHandler(this.sortByNameButton_Click);
            // 
            // sortByQuantityButton
            // 
            this.sortByQuantityButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.sortByQuantityButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sortByQuantityButton.Location = new System.Drawing.Point(832, 220);
            this.sortByQuantityButton.Name = "sortByQuantityButton";
            this.sortByQuantityButton.Size = new System.Drawing.Size(236, 35);
            this.sortByQuantityButton.TabIndex = 7;
            this.sortByQuantityButton.Text = "Сортувати за кількістю";
            this.sortByQuantityButton.UseVisualStyleBackColor = false;
            this.sortByQuantityButton.Click += new System.EventHandler(this.sortByQuantityButton_Click);
            // 
            // sortByPriceButton
            // 
            this.sortByPriceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.sortByPriceButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sortByPriceButton.Location = new System.Drawing.Point(832, 280);
            this.sortByPriceButton.Name = "sortByPriceButton";
            this.sortByPriceButton.Size = new System.Drawing.Size(236, 35);
            this.sortByPriceButton.TabIndex = 8;
            this.sortByPriceButton.Text = "Сортувати за ціною";
            this.sortByPriceButton.UseVisualStyleBackColor = false;
            this.sortByPriceButton.Click += new System.EventHandler(this.sortByPriceButton_Click);
            // 
            // ShowTovar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1092, 506);
            this.Controls.Add(this.sortByPriceButton);
            this.Controls.Add(this.sortByQuantityButton);
            this.Controls.Add(this.sortByNameButton);
            this.Controls.Add(this.sortByIdButton);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.searchButton);
            this.Name = "ShowTovar";
            this.Text = "Перегляд товарів";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button sortByIdButton;
        private System.Windows.Forms.Button sortByNameButton;
        private System.Windows.Forms.Button sortByQuantityButton;
        private System.Windows.Forms.Button sortByPriceButton;
    }
}