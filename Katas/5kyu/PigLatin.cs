////////////////////////////////////////////////////////////////////////////////////////////////////////
//FileName: PigLatin.cs
//FileType: Visual C# Source file
//Author : Michael Harris
//Description : Class for CodeWars problem: Simple Pig Latin
//Link: https://www.codewars.com/kata/520b9d2ad5c005041100000f/csharp
////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas._5kyu
{
    /// <summary>
    /// Move the first letter of each word to the end of it, 
    /// then add "ay" to the end of the word. Leave punctuation marks untouched.
    /// </summary>
    public static class PigLatin
    {
        public static string PigIt(string str)
        {
            string pigLatin = "";
            string[] words = str.Split(' ');
            foreach (string word in words) {
                if (Char.IsLetter(word.ElementAt(0))){
                    pigLatin += word.Substring(1) + word.ElementAt(0) + "ay ";
                }
                else
                {
                    pigLatin += word;
                }
            }
            return pigLatin.TrimEnd();
        }
    }
}
