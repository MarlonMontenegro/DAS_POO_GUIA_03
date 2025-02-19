using Bl;

namespace GUI
{

    public partial class Form1 : Form
    {

        private Venta venta;

        public Form1()
        {
            InitializeComponent();




        }


        private void agregarBtn_Click(object sender, EventArgs e)
        {

            string ID = IdTextBox.Text;


            if (venta == null)
            {
                MessageBox.Show("Debe asignar un cliente");
                clienteTextBox.Focus();
                return;
            }


            // Validacion de ID

            if (string.IsNullOrEmpty(ID))
            {
                MessageBox.Show("Debe Ingresar un ID");
                IdTextBox.Focus();
                return;
            }

            int id = 0;

            if (!int.TryParse(ID,out id))
            {
                MessageBox.Show("Debe Ingresar un ID numerico entero");
                IdTextBox.Focus();
                return;
            }

            if (id <= 0)
            {
                MessageBox.Show("Debe Ingresar un ID mayo a cero");
                IdTextBox.Focus();
                return;
            }

            if (DescTextBox.Text == string.Empty)
            {
                MessageBox.Show("Debe Ingresar una Description");
                DescTextBox.Focus();
                return;
            }


            // Validacion Precio

            if (PrecioTextBox.Text == string.Empty)
            {
                MessageBox.Show("Debe Ingresar un precio");
                PrecioTextBox.Focus();
                return;
            }

            decimal precio = 0;

            if (!decimal.TryParse(PrecioTextBox.Text, out precio))
            {
                MessageBox.Show("Debe Ingresar un precio numerico");
                PrecioTextBox.Focus();
                return;
            }

            if (precio <= 0)
            {
                MessageBox.Show("Debe Ingresar un ID mayo a cero");
                PrecioTextBox.Focus();
                return;
            }


            // Validacion Cantidad

            if (cantidadTextBox.Text == string.Empty)
            {
                MessageBox.Show("Debe Ingresar una cantidad");
                cantidadTextBox.Focus();
                return;
            }

            float cantidad = 0;

            if (!float.TryParse(cantidadTextBox.Text, out cantidad))
            {
                MessageBox.Show("Debe Ingresar una cantidad numerica");
                cantidadTextBox.Focus();
                return;
            }

            if (cantidad <= 0)
            {
                MessageBox.Show("Debe Ingresar un cantidad mayor a cero");
                cantidadTextBox.Focus();
                return;
            }

            Producto producto = new Producto();
            producto.ID = id;
            producto.Description = DescTextBox.Text;
            producto.Precio = precio;
            producto.Cantidad = cantidad;

            venta.AgregarProducto(producto);

            detalleDataGridView.DataSource = null;
            detalleDataGridView.DataSource = venta.Productos;

            IdTextBox.Text = string.Empty;
            DescTextBox.Text = string.Empty;
            PrecioTextBox.Text = string.Empty;
            cantidadTextBox.Text = string.Empty;

            IdTextBox.Focus();

        }

        private void asignarButton_Click(object sender, EventArgs e)
        {
            string cliente = clienteTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(cliente))
            {
                MessageBox.Show("Debe ingresar un cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clienteTextBox.Focus();
                return;
            }

            venta = new Venta(cliente.ToLower());
            detalleDataGridView.DataSource = venta.Productos;
        }

        private void pagarBtn_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show(this, string.Format("su cuenta es:{0:C2}" + "¿Desea Pagar?", venta.Total()), "pagar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (rta == DialogResult.No){ return; }

            venta = null;
            clienteTextBox.Text = string.Empty;
            clienteTextBox.Focus();

            detalleDataGridView.DataSource = null;
        }
    }
}
