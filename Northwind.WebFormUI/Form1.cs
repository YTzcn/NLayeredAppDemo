using System.ComponentModel;
using Microsoft.VisualBasic;
using Northwind.Bussines.Abstract;
using Northwind.Bussines.Concrete;
using Northwind.Bussines.Concrete.EntityFramework;
using Northwind.Bussines.DependencyResolvers.Ninject;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.DataAccess.Concrete.NHibernate;
using Northwind.Entities.Concrete;

namespace Northwind.WebFormUI
{
    public partial class Form1 : Form
    {
        private IProductService _productService;
        private ICategoryService _categoryService;
        public Form1()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>(); 
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
        }

        private void LoadCategories()
        {
            cbxCategories.DataSource = _categoryService.GetAll();
            cbxCategories.DisplayMember = "CategoryName";
            cbxCategories.ValueMember = "CategoryId";

            cbxCategoryAdd.DataSource = _categoryService.GetAll();
            cbxCategoryAdd.DisplayMember = "CategoryName";
            cbxCategoryAdd.ValueMember = "CategoryId";

            cbxCategoryUpdate.DataSource = _categoryService.GetAll();
            cbxCategoryUpdate.DisplayMember = "CategoryName";
            cbxCategoryUpdate.ValueMember = "CategoryId";
        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = _productService.GetAll();
        }

        private void cbxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                dgwProducts.DataSource = _productService.GetProductByCategory(Convert.ToInt32(cbxCategories.SelectedValue));
            }
            catch
            {

            }
        }

        private void tbxSearchByName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxSearchByName.Text))
            {
                dgwProducts.DataSource = _productService.GetProductsByName(tbxSearchByName.Text);
            }
            else
            {
                LoadProducts();
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Add(new Product
                {
                    ProductName = tbxProductAddName.Text,
                    CategoryId = Convert.ToInt32(cbxCategories.SelectedValue),
                    UnitPrice = Convert.ToDecimal(tbxProductAddPrice.Text),
                    QuantityPerUnit = tbxQuantityPerUnitAdd.Text,
                    UnitsInStock = Convert.ToInt16(tbxStockAmountAdd.Text)
                });
                LoadProducts();
                MessageBox.Show("Ürün Eklendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Update(new Product
                {
                    ProductId = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                    ProductName = tbxNameUpdate.Text,
                    CategoryId = Convert.ToInt32(cbxCategories.SelectedValue),
                    UnitPrice = Convert.ToDecimal(tbxPriceUpdate.Text),
                    QuantityPerUnit = tbxQuantityPerUnitUpdate.Text,
                    UnitsInStock = Convert.ToInt16(tbxStockAmountUpdate.Text)
                });
                LoadProducts();
                MessageBox.Show("Ürün Güncellendi");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwProducts.CurrentRow;
            tbxNameUpdate.Text = row.Cells[2].Value.ToString();
            cbxCategoryUpdate.SelectedValue = row.Cells[1].Value;
            tbxPriceUpdate.Text = row.Cells[3].Value.ToString();
            tbxQuantityPerUnitUpdate.Text = row.Cells[4].Value.ToString();
            tbxStockAmountUpdate.Text = row.Cells[5].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgwProducts.CurrentRow != null)
            {
                try
                {
                    _productService.Delete(new Product
                    {
                        ProductId = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                    });
                    LoadProducts();
                    MessageBox.Show("Ürün Silindi");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Satýr Seçiniz!");
            }

        }
    }
}