using System.Numerics;

namespace ShafferAmazon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listView.View = View.Details;
            listView.FullRowSelect = true;
            listView.GridLines = true;

            listView.Columns.Add("Product ID", 100);
            listView.Columns.Add("Product Name", 150);
            listView.Columns.Add("Description", 250);
            listView.Columns.Add("Special Feature", 150);
            listView.Columns.Add("Vendor", 150);
            listView.Columns.Add("Availability Status", 150);
            listView.Columns.Add("Creation Date", 150);

            lblCount.Text = $"Product Count: {listView.Items.Count}";
            lblStoreName.Text = $"Store Name: {Product.StoreName}";
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product;
            if (txtPID.Text != "" && txtName.Text == "" && txtDescription.Text == "" && txtSpecialFeature.Text == "" && txtVendor.Text == "")
            {
                product = new Product(txtPID.Text);
            }
            else if (txtPID.Text != "" && txtName.Text != "" && txtDescription.Text != "" && txtSpecialFeature.Text != "" && txtVendor.Text != "" && txtAvailability.Text != "")
            {
                product = new Product(txtPID.Text, txtName.Text, txtDescription.Text, txtSpecialFeature.Text, txtVendor.Text, txtAvailability.Text);
            }
            else
            {
                product = new Product();
            }

            ListViewItem item = new ListViewItem(product.ProductID);
            item.SubItems.Add(product.ProductName);
            item.SubItems.Add(product.ProductDescription);
            item.SubItems.Add(product.SpecialFeature);
            item.SubItems.Add(product.Vendor);
            item.SubItems.Add(product.AvailabilityStatus);
            item.SubItems.Add(product.CreationDate);
            listView.Items.Add(item);
            txtPID.Clear();
            txtName.Clear();
            txtDescription.Clear();
            txtSpecialFeature.Clear();
            txtVendor.Clear();
            txtAvailability.Clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView.SelectedItems.Count; i++)
            {
                listView.Items.Remove(listView.SelectedItems[i]);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPID.Clear();
            txtName.Clear();
            txtDescription.Clear();
            txtSpecialFeature.Clear();
            txtVendor.Clear();
            txtAvailability.Clear();

            txtPID.Focus();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            lblCount.Text = $"Product Count: {listView.Items.Count}";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
