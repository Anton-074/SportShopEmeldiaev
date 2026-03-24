using Microsoft.EntityFrameworkCore;
using ShoesShop.Properties;
using SportShopEmeld.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Text;
using System.Windows.Forms;

namespace SportShopEmeld
{
    public partial class FormGoods : Form
    {
        public User CurrentUser { get; private set; }
        public bool IsGuest { get; private set; }
        public FormGoods(User user, bool guest)
        {
            InitializeComponent();
            var colPhoto = new DataGridViewImageColumn();
            colPhoto.Name = "colPhoto";
            colPhoto.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colPhoto.Width = 200;
            colPhoto.FillWeight = 30;

            var colInfo = new DataGridViewTextBoxColumn();
            colInfo.Name = "colInfo";
            colInfo.FillWeight = 60;
            colInfo.Width = 350;
            colInfo.DefaultCellStyle.WrapMode = DataGridViewTriState.True;


            var colDiscount = new DataGridViewTextBoxColumn();
            colDiscount.Name = "colDiscount";
            colDiscount.FillWeight = 10;
            colDiscount.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvProducts.Columns.AddRange(
            [
                colPhoto, colInfo, colDiscount
            ]);

            CurrentUser = user;
            IsGuest = guest;

            lblUserName.Text = IsGuest ? "Гость" : CurrentUser.Fullname;

            LoadProducts();

        }
        private void LoadProducts()
        {
            try
            {
                using (var db = new SportShopContext())
                {
                    var products = db.Goods
                        .Include(i => i.Category)
                        .Include(i => i.Manufacture)
                        .Include(i => i.Supplier)
                        .Include(i => i.Unit)
                        .ToList();

                    dgvProducts.SuspendLayout();
                    dgvProducts.Rows.Clear();

                    foreach (var product in products)
                    {
                        int rowIndex = dgvProducts.Rows.Add();
                        var row = dgvProducts.Rows[rowIndex];

                       //row.Cells["colPhoto"].Value = LoadProductImage(product.PhotoUrl);

                        row.Cells["colInfo"].Value = FormatProductInfo(product);

                        row.Cells["colDiscount"].Value = $"{product.Sale}%";
                        row.Cells["colDiscount"].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                        ApplyRowStyles(row, product);
                    }
                    dgvProducts.ResumeLayout();
                    dgvProducts.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ApplyRowStyles(DataGridViewRow row, Good product)
        {
            if (product.Sale > 15)
            {
                row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#2EC4B6");
                row.DefaultCellStyle.ForeColor = Color.White;
            }

            if (product.CountInStock <= 0)
            {
                row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#E9F5FF") ;
                if (product.Sale <= 15)
                {
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
            }

            if (product.Sale > 0)
            {
                row.Cells["colDiscount"].Style.ForeColor = Color.Red;
                row.Cells["colDiscount"].Style.Font = new Font(
                    "Times New Roman",
                    12,
                    FontStyle.Bold);
            }
        }
        private string FormatProductInfo(Good product)
        {
            string priceText;

            if (product.Sale > 0)
            {
                decimal finalPrice = product.Price * (100 - product.Sale) / 100;
                priceText = $"Цена: {product.Price:C} -> {finalPrice:C}";
            }
            else
            {
                priceText = $"Цена: {product.Price:C}";
            }

            return $"{product.Category.Name}" + Environment.NewLine +
                $"Описание товара: {product.Description}" + Environment.NewLine +
                $"Производитель: {product.Manufacture.Name}" + Environment.NewLine +
                $"Поставщик: {product.Supplier.Name}" + Environment.NewLine +
                $"Цена {priceText}" + Environment.NewLine +
                $"Единица измерения: {product.Unit.Name}" + Environment.NewLine +
                $"Количество на складе: {product.CountInStock}";
        }

        private Image LoadProductImage(string photoUrl)
        {
            if (!String.IsNullOrEmpty(photoUrl) && System.IO.File.Exists(photoUrl))
            {
                return Image.FromFile(photoUrl);
            }

            return Resources.picture;
        }
        private void BtnLogut_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
        }

    }
}
