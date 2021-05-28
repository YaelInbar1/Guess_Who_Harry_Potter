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
    public partial class frmChooseQuestion : Form
    {
        playBoard frm;
        public frmChooseQuestion(playBoard frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        Question Q = new Question();
        PictureBox[] Choice = new PictureBox[5];
        PictureBox p;
        public static string cQues = "";

        private void frmChooseQuestion_Load(object sender, EventArgs e)
        {
            //string s;
            //int x = 100, y = 150;
            //string[] allQuestions = new string[5];
            //allQuestions[0] = Q.Ques1;
            //allQuestions[1] = Q.Ques2;
            //allQuestions[2] = Q.Ques3;
            //allQuestions[3] = Q.Ques4;
            //allQuestions[4] = Q.Ques5;

            //for (int j = 0; j < allQuestions.Length; j++)
            //{
            //    s = allQuestions[j];
            //    for (int i = 0; i < allQuestions[j].Length; i++)
            //    {

            //        picDef(p, x, y, (Image)Properties.Resources.ResourceManager.GetObject(s[i] + ""), null, 0);
            //        x += 40;
            //    }


            //    picDef(Choice[j], 40, y, Properties.Resources.choose, s, 1);
            //    x = 100;
            //    y += 50;

            //}
        }
            public void picDef(PictureBox p, int x, int y, Image img, string tag, int press)
            {
                p = new PictureBox();
                p.Size = new Size(40, 40);
                p.SizeMode = PictureBoxSizeMode.StretchImage;
                p.Location = new Point(x, y);
                p.Image = img;
                p.Tag = tag;
                p.BackColor = Color.Transparent;
                if (press == 1)
                    p.Click += P_Click;
                Controls.Add(p);
            }

            private void P_Click(object sender, EventArgs e)
            {
                PictureBox pressPic = (PictureBox)sender;
                cQues = pressPic.Tag.ToString();
                this.Close();
                // MessageBox.Show(pressPic.Tag.ToString());
            }

        public string QChosen;


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            QChosen = "Does your character have red hair?";

        }

        private void radioButton23_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton30_Click(object sender, EventArgs e)
        {
            RadioButton pressrd = (RadioButton)sender;
            QChosen = pressrd.Text;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            MessageBox.Show(QChosen);
            frm.showAndSendQ(QChosen);
            this.Close();
        }
    }
}
