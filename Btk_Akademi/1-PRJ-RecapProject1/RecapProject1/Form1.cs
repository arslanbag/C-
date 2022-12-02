using RecapProject1.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapProject1
{
    public partial class FormProductList : Form
    {
        public FormProductList()
        {
            InitializeComponent();
        }

        private void FormProductList_Load(object sender, EventArgs e)
        {
            listProducts();
            listCategories();
        }
        private void listProducts(int categoryId = -1) 
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                if (categoryId > -1)
                    dgwProducts.DataSource = context.Products.Where(p => p.CategoryId == categoryId && p.ProductName.Contains(txtSearch.Text)).ToList();
                else
                    dgwProducts.DataSource = context.Products.ToList();
            }
        }

        private void listCategories()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                cbxCategory.DataSource = context.Categories.ToList();
                cbxCategory.DisplayMember = "CategoryName";
                cbxCategory.ValueMember= "CategoryId";   
            }
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                listProducts(Convert.ToInt32(cbxCategory.SelectedValue.ToString()));
            }
            catch
            {
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            listProducts(Convert.ToInt32(cbxCategory.SelectedValue.ToString()));
        }
    }
}
