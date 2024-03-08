using System.ComponentModel;
using System.Windows.Forms;

namespace C968SwadeMockUp
{
    public partial class Form1 : Form
    {
        //Initialize main form and bind AllParts and Products to the DataGridArrays
        public Form1()
        {
            InitializeComponent();
            this.Text = "Inventory Management System";
            var bindingParts = new BindingSource();
            var bindingProducts = new BindingSource();
            bindingParts.DataSource = Inventory.AllParts;
            bindingProducts.DataSource = Inventory.Products;
            PartsDataGrid.DataSource = bindingParts;
            ProductsDataGrid.DataSource = bindingProducts;
        }
        // public datapoint to reference the currently selected Part/Product ID
        public string selectedID;

        //Open the Part Add form and hide Main form
        private void PartsAddButton_Click(object sender, EventArgs e)
        {
            PartsForm part = new PartsForm(true, 0);
            this.Hide();
            part.Text = "Add Part";
            part.ShowDialog();
            this.Show();
        }

        //Open the Part Modify form and hide Main form
        private void PartsModifyButton_Click(object sender, EventArgs e)
        {
            PartsForm part = new PartsForm(false, int.Parse(selectedID));
            this.Hide();
            part.Text = "Modify Part";
            part.ShowDialog();
            this.Show();
        }

        //Exit application
        private void MainExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Open the Product Modify form and hide Main form
        private void ProductsAddButton_Click(object sender, EventArgs e)
        {
            ProductForm product = new ProductForm(true, 0);
            this.Hide();
            product.Text = "Add Product";
            product.ShowDialog();
            this.Show();
        }

        //Open the Product Modify form and hide Main form
        private void ProductsModifyButton_Click(object sender, EventArgs e)
        {
            ProductForm product = new ProductForm(false, int.Parse(selectedID));
            this.Hide();
            product.Text = "Modify Product";
            product.ShowDialog();
            this.Show();
        }

        //Search based on value in Parts Search Box.  Checks if value is a number and compares to Part ID first, then compares to Part Names.  Selects row of matches, sets bar to red if no results found
        private void PartsSearchButton_Click(object sender, EventArgs e)
        {
            PartsDataGrid.ClearSelection();
            ProductsDataGrid.ClearSelection();

            string searchValue = PartsSearchBox.Text;

            if (int.TryParse(searchValue, out _))
            {
                foreach (DataGridViewRow row in PartsDataGrid.Rows)
                {
                    if (row.Cells[0].Value.Equals(int.Parse(searchValue)))
                    {
                        PartsDataGrid.Rows[row.Index].Selected = true;
                        PartsModifyButton.Enabled = true;
                        PartsDeleteButton.Enabled = true;
                        ProductsModifyButton.Enabled = false;
                        ProductsDeleteButton.Enabled = false;
                        selectedID = row.Cells[0].Value.ToString();
                        return;
                    }
                }
            }
            foreach (DataGridViewRow row in PartsDataGrid.Rows)
            {
                if (row.Cells[1].Value.ToString().ToLower().Contains(searchValue.ToLower()))
                {
                    PartsDataGrid.Rows[row.Index].Selected = true;
                    PartsModifyButton.Enabled = true;
                    PartsDeleteButton.Enabled = true;
                    ProductsModifyButton.Enabled = false;
                    ProductsDeleteButton.Enabled = false;
                    selectedID = row.Cells[0].Value.ToString();
                    return;
                }
            }

            PartsSearchBox.BackColor = Color.Salmon;
        }

        //Sets parts search bar to white on change in case it was red from a previous failed search
        private void PartsSearchBox_TextChanged(object sender, EventArgs e)
        {
            PartsSearchBox.BackColor = Color.White;
        }

