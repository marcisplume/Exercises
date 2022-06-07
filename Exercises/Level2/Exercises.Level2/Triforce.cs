using System;

namespace Exercises.Level2;
public class Triforce
{
    /// <summary>
    /// !!! COMPLETE TRIANGLE BEFORE ATTEMPTING THIS !!!
    /// 
    /// 
    /// The program:
    ///  You must create a program that echoes a Triforce of a given size N.       
    /// - A triforce is made of 3 identical triangles
    /// - A triangle of size N should be made of N lines
    /// - A triangle's line starts from 1 star, and earns 2 stars each line
    /// 
    /// For example, a Triforce of size 3 will look like:
    ///        
    ///     *
    ///    ***
    ///   *****
    ///  *     *
    /// ***   ***
    ///***** *****
    ///
    /// Another example, a Triforce of size 5 will look like:
    ///
    ///         *
    ///        ***
    ///       *****
    ///      *******
    ///     *********
    ///    *         *
    ///   ***       ***
    ///  *****     *****
    /// *******   *******
    ///********* *********
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>


    public string[] GetTriforce(int n)
    {
        string[] gala = new string[n * 2];

        int atlikusaisRinduSkaits = n * 2;
        char zime = '*';
        char tukss = ' ';
        int tuksumsSkaits = n*2-1;
        int zvaigzneSkaits = 1;
        int tuksimaSkaits2 = n*2-1;
        int tuksimaSkaits3 = n-zvaigzneSkaits;



        for (int i = 0; i < n; i++)
        {

            gala[i] = (new String(tukss, tuksumsSkaits)) + (new String(zime, zvaigzneSkaits));
            tuksumsSkaits--;
            zvaigzneSkaits += 2;

        }
        zvaigzneSkaits = 1;

        for (int i = n; i < n*2; i++)
        {

            gala[i] = (new String(tukss, tuksimaSkaits3)) + (new String(zime, zvaigzneSkaits)) + (new String(tukss, tuksimaSkaits2)) + (new String(zime, zvaigzneSkaits));
            tuksumsSkaits--;
            zvaigzneSkaits += 2;
            tuksimaSkaits2 -= 2;
            tuksimaSkaits3--;
        }

        return gala;













        throw new NotImplementedException();
    }
}
