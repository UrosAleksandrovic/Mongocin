namespace MongocinDesktop.Forms
{
    partial class Orders
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
            this.listViewOrders = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.viewProductsButton = new System.Windows.Forms.Button();
            this.handleOrderButton = new System.Windows.Forms.Button();
            this.deleteOrderButton = new System.Windows.Forms.Button();
            this.editOrderButton = new System.Windows.Forms.Button();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewOrders
            // 
            this.listViewOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewOrders.HideSelection = false;
            this.listViewOrders.Location = new System.Drawing.Point(40, 39);
            this.listViewOrders.Name = "listViewOrders";
            this.listViewOrders.Size = new System.Drawing.Size(571, 322);
            this.listViewOrders.TabIndex = 0;
            this.listViewOrders.UseCompatibleStateImageBehavior = false;
            this.listViewOrders.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Customer Name";
            this.columnHeader2.Width = 117;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Customer Address";
            this.columnHeader3.Width = 129;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Date & time";
            this.columnHeader4.Width = 98;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "State";
            this.columnHeader5.Width = 66;
            // 
            // viewProductsButton
            // 
            this.viewProductsButton.Location = new System.Drawing.Point(710, 159);
            this.viewProductsButton.Name = "viewProductsButton";
            this.viewProductsButton.Size = new System.Drawing.Size(106, 44);
            this.viewProductsButton.TabIndex = 1;
            this.viewProductsButton.Text = "View Products";
            this.viewProductsButton.UseVisualStyleBackColor = true;
            this.viewProductsButton.Click += new System.EventHandler(this.viewProductsButton_Click);
            // 
            // handleOrderButton
            // 
            this.handleOrderButton.Location = new System.Drawing.Point(710, 71);
            this.handleOrderButton.Name = "handleOrderButton";
            this.handleOrderButton.Size = new System.Drawing.Size(106, 44);
            this.handleOrderButton.TabIndex = 2;
            this.handleOrderButton.Text = "Handle order";
            this.handleOrderButton.UseVisualStyleBackColor = true;
            // 
            // deleteOrderButton
            // 
            this.deleteOrderButton.Location = new System.Drawing.Point(710, 317);
            this.deleteOrderButton.Name = "deleteOrderButton";
            this.deleteOrderButton.Size = new System.Drawing.Size(106, 44);
            this.deleteOrderButton.TabIndex = 3;
            this.deleteOrderButton.Text = "Delete";
            this.deleteOrderButton.UseVisualStyleBackColor = true;
            // 
            // editOrderButton
            // 
            this.editOrderButton.Location = new System.Drawing.Point(710, 251);
            this.editOrderButton.Name = "editOrderButton";
            this.editOrderButton.Size = new System.Drawing.Size(106, 44);
            this.editOrderButton.TabIndex = 4;
            this.editOrderButton.Text = "Edit";
            this.editOrderButton.UseVisualStyleBackColor = true;
            this.editOrderButton.Click += new System.EventHandler(this.editOrderButton_Click);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Id";
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 535);
            this.Controls.Add(this.editOrderButton);
            this.Controls.Add(this.deleteOrderButton);
            this.Controls.Add(this.handleOrderButton);
            this.Controls.Add(this.viewProductsButton);
            this.Controls.Add(this.listViewOrders);
            this.Name = "Orders";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.Orders_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewOrders;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button viewProductsButton;
        private System.Windows.Forms.Button handleOrderButton;
        private System.Windows.Forms.Button deleteOrderButton;
        private System.Windows.Forms.Button editOrderButton;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}