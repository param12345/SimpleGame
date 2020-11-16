using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleGame
{
    public partial class Game_form : Form
    {
        Game_logic game_object = new Game_logic();
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

            //code to display image in picture box on button click  
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("SimpleGame.Resources.welcome.jpeg");
            Bitmap bmp_Object = new Bitmap(myStream);
            PicBox_Main.Image = bmp_Object;

            game_object.load_data = 1;
        }

        private void btn_spin_Click(object sender, EventArgs e)
        {
            Btn_shoot.Enabled = true;
            btn_spin.Enabled = false;

            //code to display image in picture box on button click  

            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("SimpleGame.Resources.shoot.gif");
            Bitmap bmp_Object = new Bitmap(myStream);
            PicBox_Main.Image = bmp_Object;

            Random Rnd_obj = new Random();
            game_object.spin_data = Rnd_obj.Next(1, 7);

            MessageBox.Show("Bullet Position after spining the chamber is "+ game_object.spin_data.ToString());
        }

        private void Btn_shoot_Click(object sender, EventArgs e)
        {
            //logic 
            game_object.shoot_data = game_object.shoot_method();
            if(game_object.shoot_data ==1)
            {
                // Sound code
                System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(SimpleGame.Properties.Resources.shoot1);
                Sound_Object.Play();
                MessageBox.Show("Bullet shot on your head. You are dead");
            }
            else
            {
                MessageBox.Show("emply shoot");
            }
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
            Game_Rules rules_obj = new Game_Rules();
            rules_obj.Show();
            this.Hide();
        }

        
    }
}
