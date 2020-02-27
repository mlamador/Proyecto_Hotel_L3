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

            habitacion1.Id = 1; //Yosethcambio

            habitacion1.Nombre = "Pedro";
            habitacion1.TipoH = "Sencilla";
            habitacion1.Precio = 500;
            habitacion1.Efectivo = false;
            habitacion1.Tarjeta = true;


            ListaHabitaciones.Add(habitacion1);

            var habitacion2 = new Habitacion();

            habitacion2.Id = 2;

            habitacion2.Nombre = "Maria";
            habitacion2.TipoH = "Doble";
            habitacion2.Precio = 900;
            habitacion2.Efectivo = true;
            habitacion2.Tarjeta = false;


            ListaHabitaciones.Add(habitacion2);

            var habitacion3 = new Habitacion();

            habitacion3.Id =3;

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
        //yose==================
    

        //yoseph------------------------
        public Resultado GuardarHabitacion(Habitacion habitacion)
        {
            var resultado = Validar(habitacion);
            if(resultado.Exitoso== false)
            {
                return resultado;
            }

            if (habitacion.Id  == 0)
            {
                habitacion.Id = ListaHabitaciones.Max(item => item.Id) + 1;
                //id===================
            }

            resultado.Exitoso = true;
            return resultado;

        }
        //yoseph------------------------

        public void AgregarHabitacion()
        {

            var nuevoHabitacion = new Habitacion();
            ListaHabitaciones.Add(nuevoHabitacion);


        }

        public bool EliminarHabitacion(int id)
        {
            foreach (var habitacion in ListaHabitaciones)
            {
                if (habitacion.Id== id)
                {
                    ListaHabitaciones.Remove(habitacion);
                        return true;
                }
            }
            return false;
        }



        //yosep===========
    
        private Resultado Validar(Habitacion habitacion)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (habitacion.Nombre == "holaaa")
            {
                resultado.Mensaje = "Ingrese un Nombre";
                resultado.Exitoso = false;
            }

            if (habitacion.Precio < 0)
            {
                resultado.Mensaje = "El precio debe ser mayor que 0";
                resultado.Exitoso = false;
            }

            if (habitacion.TipoH == "" )
            {
                resultado.Mensaje = "Deve eligir un tipo de habitasion ";
                resultado.Exitoso = false;
            }


            return resultado;
        }

    }

    public class Habitacion
    {
        public string Nombre { get; set; }
        public string TipoH { get; set; }
        public double Precio { get; set; }
        public bool Efectivo { get; set; }
        public bool Tarjeta { get; set; }
        public int Id { get; internal set; }
    }
    public class Resultado
    {

        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    }


}
