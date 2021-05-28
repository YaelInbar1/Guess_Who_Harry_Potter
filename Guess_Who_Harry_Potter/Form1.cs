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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //var newForm = new playBoard();
            var newForm = new Rules();
            //this.Hide();
            newForm.Show();
            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

    //    public static implicit operator Form1(playBoard v)
    //    {
    //        throw new NotImplementedException();
    //    }
    }
}
