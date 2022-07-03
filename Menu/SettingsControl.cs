using MyLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class SettingsControl : UserControl
    {
        private SettingsEditor SE = new SettingsEditor ();

        public SettingsControl()
        {
            try
            {
                InitializeComponent();

                // Чтение текущих настроек из файла

                // Длина игрового поля
                TextBoxLenght.Text = SE.ReadSetting(SE.NUM_FIELD_LENGHT);
                LabelLenght.Text = "min " + SE.MIN_FIELD_LENGHT + ", max " + SE.MAX_FIELD_LENGHT;

                // Высота игрового поля
                TextBoxHeight.Text = SE.ReadSetting(SE.NUM_FIELD_HEIGHT);
                LabelHeight.Text = "min " + SE.MIN_FIELD_HEIGHT + ", max " + SE.MAX_FIELD_HEIGHT;

                // Задержка между кадрами
                TextBoxDelay.Text = SE.ReadSetting(SE.NUM_INTERFRAME_DELAY);
                LabelDelay.Text = "min " + SE.MIN_INTERFRAME_DELAY + ", max " + SE.MAX_INTERFRAME_DELAY;

                // Шанс спавна
                if (SE.ReadSetting(SE.NUM_SHOW_SPAWN_CHANCE) == "0")
                { ButtonChanceDisabled.BringToFront(); }
                else
                { ButtonChanceEnabled.BringToFront(); }

                // Дебаг
                if (SE.ReadSetting(SE.NUM_DEBUG) == "0")
                { ButtonDebugDisabled.BringToFront(); }
                else
                { ButtonDebugEnabled.BringToFront(); }
            }
            catch { }
        }

        // Длина игрового поля
        private void TextBoxLenght_MouseHover(object sender, EventArgs e)
        { LabelLenght.Visible = true; }

        private void TextBoxLenght_MouseLeave(object sender, EventArgs e)
        {
            LabelLenght.Visible = false;

            try
            {
                if (int.Parse(TextBoxLenght.Text) < SE.MIN_FIELD_LENGHT)
                { TextBoxLenght.Text = SE.MIN_FIELD_LENGHT.ToString(); }

                if (int.Parse(TextBoxLenght.Text) > SE.MAX_FIELD_LENGHT)
                { TextBoxLenght.Text = SE.MAX_FIELD_LENGHT.ToString(); }

                if ((SE.MIN_FIELD_LENGHT <= int.Parse(TextBoxLenght.Text)) && (int.Parse(TextBoxLenght.Text) <= SE.MAX_FIELD_LENGHT))
                { SE.WriteSetting(SE.NUM_FIELD_LENGHT, TextBoxLenght.Text); }
            }
            catch { TextBoxLenght.Text = SE.ReadSetting(SE.NUM_FIELD_LENGHT); }

            SE.WriteSetting(SE.NUM_FIELD_LENGHT, TextBoxLenght.Text);
            
            TextBoxLenght.Text = SE.ReadSetting(SE.NUM_FIELD_LENGHT);

            // Чтобы каретка ввода пропадала
            label1.Select();
        }

        private void TextBoxLenght_MouseDown(object sender, MouseEventArgs e)
        {
            LabelLenght.Visible = true;
            TextBoxLenght.Text = string.Empty;
        }

        private void TextBoxLenght_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            { return; }
            else
            { e.Handled = true; }
        }

        private void TextBoxLenght_KeyDown(object sender, KeyEventArgs e)
        { TextBoxLenght.Text = string.Empty; }

        // Высота игрового поля
        private void TextBoxHeight_MouseHover(object sender, EventArgs e)
        { LabelHeight.Visible = true; }

        private void TextBoxHeight_MouseLeave(object sender, EventArgs e)
        {
            LabelHeight.Visible = false;

            try
            {
                if (int.Parse(TextBoxHeight.Text) < SE.MIN_FIELD_HEIGHT)
                { TextBoxHeight.Text = SE.MIN_FIELD_HEIGHT.ToString(); }

                if (int.Parse(TextBoxHeight.Text) > SE.MAX_FIELD_HEIGHT)
                { TextBoxHeight.Text = SE.MAX_FIELD_HEIGHT.ToString(); }

                if ((SE.MIN_FIELD_HEIGHT <= int.Parse(TextBoxHeight.Text)) && (int.Parse(TextBoxHeight.Text) <= SE.MAX_FIELD_HEIGHT))
                { SE.WriteSetting(SE.NUM_FIELD_HEIGHT, TextBoxHeight.Text); }
            }
            catch { TextBoxHeight.Text = SE.ReadSetting(SE.NUM_FIELD_HEIGHT); }

            SE.WriteSetting(SE.NUM_FIELD_HEIGHT, TextBoxHeight.Text);

            TextBoxHeight.Text = SE.ReadSetting(SE.NUM_FIELD_HEIGHT);

            // Чтобы каретка ввода пропадала
            label1.Select();
        }

        private void TextBoxHeight_MouseDown(object sender, MouseEventArgs e)
        {
            LabelHeight.Visible = true;
            TextBoxHeight.Text = string.Empty;
        }

        private void TextBoxHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            { return; }
            else
            { e.Handled = true; }
        }

        private void TextBoxHeight_KeyDown(object sender, KeyEventArgs e)
        { TextBoxHeight.Text = string.Empty; }

        // Задержка между кадрами
        private void TextBoxDelay_MouseHover(object sender, EventArgs e)
        { LabelDelay.Visible = true; }

        private void TextBoxDelay_MouseLeave(object sender, EventArgs e)
        {
            LabelDelay.Visible = false;

            try
            {
                if (int.Parse(TextBoxDelay.Text) < SE.MIN_INTERFRAME_DELAY)
                { TextBoxDelay.Text = SE.MIN_INTERFRAME_DELAY.ToString(); }

                if (int.Parse(TextBoxDelay.Text) > SE.MAX_INTERFRAME_DELAY)
                { TextBoxDelay.Text = SE.MAX_INTERFRAME_DELAY.ToString(); }

                if ((SE.MIN_INTERFRAME_DELAY <= int.Parse(TextBoxDelay.Text)) && (int.Parse(TextBoxDelay.Text) <= SE.MAX_INTERFRAME_DELAY))
                { SE.WriteSetting(SE.NUM_INTERFRAME_DELAY, TextBoxDelay.Text); }
            }
            catch { TextBoxDelay.Text = SE.ReadSetting(SE.NUM_INTERFRAME_DELAY); }

            SE.WriteSetting(SE.NUM_INTERFRAME_DELAY, TextBoxDelay.Text);

            TextBoxDelay.Text = SE.ReadSetting(SE.NUM_INTERFRAME_DELAY);

            // Чтобы каретка ввода пропадала
            label1.Select();
        }

        private void TextBoxDelay_MouseDown(object sender, MouseEventArgs e)
        {
            LabelDelay.Visible = true;
            TextBoxDelay.Text = string.Empty;
        }

        private void TextBoxDelay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            { return; }
            else
            { e.Handled = true; }
        }

        private void TextBoxDelay_KeyDown(object sender, KeyEventArgs e)
        { TextBoxDelay.Text = string.Empty; }

        // Показывать шанс спавна
        private void ButtonChanceEnabled_Click(object sender, EventArgs e)
        {
            try
            {
                SE.WriteSetting(SE.NUM_SHOW_SPAWN_CHANCE, "0");
                ButtonChanceDisabled.BringToFront();
            }
            catch { }
        }

        private void ButtonChanceDisabled_Click(object sender, EventArgs e)
        {
            try
            {
                SE.WriteSetting(SE.NUM_SHOW_SPAWN_CHANCE, "1");
                ButtonChanceEnabled.BringToFront();
            }
            catch { }
        }

        // Дебаг
        private void ButtonDebugEnabled_Click(object sender, EventArgs e)
        {
            try
            {
                SE.WriteSetting(SE.NUM_DEBUG, "0");
                ButtonDebugDisabled.BringToFront();
            }
            catch { }
        }

        private void ButtonDebugDisabled_Click(object sender, EventArgs e)
        {
            try
            {
                SE.WriteSetting(SE.NUM_DEBUG, "1");
                ButtonDebugEnabled.BringToFront();
            }
            catch { }
        }
    }
}
