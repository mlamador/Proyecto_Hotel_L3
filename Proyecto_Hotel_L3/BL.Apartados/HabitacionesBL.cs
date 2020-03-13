using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Apartados
{
    public class HabitacionesBL
    {
        Contexto _contexto;






        public BindingList<Habitacion> ListaHabitaciones { get; set; }

        public HabitacionesBL()

        {
            _contexto = new Contexto();

            ListaHabitaciones = new BindingList<Habitacion>();

            
        }

        public BindingList<Habitacion> ObtenerHabitaciones()
        {
            _contexto.Habitaciones.Load();

            ListaHabitaciones = _contexto.Habitaciones.Local.ToBindingList();

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

            if (habitacion.TipoId == 0)
            {
                resultado.Mensaje = "SELECCIONE UN TIPO";
                resultado.Exitoso = false;
            }




            _contexto.SaveChanges();

            resultado.Exitoso = true;
            return resultado;

        }
        //------------------------

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

                    _contexto.SaveChanges();

                    return true;
                }
            }
            return false;
        }


        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }

        }


        //yosep===========

        private Resultado Validar(Habitacion habitacion)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (string.IsNullOrEmpty(habitacion.Nombre) ==true)
            {
                resultado.Mensaje = "Ingrese un Nombre";
                resultado.Exitoso = false;
            }

            if (habitacion.Precio < 0)
            {
                resultado.Mensaje = "El precio debe ser mayor que 0";
                resultado.Exitoso = false;
            }

            //  if (habitacion.TipoH == "" )
            if (string.IsNullOrEmpty(habitacion.TipoH) == true)
            {
                resultado.Mensaje = "Deve eligir un tipo de habitacion ";
                resultado.Exitoso = false;
            }


            return resultado;
        }

    }

    public class Habitacion
    {
        public string Nombre { get; set; }
        public string TipoH { get; set; }

        public int TipoId { get; set; }
        public Tipo Tipos { get; set; }
        

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
