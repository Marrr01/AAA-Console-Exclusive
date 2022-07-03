using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class SettingsEditor
    {
        // Ссылка на файл
        const string LINK = "Settings.txt";

        // Объявление переменных для чтения настроек
        private StreamReader SR = null;
        private string[] StringSeparators = new string[] { "//" };
        private string[] DividedString = new string[2]; // в результате чтения одной настройки будет 2 строки - параметр и комментарий

        // Объявление переменных для записи настроек
        private StreamWriter SW = null;
        public int NUM_GAME_MODE            { get; } = 0;
        public int NUM_FIELD_LENGHT         { get; } = 1;
        public int NUM_FIELD_HEIGHT         { get; } = 2;
        public int NUM_INTERFRAME_DELAY     { get; } = 3;
        public int NUM_SHOW_SPAWN_CHANCE    { get; } = 4;
        public int NUM_DEBUG                { get; } = 5;
        public int NUM_OF_SETTING_STRINGS   { get; } = 6;
        public int MIN_FIELD_LENGHT         { get; } = 25;
        public int MAX_FIELD_LENGHT         { get; } = 150;
        public int MIN_FIELD_HEIGHT         { get; } = 10;
        public int MAX_FIELD_HEIGHT         { get; } = 100;
        public int MIN_INTERFRAME_DELAY     { get; } = 0;
        public int MAX_INTERFRAME_DELAY     { get; } = 1000;

        public void CheckSettingsFile()
        {
            try   { SR = new StreamReader(LINK); SR.Close(); }
            catch { throw new Exception("Не удалось открыть файл '" + LINK + "'"); }
            SR.Close();
        }

        public string ReadSetting(int SettingNum)
        {
            //CheckSettingsFile();

            string Result = string.Empty;

            SR = new StreamReader(LINK);

            for (int i = 0; i < NUM_OF_SETTING_STRINGS; i++)
            {

                if (i == SettingNum)
                {
                    DividedString = SR.ReadLine().Split(StringSeparators, StringSplitOptions.None);
                    Result = DividedString[0];
                }
                else
                { SR.ReadLine(); }
            }

            SR.Close();

            return Result;
        }

        public void WriteSetting(int SettingNum, string Value)
        {
            //CheckSettingsFile();

            SR = new StreamReader(LINK);

            string[] Settings = new string[NUM_OF_SETTING_STRINGS];

            for (int i = 0; i < NUM_OF_SETTING_STRINGS; i++)
            {
                if (i == SettingNum)
                { DividedString = SR.ReadLine().Split(StringSeparators, StringSplitOptions.None); }
                else
                { Settings[i] = SR.ReadLine(); }
            }

            SR.Close();

            SW = new StreamWriter(LINK);

            for (int i = 0; i < NUM_OF_SETTING_STRINGS; i++)
            {
                if (i == SettingNum)
                { SW.WriteLine(Value + StringSeparators[0] + DividedString[1]); }
                else
                { SW.WriteLine(Settings[i]); }
            }

            SW.Close();
        }
    }
}
