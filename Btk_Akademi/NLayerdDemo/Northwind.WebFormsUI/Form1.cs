using Northwind.Businness.Abstracts.Type;
using Northwind.Businness.Concretes.Type;
using Northwind.Businness.DependencyResolvers.Ninject;
using Northwind.DataAccess.Abstracts.Type;
using Northwind.DataAccess.Concretes.EntityFramework.Config;
using Northwind.DataAccess.Concretes.EntityFramework.Type;
using Northwind.DataAccess.Concretes.NHibernate;
using Northwind.Entites.Concretes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        IProductService _productService = InstanceFactory.GetIstance<IProductService>();
        ICategoryService _categoryService = InstanceFactory.GetIstance<ICategoryService>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupShow("gbxSave");
            listProducts();
            fiilCategory(getCategories(),cbxCategory);
            fiilCategory(getCategories(false), cbxSaveCategory);
            fiilCategory(getCategories(false), cbxUpdateCategory);

        }

        //Searchs
        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                listProducts(Convert.ToInt32(cbxCategory.SelectedValue.ToString()));
            }
            catch
            {}

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            listProducts(Convert.ToInt32(cbxCategory.SelectedValue.ToString()));
        }

        //Clicks
        private void btnSaveSave_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product();
                product.ProductName = txtSaveName.Text;
                product.CategoryId = Convert.ToInt32(cbxSaveCategory.SelectedValue);
                product.QuantityPerUnit = txtSaveQuantity.Text;
                product.UnitPrice = Convert.ToDecimal(txtSavePrice.Text);
                product.UnitsInStock = Convert.ToInt16(txtSaveStock.Text);
                _productService.Add(product);
                listProducts();
                MessageBox.Show("Ürün Kayıt Edildi ✅");
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
        }

        private void btnUpdateUpdate_Click(object sender, EventArgs e)
        {
            groupShow("gbxUpdate");
            Product product = new Product();
            product.ProductId = Convert.ToInt32(dgwProducts.SelectedRows[0].Cells[0].Value);
            product.ProductName = txtUpdateName.Text;
            product.CategoryId = Convert.ToInt32(cbxUpdateCategory.SelectedValue);
            product.QuantityPerUnit = txtUpdateQuantity.Text;
            product.UnitPrice = Convert.ToDecimal(txtUpdatePrice.Text);
            product.UnitsInStock = Convert.ToInt16(txtUpdateStock.Text);
            _productService.Update(product);
            listProducts();
            MessageBox.Show("Ürün Güncellendi ✅");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgwProducts.CurrentRow != null) {
                try
                {
                    Product product = new Product();
                    product.ProductId = Convert.ToInt32(dgwProducts.SelectedRows[0].Cells[0].Value);
                    _productService.Delete(product);
                    MessageBox.Show("Başarı ile Silindi! ✅");
                    listProducts();
                    groupShow("gbxUpdate");

                }
                catch (Exception exception) { MessageBox.Show(exception.InnerException.InnerException.Message); }
            }
        }


        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            groupShow("gbxUpdate");
            cbxUpdateCategory.SelectedIndex = Convert.ToInt32(dgwProducts.CurrentRow.Cells[1].Value.ToString()) - 1;
            txtUpdateName.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            txtUpdateQuantity.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
            txtUpdatePrice.Text = dgwProducts.CurrentRow.Cells[4].Value.ToString();
            txtUpdateStock.Text = dgwProducts.CurrentRow.Cells[5].Value.ToString();

        }

        //Clear Buttons

        private void btnSaveX_Click(object sender, EventArgs e)
        {
            cbxSaveCategory.SelectedIndex = 0;
            txtSaveName.Text = "";
            txtSaveQuantity.Text = "";
            txtSavePrice.Text = "";
            txtSaveStock.Text = "";
        }

        private void btnUpdateX_Click(object sender, EventArgs e)
        {
            cbxUpdateCategory.SelectedIndex = 0;
            txtUpdateName.Text = "";
            txtUpdateQuantity.Text = "";
            txtUpdatePrice.Text = "";
            txtUpdateStock.Text = "";
            groupShow("gbxSave");
        }

        private void btnNewSave_Click(object sender, EventArgs e)
        {
            groupShow("gbxSave");
        }


        //Tools
        private List<Category> getCategories(bool allCategoryOption = true)
        {

            List<Category> categories = new List<Category>();
            if (allCategoryOption)
            {
                Category category = new Category();
                category.CategoryId = -1;
                category.CategoryName = "Tüm Kategoriler";
                categories.Add(category);
            }
            categories.AddRange(_categoryService.GetAll());
            return categories;
        }

        private void fiilCategory(List<Category> categories, ComboBox combox)
        {
            combox.DataSource = categories;
            combox.DisplayMember = "CategoryName";
            combox.ValueMember = "CategoryId";

        }

        private void listProducts(int categoryId = -1)
        {
            if (categoryId > -1)
                dgwProducts.DataSource = _productService.GetAll(p => p.CategoryId == categoryId && p.ProductName.Contains(txtSearch.Text));
            else
                dgwProducts.DataSource = _productService.GetAll(p => p.ProductName.Contains(txtSearch.Text));

        }

        private void groupShow(String showPanel)
        {
            GroupBox[] panels = new GroupBox[]
              {
                gbxSave,
                gbxUpdate
              };
            foreach (GroupBox arrayItem in panels)
            {
                if (arrayItem.Name == showPanel)
                    arrayItem.Visible = true;
                else
                    arrayItem.Visible = false;
            }
        }

    }
}
