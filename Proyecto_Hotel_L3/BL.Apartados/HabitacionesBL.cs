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

            habitacion1.Nombre = "Pedro";
            habitacion1.TipoH = "Sencilla";
            habitacion1.Precio = 500;
            habitacion1.Efectivo = false;
            habitacion1.Tarjeta = true;


            ListaHabitaciones.Add(habitacion1);

            var habitacion2 = new Habitacion();

            habitacion2.Nombre = "Maria";
            habitacion2.TipoH = "Doble";
            habitacion2.Precio = 900;
            habitacion2.Efectivo = true;
            habitacion2.Tarjeta = false;


            ListaHabitaciones.Add(habitacion2);

            var habitacion3 = new Habitacion();

            habitacion3.Nombre = "Juan";
            habitacion3.TipoH = "Triple";
            habitacion3.Precio = 1300;
            habitacion3.Efectivo = false;
            habitacion3.Tarjeta = true;


            ListaHabitaciones.Add(habitacion3);
        }

        public BindingList<Habitacion> ObtenerHabitaciones()
        {
            return ListaHabitaciones;
        }
    }

    public class Habitacion
    {
        public string Nombre { get; set; }
        public string TipoH { get; set; }
        public double Precio { get; set; }
        public bool Efectivo { get; set; }
        public bool Tarjeta { get; set; }
    }
}
