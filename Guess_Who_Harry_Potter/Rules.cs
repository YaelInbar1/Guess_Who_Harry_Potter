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
    public partial class Rules : Form
    {
        public Rules()
        {
            InitializeComponent();
        }

        private void lblStart_Click(object sender, EventArgs e)
        {
            var newForm = new playBoard();
            newForm.Show();
            this.Close();
        }

        private void Rules_Load(object sender, EventArgs e)
        {

        }
    }
}
