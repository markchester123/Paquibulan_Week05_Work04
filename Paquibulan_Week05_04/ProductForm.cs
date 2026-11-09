using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Paquibulan_Week05_04
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();

            btnSave.Click += btnSave_Click;
            btnClear.Click += btnClear_Click;
            btnCancel.Click += btnCancel_Click;
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            decimal cost;
            decimal price;
            decimal markup;

            if (string.IsNullOrWhiteSpace(txtboxBarcode.Text) ||
                string.IsNullOrWhiteSpace(txtboxName.Text))
            {
                MessageBox.Show(
                    "Barcode and name are required.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!decimal.TryParse(txtboxCost.Text, out cost) ||
                !decimal.TryParse(txtboxPrice.Text, out price) ||
                !decimal.TryParse(txtboxMarkup.Text, out markup))
            {
                MessageBox.Show(
                    "Cost, price, and markup must be valid numbers.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string origin = rbtnLocal.Checked ? "Local" :
                            rbtnAbroad.Checked ? "Abroad" : "Not specified";

            ProductRecord product = new ProductRecord
            {
                Barcode = txtboxBarcode.Text.Trim(),
                Name = txtboxName.Text.Trim(),
                Description = txtboxDescription.Text.Trim(),
                Category = cboxCategory.Text.Trim(),
                Origin = origin,
                IsActive = checkboxActive.Checked,
                Cost = cost,
                Price = price,
                Markup = markup
            };

            List.Products.Add(product);

            MessageBox.Show(
                "Product added successfully.",
                "Saved",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            using (List productList = new List())
            {
                productList.ShowDialog();
                this.Hide();
            }

            ClearFields();
        }
        private void ClearFields()
        {
            txtboxBarcode.Clear();
            txtboxName.Clear();
            txtboxDescription.Clear();
            cboxCategory.SelectedIndex = -1;
            txtboxCost.Clear();
            txtboxPrice.Clear();
            txtboxMarkup.Clear();
            checkboxActive.Checked = false;
            rbtnLocal.Checked = false;
            rbtnAbroad.Checked = false;
        }
    }

}
