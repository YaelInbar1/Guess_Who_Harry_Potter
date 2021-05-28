using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Guess_Who_Harry_Potter
{
    class Board
    {
        Cell[,] allC = new Cell[6,4];
        int x, y;
        Form1 frm1;
        private playBoard playBoard;
        private int v1;
        private int v2;
        private ChoseGuess choseGuess;
        AllCar characters = new AllCar();
        public int tag { get; private set; }
        public Board(Form1 frm1, int x, int y, AllCar characters)
        {
            this.frm1 = frm1;
            this.x = x;
            this.y = y;
            this.characters = characters;
            drawBoard(frm1);
        }

        public Board(playBoard playBoard, int v1, int v2, AllCar characters)
        {
            this.playBoard = playBoard;
            this.v1 = v1;
            this.v2 = v2;
            drawBoard(playBoard);
        }

        public Board(ChoseGuess choseGuess, int v1, int v2)
        {
            this.choseGuess = choseGuess;
            this.v1 = v1;
            this.v2 = v2;
            drawBoard(choseGuess);
        }

        public void drawBoard(Form frm)
        {
            x = 660;
            y = 30;
            int originalX = x;
            //line 1
            allC[0, 0] = new Cell(x, y, 1, 0, Properties.Resources.Harry,1,this, characters.allchar[0]);
            frm.Controls.Add(allC[0, 0].CellPic1);
            allC[0, 1] = new Cell(x + 100, y, 1, 0, Properties.Resources.Hermione,2, this, characters.allchar[1]);
            frm.Controls.Add(allC[0, 1].CellPic1);
            allC[0, 2] = new Cell(x + 200, y, 1, 0, Properties.Resources.Ron,3, this, characters.allchar[2]);
            frm.Controls.Add(allC[0, 2].CellPic1);
            allC[0, 3] = new Cell(x + 300, y, 1, 0, Properties.Resources.Ginny,4, this, characters.allchar[3]);
            frm.Controls.Add(allC[0, 3].CellPic1);

            y += 100;
            x = originalX;

            //line 2
            allC[1, 0] = new Cell(x, y, 1, 0, Properties.Resources.McGonagall,5, this, characters.allchar[4]);
            frm.Controls.Add(allC[1, 0].CellPic1);
            allC[1, 1] = new Cell(x + 100, y, 1, 0, Properties.Resources.Hagrid, 6, this, characters.allchar[5]);
            frm.Controls.Add(allC[1, 1].CellPic1);
            allC[1, 2] = new Cell(x + 200, y, 1, 0, Properties.Resources.Sirius, 7, this, characters.allchar[6]);
            frm.Controls.Add(allC[1, 2].CellPic1);
            allC[1, 3] = new Cell(x + 300, y, 1, 0, Properties.Resources.Dumbledore, 8, this, characters.allchar[7]);
            frm.Controls.Add(allC[1, 3].CellPic1);

            y += 100;
            x = originalX;

            //line 3
            allC[2, 0] = new Cell(x, y, 1, 0, Properties.Resources.Longbottom, 9, this, characters.allchar[8]);
            frm.Controls.Add(allC[2, 0].CellPic1);
            allC[2, 1] = new Cell(x + 100, y, 1, 0, Properties.Resources.MadEye, 10, this, characters.allchar[9]);
            frm.Controls.Add(allC[2, 1].CellPic1);
            allC[2, 2] = new Cell(x + 200, y, 1, 0, Properties.Resources.Lupin, 11, this, characters.allchar[10]);
            frm.Controls.Add(allC[2, 2].CellPic1);
            allC[2, 3] = new Cell(x + 300, y, 1, 0, Properties.Resources.Pettigrew, 12, this, characters.allchar[11]);
            frm.Controls.Add(allC[2, 3].CellPic1);

            y += 100;
            x = originalX;

            //line 4
            allC[3, 0] = new Cell(x, y, 1, 0, Properties.Resources.Draco, 13, this, characters.allchar[12]);
            frm.Controls.Add(allC[3, 0].CellPic1);
            allC[3, 1] = new Cell(x + 100, y, 1, 0, Properties.Resources.Bellatrix, 14, this, characters.allchar[13]);
            frm.Controls.Add(allC[3, 1].CellPic1);
            allC[3, 2] = new Cell(x + 200, y, 1, 0, Properties.Resources.Lucius, 15, this, characters.allchar[14]);
            frm.Controls.Add(allC[3, 2].CellPic1);
            allC[3, 3] = new Cell(x + 300, y, 1, 0, Properties.Resources.Snape, 16, this, characters.allchar[15]);
            frm.Controls.Add(allC[3, 3].CellPic1);

            y += 100;
            x = originalX;

            //line 5
            allC[4, 0] = new Cell(x, y, 1, 0, Properties.Resources.Umbridge, 17, this, characters.allchar[16]);
            frm.Controls.Add(allC[4, 0].CellPic1);
            allC[4, 1] = new Cell(x + 100, y, 1, 0, Properties.Resources.Voldemort, 18, this, characters.allchar[17]);
            frm.Controls.Add(allC[4, 1].CellPic1);
            allC[4, 2] = new Cell(x + 200, y, 1, 0, Properties.Resources.Cedric, 19, this, characters.allchar[18]);
            frm.Controls.Add(allC[4, 2].CellPic1);
            allC[4, 3] = new Cell(x + 300, y, 1, 0, Properties.Resources.Tonks, 20, this, characters.allchar[19]);
            frm.Controls.Add(allC[4, 3].CellPic1);

            y += 100;
            x = originalX;

            //line 6
            allC[5, 0] = new Cell(x, y, 1, 0, Properties.Resources.Luna, 21, this, characters.allchar[20]);
            frm.Controls.Add(allC[5, 0].CellPic1);
            allC[5, 1] = new Cell(x + 100, y, 1, 0, Properties.Resources.Cho, 22, this, characters.allchar[21]);
            frm.Controls.Add(allC[5, 1].CellPic1);
            allC[5, 2] = new Cell(x + 200, y, 1, 0, Properties.Resources.Lockhart, 23, this, characters.allchar[22]);
            frm.Controls.Add(allC[5, 2].CellPic1);
            allC[5, 3] = new Cell(x + 300, y, 1, 0, Properties.Resources.Trelawney, 24, this, characters.allchar[23]);
            frm.Controls.Add(allC[5, 3].CellPic1);

            //chose guess clicking
            for (int i = 0; i < allC.GetLength(0); i++)
            {
                for (int j = 0; j < allC.GetLength(1); j++)
                {
                    allC[i, j].CellPic1.DoubleClick += new EventHandler(AllCDoubleClick);
                }
            }
        }

        public void AllCDoubleClick(object sender, EventArgs e)
        {
            //insert (picturebox)sender tag to some variable.
            PictureBox p = (PictureBox)sender;
            tag = (int)p.Tag;
            sendMyGessToServer(tag);
        }

        internal void sendMyGessToServer(int info)
        {
            playBoard.sendguesstoserver(info);

        }
    }
}
