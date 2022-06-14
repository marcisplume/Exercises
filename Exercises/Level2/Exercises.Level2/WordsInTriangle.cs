using System;

namespace Exercises.Level2;
public class WordsInTriangle
{
    /// <summary>
    /// Given array of words draw them inside a smallest possible triangle, compleeting rules. 
    /// !. Every word has to be drawn in a new line.
    /// 2. No word can touch wall of the triangle, meaning there has to a " " between a wall and word.
    /// 
    /// For example word Home:
    /// 
    ///      *
    ///     * *
    ///    *   *
    ///   *     *
    ///  * home  *
    /// ***********
    /// 
    /// a beautiful home:
    /// 
    ///         *
    ///        * *
    ///       *   *
    ///      *     *
    ///     *       *
    ///    * a       *
    ///   * beautiful *
    ///  * home        *
    /// *****************
    /// 
    /// </summary>
    /// <param name="words">Words to put in triangle</param>
    /// <returns></returns>
    public string[] GetWordInTriangle(string[] words)
    {

        string[] gala = new string[3];

        gala[0] = "  *";
        gala[1] = " * *";
        gala[2] = "*****";


        if (words == null || words.Length == 0)
        {
            return gala;
        }



        int max = words[0].Length; // max burtu skaits vārdā
        string maxx = words[0]; // garākais vārds



        for (int i = 1; i < words.Length; i++)
        {
            int length = words[i].Length;
            if (length > max)
            {
                maxx = words[i];
                max = length;
            }

        }


        int GarAtrViet = Array.IndexOf(words, maxx);
        int ArrayLength = words.Length;
        int cikVardiPecGarVarda = ArrayLength - (GarAtrViet + 1);

        string paraugs = maxx;
        int garumsParaugam = paraugs.Length;

        int home = garumsParaugam;
        int home1 = garumsParaugam;

        if (garumsParaugam % 2 == 0)
        {
            home1 = home + 1;
        }



        int papildusRinduSkaits = 0;

        for (int i = 0; i <= home1; i++)
        {
            if (i % 2 == 1)
            {
                papildusRinduSkaits++;
            }
            else continue;
        }



        string[] TETS = new string[papildusRinduSkaits + 3 + cikVardiPecGarVarda]; // 

        int TETSLength = TETS.Length;




        for (int i = 0; i < TETSLength; i++)
        {
            TETS[i] = new string('*', 1);
        }






        TETS[TETS.Length - 1] = new string('*', TETSLength * 2 - 1);





        int ieliecVardu = 0;

        for (int i = 1; i < TETS.Length - 1; i++)
        {
            TETS[i] = TETS[i] + " ";
        }


        for (int i = TETS.Length - words.Length - 1; i < TETSLength - 1; i++)
        {

            if ((ieliecVardu < words.Length))
                TETS[i] = TETS[i] + words[ieliecVardu];
            ieliecVardu++;


        }


        int tuksums = TETS[TETS.Length - 1].Length - 2;


        for (int i = TETS.Length - 2; i > 1; i--)
        {

            TETS[i] = TETS[i] + new string(' ', tuksums - TETS[i].Length - 1);
            tuksums -= 2;
        }


        for (int i = 1; i < TETS.Length - 1; i++)
        {
            TETS[i] = TETS[i] + new string('*', 1);
        }


        int atstarpe = 0;

        for (int i = TETS.Length - 1; i >= 0; i--)
        {
            TETS[i] = new string(' ', atstarpe) + TETS[i];
            atstarpe++;
        }


        return TETS;


        
    }
}
