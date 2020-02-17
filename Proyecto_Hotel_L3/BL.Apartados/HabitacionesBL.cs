using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Apartados
{
    public class HabitacionesBL
    {
        public BindingList<Habitacion> ListaHabitaciones { get; set; }
        public HabitacionesBL()
        {
            ListaHabitaciones = new BindingList<Habitacion>();

            var habitacion1 = new Habitacion();

            habitacion1.Tipo = "Sencilla";
            habitacion1.Descripcion = "Cama King , AC y TV";
            habitacion1.Precio = 500;
            habitacion1.Activo = true;


            ListaHabitaciones.Add(habitacion1);    
        }

        public BindingList<Habitacion> ObtenerHabitaciones()
        {
            return ListaHabitaciones;
        }
    }

    public class Habitacion
    {
        public string Tipo { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public bool Activo { get; set; }
    }
}
