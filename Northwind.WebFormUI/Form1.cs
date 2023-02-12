using Nortwind.Business.Abstract;
using Nortwind.Business.Concrete;
using Nortwind.Business.DependecyResolver.Ninject;
using Nortwind.DataAccess.Concrete.EntityFramework;
using NortwindEntities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WebFormUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //dependency injection bir katman diyerini new leye bilmez
            //ioc container ile isleyrik
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _catagoryService = InstanceFactory.GetInstance<ICatagoryService>();
        }
        IProductService _productService;
        ICatagoryService _catagoryService;
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProduct();
            LoadCatagory();
            //yanliz product manageri kullaniriq

            // D dependenci inversion bir katman diyer katmani newleye bilmez bagilmi olursun
            // Open close prinsipi bi ekleme yapiliginda koldlarda deyisiklik  yapmamalisin

        }

        private void LoadCatagory()
        {
            cbxKatagory.DataSource = _catagoryService.getAll();
            cbxKatagory.DisplayMember = "CategoryName";
            cbxKatagory.ValueMember = "CategoryID";

            cbxKatagoryAdd.DataSource = _catagoryService.getAll();
            cbxKatagoryAdd.DisplayMember = "CategoryName";
            cbxKatagoryAdd.ValueMember = "CategoryID";

            cbxUpdateKatagory.DataSource = _catagoryService.getAll();
            cbxUpdateKatagory.DisplayMember = "CategoryName";
            cbxUpdateKatagory.ValueMember = "CategoryID";
        }

        private void LoadProduct()
        {
            dgvProduct.DataSource = _productService.GetProducts();
        }

        private void cbxKatagory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgvProduct.DataSource = _productService.GetProductByCatagory(Convert.ToInt32(cbxKatagory.SelectedValue));

            }
            catch
            {


            }

        }

        private void tbxUrun_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxUrun.Text))
            {
                dgvProduct.DataSource = _productService.GetProductByProductName(tbxUrun.Text);
            }
            else
            {
                LoadProduct();
            }


        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Add(new Product
                {
                    CategoryID = Convert.ToInt32(cbxKatagoryAdd.SelectedValue),
                    ProductName = tbxProductName2.Text.ToString(),
                    QuantityPerUnit = tbxQuantity.Text.ToString(),
                    UnitPrice = Convert.ToInt32(tbxPrice.Text),
                    UnitsInStock = Convert.ToInt16(tbxStockAmount.Text)
                });
                MessageBox.Show("urun eklendi");

                LoadProduct();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }


        }

        private void bntUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Update(new Product
                {
                    ProductId = Convert.ToInt32(dgvProduct.CurrentRow.Cells[0].Value)
                              ,
                    UnitPrice = Convert.ToDecimal(tbxUpdatePrice.Text),
                    ProductName = tbxProductNameUpdate.Text
                          ,
                    CategoryID = Convert.ToInt32(cbxUpdateKatagory.SelectedValue),
                    UnitsInStock = Convert.ToInt16(tbxUpdateStock.Text),
                    QuantityPerUnit = tbxUpdatePerUnit.Text

                });
                MessageBox.Show("urun guncellendi");

                LoadProduct();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }


        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxProductNameUpdate.Text = dgvProduct.CurrentRow.Cells[2].Value.ToString();
            tbxUpdatePerUnit.Text = dgvProduct.CurrentRow.Cells[5].Value.ToString();
            tbxUpdatePrice.Text = dgvProduct.CurrentRow.Cells[3].Value.ToString();
            tbxUpdateStock.Text = dgvProduct.CurrentRow.Cells[4].Value.ToString();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
                _productService.Delete(new Product
                {
                    ProductId = Convert.ToInt32(dgvProduct.CurrentRow.Cells[0].Value)


                });
                MessageBox.Show("urun Silindu");

                LoadProduct();

         
        }
    }
}
