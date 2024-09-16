partial class CartForm
{
	private System.Windows.Forms.DataGridView dataGridViewCart;
	private System.Windows.Forms.Button btnDelete;
	private System.Windows.Forms.Button btnPurchase;

	private void InitializeComponent()
	{
		this.dataGridViewCart = new System.Windows.Forms.DataGridView();
		this.btnDelete = new System.Windows.Forms.Button();
		this.btnPurchase = new System.Windows.Forms.Button();

		// 
		// dataGridViewCart
		// 
		this.dataGridViewCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dataGridViewCart.Location = new System.Drawing.Point(12, 12);
		this.dataGridViewCart.Name = "dataGridViewCart";
		this.dataGridViewCart.Size = new System.Drawing.Size(460, 200);
		this.dataGridViewCart.TabIndex = 0;

		// 
		// btnDelete
		// 
		this.btnDelete.Location = new System.Drawing.Point(12, 230);
		this.btnDelete.Name = "btnDelete";
		this.btnDelete.Size = new System.Drawing.Size(75, 23);
		this.btnDelete.TabIndex = 1;
		this.btnDelete.Text = "Удалить";
		this.btnDelete.UseVisualStyleBackColor = true;
		this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

		// 
		// btnPurchase
		// 
		this.btnPurchase.Location = new System.Drawing.Point(397, 230);
		this.btnPurchase.Name = "btnPurchase";
		this.btnPurchase.Size = new System.Drawing.Size(75, 23);
		this.btnPurchase.TabIndex = 2;
		this.btnPurchase.Text = "Приобрести";
		this.btnPurchase.UseVisualStyleBackColor = true;
		this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);

		// 
		// CartForm
		// 
		this.ClientSize = new System.Drawing.Size(484, 261);
		this.Controls.Add(this.btnPurchase);
		this.Controls.Add(this.btnDelete);
		this.Controls.Add(this.dataGridViewCart);
		this.Name = "CartForm";
		this.Text = "Корзина";
		((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).EndInit();
		this.ResumeLayout(false);
	}
}