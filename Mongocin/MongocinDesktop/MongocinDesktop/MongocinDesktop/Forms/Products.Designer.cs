namespace MongocinDesktop.Forms
{
    partial class Products
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
            this.listViewProducts = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addProductButton = new System.Windows.Forms.Button();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.editProductButton = new System.Windows.Forms.Button();
            this.listViewAllProducts = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewProducts
            // 
            this.listViewProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewProducts.HideSelection = false;
            this.listViewProducts.Location = new System.Drawing.Point(74, 80);
            this.listViewProducts.Name = "listViewProducts";
            this.listViewProducts.Size = new System.Drawing.Size(376, 339);
            this.listViewProducts.TabIndex = 1;
            this.listViewProducts.UseCompatibleStateImageBehavior = false;
            this.listViewProducts.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Quantity";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Description";
            this.columnHeader3.Width = 223;
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(834, 547);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(96, 41);
            this.addProductButton.TabIndex = 8;
            this.addProductButton.Text = "Add";
            this.addProductButton.UseVisualStyleBackColor = true;
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.Location = new System.Drawing.Point(311, 473);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(96, 37);
            this.deleteProductButton.TabIndex = 7;
            this.deleteProductButton.Text = "Delete";
            this.deleteProductButton.UseVisualStyleBackColor = true;
            // 
            // editProductButton
            // 
            this.editProductButton.Location = new System.Drawing.Point(83, 471);
            this.editProductButton.Name = "editProductButton";
            this.editProductButton.Size = new System.Drawing.Size(96, 41);
            this.editProductButton.TabIndex = 9;
            this.editProductButton.Text = "Edit";
            this.editProductButton.UseVisualStyleBackColor = true;
            // 
            // listViewAllProducts
            // 
            this.listViewAllProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4});
            this.listViewAllProducts.HideSelection = false;
            this.listViewAllProducts.Location = new System.Drawing.Point(783, 80);
            this.listViewAllProducts.Name = "listViewAllProducts";
            this.listViewAllProducts.Size = new System.Drawing.Size(195, 339);
            this.listViewAllProducts.TabIndex = 10;
            this.listViewAllProducts.UseCompatibleStateImageBehavior = false;
            this.listViewAllProducts.View = System.Windows.Forms.View.Details;
            this.listViewAllProducts.SelectedIndexChanged += new System.EventHandler(this.listViewAllProducts_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Name";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(869, 473);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(100, 22);
            this.textBoxQuantity.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(756, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Select product and insert quantity";
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Location = new System.Drawing.Point(780, 478);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(61, 17);
            this.Quantity.TabIndex = 13;
            this.Quantity.Text = "Quantity";
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 659);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.listViewAllProducts);
            this.Controls.Add(this.editProductButton);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.deleteProductButton);
            this.Controls.Add(this.listViewProducts);
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewProducts;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button deleteProductButton;
        private System.Windows.Forms.Button editProductButton;
        private System.Windows.Forms.ListView listViewAllProducts;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Quantity;
    }
}