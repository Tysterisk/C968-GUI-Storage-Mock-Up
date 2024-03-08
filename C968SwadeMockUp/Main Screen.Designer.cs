namespace C968SwadeMockUp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            PartsSearchButton = new Button();
            PartsSearchBox = new TextBox();
            label1 = new Label();
            ProductsSearchBox = new TextBox();
            ProductsSearchButton = new Button();
            PartsDataGrid = new DataGridView();
            partBindingSource = new BindingSource(components);
            ProductsDataGrid = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            PartsAddButton = new Button();
            PartsDeleteButton = new Button();
            PartsModifyButton = new Button();
            ProductsModifyButton = new Button();
            ProductsDeleteButton = new Button();
            ProductsAddButton = new Button();
            MainExitButton = new Button();
            productFormBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)PartsDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)partBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductsDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productFormBindingSource).BeginInit();
            SuspendLayout();
            // 
            // PartsSearchButton
            // 
            PartsSearchButton.Location = new Point(334, 72);
            PartsSearchButton.Name = "PartsSearchButton";
            PartsSearchButton.Size = new Size(75, 23);
            PartsSearchButton.TabIndex = 0;
            PartsSearchButton.Text = "Search";
            PartsSearchButton.UseVisualStyleBackColor = true;
            PartsSearchButton.Click += PartsSearchButton_Click;
            // 
            // PartsSearchBox
            // 
            PartsSearchBox.Location = new Point(429, 72);
            PartsSearchBox.Name = "PartsSearchBox";
            PartsSearchBox.Size = new Size(193, 23);
            PartsSearchBox.TabIndex = 2;
            PartsSearchBox.TextChanged += PartsSearchBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(320, 30);
            label1.TabIndex = 4;
            label1.Text = "Inventory Management System";
            // 
            // ProductsSearchBox
            // 
            ProductsSearchBox.Location = new Point(1050, 71);
            ProductsSearchBox.Name = "ProductsSearchBox";
            ProductsSearchBox.Size = new Size(193, 23);
            ProductsSearchBox.TabIndex = 6;
            ProductsSearchBox.TextChanged += ProductsSearchBox_TextChanged;
            // 
            // ProductsSearchButton
            // 
            ProductsSearchButton.Location = new Point(955, 71);
            ProductsSearchButton.Name = "ProductsSearchButton";
            ProductsSearchButton.Size = new Size(75, 23);
            ProductsSearchButton.TabIndex = 5;
            ProductsSearchButton.Text = "Search";
            ProductsSearchButton.UseVisualStyleBackColor = true;
            ProductsSearchButton.Click += ProductsSearchButton_Click;
            // 
            // PartsDataGrid
            // 
            PartsDataGrid.AllowUserToAddRows = false;
            PartsDataGrid.AllowUserToResizeColumns = false;
            PartsDataGrid.AllowUserToResizeRows = false;
            PartsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PartsDataGrid.Location = new Point(29, 116);
            PartsDataGrid.Name = "PartsDataGrid";
            PartsDataGrid.ReadOnly = true;
            PartsDataGrid.RowHeadersVisible = false;
            PartsDataGrid.RowTemplate.Height = 25;
            PartsDataGrid.Size = new Size(593, 259);
            PartsDataGrid.TabIndex = 7;
            PartsDataGrid.CellClick += PartsDataGrid_CellClick;
            PartsDataGrid.DataBindingComplete += PartsDataGrid_DataBindingComplete;
            // 
            // partBindingSource
            // 
            partBindingSource.DataSource = typeof(Part);
            // 
            // ProductsDataGrid
            // 
            ProductsDataGrid.AllowUserToAddRows = false;
            ProductsDataGrid.AllowUserToResizeColumns = false;
            ProductsDataGrid.AllowUserToResizeRows = false;
            ProductsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductsDataGrid.Location = new Point(650, 116);
            ProductsDataGrid.Name = "ProductsDataGrid";
            ProductsDataGrid.ReadOnly = true;
            ProductsDataGrid.RowHeadersVisible = false;
            ProductsDataGrid.RowTemplate.Height = 25;
            ProductsDataGrid.Size = new Size(593, 259);
            ProductsDataGrid.TabIndex = 8;
            ProductsDataGrid.CellClick += ProductsDataGrid_CellClick;
            ProductsDataGrid.DataBindingComplete += ProductsDataGrid_DataBindingComplete;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(29, 83);
            label2.Name = "label2";
            label2.Size = new Size(62, 30);
            label2.TabIndex = 9;
            label2.Text = "Parts";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(650, 83);
            label3.Name = "label3";
            label3.Size = new Size(100, 30);
            label3.TabIndex = 10;
            label3.Text = "Products";
            // 
            // PartsAddButton
            // 
            PartsAddButton.Location = new Point(424, 381);
            PartsAddButton.Name = "PartsAddButton";
            PartsAddButton.Size = new Size(62, 37);
            PartsAddButton.TabIndex = 11;
            PartsAddButton.Text = "Add";
            PartsAddButton.UseVisualStyleBackColor = true;
            PartsAddButton.Click += PartsAddButton_Click;
            // 
            // PartsDeleteButton
            // 
            PartsDeleteButton.Enabled = false;
            PartsDeleteButton.Location = new Point(560, 381);
            PartsDeleteButton.Name = "PartsDeleteButton";
            PartsDeleteButton.Size = new Size(62, 37);
            PartsDeleteButton.TabIndex = 12;
            PartsDeleteButton.Text = "Delete";
            PartsDeleteButton.UseVisualStyleBackColor = true;
            PartsDeleteButton.Click += PartsDeleteButton_Click;
            // 
            // PartsModifyButton
            // 
            PartsModifyButton.Enabled = false;
            PartsModifyButton.Location = new Point(492, 381);
            PartsModifyButton.Name = "PartsModifyButton";
            PartsModifyButton.Size = new Size(62, 37);
            PartsModifyButton.TabIndex = 13;
            PartsModifyButton.Text = "Modify";
            PartsModifyButton.UseVisualStyleBackColor = true;
            PartsModifyButton.Click += PartsModifyButton_Click;
            // 
            // ProductsModifyButton
            // 
            ProductsModifyButton.Enabled = false;
            ProductsModifyButton.Location = new Point(1114, 381);
            ProductsModifyButton.Name = "ProductsModifyButton";
            ProductsModifyButton.Size = new Size(62, 37);
            ProductsModifyButton.TabIndex = 16;
            ProductsModifyButton.Text = "Modify";
            ProductsModifyButton.UseVisualStyleBackColor = true;
            ProductsModifyButton.Click += ProductsModifyButton_Click;
            // 
            // ProductsDeleteButton
            // 
            ProductsDeleteButton.Enabled = false;
            ProductsDeleteButton.Location = new Point(1182, 381);
            ProductsDeleteButton.Name = "ProductsDeleteButton";
            ProductsDeleteButton.Size = new Size(62, 37);
            ProductsDeleteButton.TabIndex = 15;
            ProductsDeleteButton.Text = "Delete";
            ProductsDeleteButton.UseVisualStyleBackColor = true;
            ProductsDeleteButton.Click += ProductsDeleteButton_Click;
            // 
            // ProductsAddButton
            // 
            ProductsAddButton.Location = new Point(1046, 381);
            ProductsAddButton.Name = "ProductsAddButton";
            ProductsAddButton.Size = new Size(62, 37);
            ProductsAddButton.TabIndex = 14;
            ProductsAddButton.Text = "Add";
            ProductsAddButton.UseVisualStyleBackColor = true;
            ProductsAddButton.Click += ProductsAddButton_Click;
            // 
            // MainExitButton
            // 
            MainExitButton.Location = new Point(1182, 454);
            MainExitButton.Name = "MainExitButton";
            MainExitButton.Size = new Size(62, 37);
            MainExitButton.TabIndex = 17;
            MainExitButton.Text = "Exit";
            MainExitButton.UseVisualStyleBackColor = true;
            MainExitButton.Click += MainExitButton_Click;
            // 
            // productFormBindingSource
            // 
            productFormBindingSource.DataSource = typeof(ProductForm);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1271, 528);
            Controls.Add(MainExitButton);
            Controls.Add(ProductsModifyButton);
            Controls.Add(ProductsDeleteButton);
            Controls.Add(ProductsAddButton);
            Controls.Add(PartsModifyButton);
            Controls.Add(PartsDeleteButton);
            Controls.Add(PartsAddButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ProductsDataGrid);
            Controls.Add(PartsDataGrid);
            Controls.Add(ProductsSearchBox);
            Controls.Add(ProductsSearchButton);
            Controls.Add(label1);
            Controls.Add(PartsSearchBox);
            Controls.Add(PartsSearchButton);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)PartsDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)partBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductsDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)productFormBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button PartsSearchButton;
        private TextBox PartsSearchBox;
        private Label label1;
        private TextBox ProductsSearchBox;
        private Button ProductsSearchButton;
        private DataGridView PartsDataGrid;
        private DataGridView ProductsDataGrid;
        private Label label2;
        private Label label3;
        private Button PartsAddButton;
        private Button PartsDeleteButton;
        private Button PartsModifyButton;
        private Button ProductsModifyButton;
        private Button ProductsDeleteButton;
        private Button ProductsAddButton;
        private Button MainExitButton;
        private BindingSource partBindingSource;
        private BindingSource productFormBindingSource;
    }
}