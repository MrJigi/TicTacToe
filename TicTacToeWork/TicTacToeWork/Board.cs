using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeWork
{
    class Board
    {
        
        Sign sign;
        MarkType position;
        string message;
        public Sign[] listOfSigns = new Sign[9];

        public void makeAMove(int place, MarkType mark)
        {
            if (isItUsed(place))
            {
                listOfSigns[place] = new Sign(place, mark);

            }
            // Sign sign = new Sign(place, mark);
        }

        public bool isItUsed(int place)
        {
            //sign.mark()
            
            sign = listOfSigns[place];
            if (sign.getMark() == "_")
            {
                return true;
            }
            MessageBox.Show("Already used space");
            return false;
        }
        private string displayTheBoard()
        {
            
           // message = $"1/2/3 \r\n 4/5/6 \r\n 7/8/9";
            foreach (Sign s in listOfSigns)
            {
                s.getMark();
                message += s.getMark();
            }

            return message;
        }
        
        private void defaultBoard()
        {
            for(int i = 0; i <= 9; i++)
            {
                listOfSigns[i] = new Sign(i,MarkType._);
            }


           /* foreach (Sign s in listOfSigns)
            {
              s.getPlace += 
            }*/
        }

        private string checkMark(MarkType mark)
        {
            switch(mark){
                case MarkType.O:
                    return MarkType.O.ToString() ;
                case MarkType.X:
                    return MarkType.X.ToString();
                default:
                case MarkType._:
                    return MarkType._.ToString();
            }
          //  return ;
        }
    }
}