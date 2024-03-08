namespace C968SwadeMockUp
{
    partial class PartsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            PartWindowLabel = new Label();
            PartsInHouseRadio = new RadioButton();
            PartsOutsourcedRadio = new RadioButton();
            PartsIDTextbox = new TextBox();
            IDLabel = new Label();
            NameLabel = new Label();
            PartsNameTextbox = new TextBox();
            InventoryLabel = new Label();
            PartsInventoryTextbox = new TextBox();
            PriceCostLabel = new Label();
            PartsPriceCostTextbox = new TextBox();
            MaxLabel = new Label();
            PartsMaxTextbox = new TextBox();
            MachineIDCompanyNameLabel = new Label();
            PartsMachineIDTextbox = new TextBox();
            MinLabel = new Label();
            PartsMinTextbox = new TextBox();
            PartSaveButton = new Button();
            PartCancelButton = new Button();
            panel1 = new Panel();
            ErrorToolTip = new ToolTip(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // PartWindowLabel
            // 
            PartWindowLabel.AutoSize = true;
            PartWindowLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            PartWindowLabel.Location = new Point(25, 11);
            PartWindowLabel.Name = "PartWindowLabel";
            PartWindowLabel.Size = new Size(47, 25);
            PartWindowLabel.TabIndex = 0;
            PartWindowLabel.Text = "Part";
            PartWindowLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PartsInHouseRadio
            // 
            PartsInHouseRadio.AutoSize = true;
            PartsInHouseRadio.Checked = true;
            PartsInHouseRadio.Location = new Point(3, 6);
            PartsInHouseRadio.Name = "PartsInHouseRadio";
            PartsInHouseRadio.Size = new Size(74, 19);
            PartsInHouseRadio.TabIndex = 1;
            PartsInHouseRadio.TabStop = true;
            PartsInHouseRadio.Text = "In-House";
            PartsInHouseRadio.UseVisualStyleBackColor = true;
            PartsInHouseRadio.CheckedChanged += PartsInHouseRadio_CheckedChanged;
            // 
            // PartsOutsourcedRadio
            // 
            PartsOutsourcedRadio.AutoSize = true;
            PartsOutsourcedRadio.Location = new Point(133, 6);
            PartsOutsourcedRadio.Name = "PartsOutsourcedRadio";
            PartsOutsourcedRadio.Size = new Size(87, 19);
            PartsOutsourcedRadio.TabIndex = 2;
            PartsOutsourcedRadio.Text = "Outsourced";
            PartsOutsourcedRadio.UseVisualStyleBackColor = true;
            PartsOutsourcedRadio.CheckedChanged += PartsOutsourcedRadio_CheckedChanged;
            // 
            // PartsIDTextbox
            // 
            PartsIDTextbox.Enabled = false;
            PartsIDTextbox.Location = new Point(187, 62);
            PartsIDTextbox.Name = "PartsIDTextbox";
            PartsIDTextbox.Size = new Size(142, 23);
            PartsIDTextbox.TabIndex = 3;
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IDLabel.Location = new Point(133, 64);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(25, 21);
            IDLabel.TabIndex = 4;
            IDLabel.Text = "ID";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NameLabel.Location = new Point(106, 102);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(52, 21);
            NameLabel.TabIndex = 6;
            NameLabel.Text = "Name";
            // 
            // PartsNameTextbox
            // 
            PartsNameTextbox.AccessibleDescription = "";
            PartsNameTextbox.AccessibleName = "";
            PartsNameTextbox.BackColor = Color.Salmon;
            PartsNameTextbox.Location = new Point(187, 100);
            PartsNameTextbox.Name = "PartsNameTextbox";
            PartsNameTextbox.Size = new Size(142, 23);
            PartsNameTextbox.TabIndex = 5;
            PartsNameTextbox.TextChanged += PartsNameTextbox_TextChanged;
            PartsNameTextbox.MouseHover += PartsNameTextbox_MouseHover;
            // 
            // InventoryLabel
            // 
            InventoryLabel.AutoSize = true;
            InventoryLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            InventoryLabel.Location = new Point(82, 142);
            InventoryLabel.Name = "InventoryLabel";
            InventoryLabel.Size = new Size(76, 21);
            InventoryLabel.TabIndex = 8;
            InventoryLabel.Text = "Inventory";
            // 
            // PartsInventoryTextbox
            // 
            PartsInventoryTextbox.BackColor = Color.Salmon;
            PartsInventoryTextbox.Location = new Point(187, 140);
            PartsInventoryTextbox.Name = "PartsInventoryTextbox";
            PartsInventoryTextbox.Size = new Size(142, 23);
            PartsInventoryTextbox.TabIndex = 7;
            PartsInventoryTextbox.TextChanged += PartsInventoryTextbox_TextChanged;
            PartsInventoryTextbox.MouseHover += PartsInventoryTextbox_MouseHover;
            // 
            // PriceCostLabel
            // 
            PriceCostLabel.AutoSize = true;
            PriceCostLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PriceCostLabel.Location = new Point(69, 179);
            PriceCostLabel.Name = "PriceCostLabel";
            PriceCostLabel.Size = new Size(89, 21);
            PriceCostLabel.TabIndex = 10;
            PriceCostLabel.Text = "Price / Cost";
            // 
            // PartsPriceCostTextbox
            // 
            PartsPriceCostTextbox.BackColor = Color.Salmon;
            PartsPriceCostTextbox.Location = new Point(187, 179);
            PartsPriceCostTextbox.Name = "PartsPriceCostTextbox";
            PartsPriceCostTextbox.Size = new Size(142, 23);
            PartsPriceCostTextbox.TabIndex = 9;
            PartsPriceCostTextbox.TextChanged += PartsPriceCostTextbox_TextChanged;
            PartsPriceCostTextbox.MouseHover += PartsPriceCostTextbox_MouseHover;
            // 
            // MaxLabel
            // 
            MaxLabel.AutoSize = true;
            MaxLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MaxLabel.Location = new Point(119, 217);
            MaxLabel.Name = "MaxLabel";
            MaxLabel.Size = new Size(39, 21);
            MaxLabel.TabIndex = 12;
            MaxLabel.Text = "Max";
            // 
            // PartsMaxTextbox
            // 
            PartsMaxTextbox.BackColor = Color.Salmon;
            PartsMaxTextbox.Location = new Point(187, 217);
            PartsMaxTextbox.Name = "PartsMaxTextbox";
            PartsMaxTextbox.Size = new Size(89, 23);
            PartsMaxTextbox.TabIndex = 11;
            PartsMaxTextbox.TextChanged += PartsMaxTextbox_TextChanged;
            PartsMaxTextbox.MouseHover += PartsMaxTextbox_MouseHover;
            // 
            // MachineIDCompanyNameLabel
            // 
            MachineIDCompanyNameLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            MachineIDCompanyNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MachineIDCompanyNameLabel.Location = new Point(35, 255);
            MachineIDCompanyNameLabel.Name = "MachineIDCompanyNameLabel";
            MachineIDCompanyNameLabel.Size = new Size(123, 21);
            MachineIDCompanyNameLabel.TabIndex = 14;
            MachineIDCompanyNameLabel.Text = "Machine ID";
            MachineIDCompanyNameLabel.TextAlign = ContentAlignment.BottomRight;
            // 
            // PartsMachineIDTextbox
            // 
            PartsMachineIDTextbox.BackColor = Color.Salmon;
            PartsMachineIDTextbox.Location = new Point(187, 255);
            PartsMachineIDTextbox.Name = "PartsMachineIDTextbox";
            PartsMachineIDTextbox.Size = new Size(142, 23);
            PartsMachineIDTextbox.TabIndex = 13;
            PartsMachineIDTextbox.TextChanged += PartsMachineIDTextbox_TextChanged;
            PartsMachineIDTextbox.MouseHover += PartsMachineIDTextbox_MouseHover;
            // 
            // MinLabel
            // 
            MinLabel.AutoSize = true;
            MinLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MinLabel.Location = new Point(292, 219);
            MinLabel.Name = "MinLabel";
            MinLabel.Size = new Size(37, 21);
            MinLabel.TabIndex = 16;
            MinLabel.Text = "Min";
            // 
            // PartsMinTextbox
            // 
            PartsMinTextbox.BackColor = Color.Salmon;
            PartsMinTextbox.Location = new Point(351, 219);
            PartsMinTextbox.Name = "PartsMinTextbox";
            PartsMinTextbox.Size = new Size(89, 23);
            PartsMinTextbox.TabIndex = 15;
            PartsMinTextbox.TextChanged += PartsMinTextbox_TextChanged;
            PartsMinTextbox.MouseHover += PartsMinTextbox_MouseHover;
            // 
            // PartSaveButton
            // 
            PartSaveButton.Enabled = false;
            PartSaveButton.Location = new Point(301, 300);
            PartSaveButton.Name = "PartSaveButton";
            PartSaveButton.Size = new Size(61, 37);
            PartSaveButton.TabIndex = 17;
            PartSaveButton.Text = "Save";
            PartSaveButton.UseVisualStyleBackColor = true;
            PartSaveButton.Click += PartSaveButton_Click;
            // 
            // PartCancelButton
            // 
            PartCancelButton.Location = new Point(379, 300);
            PartCancelButton.Name = "PartCancelButton";
            PartCancelButton.Size = new Size(61, 37);
            PartCancelButton.TabIndex = 18;
            PartCancelButton.Text = "Cancel";
            PartCancelButton.UseVisualStyleBackColor = true;
            PartCancelButton.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(PartsInHouseRadio);
            panel1.Controls.Add(PartsOutsourcedRadio);
            panel1.Location = new Point(165, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(242, 45);
            panel1.TabIndex = 19;
            // 
            // ErrorToolTip
            // 
            ErrorToolTip.AutomaticDelay = 0;
            // 
            // Part
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 366);
            Controls.Add(panel1);
            Controls.Add(PartCancelButton);
            Controls.Add(PartSaveButton);
            Controls.Add(MinLabel);
            Controls.Add(PartsMinTextbox);
            Controls.Add(MachineIDCompanyNameLabel);
            Controls.Add(PartsMachineIDTextbox);
            Controls.Add(MaxLabel);
            Controls.Add(PartsMaxTextbox);
            Controls.Add(PriceCostLabel);
            Controls.Add(PartsPriceCostTextbox);
            Controls.Add(InventoryLabel);
            Controls.Add(PartsInventoryTextbox);
            Controls.Add(NameLabel);
            Controls.Add(PartsNameTextbox);
            Controls.Add(IDLabel);
            Controls.Add(PartsIDTextbox);
            Controls.Add(PartWindowLabel);
            Name = "Part";
            Text = "Part";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PartWindowLabel;
        private RadioButton PartsInHouseRadio;
        private RadioButton PartsOutsourcedRadio;
        private TextBox PartsIDTextbox;
        private Label IDLabel;
        private Label NameLabel;
        private TextBox PartsNameTextbox;
        private Label InventoryLabel;
        private TextBox PartsInventoryTextbox;
        private Label PriceCostLabel;
        private TextBox PartsPriceCostTextbox;
        private Label MaxLabel;
        private TextBox PartsMaxTextbox;
        private Label MachineIDCompanyNameLabel;
        private TextBox PartsMachineIDTextbox;
        private Label MinLabel;
        private TextBox PartsMinTextbox;
        private Button PartSaveButton;
        private Button PartCancelButton;
        private Panel panel1;
        private ToolTip ErrorToolTip;
    }
}