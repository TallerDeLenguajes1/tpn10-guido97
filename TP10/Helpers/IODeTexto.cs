using System;
using System.IO;
using System.Collections.Generic;

namespace TP10.Helpers
{
    public static class IODeTexto
    {
        public static void EscribirArchivo(string ubicacion,string nombre,string contenido)
        {
            Directory.CreateDirectory(ubicacion);
            FileStream archivo = new FileStream(ubicacion+nombre, FileMode.Create);
            StreamWriter stream = new StreamWriter(archivo);
            stream.Write(contenido);
            stream.Close();
        }

        public static string LeerArchivo(string pathArchivo)
        {
            FileStream archivo = new FileStream(pathArchivo, FileMode.Open);
            StreamReader stream = new StreamReader(archivo);
            string leido = stream.ReadToEnd();
            stream.Close();
            return leido;
        }


        public static List<string[]> LeerPropiedadDesdeCVS(string pathArchivo)
        {
            List<string[]> propiedades = new List<string[]>();
            FileStream archivo = new FileStream(pathArchivo, FileMode.Open);
            StreamReader stream = new StreamReader(archivo);
            string linea;

            while ((linea=stream.ReadLine())!=null)
            {
                propiedades.Add(linea.Split(';'));
            }

            stream.Close();
            return propiedades;

        }
    }
}
