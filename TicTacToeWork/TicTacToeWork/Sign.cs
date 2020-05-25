using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeWork
{
    class Sign
    {
        private int place;
        private MarkType marks;

        public Sign(int placing, MarkType mark)
        {
            place = placing;
            marks = mark;
        }
        public string returnString(int place,MarkType marks)
        {
            return this.place + marks.ToString();
        }

        public int getPlace()
        {
            return this.place;
        }
        public string getMark()
        {
           string markThing = marks.ToString();
           return markThing;
        }
    }
}
