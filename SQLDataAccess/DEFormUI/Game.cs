using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEFormUI
{
    public class Game
    {
        public string Title { get; set; }
        public int Release_Date {get; set; }
        public string Hardware_Type { get; set; }
        public string Genre { get; set; }

        //public string FullInfo
        //{
        //    get
        //    {
        //        return $"{Title} {Release_Date} {Hardware_Type} ({Genre})";
        //    }
        //}
    }
}
