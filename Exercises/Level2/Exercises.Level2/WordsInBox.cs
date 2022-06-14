using System;

namespace Exercises.Level2;
public class WordsInBox
{
    /// <summary>
    /// Draw a box made out of stars (*) and put the word inide of them.
    /// So that a word Home makes:
    /// 
    /// ********
    /// * Home *
    /// ********
    /// 
    /// If you need more examples go to the tests project.
    /// </summary>
    /// <param name="word">Word to put in a box</param>
    /// <returns></returns>
    public string[] GetBox(string word)
    {

        int vardaGarums = word.Length;

        string [] box = new string[3];


        box[0] = new String('*', vardaGarums+4);
        box[1] = $"* {word} *";
        box[2] = new String('*', vardaGarums + 4);

         return box;

    }
}
