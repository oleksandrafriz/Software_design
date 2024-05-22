﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ClassLibrary;
using ClassLibrary.Controllers;

namespace Inventory
{
    public partial class ShowTovar : Form
    {
        private ProductController productController;

        public ShowTovar(ProductController productController)
        {
            InitializeComponent();
            this.productController = productController;
            LoadProducts();
        }

        private void LoadProducts()
        {
            var products = productController.GetAllProducts();
            DisplayProducts(products);
        }

        private void DisplayProducts(List<Product> products)
        {
            dgvProducts.DataSource = products;

            SetColumnHeaders();
        }

        private void SetColumnHeaders()
        {
            dgvProducts.Columns["Id"].HeaderText = "ID товару";
            dgvProducts.Columns["Name"].HeaderText = "Назва товару";
            dgvProducts.Columns["Quantity"].HeaderText = "Кількість";
            dgvProducts.Columns["Price"].HeaderText = "Ціна";
            dgvProducts.Columns["Postachalnik"].HeaderText = "Постачальник";
        }

        private void LoadProductsSorted(Func<Product, object> keySelector, bool ascending = true)
        {
            var products = productController.GetAllProducts();
            var sortedProducts = ascending ? products.OrderBy(keySelector).ToList() : products.OrderByDescending(keySelector).ToList();
            DisplayProducts(sortedProducts);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                var productId = (int)dgvProducts.SelectedRows[0].Cells[0].Value;
                productController.DeleteProduct(productId);
                LoadProducts();
                MessageBox.Show("Продукт успішно видалено!");
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var searchText = searchTextBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(searchText))
            {
                MessageBox.Show("Будь ласка, введіть пошуковий термін.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var products = productController.GetAllProducts()
                                         .Where(p => p.Name.Split(' ').Any(word => word.Contains(searchText, StringComparison.CurrentCultureIgnoreCase)))
                                         .ToList();

            if (products.Count == 0)
            {
                MessageBox.Show("Не знайдено продуктів, що відповідають пошуковому терміну.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            DisplayProducts(products);
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadProducts();
        }

        private void sortByIdButton_Click(object sender, EventArgs e)
        {
            LoadProductsSorted(p => p.Id);
        }

        private void sortByNameButton_Click(object sender, EventArgs e)
        {
            LoadProductsSorted(p => p.Name);
        }

        private void sortByQuantityButton_Click(object sender, EventArgs e)
        {
            LoadProductsSorted(p => p.Quantity);
        }

        private void sortByPriceButton_Click(object sender, EventArgs e)
        {
            LoadProductsSorted(p => p.Price);
        }
    }
}
