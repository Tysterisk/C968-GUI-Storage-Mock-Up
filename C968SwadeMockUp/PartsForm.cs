using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace C968SwadeMockUp
{
    public partial class PartsForm : Form
    {
        public PartsForm(bool addModForm, int partInfo)
        {
            // Initialize form with appropriate title.  If modify is called, populate text boxes with selected part values
            InitializeComponent();
            if (addModForm) 
            { 
                PartWindowLabel.Text = "Add Part";
                PartsIDTextbox.Text = Inventory.getNextPartID().ToString();
            }
            else 
            { 
                PartWindowLabel.Text = "Modify Part";
                Part tempPart = Inventory.lookupPart(partInfo);
                PartsIDTextbox.Text = tempPart.PartID.ToString();
                PartsNameTextbox.Text = tempPart.Name; ;
                PartsInventoryTextbox.Text = tempPart.InStock.ToString(); ;
                PartsPriceCostTextbox.Text = tempPart.Price.ToString(); ;
                PartsMaxTextbox.Text = tempPart.Max.ToString(); ;
                PartsMinTextbox.Text = tempPart.Min.ToString(); ;

                if (tempPart.CheckPartType()[1] == "Outsourced")
                {
                    PartsInHouseRadio.Checked = false;
                    PartsOutsourcedRadio.Checked = true;
                    PartsMachineIDTextbox.Text = tempPart.CheckPartType()[0];
                }
                else
                {
                    PartsInHouseRadio.Checked = true;
                    PartsOutsourcedRadio.Checked = false;
                    PartsMachineIDTextbox.Text = tempPart.CheckPartType()[0];
                }
            }
        }

        // Generic reference values for cell compares
        public int invValue;
        public int maxValue;
        public int minValue;

        // Check if Inventory, Min, and Max boxes contain correct values per requirements.  Red cells indicate condition failure in that cell.
        public bool MinMaxInvChecker(int checkType)
        {
            bool result = false;

            if (minValue <= invValue && invValue <= maxValue && !string.IsNullOrEmpty(PartsInventoryTextbox.Text))
            {
                PartsInventoryTextbox.BackColor = Color.White;
            }
            else PartsInventoryTextbox.BackColor = Color.Salmon;

            if (maxValue >= invValue && maxValue >= minValue && !string.IsNullOrEmpty(PartsMaxTextbox.Text))
            {
                PartsMaxTextbox.BackColor = Color.White;
            }
            else PartsMaxTextbox.BackColor = Color.Salmon;

            if (minValue <= invValue && maxValue >= minValue && !string.IsNullOrEmpty(PartsMinTextbox.Text))
            {
                PartsMinTextbox.BackColor = Color.White;
            }
            else PartsMinTextbox.BackColor = Color.Salmon;

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
            if (PartsNameTextbox.BackColor != Color.Salmon && PartsInventoryTextbox.BackColor != Color.Salmon && PartsPriceCostTextbox.BackColor != Color.Salmon && PartsMaxTextbox.BackColor != Color.Salmon && PartsMinTextbox.BackColor != Color.Salmon && PartsMachineIDTextbox.BackColor != Color.Salmon)
                PartSaveButton.Enabled = true;
        }

        // Change part labels/data to Inhouse information
        private void PartsInHouseRadio_CheckedChanged(object sender, EventArgs e)
        {
            MachineIDCompanyNameLabel.Text = "Machine ID";
            PartsMachineIDTextbox.Text = string.Empty;
            PartsMachineIDTextbox.BackColor = Color.Salmon;
            PartSaveButton.Enabled = false;
        }

        // Change part labels/data to Outsourced information
        private void PartsOutsourcedRadio_CheckedChanged(object sender, EventArgs e)
        {
            MachineIDCompanyNameLabel.Text = "Company Name";
            PartsMachineIDTextbox.Text = string.Empty;
            PartsMachineIDTextbox.BackColor = Color.Salmon;
            PartSaveButton.Enabled = false;
        }

        // Exit button for Parts form.  Discards entered information
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Error information on mouse hover if cell value deemed delinquent
        private void PartsNameTextbox_MouseHover(object sender, EventArgs e)
        {
            if (PartsNameTextbox.BackColor == Color.Salmon)
                ErrorToolTip.SetToolTip(PartsNameTextbox, "Name Required.");
        }

        //Error information on mouse hover if cell value deemed delinquent
        private void PartsInventoryTextbox_MouseHover(object sender, EventArgs e)
        {
            if (PartsInventoryTextbox.BackColor == Color.Salmon)
                ErrorToolTip.SetToolTip(PartsInventoryTextbox, "Part Inventory Required.  Must be a whole number between Min and Max values.");
        }

        //Error information on mouse hover if cell value deemed delinquent
        private void PartsPriceCostTextbox_MouseHover(object sender, EventArgs e)
        {
            if (PartsPriceCostTextbox.BackColor == Color.Salmon)
                ErrorToolTip.SetToolTip(PartsPriceCostTextbox, "Price / Cost Required.  Must be a number.");
        }

        //Error information on mouse hover if cell value deemed delinquent
        private void PartsMaxTextbox_MouseHover(object sender, EventArgs e)
        {
            if (PartsMaxTextbox.BackColor == Color.Salmon)
                ErrorToolTip.SetToolTip(PartsMaxTextbox, "Maximum inventory Required.  Must be a whole number larger than Minimum and greater than or equal to Inventory.");
        }

        //Error information on mouse hover if cell value deemed delinquent
        private void PartsMinTextbox_MouseHover(object sender, EventArgs e)
        {
            if (PartsMinTextbox.BackColor == Color.Salmon)
                ErrorToolTip.SetToolTip(PartsMinTextbox, "Minimum inventory Required.  Must be a whole number smaller than Maximum and less than or equal to Inventory.");
        }

        //Error information on mouse hover if cell value deemed delinquent based on whether the textbox is currently Inhouse or Outsourced
        private void PartsMachineIDTextbox_MouseHover(object sender, EventArgs e)
        {
            if (PartsMachineIDTextbox.BackColor == Color.Salmon)
                if (PartsInHouseRadio.Checked)
                    ErrorToolTip.SetToolTip(PartsMachineIDTextbox, "Machine ID Required.  Must be a number.");
                else ErrorToolTip.SetToolTip(PartsMachineIDTextbox, "Company Name Required.");
        }

        // Check if text box contents are correct per expected values and assigns background color to white if good, or salmon if bad
        private void PartsNameTextbox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(PartsNameTextbox.Text))
            {
                PartsNameTextbox.BackColor = Color.White;
                SaveValidityCheck();
            }
            else PartsNameTextbox.BackColor = Color.Salmon;
        }

        // Check if text box contents are correct per expected values and assigns background color to white if good, or salmon if bad
        private void PartsInventoryTextbox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(PartsInventoryTextbox.Text, out invValue) && MinMaxInvChecker(0))
            {
                PartsInventoryTextbox.BackColor = Color.White;
                SaveValidityCheck();
            }
            else PartsInventoryTextbox.BackColor = Color.Salmon;
        }

        // Check if text box contents are correct per expected values and assigns background color to white if good, or salmon if bad
        private void PartsPriceCostTextbox_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(PartsPriceCostTextbox.Text, out _))
            {
                PartsPriceCostTextbox.BackColor = Color.White;
                SaveValidityCheck();
            }
            else PartsPriceCostTextbox.BackColor = Color.Salmon;
        }

        // Check if text box contents are correct per expected values and assigns background color to white if good, or salmon if bad
        private void PartsMaxTextbox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(PartsMaxTextbox.Text, out maxValue) && MinMaxInvChecker(1))
            {
                PartsMaxTextbox.BackColor = Color.White;
                SaveValidityCheck();
            }
            else PartsMaxTextbox.BackColor = Color.Salmon;
        }

        // Check if text box contents are correct per expected values and assigns background color to white if good, or salmon if bad
        private void PartsMinTextbox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(PartsMinTextbox.Text, out minValue) && MinMaxInvChecker(2))
            {
                PartsMinTextbox.BackColor = Color.White;
                SaveValidityCheck();
            }
            else PartsMinTextbox.BackColor = Color.Salmon;
        }

        // Check if text box contents are correct per expected values and assigns background color to white if good, or salmon if bad.  Adjusted per Inhouse or Outsourced
        private void PartsMachineIDTextbox_TextChanged(object sender, EventArgs e)
        {
            if (PartsInHouseRadio.Checked)
            {
                if (int.TryParse(PartsMachineIDTextbox.Text, out _))
                {
                    PartsMachineIDTextbox.BackColor = Color.White;
                    SaveValidityCheck();
                }
                else PartsMachineIDTextbox.BackColor = Color.Salmon;
            }
            else if (PartsOutsourcedRadio.Checked)
            {
                if (!string.IsNullOrEmpty(PartsMachineIDTextbox.Text))
                {
                    PartsMachineIDTextbox.BackColor = Color.White;
                    SaveValidityCheck();
                }
                else PartsMachineIDTextbox.BackColor = Color.Salmon;
            }
        }

        // Save button generates Part object and, if modify, called update part.  If add, calls addpart.  
        private void PartSaveButton_Click(object sender, EventArgs e)
        {

            int tempID = int.Parse(PartsIDTextbox.Text);
            string tempName = PartsNameTextbox.Text;
            int tempInv = int.Parse(PartsInventoryTextbox.Text);
            decimal tempPrice = decimal.Parse(PartsPriceCostTextbox.Text);
            int tempMax = int.Parse(PartsMaxTextbox.Text);
            int tempMin = int.Parse(PartsMinTextbox.Text);

            if (int.TryParse(PartsMachineIDTextbox.Text, out _))
            {
                Inhouse savePart = new Inhouse (tempID, tempName, tempPrice, tempInv, tempMax, tempMin, int.Parse(PartsMachineIDTextbox.Text));
                if (PartWindowLabel.Text == "Modify Part")
                {
                    Inventory.updatePart(tempID, savePart);
                }
                else Inventory.addPart(savePart);
            }
            else
            {
                Outsourced savePart = new Outsourced(tempID, tempName, tempPrice, tempInv, tempMax, tempMin, PartsMachineIDTextbox.Text);
                if (PartWindowLabel.Text == "Modify Part")
                {
                    Inventory.updatePart(tempID, savePart);
                }
                else Inventory.addPart(savePart);
            }
            this.Close();
        }
    }
}
