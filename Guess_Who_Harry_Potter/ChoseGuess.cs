using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guess_Who_Harry_Potter
{
    public partial class ChoseGuess : Form
    {
        public ChoseGuess(playBoard Meaw)
        {
            InitializeComponent();
            pbfrm = Meaw;
        }

        playBoard pbfrm;
        Board board;
        AllCar characters;
        public int pictag ; 

        private void ChoseGuess_Load(object sender, EventArgs e)
        {
            board = new Board(this, 420, 12);
            characters = new AllCar();
        }

        public void btnChosen_Click(object sender, EventArgs e)
        {            
            for (int i = 0; i < board.allC.GetLength(0); i++)
            {
                for (int j = 0; j < board.allC.GetLength(1); j++)
                {
                    if (board.allC[i, j].lastone)
                    {                        
                        string r = board.allC[i, j].CellPic1.Tag.ToString().Split(' ')[1];
                        int tagtag = int.Parse(r);                    
                        sendMyGessToServer(tagtag);
                        break;
                    }                    
                }
            }
        }

        internal void sendMyGessToServer(int info)
        {
            pbfrm.sendguesstoserver(info);
        }
    }
}
