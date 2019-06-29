using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCS
{
    //global vars
    class GV
    {
        //the array with possible values
        private static readonly char[] faces = new char[] { 'A', 'K', 'Q', 'J', 'T', '9', '8', '7', '6', '5', '4', '3', '2' };
        // the array with possible suits
        private static readonly char[] suits = new char[] { 'c', 'd', 's', 'h' };

        public static char GetFaces(byte Param1)
        {
            return faces[Param1];
        }

        public static char GetSuits(byte Param1)
        {
            return suits[Param1];
        }
    }
}
