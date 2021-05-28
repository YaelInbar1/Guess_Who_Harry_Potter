using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guess_Who_Harry_Potter
{
    class Cell //: CharacterInfo //לכל תא יש את המאיפיינים של המחלקה
    {
        int x, y; //מיקומו של התא על הטופס
        int i, j; // מיקומו של התא ביחס ללוח המשחק
        PictureBox CellPic;
        Image backimg;
        Image img;
        string info;
        //int indx;

        Board b;
        public Image Backimg { get => backimg; set => backimg = value; }
        public Image Img { get => img; set => img = value; }
        public PictureBox CellPic1 { get => CellPic; set => CellPic = value; }

        public void picDef()
        {
            CellPic1 = new PictureBox();
            CellPic1.Image = Img;
            CellPic1.BackgroundImage = Backimg;
            CellPic1.BackgroundImageLayout = ImageLayout.Stretch;
            CellPic1.Location = new Point(x, y);
            CellPic1.Size = new Size(100, 100);
            CellPic1.SizeMode = PictureBoxSizeMode.StretchImage;
            CellPic1.BorderStyle = BorderStyle.Fixed3D;
            CellPic1.Tag = 1 + " " + j;
            CellPic1.Click += CellPic1_Click;
        }

        private void CellPic1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(info+" ");
            //b.sendMyGessToServer(indx);

        }

        public Cell(int x,int y, int i, int j, Image img,int CARNum, Board b, CharacterInfo information)
        {
            this.x = x;
            this.y = y;
            this.i = i;
            this.j = j;            
            this.Img = img;
            this.info = information.ToString();            
            this.b = b;
            this.indx = CARNum;
            picDef();           
        }

        public Cell()
        {

        }

    }
}
