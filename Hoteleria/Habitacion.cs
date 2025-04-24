namespace Hoteleria
{
    public class Habitacion
    {
        private static int _nextId = 1;

        public int Id { get; private set; }
        public string NumHabitacion { get; set; }
        public decimal Precio { get; set; }
        public bool Disponibilidad { get; set; }
        public CategoriaHabitacion Categoria { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaSalida { get; set; }

        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }

        public Habitacion()
        {
            Id = _nextId++;
        }

    }
}