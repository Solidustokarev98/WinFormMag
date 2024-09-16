namespace CameraApp
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			dataGridView = new DataGridView();
			txtName = new TextBox();
			dtpReleaseDate = new DateTimePicker();
			txtManufacturer = new TextBox();
			txtPrice = new TextBox();
			txtSupplier = new TextBox();
			chkIsDefective = new CheckBox();
			btnAdd = new Button();
			btnEdit = new Button();
			btnDelete = new Button();
			btnAddToCart = new Button();
			btnOpenCart = new Button();

			((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
			SuspendLayout();
			// 
			// dataGridView
			// 
			dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView.Location = new Point(14, 14);
			dataGridView.Margin = new Padding(4, 3, 4, 3);
			dataGridView.Name = "dataGridView";
			dataGridView.Size = new Size(905, 346);
			dataGridView.TabIndex = 0;
			dataGridView.SelectionChanged += dataGridView_SelectionChanged;
			// 
			// txtName
			// 
			txtName.Location = new Point(14, 367);
			txtName.Margin = new Padding(4, 3, 4, 3);
			txtName.Name = "txtName";
			txtName.Size = new Size(233, 23);
			txtName.TabIndex = 1;
			// 
			// dtpReleaseDate
			// 
			dtpReleaseDate.Location = new Point(266, 367);
			dtpReleaseDate.Margin = new Padding(4, 3, 4, 3);
			dtpReleaseDate.Name = "dtpReleaseDate";
			dtpReleaseDate.Size = new Size(233, 23);
			dtpReleaseDate.TabIndex = 2;
			// 
			// txtManufacturer
			// 
			txtManufacturer.Location = new Point(518, 367);
			txtManufacturer.Margin = new Padding(4, 3, 4, 3);
			txtManufacturer.Name = "txtManufacturer";
			txtManufacturer.Size = new Size(233, 23);
			txtManufacturer.TabIndex = 3;
			// 
			// txtPrice
			// 
			txtPrice.Location = new Point(14, 415);
			txtPrice.Margin = new Padding(4, 3, 4, 3);
			txtPrice.Name = "txtPrice";
			txtPrice.Size = new Size(233, 23);
			txtPrice.TabIndex = 4;
			// 
			// txtSupplier
			// 
			txtSupplier.Location = new Point(266, 415);
			txtSupplier.Margin = new Padding(4, 3, 4, 3);
			txtSupplier.Name = "txtSupplier";
			txtSupplier.Size = new Size(233, 23);
			txtSupplier.TabIndex = 5;
			// 
			// chkIsDefective
			// 
			chkIsDefective.AutoSize = true;
			chkIsDefective.Location = new Point(518, 415);
			chkIsDefective.Margin = new Padding(4, 3, 4, 3);
			chkIsDefective.Name = "chkIsDefective";
			chkIsDefective.Size = new Size(86, 19);
			chkIsDefective.TabIndex = 6;
			chkIsDefective.Text = "Is Defective";
			chkIsDefective.UseVisualStyleBackColor = true;
			// 
			// btnAdd
			// 
			btnAdd.Location = new Point(14, 462);
			btnAdd.Margin = new Padding(4, 3, 4, 3);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(88, 27);
			btnAdd.TabIndex = 7;
			btnAdd.Text = "Add";
			btnAdd.UseVisualStyleBackColor = true;
			btnAdd.Click += btnAdd_Click;
			// 
			// btnEdit
			// 
			btnEdit.Location = new Point(108, 462);
			btnEdit.Margin = new Padding(4, 3, 4, 3);
			btnEdit.Name = "btnEdit";
			btnEdit.Size = new Size(88, 27);
			btnEdit.TabIndex = 8;
			btnEdit.Text = "Edit";
			btnEdit.UseVisualStyleBackColor = true;
			btnEdit.Click += btnEdit_Click;
			// 
			// btnDelete
			// 
			btnDelete.Location = new Point(203, 462);
			btnDelete.Margin = new Padding(4, 3, 4, 3);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(88, 27);
			btnDelete.TabIndex = 9;
			btnDelete.Text = "Delete";
			btnDelete.UseVisualStyleBackColor = true;
			btnDelete.Click += btnDelete_Click;
			// 
			// btnAddToCart
			// 
			btnAddToCart.Location = new Point(299, 462);
			btnAddToCart.Margin = new Padding(4, 3, 4, 3);
			btnAddToCart.Name = "btnAddToCart";
			btnAddToCart.Size = new Size(117, 27);
			btnAddToCart.TabIndex = 10;
			btnAddToCart.Text = "Добавить в корзину";
			btnAddToCart.UseVisualStyleBackColor = true;
			btnAddToCart.Click += btnAddToCart_Click;
			// 
			// btnOpenCart
			// 
			btnOpenCart.Location = new Point(420, 462);
			btnOpenCart.Margin = new Padding(4, 3, 4, 3);
			btnOpenCart.Name = "btnOpenCart";
			btnOpenCart.Size = new Size(117, 27);
			btnOpenCart.TabIndex = 11;
			btnOpenCart.Text = "Открыть корзину";
			btnOpenCart.UseVisualStyleBackColor = true;
			btnOpenCart.Click += btnOpenCart_Click;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(933, 519);
			Controls.Add(btnDelete);
			Controls.Add(btnEdit);
			Controls.Add(btnAdd);
			Controls.Add(chkIsDefective);
			Controls.Add(txtSupplier);
			Controls.Add(txtPrice);
			Controls.Add(txtManufacturer);
			Controls.Add(dtpReleaseDate);
			Controls.Add(txtName);
			Controls.Add(dataGridView);
			Controls.Add(btnAddToCart);
			Controls.Add(btnOpenCart);
			Margin = new Padding(4, 3, 4, 3);
			Name = "MainForm";
			Text = "Camera Management";
			((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.DateTimePicker dtpReleaseDate;
		private System.Windows.Forms.TextBox txtManufacturer;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.TextBox txtSupplier;
		private System.Windows.Forms.CheckBox chkIsDefective;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnAddToCart;
		private System.Windows.Forms.Button btnOpenCart;
	}
}