using Entities.Concrete;
using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.Business.DependencyResolvers.Ninject;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.DataAccess.Concrete.NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WebFormsUI
{
    /*Bir katman diğerini newleyemez.*/
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
        }
        private IProductService _productService;
        private ICategoryService _categoryService;

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
        }

        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";

            cbxProductAddCategori.DataSource = _categoryService.GetAll();
            cbxProductAddCategori.DisplayMember = "CategoryName";
            cbxProductAddCategori.ValueMember = "CategoryId";

            cbxProductUpdateCategory.DataSource = _categoryService.GetAll();
            cbxProductUpdateCategory.DisplayMember = "CategoryName";
            cbxProductUpdateCategory.ValueMember = "CategoryId";
        }

        private void LoadProducts()
        {
            dgwProduct.DataSource = _productService.GetAll();
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProduct.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch 
            {

            }
            
        }

        private void tbxProductName_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbxProductName.Text))
            {
                dgwProduct.DataSource = _productService.GetProductsByProductName(tbxProductName.Text);
            }
            else
            {
                LoadProducts();
            }
            

        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            _productService.Add(new Product
            {

                CategoryId = Convert.ToInt32(cbxProductAddCategori.SelectedValue),
                ProductName=tbxProductAddProductName.Text,
                QuantityPerUnit=tbxProductAddQuantityPerUnit.Text,
                UnitPrice=Convert.ToDecimal(tbxProductAddUnitPrice.Text),
                UnitsInStock=Convert.ToInt16(tbxProductAddStockAmount.Text)

            });

            MessageBox.Show("Yeni Ürün Eklendi.");
            LoadProducts();

        }

        private void btnProductUpdate_Click(object sender, EventArgs e)
        {
            _productService.Update(new Product
            {
                ProductId=Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                ProductName=tbxProductUpdateProductName.Text,
                CategoryId=Convert.ToInt32(cbxProductUpdateCategory.SelectedValue),
                UnitsInStock=Convert.ToInt16(tbxProductUpdateStockAmount.Text),
                QuantityPerUnit=tbxProductUpdateQuantityPerUnit.Text,
                UnitPrice=Convert.ToDecimal(tbxProductUpdateUnitPrice.Text)
            });

            MessageBox.Show("Ürün Güncellendi.");
            LoadProducts();
        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwProduct.CurrentRow;
            tbxProductUpdateProductName.Text = row.Cells[2].Value.ToString();
            cbxProductUpdateCategory.SelectedValue = row.Cells[1].Value;
            tbxProductUpdateUnitPrice.Text = row.Cells[3].Value.ToString();
            tbxProductUpdateQuantityPerUnit.Text = row.Cells[4].Value.ToString();
            tbxProductUpdateStockAmount.Text = row.Cells[5].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                _productService.Delete(new Product
                {
                    ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value)
                });

                MessageBox.Show("Ürün Silindi.");
                LoadProducts();
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
