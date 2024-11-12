using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;
using System.Xml;

namespace Vistas
{
    public class ConversorDeEstados : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is XmlElement estadoElement)
            {
                string estado = estadoElement.GetAttribute("name"); // Obtiene el atributo name
                switch (estado)
                {
                    case "Programado":
                        return Brushes.Green; // Verde
                    case "Postergado":
                        return Brushes.Yellow; // Amarillo
                    case "Reprogramado":
                        return Brushes.Blue; // Azul
                    case "Cancelado":
                        return Brushes.Red; // Rojo
                    default:
                        return Brushes.Transparent; // Por defecto
                }
            }
            return Brushes.Transparent; // Por defecto si el valor no es un estado
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
