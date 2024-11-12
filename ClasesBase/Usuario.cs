using System;
using System.ComponentModel;

namespace ClasesBase
{
    public class Usuario : INotifyPropertyChanged
    {
        public Usuario() { }

        public Usuario(int usu_ID, string usu_NombreUsuario, string usu_Contraseña, string usu_ApellidoNombre, int rol_Codigo)
        {
            Usu_ID = usu_ID;
            Usu_NombreUsuario = usu_NombreUsuario;
            Usu_Contraseña = usu_Contraseña;
            Usu_ApellidoNombre = usu_ApellidoNombre;
            Rol_Codigo = rol_Codigo;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private int _usu_ID;
        public int Usu_ID
        {
            get => _usu_ID;
            set
            {
                if (_usu_ID != value)
                {
                    _usu_ID = value;
                    OnPropertyChanged(nameof(Usu_ID));
                }
            }
        }

        private string _usu_NombreUsuario = string.Empty;
        public string Usu_NombreUsuario
        {
            get => _usu_NombreUsuario;
            set
            {
                if (_usu_NombreUsuario != value)
                {
                    _usu_NombreUsuario = value;
                    OnPropertyChanged(nameof(Usu_NombreUsuario));
                }
            }
        }

        private string _usu_Contraseña = string.Empty;
        public string Usu_Contraseña
        {
            get => _usu_Contraseña;
            set
            {
                if (_usu_Contraseña != value)
                {
                    _usu_Contraseña = value;
                    OnPropertyChanged(nameof(Usu_Contraseña));
                }
            }
        }

        private string _usu_ApellidoNombre = string.Empty;
        public string Usu_ApellidoNombre
        {
            get => _usu_ApellidoNombre;
            set
            {
                if (_usu_ApellidoNombre != value)
                {
                    _usu_ApellidoNombre = value;
                    OnPropertyChanged(nameof(Usu_ApellidoNombre));
                }
            }
        }

        private int _rol_Codigo;
        public int Rol_Codigo
        {
            get => _rol_Codigo;
            set
            {
                if (_rol_Codigo != value)
                {
                    _rol_Codigo = value;
                    OnPropertyChanged(nameof(Rol_Codigo));
                }
            }
        }

        public string RolNombre => RolHelper.ObtenerNombreRol(Rol_Codigo);
    }
}
