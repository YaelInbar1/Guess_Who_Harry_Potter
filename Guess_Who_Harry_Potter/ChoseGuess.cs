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
        public ChoseGuess()
        {
            InitializeComponent();
        }

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
            
            
            //להגדיר דמות של שחקן 1 ודמות של שחקן 2 ולעשות קייסים
            if (true)// אם השחקן בחר את הדמות של השחקן השני אז מסך ניצחת
            {

            }
            else // אחרת יופיע מסך הפסדת
            {

            }
        }
    }
}
