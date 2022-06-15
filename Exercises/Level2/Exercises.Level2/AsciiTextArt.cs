using System;

namespace Exercises.Level2;
public class AsciiTextArt
{
    /// <summary>
    /// You are givven letters in ASCII art format, now you must draw the art of ASCII.
    /// Using ASCII letters you must convert them and create the word using theese letters.
    /// To gain better understanding go to the tests project inside folder AsciiFiles
    /// to see format of letters and expected output of words.
    /// 
    /// </summary>
    /// <param name="letters">ASCII art letters in range ABCDEFGHIJKLMNOPQRSTUVWXYZ?</param>
    /// <param name="word">Word to output in ascii art</param>
    /// <param name="h">Height of letters</param> tas ir vienmēr 5 
    /// <param name="l">Length of letters</param> // burta garuma parametrs  tas vienmār ir 4
    /// <returns></returns>
    public string[] GetArt(string[] letters, string word, int h, int l)
    {
              
        string alfabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZ?";
        int alfabetaGarums = alfabets.Length;
        char[] alfabetsChar = alfabets.ToCharArray();

        string dotaisVards = word;
        string arLieliemBurtiem = dotaisVards.ToUpper(); 
        int DotaVardaGarums = arLieliemBurtiem.Length; 
        char[] DotaVardaChar = arLieliemBurtiem.ToCharArray();  

        int[] vardaBurtuAtrasanasVietas = new int[arLieliemBurtiem.Length];

        for (int i = 0; i < arLieliemBurtiem.Length; i++)
        {

            for (int t = 0; t < alfabetsChar.Length; t++)
            {
                bool result = Char.IsLetter(DotaVardaChar[i]);

                if (!result)
                {
                    vardaBurtuAtrasanasVietas[i] = 26;
                }

                else if (alfabetsChar[t] == DotaVardaChar[i])
                {
                    vardaBurtuAtrasanasVietas[i] = t;

                }
            }


        }

        string[] gala = new string[5];


        for (int i = 0; i < vardaBurtuAtrasanasVietas.Length; i++)
        {

            for (int j = 0; j < gala.Length; j++)
            {
                gala[j] = gala[j] + letters[j].Substring(vardaBurtuAtrasanasVietas[i] * 4, 4);

            }

        }

        return gala;
        
    }
}
