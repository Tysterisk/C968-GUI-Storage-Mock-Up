using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968SwadeMockUp
{
    public partial class ProductForm : Form
    {
        // Generic reference values for cell compares
        public int invValue;
        public int maxValue;
        public int minValue;
        public string selectedID;
        public BindingList<Part> toBeAdded = new BindingList<Part>();
        public ProductForm(bool addModForm, int prodID)
        {
            // Initialize form with appropriate title.  If modify is called, populate text boxes with selected part values
            InitializeComponent();
            if (addModForm)
            {
                ProductWindowLabel.Text = "Add Product";
                ProductIDTextbox.Text = Inventory.getNextProductID().ToString();
            }
            else
            {
                ProductWindowLabel.Text = "Modify Product";
                Product tempProd = Inventory.lookupProduct(prodID);
                ProductIDTextbox.Text = tempProd.ProductID.ToString();
                ProductNameTextbox.Text = tempProd.Name.ToString();
                ProductPriceTextbox.Text = tempProd.Price.ToString();
                ProductInventoryTextbox.Text = tempProd.InStock.ToString();
                ProductMaxTextbox.Text = tempProd.Max.ToString();
                ProductMinTextbox.Text = tempProd.Min.ToString();
                foreach (Part part in tempProd.AssociatedParts)
                {
                    toBeAdded.Add(part);
                }
            }

            var bindingParts = new BindingSource();
            var bindingProducts = new BindingSource();
            bindingParts.DataSource = Inventory.AllParts;
            bindingProducts.DataSource = toBeAdded;
            ProductCandidateParts.DataSource = bindingParts;
            ProductAssociatedParts.DataSource = bindingProducts;
        }

        // Checks if Inventory, Min, and Max rules
        public bool MinMaxInvChecker(int checkType)
        {
            bool result = false;

            if (minValue <= invValue && invValue <= maxValue && !string.IsNullOrEmpty(ProductInventoryTextbox.Text))
            {
                ProductInventoryTextbox.BackColor = Color.White;
            }
            else ProductInventoryTextbox.BackColor = Color.Salmon;

            if (maxValue >= invValue && maxValue >= minValue && !string.IsNullOrEmpty(ProductMaxTextbox.Text))
            {
                ProductMaxTextbox.BackColor = Color.White;
            }
            else ProductMaxTextbox.BackColor = Color.Salmon;

            if (minValue <= invValue && maxValue >= minValue && !string.IsNullOrEmpty(ProductMinTextbox.Text))
            {
                ProductMinTextbox.BackColor = Color.White;
            }
            else ProductMinTextbox.BackColor = Color.Salmon;

            switch (checkType)
            {
                case 0:
                    if (minValue <= invValue && invValue <= maxValue)
                    {
                        result = true;
                    }
                    break;
                case 1:
                    if (maxValue >= invValue && maxValue >= minValue)
                    {
                        result = true;
                    }
                    break;
                case 2:
                    if (minValue <= invValue && maxValue >= minValue)
                    {
                        result = true;
                    }
                    break;
            }
            return result;
        }

        // Check if all cells are correct (rules enforced via cell background color) to enable saving
        private void SaveValidityCheck()
        {
            if (ProductNameTextbox.BackColor != Color.Salmon && ProductInventoryTextbox.BackColor != Color.Salmon && ProductPriceTextbox.BackColor != Color.Salmon && ProductMaxTextbox.BackColor != Color.Salmon && ProductMinTextbox.BackColor != Color.Salmon)
                ProductSaveButton.Enabled = true;
        }

        // Exit button for Parts form.  Discards entered information
        private void ProductCancelButton_Click(object sender, EventArgs e)
        {
            toBeAdded.Clear();
            this.Close();
        }

        // Check if text box contents are correct per expected values and assigns background color to white if good, or salmon if bad
        private void ProductNameTextbox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ProductNameTextbox.Text))
            {
                ProductNameTextbox.BackColor = Color.White;
                SaveValidityCheck();
            }
            else ProductNameTextbox.BackColor = Color.Salmon;
        }

        // Check if text box contents are correct per expected values and assigns background color to white if good, or salmon if bad
        private void ProductInventoryTextbox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(ProductInventoryTextbox.Text, out invValue) && MinMaxInvChecker(0))
            {
                ProductInventoryTextbox.BackColor = Color.White;
                SaveValidityCheck();
            }
            else ProductInventoryTextbox.BackColor = Color.Salmon;
        }

        // Check if text box contents are correct per expected values and assigns background color to white if good, or salmon if bad
        private void ProductPriceCostTextbox_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(ProductPriceTextbox.Text, out _))
            {
                ProductPriceTextbox.BackColor = Color.White;
                SaveValidityCheck();
            }
            else ProductPriceTextbox.BackColor = Color.Salmon;
        }

        // Check if text box contents are correct per expected values and assigns background color to white if good, or salmon if bad
        private void ProductMaxTextbox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(ProductMaxTextbox.Text, out maxValue) && MinMaxInvChecker(1))
            {
                ProductMaxTextbox.BackColor = Color.White;
                SaveValidityCheck();
            }
            else ProductMaxTextbox.BackColor = Color.Salmon;
        }

        // Check if text box contents are correct per expected values and assigns background color to white if good, or salmon if bad
        private void ProductMinTextbox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(ProductMinTextbox.Text, out minValue) && MinMaxInvChecker(2))
            {
                ProductMinTextbox.BackColor = Color.White;
                SaveValidityCheck();
            }
            else ProductMinTextbox.BackColor = Color.Salmon;
        }

        //Error information on mouse hover if cell value deemed delinquent
        private void ProductNameTextbox_MouseHover(object sender, EventArgs e)
        {
            if (ProductNameTextbox.BackColor == Color.Salmon)
                ErrorToolTip.SetToolTip(ProductNameTextbox, "Name Required.");
        }

        //Error information on mouse hover if cell value deemed delinquent
        private void ProductInventoryTextbox_MouseHover(object sender, EventArgs e)
        {
            if (ProductInventoryTextbox.BackColor == Color.Salmon)
                ErrorToolTip.SetToolTip(ProductInventoryTextbox, "Part Inventory Required.  Must be a whole number between Min and Max values.");
        }

        //Error information on mouse hover if cell value deemed delinquent
        private void ProductPriceTextbox_MouseHover(object sender, EventArgs e)
        {
            if (ProductPriceTextbox.BackColor == Color.Salmon)
                ErrorToolTip.SetToolTip(ProductPriceTextbox, "Price / Cost Required.  Must be a number.");
        }

        //Error information on mouse hover if cell value deemed delinquent
        private void ProductMaxTextbox_MouseHover(object sender, EventArgs e)
        {
            if (ProductMaxTextbox.BackColor == Color.Salmon)
                ErrorToolTip.SetToolTip(ProductMaxTextbox, "Maximum inventory Required.  Must be a whole number larger than Minimum and greater than or equal to Inventory.");
        }

        //Error information on mouse hover if cell value deemed delinquent
        private void ProductMinTextbox_MouseHover(object sender, EventArgs e)
        {
            if (ProductMinTextbox.BackColor == Color.Salmon)
                ErrorToolTip.SetToolTip(ProductMinTextbox, "Minimum inventory Required.  Must be a whole number smaller than Maximum and less than or equal to Inventory.");
        }

        //Sets parts search bar to white on change in case it was red from a previous failed search
        private void ProductsSearchBox_TextChanged(object sender, EventArgs e)
        {
            ProductCandidateParts.BackColor = Color.White;
        }

        // Save button.  Updates product if modify document, Adds product if add.  Adds all associated parts and then clears the associated parts temporary storage queue variable toBeAdded
        private void ProductSaveButton_Click(object sender, EventArgs e)
        {
            int tempID = int.Parse(ProductIDTextbox.Text);
            string tempName = ProductNameTextbox.Text;
            int tempInv = int.Parse(ProductInventoryTextbox.Text);
            decimal tempPrice = decimal.Parse(ProductPriceTextbox.Text);
            int tempMax = int.Parse(ProductMaxTextbox.Text);
            int tempMin = int.Parse(ProductMinTextbox.Text);

            Product product = new Product(tempID, tempName, tempPrice, tempInv, tempMin, tempMax);

            if (ProductWindowLabel.Text == "Modify Product") { Inventory.updateProduct(tempID, product); }
            else { Inventory.addProduct(product); }

            foreach (Part part in toBeAdded)
            {
                product.addAssociatedPart(part);
            }
            toBeAdded.Clear();
            this.Close();
        }

        // Adds part to product if not already associated
        private void ProductCandidatePartsAddButton_Click(object sender, EventArgs e)
        {
            if (toBeAdded.Contains(Inventory.lookupPart(int.Parse(selectedID))))
            {
                MessageBox.Show("Part already associated with Product.", "Warning");
            }
            else { toBeAdded.Add(Inventory.lookupPart(int.Parse(selectedID))); }
        }

        //Selects Parts row that was clicked and enabling/disabling relevant buttons
        private void ProductCandidateParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedID = ProductCandidateParts.CurrentRow.Cells[0].Value.ToString();
            ProductCandidateParts.CurrentRow.Selected = true;
            ProductCandidatePartsAddButton.Enabled = true;
            ProductDeleteButton.Enabled = false;
            ProductAssociatedParts.ClearSelection();
        }

        //Selects Parts row that was clicked and enabling/disabling relevant buttons
        private void ProductAssociatedParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedID = ProductAssociatedParts.CurrentRow.Cells[0].Value.ToString();
            ProductAssociatedParts.CurrentRow.Selected = true;
            ProductDeleteButton.Enabled = true;
            ProductCandidatePartsAddButton.Enabled = false;
            ProductCandidateParts.ClearSelection();
        }

        // Removes associated part if user accepts deletion prompt
        private void ProductDeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult delete = MessageBox.Show("Are you sure you want to delete this part?", "Delete Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (delete == DialogResult.Yes) { toBeAdded.Remove(Inventory.lookupPart(int.Parse(selectedID))); }
        }

        // Clear selected cells if click outside of datagridarray
        private void ProductForm_Click(object sender, EventArgs e)
        {
            ProductDeleteButton.Enabled = false;
            ProductCandidatePartsAddButton.Enabled = false;
            ProductCandidateParts.ClearSelection();
            ProductAssociatedParts.ClearSelection();
        }

        //Search based on value in Parts Search Box.  Checks if value is a number and compares to Part ID first, then compares to Part Names.  Selects row of matches, sets bar to red if no results found
        private void ProductsSearchButton_Click_1(object sender, EventArgs e)
        {
            ProductCandidateParts.ClearSelection();
            ProductAssociatedParts.ClearSelection();

            string searchValue = ProductSearchBarBox.Text;

            if (int.TryParse(searchValue, out _))
            {
                foreach (DataGridViewRow row in ProductCandidateParts.Rows)
                {
                    if (row.Cells[0].Value.Equals(int.Parse(searchValue)))
                    {
                        ProductCandidateParts.Rows[row.Index].Selected = true;
                        ProductCandidatePartsAddButton.Enabled = true;
                        selectedID = row.Cells[0].Value.ToString();
                        return;
                    }
                }
            }
            foreach (DataGridViewRow row in ProductCandidateParts.Rows)
            {
                if (row.Cells[1].Value.ToString().ToLower().Contains(searchValue.ToLower()))
                {
                    ProductCandidateParts.Rows[row.Index].Selected = true;
                    ProductCandidatePartsAddButton.Enabled = true;
                    selectedID = row.Cells[0].Value.ToString();
                    return;
                }
            }
            ProductCandidateParts.BackColor = Color.Salmon;
        }

        // Remove default cell highlight on open
        private void ProductCandidateParts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ProductCandidateParts.ClearSelection();
        }

        // Remove default cell highlight on open
        private void ProductAssociatedParts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ProductAssociatedParts.ClearSelection();
        }
    }
}
