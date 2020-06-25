using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using TP10.Helpers;

namespace TP10
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            String destino = "./Mover/";
            Helpers.SoporteParaConfiguracion.CrearArchivoDeConfiguracion("./destino.dat", destino);
            String destinoLeido = Helpers.SoporteParaConfiguracion.LeerConfiguracion("./destino.dat");
            Directory.CreateDirectory(destino);

            foreach (string item in Directory.GetFiles("./"))
            {
                if (item.EndsWith(".txt") || item.EndsWith(".mp3"))
                {
                    Directory.Move(item, destino+Path.GetFileName(item));
                }
            }


            //Console.WriteLine(ConversorDeMorse.MorseATexto(".... --- .-.. .- / --.- ..- . / --- -. -.. .- .-.-."));
            //Console.WriteLine(ConversorDeMorse.TextoAMorse("Hola que onda"));

            //Console.Write("\nIngrese el texto a convertir: ");
            //string texto = Console.ReadLine();

            //string traduccion = ConversorDeMorse.TextoAMorse(texto);
            //string nombre = "morse" + DateTime.Now.ToString("dd-MM-yy");
            //IODeTexto.EscribirArchivo("./Morse/", nombre, traduccion);

            //string enMorse =IODeTexto.LeerArchivo("./Morse/" + nombre);
            //traduccion= ConversorDeMorse.MorseATexto(enMorse);
            //Console.WriteLine("Resultado de la traducción: "+traduccion);

            //IODeTexto.EscribirArchivo("./Morse/", "traduc_"+nombre, traduccion);



            ConversorDeMorse.Morse_A_MP3(".... --- .-.. .- / --.- ..- . / --- -. -.. .- .-.-.", destino);
        }
    }
}
