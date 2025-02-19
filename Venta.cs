using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl
{
    public class Venta
    {

        private string cliente;

        private DateTime fecha;

        private List<Producto> productos;

        public List<Producto> Productos
        {
            get { return productos; }
        }

        public Venta(string cliente)
        {
            this.cliente = cliente;
            this.fecha = DateTime.Now;
            this.productos = new List<Producto>();
        }

       

        public void AgregarProducto(Producto producto)
        {
            productos.Add(producto);
        }

        public decimal Total()
        {
            decimal total = 0;

            foreach (Producto producto in productos)
            {
                total += producto.valor;
            }

            return total;

        }
    }
}
