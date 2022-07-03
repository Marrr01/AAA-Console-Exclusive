using MyLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            EmptyControl_.BringToFront();
            SettingsEditor SE = new SettingsEditor();
            SE.CheckSettingsFile();
        }

        private void ButtonPlay_Click(object sender, EventArgs e)
        {
            if ((SidePanel.Top == ButtonPlay.Top) && SidePanel.Visible)
            {
                SidePanel.Visible = false;
                EmptyControl_.BringToFront();
            }

            else
            {
                SidePanel.Visible = true;
                SidePanel.Height = ButtonPlay.Height;
                SidePanel.Top = ButtonPlay.Top;

                PlayControl_.BringToFront();
            }
        }

        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            if ((SidePanel.Top == ButtonSettings.Top) && SidePanel.Visible)
            {
                SidePanel.Visible = false;
                EmptyControl_.BringToFront();
            }

            else
            {
                SidePanel.Visible = true;
                SidePanel.Height = ButtonSettings.Height;
                SidePanel.Top = ButtonSettings.Top;

                SettingsControl_.BringToFront();
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            SidePanel.Visible = true;
            SidePanel.Height = ButtonClose.Height;
            SidePanel.Top = ButtonClose.Top;

            Close();
        }
    }
}
