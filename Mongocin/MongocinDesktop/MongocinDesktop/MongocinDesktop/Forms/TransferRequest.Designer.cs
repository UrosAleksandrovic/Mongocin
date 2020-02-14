namespace MongocinDesktop.Forms
{
    partial class TransferRequest
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
            this.listViewStorage = new System.Windows.Forms.ListView();
            this.buttonSave = new System.Windows.Forms.Button();
            this.listViewProducts = new System.Windows.Forms.ListView();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewAllProducts = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listViewStorage
            // 
            this.listViewStorage.HideSelection = false;
            this.listViewStorage.Location = new System.Drawing.Point(27, 40);
            this.listViewStorage.Name = "listViewStorage";
            this.listViewStorage.Size = new System.Drawing.Size(289, 250);
            this.listViewStorage.TabIndex = 0;
            this.listViewStorage.UseCompatibleStateImageBehavior = false;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(534, 553);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(96, 38);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // listViewProducts
            // 
            this.listViewProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewProducts.HideSelection = false;
            this.listViewProducts.Location = new System.Drawing.Point(923, 40);
            this.listViewProducts.Name = "listViewProducts";
            this.listViewProducts.Size = new System.Drawing.Size(289, 250);
            this.listViewProducts.TabIndex = 2;
            this.listViewProducts.UseCompatibleStateImageBehavior = false;
            this.listViewProducts.View = System.Windows.Forms.View.Details;
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(503, 381);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(96, 38);
            this.buttonAddProduct.TabIndex = 3;
            this.buttonAddProduct.Text = "Add product";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Quantity";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(555, 323);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(128, 22);
            this.textBoxQuantity.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(419, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Quantity";
            // 
            // listViewAllProducts
            // 
            this.listViewAllProducts.HideSelection = false;
            this.listViewAllProducts.Location = new System.Drawing.Point(404, 40);
            this.listViewAllProducts.Name = "listViewAllProducts";
            this.listViewAllProducts.Size = new System.Drawing.Size(289, 250);
            this.listViewAllProducts.TabIndex = 8;
            this.listViewAllProducts.UseCompatibleStateImageBehavior = false;
            // 
            // TransferRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 634);
            this.Controls.Add(this.listViewAllProducts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.buttonAddProduct);
            this.Controls.Add(this.listViewProducts);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.listViewStorage);
            this.Name = "TransferRequest";
            this.Text = "TransferRequest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewStorage;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ListView listViewProducts;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewAllProducts;
    }
}