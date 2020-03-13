using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Apartados
{
    public class SeguridadBL
    {
        Contexto _contexto;


        public SeguridadBL()
        {
            _contexto = new Contexto();
        }

        public bool Autorizar(string usuario, string contrasena)
        {
            //return true;

/*
            var usuarios = _contexto.Usuarios.ToList();

            foreach (var usuarioDB in usuarios)
            {
                if (usuario == usuarioDB.usuario && contrasena == usuarioDB.contrasena)
                {
                    return true;
                }
            }


*/

           if (usuario == "admin" && contrasena == "123")
            {
                return true;
            }
            else
            {
                if (usuario == "user" && contrasena == "456")
                {
                    return true;
                }
            }

            return false;
        }
    }
}
