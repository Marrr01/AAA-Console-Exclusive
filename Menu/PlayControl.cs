using MyLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class PlayControl : UserControl
    {
        private SettingsEditor SE = new SettingsEditor();
        private const string PATH_TO_GAME_EXE = "Game.exe";
        public PlayControl()
        {
            InitializeComponent();
        }

        private void ButtonPlayWithBoss_Click(object sender, EventArgs e)
        {
            SE.WriteSetting(SE.NUM_GAME_MODE, "0");
            Process.Start(PATH_TO_GAME_EXE);
            Environment.Exit(0);
        }

        private void ButtonEndless_Click(object sender, EventArgs e)
        {
            SE.WriteSetting(SE.NUM_GAME_MODE, "1");
            Process.Start(PATH_TO_GAME_EXE);
            Environment.Exit(0);
        }
    }
}
