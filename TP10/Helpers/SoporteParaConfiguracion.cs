using System;
using System.IO;
namespace TP10.Helpers
{
    static public class SoporteParaConfiguracion
    {
        public static void CrearArchivoDeConfiguracion(string rutaRelativa,string contenido)
        {
            FileStream archivo = new FileStream(rutaRelativa, FileMode.Create);
            BinaryWriter binary = new BinaryWriter(archivo);
            binary.Write(contenido);
            binary.Close();
        }

        public static string LeerConfiguracion(string rutaRelativa)
        {
            FileStream archivo = new FileStream(rutaRelativa, FileMode.Open);
            BinaryReader binary = new BinaryReader(archivo);
            string leido=binary.ReadString();
            binary.Close();
            return leido;
        }
    }
}
