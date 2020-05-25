using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeWork
{
    public partial class Form1 : Form 
    {
        public Form1()
        {
            InitializeComponent();
            
           // Board b = new Board();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bt_select_Click(object sender, EventArgs e)
        {
            string position = tb_selectedNum.Text;

            
            
            /*if (checkIfInt(position))
            {
                
                //tb_board.Text = displayTheBoard();
            }*/
            
        }

        private bool checkIfInt(string selectedNum)
        {
            //string mess = tb_selectedNum.Text;
            foreach(char c in selectedNum)
            //If its not a digit it will stop the cycle and give false
            {
                if (!char.IsDigit(c)) 
                {
                    return false;
                }
            }
            return true;
        }

        
    }
}
