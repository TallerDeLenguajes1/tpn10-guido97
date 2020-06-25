using System;
namespace TP10
{
    public enum TipoDePropiedad
    {
        Venta,Alquiler
    }
    public enum TipoDeOperacion
    {
        Departamento, Casa, Duplex, Penthhouse,Terreno
    }

    public class Propiedad
    {

        public Propiedad()
        {
        }

        int Id; //representa el número de propiedad ingresada
        TipoDePropiedad tipoProp;
        TipoDeOperacion tipoOp;
        float Tamanio; // punto flotante
        int CantBaños;
        int CantHabitaciones;
        string Domicilio;// string
        int Precio; // Valor Entero
        bool Estado;// bool activo / inactivo


        public float ValorDelInmueble()
        {
            if (tipoProp == TipoDePropiedad.Venta)
            {
                return (float)((Precio * 1.1 + 10000) * 1.21);
            }
            if (tipoProp==TipoDePropiedad.Alquiler)
            {
                return (float)(Precio * 1.025);
            }
            return 0;
        }

    }
}
