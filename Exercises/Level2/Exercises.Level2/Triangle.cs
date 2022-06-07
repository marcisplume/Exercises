using System;

namespace Exercises.Level2;
public class Triangle
{
    /// <summary>
    /// Note: compleete half trangle first
    /// 
    /// The program:
    ///  You must create a triangle. 
    ///  n is the number of lines a triangle will have.
    ///  Triangle body has to be made out of "*",
    ///  so result should for 3 be like:
    ///  * 
    /// ***
    ///*****
    /// 
    /// Example of 5:
    /// 
    ///    *
    ///   ***
    ///  *****
    /// *******
    ///*********
    ///
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public string[] GetTRiangle(int n)
    {

        string[] gala = new string[n];

        char ir = '*';
        char tukss = ' ';
        int tuksums = n- 1;
        int zvaigzne = 1;



        for (int i = 0; i < n; i++)
        {

            gala[i] = (new String(tukss, tuksums)) + (new String(ir, zvaigzne)) ;
            tuksums--;
            zvaigzne += 2;

        }

        return gala;







        throw new NotImplementedException();
    }
}
