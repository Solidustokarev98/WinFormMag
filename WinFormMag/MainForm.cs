using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace CameraApp
{
    public partial class MainForm : Form
    {
        private readonly CameraContext _context;

        public MainForm()
        {
            InitializeComponent();
            _context = new CameraContext();
            LoadData();
        }

        private void LoadData()
        {
            List<Camera> cameras = _context.Cameras.ToList();
            dataGridView.DataSource = cameras;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var camera = new Camera
            {
                Name = txtName.Text,
                ReleaseDate = dtpReleaseDate.Value,
                Manufacturer = txtManufacturer.Text,
                Price = decimal.Parse(txtPrice.Text),
                Supplier = txtSupplier.Text,
                SaleDate = null, // установить, если это необходимо
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
                selectedCamera.ReleaseDate = dtpReleaseDate.Value;
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
                dtpReleaseDate.Value = selectedCamera.ReleaseDate;
                txtManufacturer.Text = selectedCamera.Manufacturer;
                txtPrice.Text = selectedCamera.Price.ToString();
                txtSupplier.Text = selectedCamera.Supplier;
                chkIsDefective.Checked = selectedCamera.IsDefective;
            }
        }
    }
}
