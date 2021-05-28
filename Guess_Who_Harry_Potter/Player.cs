using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_Who_Harry_Potter
{
    class Player
    {
        int playerNum;
        string playerName;
        Image playerImage;
        int score;
        int toolNum;
        Color color;

        public Player(int num, string name, Image img, int score, int tool, Color color)
        {
            this.playerNum = num;
            this.playerName = name;
            this.playerImage = img;
            this.score = score;
            this.toolNum = tool;
            this.color = color;
        }

        public int PlayerNum { get => playerNum; set => playerNum = value; }
        public string PlayerName { get => playerName; set => playerName = value; }
        public Image PlayerImage { get => playerImage; set => playerImage = value; }
        public int Score { get => score; set => score = value; }
        public int ToolNum { get => toolNum; set => toolNum = value; }
        public Color Color { get => color; set => color = value; }
    }
}
