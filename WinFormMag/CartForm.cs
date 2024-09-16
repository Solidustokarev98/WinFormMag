public partial class CartForm : Form
{
	private List<CartItem> _cartItems;

	public CartForm()
	{
		InitializeComponent();
		_cartItems = new List<CartItem>();
		UpdateCartView();
	}

	// Метод для добавления товаров в корзину
	public void AddToCart(CartItem item)
	{
		var existingItem = _cartItems.FirstOrDefault(i => i.Id == item.Id);
		if (existingItem != null)
		{
			existingItem.Quantity += item.Quantity;
		}
		else
		{
			_cartItems.Add(item);
		}
		UpdateCartView();
	}

	// Обновление отображения корзины
	private void UpdateCartView()
	{
		dataGridViewCart.DataSource = null;
		dataGridViewCart.DataSource = _cartItems;
	}

	// Удаление товара из корзины
	private void btnDelete_Click(object sender, EventArgs e)
	{
		if (dataGridViewCart.SelectedRows.Count > 0)
		{
			var selectedItem = (CartItem)dataGridViewCart.SelectedRows[0].DataBoundItem;
			_cartItems.Remove(selectedItem);
			UpdateCartView();
		}
	}

	// Покупка товаров
	private void btnPurchase_Click(object sender, EventArgs e)
	{
		if (_cartItems.Count > 0)
		{
			// Здесь можно добавить логику покупки товаров, например, сохранить информацию о продаже в базе данных
			MessageBox.Show("Товары приобретены!");

			_cartItems.Clear(); // Очистить корзину после покупки
			UpdateCartView();
		}
		else
		{
			MessageBox.Show("Корзина пуста.");
		}
	}
}