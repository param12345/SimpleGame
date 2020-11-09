using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleGame
{
    public partial class Game_form : Form
    {
        public Game_form()
        {
            InitializeComponent();
        }

        // Game_form_Load function will disable all the buttons except Load button
        private void Game_form_Load(object sender, EventArgs e)
        {
            btn_spin.Enabled = false; //disabling the Spin button
            Btn_shoot.Enabled = false; 
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            btn_spin.Enabled = true;
            btn_load.Enabled = false;
        }

        private void btn_spin_Click(object sender, EventArgs e)
        {
            Btn_shoot.Enabled = true;
            btn_spin.Enabled = false;
        }

        private void Btn_PlayAgain_Click(object sender, EventArgs e)
        {
            btn_load.Enabled = true;
            btn_spin.Enabled = false;
            Btn_shoot.Enabled = false;
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Rules_Click(object sender, EventArgs e)
        {

        }
    }
}
