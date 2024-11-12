using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ClasesBase
{
    public class Atleta : IDataErrorInfo
    {
        public int Atl_ID { get; set; }

        public string Atl_DNI { get; set; }

        public string Atl_Apellido { get; set; }

        public string Atl_Nombre { get; set; }

        public string Atl_Nacionalidad { get; set; }

        public string Atl_Entrenador { get; set; }

        public char Atl_Genero { get; set; }

        public double Atl_Altura { get; set; }

        public double Atl_Peso { get; set; }

        public DateTime Atl_FechaNac { get; set; }

        public string Atl_Direccion { get; set; }

        public string Atl_email { get; set; }

        public string this[string columnName]
        {
            get
            {
                string error = null;
                switch (columnName)
                {
                    case nameof(Atl_DNI):
                        if (string.IsNullOrWhiteSpace(Atl_DNI))
                            error = "El DNI es obligatorio.";
                        break;
                    case nameof(Atl_Apellido):
                        if (string.IsNullOrWhiteSpace(Atl_Apellido))
                            error = "El apellido es obligatorio.";
                        break;
                    case nameof(Atl_Nombre):
                        if (string.IsNullOrWhiteSpace(Atl_Nombre))
                            error = "El nombre es obligatorio.";
                        break;
                    case nameof(Atl_Altura):
                        if (double.IsNaN(Atl_Altura))
                            error = "La altura es obligatoria";
                          else  if (Atl_Altura <= 0)
                            error = "La altura debe ser mayor que cero.";
                        break;
                    case nameof(Atl_Peso):
                         if (double.IsNaN(Atl_Peso))
                            error = "El peso es obligatorio";
                        else if (Atl_Peso <= 0)
                            error = "El peso debe ser mayor que cero.";
                        break;
                }
                return error;
            }
        }

        public string Error => null;
    }
}
