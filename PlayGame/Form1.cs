using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace PlayGame
{
    public partial class Background : Form
    {
        public Background()
        {
            InitializeComponent();
        }

        private void PlayGame_Click(object sender, EventArgs e)
        {
            PlayGame.Visible = false;

            countdown.Text = "Game starts in 3";

        }
    }
}