        //Search based on value in Product Search Box.  Checks if value is a number and compares to Part ID first, then compares to Part Names.  Selects row of matches, sets bar to red if no results found
        private void ProductsSearchButton_Click(object sender, EventArgs e)
        {
            PartsDataGrid.ClearSelection();
            ProductsDataGrid.ClearSelection();

            string searchValue = ProductsSearchBox.Text;

            if (int.TryParse(searchValue, out _))
            {
                foreach (DataGridViewRow row in ProductsDataGrid.Rows)
                {
                    if (row.Cells[0].Value.Equals(int.Parse(searchValue)))
                    {
                        ProductsDataGrid.Rows[row.Index].Selected = true;
                        ProductsModifyButton.Enabled = true;
                        ProductsDeleteButton.Enabled = true;
                        PartsModifyButton.Enabled = false;
                        PartsDeleteButton.Enabled = false;
                        selectedID = row.Cells[0].Value.ToString();
                        return;
                    }
                }
            }
            foreach (DataGridViewRow row in ProductsDataGrid.Rows)
            {
                if (row.Cells[1].Value.ToString().ToLower().Contains(searchValue.ToLower()))
                {
                    ProductsDataGrid.Rows[row.Index].Selected = true;
                    ProductsModifyButton.Enabled = true;
                    ProductsDeleteButton.Enabled = true;
                    PartsModifyButton.Enabled = false;
                    PartsDeleteButton.Enabled = false;
                    selectedID = row.Cells[0].Value.ToString();
                    return;
                }
            }
            ProductsSearchBox.BackColor = Color.Salmon;
        }

        //Sets product search bar to white on change in case it was red from a previous failed search
        private void ProductsSearchBox_TextChanged(object sender, EventArgs e)
        {
            ProductsSearchBox.BackColor = Color.White;
        }

        //Selects Parts row that was clicked and enabling/disabling relevant buttons
        private void PartsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                selectedID = PartsDataGrid.CurrentRow.Cells[0].Value.ToString();
                PartsDataGrid.CurrentRow.Selected = true;
                PartsModifyButton.Enabled = true;
                PartsDeleteButton.Enabled = true;
                ProductsModifyButton.Enabled = false;
                ProductsDeleteButton.Enabled = false;
                ProductsDataGrid.ClearSelection();
            }
        }

        //Selects Prodct row that was clicked and enabling/disabling relevant buttons
        private void ProductsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                selectedID = ProductsDataGrid.CurrentRow.Cells[0].Value.ToString();
                ProductsDataGrid.CurrentRow.Selected = true;
                ProductsModifyButton.Enabled = true;
                ProductsDeleteButton.Enabled = true;
                PartsModifyButton.Enabled = false;
                PartsDeleteButton.Enabled = false;
                PartsDataGrid.ClearSelection();
            }
        }

        // Warns user and deletes Product if deletion confirmed
        private void ProductsDeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult delete = MessageBox.Show("Are you sure you want to delete this product?  This will also disassociate all parts with this product.", "Delete Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (delete == DialogResult.Yes) { Inventory.removeProduct(int.Parse(selectedID)); }
        }

        // Warns user of part deletion and refuses deletion if part is associated with Product.  Lists products in deletion failed message.  Deletes if not present in Products and user confirms.
        private void PartsDeleteButton_Click(object sender, EventArgs e)
        {
            selectedID = PartsDataGrid.CurrentRow.Cells[0].Value.ToString();
            Part deletePart = Inventory.lookupPart(int.Parse(selectedID));
            List<String> containedIn = new List<String>();
            foreach (Product prod in Inventory.Products)
            {
                if (prod.AssociatedParts.Contains(deletePart)) { containedIn.Add(prod.Name); }
            }
            if (containedIn.Count > 0)
            {
                string text = string.Join(", ", containedIn);
                MessageBox.Show("Cannot delete part, contained in products: " + text, "Delete Alert");
            }
            else if (containedIn.Count == 0)
            {
                DialogResult delete = MessageBox.Show("Are you sure you want to delete this part?", "Delete Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (delete == DialogResult.Yes) { Inventory.removePart(int.Parse(selectedID)); }
            }
        }

        // Remove default cell highlight on open
        private void ProductsDataGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ProductsDataGrid.ClearSelection();
        }

        // Remove default cell highlight on open
        private void PartsDataGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            PartsDataGrid.ClearSelection();
        }
    }
}