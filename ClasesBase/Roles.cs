using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    //public class Roles
    //{
    //    public Roles()
    //    {
    //    }

    //    public Roles(int rol_codigo, string rol_descripcion)
    //    {
    //        Rol_Codigo = rol_codigo;
    //        Rol_Descripcion = rol_descripcion;
    //    }

    //    public int Rol_Codigo
    //    {
    //        get => default;
    //        set
    //        {
    //        }
    //    }

    //    public string Rol_Descripcion
    //    {
    //        get => default;
    //        set
    //        {
    //        }
    //    }
    //}
    public class Roles
{
    private int _rol_Codigo;
    private string _rol_Descripcion;

    public int Rol_Codigo
    {
        get => _rol_Codigo;
        set
        {
            _rol_Codigo = value;
            // Si quieres implementar INotifyPropertyChanged, añade el código aquí
        }
    }

    public string Rol_Descripcion
    {
        get => _rol_Descripcion;
        set
        {
            _rol_Descripcion = value;
            // Si quieres implementar INotifyPropertyChanged, añade el código aquí
        }
    }

    public Roles() { }

    //public Roles(int rol_codigo, string rol_descripcion)
    //{
    //    Rol_Codigo = rol_codigo;
    //    Rol_Descripcion = rol_descripcion;
    //}
}

}