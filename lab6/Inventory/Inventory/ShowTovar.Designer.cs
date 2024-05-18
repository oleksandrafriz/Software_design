
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
            this.searchButton.Location = new System.Drawing.Point(237, 43);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(94, 29);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Пошук";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(82, 391);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(94, 29);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Видалити";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(603, 391);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(94, 29);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Оновити";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(67, 43);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(125, 27);
            this.searchTextBox.TabIndex = 3;
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(67, 110);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 29;
            this.dgvProducts.Size = new System.Drawing.Size(630, 232);
            this.dgvProducts.TabIndex = 4;
            this.dgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellContentClick);
            // 
            // sortByIdButton
            // 
            this.sortByIdButton.Location = new System.Drawing.Point(798, 144);
            this.sortByIdButton.Name = "sortByIdButton";
            this.sortByIdButton.Size = new System.Drawing.Size(94, 29);
            this.sortByIdButton.TabIndex = 5;
            this.sortByIdButton.Text = "button1";
            this.sortByIdButton.UseVisualStyleBackColor = true;
            this.sortByIdButton.Click += new System.EventHandler(this.sortByIdButton_Click);
            // 
            // sortByNameButton
            // 
            this.sortByNameButton.Location = new System.Drawing.Point(798, 202);
            this.sortByNameButton.Name = "sortByNameButton";
            this.sortByNameButton.Size = new System.Drawing.Size(94, 29);
            this.sortByNameButton.TabIndex = 6;
            this.sortByNameButton.Text = "button2";
            this.sortByNameButton.UseVisualStyleBackColor = true;
            this.sortByNameButton.Click += new System.EventHandler(this.sortByNameButton_Click);
            // 
            // sortByQuantityButton
            // 
            this.sortByQuantityButton.Location = new System.Drawing.Point(798, 263);
            this.sortByQuantityButton.Name = "sortByQuantityButton";
            this.sortByQuantityButton.Size = new System.Drawing.Size(94, 29);
            this.sortByQuantityButton.TabIndex = 7;
            this.sortByQuantityButton.Text = "button3";
            this.sortByQuantityButton.UseVisualStyleBackColor = true;
            this.sortByQuantityButton.Click += new System.EventHandler(this.sortByQuantityButton_Click);
            // 
            // sortByPriceButton
            // 
            this.sortByPriceButton.Location = new System.Drawing.Point(798, 313);
            this.sortByPriceButton.Name = "sortByPriceButton";
            this.sortByPriceButton.Size = new System.Drawing.Size(94, 29);
            this.sortByPriceButton.TabIndex = 8;
            this.sortByPriceButton.Text = "button4";
            this.sortByPriceButton.UseVisualStyleBackColor = true;
            this.sortByPriceButton.Click += new System.EventHandler(this.sortByPriceButton_Click);
            // 
            // ShowTovar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 450);
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
            this.Text = "ShowTovar";
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