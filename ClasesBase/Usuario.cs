using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Usuario
    {
        public Usuario()
        {
        }

        public Usuario(int usu_ID, string usu_NombreUsuario, string usu_Contraseña, string usu_ApellidoNombre, int rol_Codigo)
        {
            Usu_ID = usu_ID;
            Usu_NombreUsuario = usu_NombreUsuario;
            Usu_Contraseña = usu_Contraseña;
            Usu_ApellidoNombre = usu_ApellidoNombre;
            Rol_Codigo = rol_Codigo;
        }

        public int Usu_ID
        {
            get => default;
            set
            {
            }
        }

        public string Usu_NombreUsuario
        {
            get => default;
            set
            {
            }
        }

        public string Usu_Contraseña
        {
            get => default;
            set
            {
            }
        }

        public string Usu_ApellidoNombre
        {
            get => default;
            set
            {
            }
        }

        public int Rol_Codigo
        {
            get => default;
            set
            {
            }
        }
    }
}