using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Collections.ObjectModel;

namespace TP10.Helpers
{
    static public class ConversorDeMorse
    {
        static Dictionary<char, string> DictMorse = new Dictionary<char, string>()
        {
            {'a' , ".-"},
            {'b' , "-..."},
            {'c' , "-.-."},
            {'d' , "-.."},
            {'e' , "."},
            {'f' , "..-."},
            {'g' , "--."},
            {'h' , "...."},
            {'i' , ".."},
            {'j' , ".---"},
            {'k' , "-.-"},
            {'l' , ".-.."},
            {'m' , "--"},
            {'n' , "-."},
            {'o' , "---"},
            {'p' , ".--."},
            {'q' , "--.-"},
            {'r' , ".-."},
            {'s' , "..."},
            {'t' , "-"},
            {'u' , "..-"},
            {'v' , "...-"},
            {'w' , ".--"},
            {'x' , "-..-"},
            {'y' , "-.--"},
            {'z' , "--.."},
            {'1' , ".---"},
            {'2' , "..---"},
            {'3' , "...--"},
            {'4' , "....-"},
            {'5' , "....."},
            {'6' , "-...."},
            {'7' , "--..."},
            {'8' , "---.."},
            {'9' , "----."},
            {'0' , "-----"}
            };

        public static String MorseATexto(String enMorse)
        {
            string[] palabras = enMorse.Split('/');
            string traduccion="";

            foreach (string palabra in palabras)
            {
                foreach(string letra in palabra.Split(' '))
                {
                    traduccion+=DictMorse.FirstOrDefault(x => x.Value.Equals(letra)).Key;
                }
                traduccion += " ";
            }

            return traduccion;
        }
            
        public static String TextoAMorse(String aMorse)
        {
            string[] palabras = aMorse.Split(' ');
            string traduccion = "";

            foreach (string palabra in palabras)
            {
                foreach (char letra in palabra.ToLower())
                {
                    traduccion += DictMorse[letra];
                    traduccion += " ";
                }
                traduccion += "/ ";
            }

            return traduccion;
        }


        public static void Morse_A_MP3(string morse,string pathAudio)
        {
            //FileStream arch_punto = new FileStream(pathAudio+"punto.mp3", FileMode.Open);
            //FileStream arch_raya = new FileStream(pathAudio+ "raya.mp3", FileMode.Open);

            byte[] arch_res = new byte[10000000];

            byte[] arch_puntoFile = File.ReadAllBytes(pathAudio + "punto.mp3");
            byte[] arch_raya = File.ReadAllBytes(pathAudio + "raya.mp3");

            int b = 0;
            foreach (char caracter in morse)
            {
                if(caracter=='.')
                {
                    arch_puntoFile.CopyTo(arch_res, b);
                    b += arch_puntoFile.Length;
                }
                else if (caracter == '-')
                {
                    arch_raya.CopyTo(arch_res, b);
                    b += arch_raya.Length;
                }
            }
            Array.Resize(ref arch_res, b);
            File.WriteAllBytes(pathAudio + "resultado.mp3", arch_res);
        }
    }
}
