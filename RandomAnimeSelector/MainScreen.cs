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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // create method that generates random number 

        }

        // Close Main Screen And Open Add_Anime Screen
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var addanime = new AddAnime();
            addanime.Closed += (s, args) => this.Close();
            addanime.Show();
        }




    }
}
