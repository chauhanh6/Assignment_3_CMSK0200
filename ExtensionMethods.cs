using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_CMSK0200
{
    public static class ExtensionMethods
    {
        public static int GetWordCount( this string str )
        { 
            return str.Split(' ').Length;
             
        }
    }
}
