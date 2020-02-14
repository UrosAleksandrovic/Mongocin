namespace MongocinDesktop.Forms
{
    partial class Receipts
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
            this.listViewReceipts = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addReceiptsButton = new System.Windows.Forms.Button();
            this.deleteReceiptButton = new System.Windows.Forms.Button();
            this.viewProductsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewReceipts
            // 
            this.listViewReceipts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewReceipts.HideSelection = false;
            this.listViewReceipts.Location = new System.Drawing.Point(63, 57);
            this.listViewReceipts.Name = "listViewReceipts";
            this.listViewReceipts.Size = new System.Drawing.Size(294, 259);
            this.listViewReceipts.TabIndex = 0;
            this.listViewReceipts.UseCompatibleStateImageBehavior = false;
            this.listViewReceipts.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Full Cost";
            this.columnHeader1.Width = 111;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Date & time";
            this.columnHeader2.Width = 116;
            // 
            // addReceiptsButton
            // 
            this.addReceiptsButton.Location = new System.Drawing.Point(475, 101);
            this.addReceiptsButton.Name = "addReceiptsButton";
            this.addReceiptsButton.Size = new System.Drawing.Size(116, 38);
            this.addReceiptsButton.TabIndex = 1;
            this.addReceiptsButton.Text = "Add";
            this.addReceiptsButton.UseVisualStyleBackColor = true;
            // 
            // deleteReceiptButton
            // 
            this.deleteReceiptButton.Location = new System.Drawing.Point(475, 179);
            this.deleteReceiptButton.Name = "deleteReceiptButton";
            this.deleteReceiptButton.Size = new System.Drawing.Size(116, 48);
            this.deleteReceiptButton.TabIndex = 3;
            this.deleteReceiptButton.Text = "Delete";
            this.deleteReceiptButton.UseVisualStyleBackColor = true;
            // 
            // viewProductsButton
            // 
            this.viewProductsButton.Location = new System.Drawing.Point(475, 268);
            this.viewProductsButton.Name = "viewProductsButton";
            this.viewProductsButton.Size = new System.Drawing.Size(116, 48);
            this.viewProductsButton.TabIndex = 4;
            this.viewProductsButton.Text = "View Products";
            this.viewProductsButton.UseVisualStyleBackColor = true;
            // 
            // Receipts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewProductsButton);
            this.Controls.Add(this.deleteReceiptButton);
            this.Controls.Add(this.addReceiptsButton);
            this.Controls.Add(this.listViewReceipts);
            this.Name = "Receipts";
            this.Text = "Receipts";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewReceipts;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button addReceiptsButton;
        private System.Windows.Forms.Button deleteReceiptButton;
        private System.Windows.Forms.Button viewProductsButton;
    }
}