////////////////////////////////////////////////////////////////////////////////////////////////////////
//FileName: CharCount.cs
//FileType: Visual C# Source file
//Author : Michael Harris
//Description : Class for CodeWars problem: Count characters in string 
//Link: https://www.codewars.com/kata/52efefcbcdf57161d4000091/csharp
////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas._5kyu
{
    public static class CharCount
    {
        public static Dictionary<char, int> Count(string str)
        {
            Dictionary<char,int> dict = new Dictionary<char,int>();
            foreach (char c in str)
            {
                if(!dict.ContainsKey(c))
                {
                    dict[c] = 1;
                }
                else
                {
                    dict[c]++;
                }
            }
            return dict;
        }
    }
}
