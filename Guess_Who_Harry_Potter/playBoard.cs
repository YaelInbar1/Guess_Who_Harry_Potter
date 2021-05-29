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
    public partial class playBoard : Form
    {
        public playBoard()
        {
            InitializeComponent();
            myDelegate = new deleForm(MyProtocol);
        }

        //private void InitializeComponent() => throw new NotImplementedException();
        //private void pictureBox1_Click(object sender, EventArgs e)
        //{            
        //}
 
        Board Play;
        public delegate void deleForm();
        public static deleForm myDelegate;
        public playBoard frmChat;
        ServerData sd;
        public static string IPAddress, UserName, Port, mess;
        private object btnLogIn;
        AllCar characters;

        public string firstCharInfoRes;
        

        private void playBoard_Load(object sender, EventArgs e)
        {
            characters = new AllCar();
            Play = new Board(this, 660, 30,characters);
            frmChat = (this);//הגדרת מצביע לטופס הנוכחי
            sd = new ServerData(frmChat);//יצירת אובייקט חדש של המחלקה
           
        }

        public static int TpicP1;
        public static int TpicP2;

        public static int tpic1Q;
        public static int tpic2Q;

        int myPlayerNumbr;
        CharacterInfo myCharacret;
        string[] splitstr;
        
        public void MyProtocol()
        {
            string s;
            firstCharInfoRes = mess.Substring(0);
            int senttag;            
            switch (firstCharInfoRes[0])
            {// חלק זה יתבצע כל פעם שיתחבר לקוח חדש ואז נמחקת  רשימת המשתמשים שאונליין והיא נבנית מחדש 
                case '@':
                    lstUsers.Items.Clear();
                    //lstUsers.Items.Add("All Users");
                    //lstUsers.SetSelected(0, true);
                    firstCharInfoRes = firstCharInfoRes.Substring(2);// מוריד גם @ וגם רווח
                    firstCharInfoRes += " ";
                    string[] s1 = firstCharInfoRes.Split(' ');
                    for (int i = 0; i < s1.Length-2; i++)
                    {
                        lstUsers.Items.Add(s1[i]);
                    }
                    if (lstUsers.Items.Count == 1)
                        lblServerInfo.Text = "waiting for another player";
                    if (lstUsers.Items.Count == 2)
                    {
                        lblServerInfo.Text = "The game is on!";
                        lblPlayer1.Text = lstUsers.Items[0].ToString();
                        lblPlayer2.Text = lstUsers.Items[1].ToString();
                        if(UserName==lblPlayer1.Text)
                        {
                            myPlayerNumbr = 1;
                            myCharacret = characters.myRandomChar();
                            picBoxPlayer1.Image = characters.MyPic(myCharacret.NumInArr1);
                            picBoxPlayer1.Tag= (int)characters.picplay;
                            TpicP1 = (int)characters.picplay;
                            tpic1Q= (int)characters.picplay;
                            picBoxPlayer2.Image = Properties.Resources.QMark;
                        }
                        else
                        {
                            myPlayerNumbr = 2;
                            myCharacret = characters.myRandomChar();
                            picBoxPlayer2.Image = characters.MyPic(myCharacret.NumInArr1);
                            picBoxPlayer2.Tag = (int)characters.picplay;
                            TpicP2 = (int)characters.picplay;
                            tpic2Q = (int)characters.picplay;
                            picBoxPlayer1.Image = Properties.Resources.QMark;
                        }
                        lblCorrentPlayer.Text = lblPlayer1.Text;
                    }
                    break;
                // חלק זה יתבצע כשאר לקוח מתנתק מהצ'אט ואז רשימת השתמשים תעודכן בלעדיו
                case '!':
                    s = firstCharInfoRes.Substring(1, firstCharInfoRes.IndexOf("\0") - 1);
                    lstUsers.Items.Remove(s);
                    break;
                // חלק זה מציג את ההודעה לכל המשתמשים בחלון הצאט
                case '#':
                    string tmp = firstCharInfoRes.Substring(1) + "\n";
                    //  messages.Add(tmp);
                    lblInfo.Text += tmp;
                    break;
                case '&':
                    splitstr = firstCharInfoRes.Split('_');
                    if (splitstr[1] != UserName)
                        if (MessageBox.Show(splitstr[2], "שאלה", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            ans = "yes";
                        else
                            ans = "no";
                    sd.WriteToServer("^_" + UserName + "_" + ans);
                    break;
                case '^':
                    splitstr = firstCharInfoRes.Split('_');
                    if (splitstr[1] != UserName)
                        MessageBox.Show(splitstr[1] + " anserd " + splitstr[2]);
                        break;
                case '*':
                    //Console.WriteLine(picBoxPlayer2.Image);
                    s = firstCharInfoRes.Substring(1);
                    Bitmap question_mark = Properties.Resources.QMark;
                    question_mark.Tag = 44;
                    if (TpicP2 == 0)
                    {
                        TpicP2 = 44;
                    }
                    else
                        tpic1Q = 44;
                    senttag = int.Parse(s); // tag of the sent pic  
                                            
                            if (senttag == TpicP2)
                            {
                                // a window jumps that indicates that he is a winner 
                                sd.WriteToServer("l2");
                            }                                                                                  
                    break;
                case 'l':
                    s = firstCharInfoRes.Substring(1);     // who lost               
                        //screens that indicates to who lost / won
                        if (myPlayerNumbr.ToString().Equals(s))
                        {
                            var newForm = new Lose();
                            newForm.Show();
                        }
                        else //
                        {
                            var newForm = new Win();
                            newForm.Show();
                        }
                    break;
                case '%':
                    s = firstCharInfoRes.Substring(1);
                    Bitmap questionmark = Properties.Resources.QMark; //change name
                    questionmark.Tag = 44;
                    if (TpicP2 == 0)
                    {
                        TpicP2 = 44;
                    }
                    else
                        tpic1Q = 44;
                    senttag = int.Parse(s); // tag of the sent pic 

                    if (senttag == TpicP1) // means that you are player 2 
                    {
                        // a window jumps that indicates that he is a winner 
                        sd.WriteToServer("l1");
                    }
                    break;
            }
        }

        //private bool Equals22(Image bmp1, Bitmap bmp2)
        //{
            //if (!bmp1.Size.Equals(bmp2.Size))
            //{
                //return false;
            //}
            //for (int x = 0; x < bmp1.Width; ++x)
            //{
                //for (int y = 0; y < bmp1.Height; ++y)
                //{
                    //if (bmp1.GetPixel(x, y) != bmp2.GetPixel(x, y))
                    //{
                        //return false;
                    //}
                //}
            //}
            //return true;
        //}

        string ans;
        private bool CheckIfTrue(int pictag)
        {
            return true; //***********
        }
        internal void showAndSendQ(string qChosen)
        {
            lblQuestion.Text = qChosen;
            sd.WriteToServer("&_"+UserName + "_" + qChosen);
        }

        private void txtMess_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnQuestion_Click(object sender, EventArgs e)
        {            
            frmChooseQuestion f1 = new frmChooseQuestion(this);
            f1.ShowDialog();
          //  lblQuestion.Text = frmChooseQuestion.cQues;
        }

        internal void sendguesstoserver(int info)
        {
            if (picBoxPlayer2.Image == Properties.Resources.QMark) //you are player 1
            {
                sd.WriteToServer("*" + info.ToString());
            }
            else
                sd.WriteToServer("%" + info.ToString());


        }

        private void lblPlayer1_Click(object sender, EventArgs e)
        {

        }

        private void btnShowChar_Click(object sender, EventArgs e)
        {
            myCharacret = characters.myRandomChar();
            picBoxPlayer1.Image = characters.MyPic(myCharacret.NumInArr1);

        }

        private void lblCorrentPlayer_Click(object sender, EventArgs e)
        {

        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }

        public  void SendGuss(string pictag)
        {
            
            sd.WriteToServer(pictag); 
        }
        private void btnGuess_Click(object sender, EventArgs e)
        {
            var newForm = new ChoseGuess(this);
            newForm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (btnLogin.Enabled == true)
            {

                btnLogin.Enabled = false;
                frmConnect f2 = new frmConnect();
                f2.ShowDialog();
                if (IPAddress != null && Port != null && UserName != null)
                {
                    sd.StartServer(UserName, IPAddress, int.Parse(Port));
                    this.Text = UserName;//הכותרת של הטקסט תהיה השם של המשתמש

                }
                else
                    MessageBox.Show("לא הזנת נתוני התחברות", "שגיאה");
            }
            else
            {
                sd.WriteToServer("!" + UserName);
                sd.OnClosing();
                sd.stm = null;
                this.Close();
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            sd.WriteToServer("!" + UserName);
            sd.stm = null;
            sd.OnClosing();                
            this.Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            sd.WriteToServer("#" + UserName + " : " + txtMess.Text + "\n");
        }

       

        //private void allC_Click(object sender, EventArgs e)
        //{
        //PictureBox c;
        //string place1 = " ", place2 = " ";
        //c = (PictureBox)sender; MessageBox.Show("name: " + c.Tag + "\n" + "color: " + color);
        //}
    }
    
    }

