using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Game_2._0
{
    public partial class Menu : Form
    {
        WindowsMediaPlayer Clicks;

        public Menu()
        {
            DoubleBuffered = true;
            BackColor = Color.Black;
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Clicks = new WindowsMediaPlayer
            {
                URL = "Sounds\\Click.mp3"
            };
            Clicks.settings.volume = SoundControl.Volume;
            Clicks.controls.stop();
        }

        private void start_Click(object sender, EventArgs e)
        {
            Clicks.controls.play();
            start_level1();
        }

        public void start_level1()
        {
            Form1 level1 = new Form1();
            Hide();
            level1.ShowDialog();
            Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Volume_Click(object sender, EventArgs e)
        {
            volumeBar.Visible = volumeBar.Visible == true ? false : true;
            Clicks.controls.play();
        }

        private void volumeBar_Scroll(object sender, EventArgs e)
        {
            SoundControl.Volume = volumeBar.Value;
            Clicks.controls.play();
        }
    }
}
