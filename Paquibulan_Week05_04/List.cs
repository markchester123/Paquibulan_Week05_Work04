using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paquibulan_Week05_04
{
    public partial class List : Form
    {
        public static readonly System.Collections.Generic.List<ProductRecord> Products =
           new System.Collections.Generic.List<ProductRecord>();
        private static readonly CultureInfo Peso = new CultureInfo("en-PH");

        public List()
        {
            InitializeComponent();
        }

        private void List_Load(object sender, EventArgs e)
        {
            DisplayProductInformation();
        }

        private void DisplayProductInformation()
        {
            if (Products.Count == 0)
            {
                lblbarcode.Text = "No product added";
                lblname.Text = "No product added";
                lbldescription.Text = "No product added";
                lblcategory.Text = "No product added";
                lblorigin.Text = "No product added";
                lblstatus.Text = "No product added";
                lblcost.Text = "No product added";
                lblprice.Text = "No product added";
                lblmarkup.Text = "No product added";

                return;
            }

            ProductRecord product = Products[Products.Count - 1];

            lblbarcode.Text = product.Barcode;
            lblname.Text = product.Name;
            lbldescription.Text = product.Description;
            lblcategory.Text = product.Category;
            lblorigin.Text = product.Origin;
            lblstatus.Text = product.IsActive ? "Active" : "Inactive";
            lblcost.Text = product.Cost.ToString("C2", Peso);
            lblprice.Text = product.Price.ToString("C2", Peso);
            lblmarkup.Text = product.Markup.ToString("0.00") + "%";

            Text = "Product Information";
            lblProductInformation.Text = "Product Information";
        }
        

        private void btnReturn_Click(object sender, EventArgs e)
        {
            var productForm = new ProductForm();
            productForm.Show();
            this.Hide();
        }
    }
    public class ProductRecord
        {
            public string Barcode { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public string Category { get; set; }
            public string Origin { get; set; }
            public bool IsActive { get; set; }
            public decimal Cost { get; set; }
            public decimal Price { get; set; }
            public decimal Markup { get; set; }
        }
}
