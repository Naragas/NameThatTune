using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameThatTune
{
    static class Victorina
    {
        static public List<string> list = new List<string>();
        static public int gameDuration = 60;
        static public int musicDuration = 10;
        static public bool randomStart = false;
        static public string lastFolder = string.Empty;
        static public bool allDirectories = false;
        static string regKeyName = "Software\\Naragas\\NameThatTune";
        static public string answer = string.Empty;

        static public void ReadMusic()
        {
            try
            {
                string[] musicFiles = Directory.GetFiles(lastFolder, "*.flac", allDirectories ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
                list.Clear();
                list.AddRange(musicFiles);
            }
            catch
            {

            }

        }

        public static void WriteParam()
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.CreateSubKey(regKeyName);
                if (rk == null) return;
                rk.SetValue("LastFolder", lastFolder);
                rk.SetValue("RandomStart", randomStart);
                rk.SetValue("GameDuration", gameDuration);
                rk.SetValue("MusicDuration", musicDuration);
                rk.SetValue("AllDirectories", allDirectories);
            }
            finally
            {
                if (rk != null) rk.Close();
            }
        }

        public static void ReadParam()
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.CreateSubKey(regKeyName);
                if (rk != null)
                {
                    lastFolder = (string)rk.GetValue("LastFolder");
                    randomStart = Convert.ToBoolean(rk.GetValue("RandomStart"));
                    gameDuration = (int)rk.GetValue("GameDuration");
                    musicDuration = (int)rk.GetValue("MusicDuration");
                    allDirectories = Convert.ToBoolean(rk.GetValue("AllDirectories"));
                }
            }
            finally
            {
                if (rk != null) rk.Close();
            }
        }
    }
}
