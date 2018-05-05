using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomAnimeSelector
{
    public partial class AddAnime : Form
    {
        public AddAnime()
        {
            InitializeComponent();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void randomAnimeSelectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainScreen main_Screen = new MainScreen();
            main_Screen.Show();
            this.Close();
        }
    }
}
