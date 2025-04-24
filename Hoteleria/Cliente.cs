using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoteleria
{
    public class Cliente
    {
        private static int _nextId = 1;

        public int Id { get; private set; }
        public string Dni { get; set; }
        public CategoriaHabitacion categoria   { get; set; }
        public EstadoCliente Estado { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaSalida { get; set; }

        public Genero Genero { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }

        public Cliente()
        {
            Id = _nextId++;
        }

    }
}
