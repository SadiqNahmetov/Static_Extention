using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace HomeworkLessonWritten.Helpers
{
    public static class Extentions
    {
        public static bool CheckString(this string str, string pattern) 
        {
            
            return Regex.IsMatch(str, pattern);
        }
         
        public static int SumNumber(this int num1, int num2)
        {
            return num1 + num2;
        }
    }
 }

