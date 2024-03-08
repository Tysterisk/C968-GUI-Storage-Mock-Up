namespace C968SwadeMockUp
{
    partial class ProductForm
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
            ProductWindowLabel = new Label();
            ProductCandidateParts = new DataGridView();
            ProductsSearchButton = new Button();
            ProductSearchBarBox = new TextBox();
            CandidatePartsLabel = new Label();
            ProductCandidatePartsAddButton = new Button();
            ProductAssociatedLabel = new Label();
            ProductAssociatedParts = new DataGridView();
            ProductDeleteButton = new Button();
            ProductCancelButton = new Button();
            ProductSaveButton = new Button();
            ProductIDLabel = new Label();
            ProductNameLabel = new Label();
            ProductInventoryLabel = new Label();
            ProductPriceLabel = new Label();
            ProductMaxLabel = new Label();
            ProductMinLabel = new Label();
            ProductIDTextbox = new TextBox();
            ProductNameTextbox = new TextBox();
            ProductInventoryTextbox = new TextBox();
            ProductPriceTextbox = new TextBox();
            ProductMaxTextbox = new TextBox();
            ProductMinTextbox = new TextBox();
            ErrorToolTip = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)ProductCandidateParts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductAssociatedParts).BeginInit();
            SuspendLayout();
            // 
            // ProductWindowLabel
            // 
            ProductWindowLabel.AutoSize = true;
            ProductWindowLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ProductWindowLabel.Location = new Point(22, 17);
            ProductWindowLabel.Name = "ProductWindowLabel";
            ProductWindowLabel.Size = new Size(79, 25);
            ProductWindowLabel.TabIndex = 0;
            ProductWindowLabel.Text = "Product";
            // 
            // ProductCandidateParts
            // 
            ProductCandidateParts.AllowUserToResizeColumns = false;
            ProductCandidateParts.AllowUserToResizeRows = false;
            ProductCandidateParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductCandidateParts.Location = new Point(355, 75);
            ProductCandidateParts.Name = "ProductCandidateParts";
            ProductCandidateParts.ReadOnly = true;
            ProductCandidateParts.RowHeadersVisible = false;
            ProductCandidateParts.RowTemplate.Height = 25;
            ProductCandidateParts.Size = new Size(599, 159);
            ProductCandidateParts.TabIndex = 1;
            ProductCandidateParts.CellClick += ProductCandidateParts_CellClick;
            ProductCandidateParts.DataBindingComplete += ProductCandidateParts_DataBindingComplete;
            // 
            // ProductsSearchButton
            // 
            ProductsSearchButton.Location = new Point(564, 31);
            ProductsSearchButton.Name = "ProductsSearchButton";
            ProductsSearchButton.Size = new Size(75, 23);
            ProductsSearchButton.TabIndex = 2;
            ProductsSearchButton.Text = "Search";
            ProductsSearchButton.UseVisualStyleBackColor = true;
            ProductsSearchButton.Click += ProductsSearchButton_Click_1;
            // 
            // ProductSearchBarBox
            // 
            ProductSearchBarBox.Location = new Point(655, 32);
            ProductSearchBarBox.Name = "ProductSearchBarBox";
            ProductSearchBarBox.Size = new Size(299, 23);
            ProductSearchBarBox.TabIndex = 3;
            ProductSearchBarBox.TextChanged += ProductsSearchBox_TextChanged;
            // 
            // CandidatePartsLabel
            // 
            CandidatePartsLabel.AutoSize = true;
            CandidatePartsLabel.Location = new Point(355, 57);
            CandidatePartsLabel.Name = "CandidatePartsLabel";
            CandidatePartsLabel.Size = new Size(105, 15);
            CandidatePartsLabel.TabIndex = 4;
            CandidatePartsLabel.Text = "All candidate Parts";
            // 
            // ProductCandidatePartsAddButton
            // 
            ProductCandidatePartsAddButton.Enabled = false;
            ProductCandidatePartsAddButton.Location = new Point(879, 240);
            ProductCandidatePartsAddButton.Name = "ProductCandidatePartsAddButton";
            ProductCandidatePartsAddButton.Size = new Size(60, 38);
            ProductCandidatePartsAddButton.TabIndex = 5;
            ProductCandidatePartsAddButton.Text = "Add";
            ProductCandidatePartsAddButton.UseVisualStyleBackColor = true;
            ProductCandidatePartsAddButton.Click += ProductCandidatePartsAddButton_Click;
            // 
            // ProductAssociatedLabel
            // 
            ProductAssociatedLabel.AutoSize = true;
            ProductAssociatedLabel.Location = new Point(355, 292);
            ProductAssociatedLabel.Name = "ProductAssociatedLabel";
            ProductAssociatedLabel.Size = new Size(184, 15);
            ProductAssociatedLabel.TabIndex = 7;
            ProductAssociatedLabel.Text = "Parts Associated with the Product";
            // 
            // ProductAssociatedParts
            // 
            ProductAssociatedParts.AllowUserToResizeColumns = false;
            ProductAssociatedParts.AllowUserToResizeRows = false;
            ProductAssociatedParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductAssociatedParts.Location = new Point(355, 310);
            ProductAssociatedParts.Name = "ProductAssociatedParts";
            ProductAssociatedParts.ReadOnly = true;
            ProductAssociatedParts.RowHeadersVisible = false;
            ProductAssociatedParts.RowTemplate.Height = 25;
            ProductAssociatedParts.Size = new Size(599, 159);
            ProductAssociatedParts.TabIndex = 6;
            ProductAssociatedParts.CellClick += ProductAssociatedParts_CellClick;
            ProductAssociatedParts.DataBindingComplete += ProductAssociatedParts_DataBindingComplete;
            // 
            // ProductDeleteButton
            // 
            ProductDeleteButton.Enabled = false;
            ProductDeleteButton.Location = new Point(879, 486);
            ProductDeleteButton.Name = "ProductDeleteButton";
            ProductDeleteButton.Size = new Size(60, 38);
            ProductDeleteButton.TabIndex = 8;
            ProductDeleteButton.Text = "Delete";
            ProductDeleteButton.UseVisualStyleBackColor = true;
            ProductDeleteButton.Click += ProductDeleteButton_Click;
            // 
            // ProductCancelButton
            // 
            ProductCancelButton.Location = new Point(879, 539);
            ProductCancelButton.Name = "ProductCancelButton";
            ProductCancelButton.Size = new Size(60, 38);
            ProductCancelButton.TabIndex = 9;
            ProductCancelButton.Text = "Cancel";
            ProductCancelButton.UseVisualStyleBackColor = true;
            ProductCancelButton.Click += ProductCancelButton_Click;
            // 
            // ProductSaveButton
            // 
            ProductSaveButton.Enabled = false;
            ProductSaveButton.Location = new Point(797, 539);
            ProductSaveButton.Name = "ProductSaveButton";
            ProductSaveButton.Size = new Size(60, 38);
            ProductSaveButton.TabIndex = 10;
            ProductSaveButton.Text = "Save";
            ProductSaveButton.UseVisualStyleBackColor = true;
            ProductSaveButton.Click += ProductSaveButton_Click;
            // 
            // ProductIDLabel
            // 
            ProductIDLabel.AutoSize = true;
            ProductIDLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ProductIDLabel.Location = new Point(22, 181);
            ProductIDLabel.Name = "ProductIDLabel";
            ProductIDLabel.Size = new Size(25, 21);
            ProductIDLabel.TabIndex = 11;
            ProductIDLabel.Text = "ID";
            // 
            // ProductNameLabel
            // 
            ProductNameLabel.AutoSize = true;
            ProductNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ProductNameLabel.Location = new Point(22, 219);
            ProductNameLabel.Name = "ProductNameLabel";
            ProductNameLabel.Size = new Size(52, 21);
            ProductNameLabel.TabIndex = 12;
            ProductNameLabel.Text = "Name";
            // 
            // ProductInventoryLabel
            // 
            ProductInventoryLabel.AutoSize = true;
            ProductInventoryLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ProductInventoryLabel.Location = new Point(22, 253);
            ProductInventoryLabel.Name = "ProductInventoryLabel";
            ProductInventoryLabel.Size = new Size(76, 21);
            ProductInventoryLabel.TabIndex = 13;
            ProductInventoryLabel.Text = "Inventory";
            // 
            // ProductPriceLabel
            // 
            ProductPriceLabel.AutoSize = true;
            ProductPriceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ProductPriceLabel.Location = new Point(22, 295);
            ProductPriceLabel.Name = "ProductPriceLabel";
            ProductPriceLabel.Size = new Size(44, 21);
            ProductPriceLabel.TabIndex = 14;
            ProductPriceLabel.Text = "Price";
            // 
            // ProductMaxLabel
            // 
            ProductMaxLabel.AutoSize = true;
            ProductMaxLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ProductMaxLabel.Location = new Point(22, 334);
            ProductMaxLabel.Name = "ProductMaxLabel";
            ProductMaxLabel.Size = new Size(39, 21);
            ProductMaxLabel.TabIndex = 15;
            ProductMaxLabel.Text = "Max";
            // 
            // ProductMinLabel
            // 
            ProductMinLabel.AutoSize = true;
            ProductMinLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ProductMinLabel.Location = new Point(168, 334);
            ProductMinLabel.Name = "ProductMinLabel";
            ProductMinLabel.Size = new Size(37, 21);
            ProductMinLabel.TabIndex = 16;
            ProductMinLabel.Text = "Min";
            // 
            // ProductIDTextbox
            // 
            ProductIDTextbox.Enabled = false;
            ProductIDTextbox.Location = new Point(117, 179);
            ProductIDTextbox.Name = "ProductIDTextbox";
            ProductIDTextbox.Size = new Size(141, 23);
            ProductIDTextbox.TabIndex = 17;
            // 
            // ProductNameTextbox
            // 
            ProductNameTextbox.BackColor = Color.Salmon;
            ProductNameTextbox.ForeColor = SystemColors.WindowText;
            ProductNameTextbox.Location = new Point(117, 217);
            ProductNameTextbox.Name = "ProductNameTextbox";
            ProductNameTextbox.Size = new Size(141, 23);
            ProductNameTextbox.TabIndex = 18;
            ProductNameTextbox.TextChanged += ProductNameTextbox_TextChanged;
            ProductNameTextbox.MouseHover += ProductNameTextbox_MouseHover;
            // 
            // ProductInventoryTextbox
            // 
            ProductInventoryTextbox.BackColor = Color.Salmon;
            ProductInventoryTextbox.Location = new Point(117, 255);
            ProductInventoryTextbox.Name = "ProductInventoryTextbox";
            ProductInventoryTextbox.Size = new Size(141, 23);
            ProductInventoryTextbox.TabIndex = 19;
            ProductInventoryTextbox.TextChanged += ProductInventoryTextbox_TextChanged;
            ProductInventoryTextbox.MouseHover += ProductInventoryTextbox_MouseHover;
            // 
            // ProductPriceTextbox
            // 
            ProductPriceTextbox.BackColor = Color.Salmon;
            ProductPriceTextbox.Location = new Point(117, 293);
            ProductPriceTextbox.Name = "ProductPriceTextbox";
            ProductPriceTextbox.Size = new Size(141, 23);
            ProductPriceTextbox.TabIndex = 20;
            ProductPriceTextbox.TextChanged += ProductPriceCostTextbox_TextChanged;
            ProductPriceTextbox.MouseHover += ProductPriceTextbox_MouseHover;
            // 
            // ProductMaxTextbox
            // 
            ProductMaxTextbox.BackColor = Color.Salmon;
            ProductMaxTextbox.Location = new Point(67, 334);
            ProductMaxTextbox.Name = "ProductMaxTextbox";
            ProductMaxTextbox.Size = new Size(95, 23);
            ProductMaxTextbox.TabIndex = 21;
            ProductMaxTextbox.TextChanged += ProductMaxTextbox_TextChanged;
            ProductMaxTextbox.MouseHover += ProductMaxTextbox_MouseHover;
            // 
            // ProductMinTextbox
            // 
            ProductMinTextbox.BackColor = Color.Salmon;
            ProductMinTextbox.Location = new Point(211, 334);
            ProductMinTextbox.Name = "ProductMinTextbox";
            ProductMinTextbox.Size = new Size(95, 23);
            ProductMinTextbox.TabIndex = 22;
            ProductMinTextbox.TextChanged += ProductMinTextbox_TextChanged;
            ProductMinTextbox.MouseHover += ProductMinTextbox_MouseHover;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 600);
            Controls.Add(ProductMinTextbox);
            Controls.Add(ProductMaxTextbox);
            Controls.Add(ProductPriceTextbox);
            Controls.Add(ProductInventoryTextbox);
            Controls.Add(ProductNameTextbox);
            Controls.Add(ProductIDTextbox);
            Controls.Add(ProductMinLabel);
            Controls.Add(ProductMaxLabel);
            Controls.Add(ProductPriceLabel);
            Controls.Add(ProductInventoryLabel);
            Controls.Add(ProductNameLabel);
            Controls.Add(ProductIDLabel);
            Controls.Add(ProductSaveButton);
            Controls.Add(ProductCancelButton);
            Controls.Add(ProductDeleteButton);
            Controls.Add(ProductAssociatedLabel);
            Controls.Add(ProductAssociatedParts);
            Controls.Add(ProductCandidatePartsAddButton);
            Controls.Add(CandidatePartsLabel);
            Controls.Add(ProductSearchBarBox);
            Controls.Add(ProductsSearchButton);
            Controls.Add(ProductCandidateParts);
            Controls.Add(ProductWindowLabel);
            Name = "ProductForm";
            Text = "Products";
            Click += ProductForm_Click;
            ((System.ComponentModel.ISupportInitialize)ProductCandidateParts).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductAssociatedParts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ProductWindowLabel;
        private DataGridView ProductCandidateParts;
        private Button ProductsSearchButton;
        private TextBox ProductSearchBarBox;
        private Label CandidatePartsLabel;
        private Button ProductCandidatePartsAddButton;
        private Label ProductAssociatedLabel;
        private DataGridView ProductAssociatedParts;
        private Button ProductDeleteButton;
        private Button ProductCancelButton;
        private Button ProductSaveButton;
        private Label ProductIDLabel;
        private Label ProductNameLabel;
        private Label ProductInventoryLabel;
        private Label ProductPriceLabel;
        private Label ProductMaxLabel;
        private Label ProductMinLabel;
        private TextBox ProductIDTextbox;
        private TextBox ProductNameTextbox;
        private TextBox ProductInventoryTextbox;
        private TextBox ProductPriceTextbox;
        private TextBox ProductMaxTextbox;
        private TextBox ProductMinTextbox;
        private ToolTip ErrorToolTip;
    }
}