using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoteleria
{
    public class HoteleriaControl
    {
        private List<Cliente> _clientes = new List<Cliente>();
        private List<Habitacion> _habitaciones = new List<Habitacion>();
        private List<MovimientoAlquiler> _movimientos = new List<MovimientoAlquiler>();

        //metodo para agregar cliente
        public void AgregarCliente(Cliente cliente)
        {
            _clientes.Add(cliente);
        }

    }
}
