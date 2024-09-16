using System;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore;

namespace CameraApp
{
	public partial class MainForm : Form
	{
		private readonly CameraContext _context;
		private CartForm _cartForm;

		public MainForm()
		{
			InitializeComponent();
			_context = new CameraContext();
			_cartForm = new CartForm(); // Создаем форму корзины

			LoadData();
		}

		private void LoadData()
		{
			var cameras = _context.Cameras.OrderBy(c => c.Name).ToList();
			dataGridView.DataSource = cameras;
		}

		
		private void btnAdd_Click(object sender, EventArgs e)
		{
			var camera = new Camera
			{
				Name = txtName.Text,
				ReleaseDate = dtpReleaseDate.Value.ToString("yyyy-MM-dd"),
				Manufacturer = txtManufacturer.Text,
				Price = decimal.Parse(txtPrice.Text),
				Supplier = txtSupplier.Text,
				SaleDate = null,
				IsDefective = chkIsDefective.Checked
			};

			_context.Cameras.Add(camera);
			_context.SaveChanges();
			LoadData();
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			if (dataGridView.SelectedRows.Count > 0)
			{
				var selectedCamera = (Camera)dataGridView.SelectedRows[0].DataBoundItem;

				selectedCamera.Name = txtName.Text;
				selectedCamera.ReleaseDate = dtpReleaseDate.Value.ToString("yyyy-MM-dd");
				selectedCamera.Manufacturer = txtManufacturer.Text;
				selectedCamera.Price = decimal.Parse(txtPrice.Text);
				selectedCamera.Supplier = txtSupplier.Text;
				selectedCamera.IsDefective = chkIsDefective.Checked;

				_context.SaveChanges();
				LoadData();
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (dataGridView.SelectedRows.Count > 0)
			{
				var selectedCamera = (Camera)dataGridView.SelectedRows[0].DataBoundItem;

				_context.Cameras.Remove(selectedCamera);
				_context.SaveChanges();
				LoadData();
			}
		}

		private void dataGridView_SelectionChanged(object sender, EventArgs e)
		{
			if (dataGridView.SelectedRows.Count > 0)
			{
				var selectedCamera = (Camera)dataGridView.SelectedRows[0].DataBoundItem;
				txtName.Text = selectedCamera.Name;
				dtpReleaseDate.Value = DateTime.Parse(selectedCamera.ReleaseDate);
				txtManufacturer.Text = selectedCamera.Manufacturer;
				txtPrice.Text = selectedCamera.Price.ToString();
				txtSupplier.Text = selectedCamera.Supplier;
				chkIsDefective.Checked = selectedCamera.IsDefective;
			}
		}
		private void btnAddToCart_Click(object sender, EventArgs e)
		{
			if (dataGridView.SelectedRows.Count > 0)
			{
				var selectedCamera = (Camera)dataGridView.SelectedRows[0].DataBoundItem;
				var cartItem = new CartItem
				{
					Id = selectedCamera.Id,
					Name = selectedCamera.Name,
					Price = selectedCamera.Price,
					Quantity = 1 // Можно добавить элемент управления для выбора количества
				};
				_cartForm.AddToCart(cartItem);
			}
		}

		private void btnOpenCart_Click(object sender, EventArgs e)
		{
			_cartForm.Show(); // Открыть форму корзины
		}
	}
}