using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Apartados
{
    public class DatosdeInicio : CreateDatabaseIfNotExists<Contexto>
    {

        protected override void Seed(Contexto contexto)
        {
            var usuarioAdmin = new Usuario();
            usuarioAdmin.usuario = "admin";
            usuarioAdmin.contrasena = "123";

            contexto.Usuarios.Add(usuarioAdmin);

            var tipo1 = new Tipo();
            tipo1.Descripcion = "Habitacio Sencilla";
            contexto.Tipos.Add(tipo1);

            var tipo2 = new Tipo();
            tipo2.Descripcion = "Habitacion Doble";
            contexto.Tipos.Add(tipo2);

            var tipo3 = new Tipo();
            tipo3.Descripcion = "Habitacion Triple";
            contexto.Tipos.Add(tipo3);


            base.Seed(contexto);
        }

    }
}
