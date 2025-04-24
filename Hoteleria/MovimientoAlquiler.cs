namespace Hoteleria
{
    public class MovimientoAlquiler
    {
        private static int _nextId = 1;
            public int Id { get; private set; }
            public Cliente cliente { get; set; }
            public Habitacion habitacion { get; set; }
 
            public CategoriaHabitacion categoria { get; set; }
            public DateTime FechaIngreso { get; set; }
            public DateTime FechaSalida { get; set; }
    

        public MovimientoAlquiler()
        {
            Id = _nextId++;
        }

    }
}