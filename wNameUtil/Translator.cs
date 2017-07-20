﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

using System.Windows.Forms;
using System.Net;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.FileIO;


namespace wNameUtil
{
    public static class Prefs
    {
        private static string _prefsFilePath = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "wNameUtil.cfg");

        public static Uri UpdateUri { get { return _updateUri; } set { _updateUri = value; } }
        public static bool AutoStart { get { return _autoStart; } set { _autoStart = value; } }
        public static bool AutoUpdate { get { return _autoUpdate; } set { _autoUpdate = value; } }

        private static Uri _updateUri;
        private static bool _autoStart;
        private static bool _autoUpdate;

        public static void ReadPrefs()
        {
            bool openSettings = false;
            using (StreamReader read = new StreamReader(_prefsFilePath))
            {
                while(!read.EndOfStream)
                {
                    string line = read.ReadLine();
                    if (string.IsNullOrWhiteSpace(line) || line.Trim()[0] == '#')
                        continue;
                    string[] kvp = line.Split('=');
                    string key = kvp[0].Trim().ToLowerInvariant();
                    string value = kvp[1].Trim().ToLowerInvariant();

                    switch (key)
                    {
                        case "updateuri":
                            string uri = Uri.EscapeUriString(value);
                            if (!Uri.IsWellFormedUriString(uri, UriKind.Absolute))
                            {
                                MessageBox.Show("The dictionary file URL is incorrectly formatted. Make sure it starts with http:// and that it points to the correct file.");
                                uri = "http://localhost";
                                openSettings = true;
                            }
                            _updateUri = new Uri(uri);
                            break;
                        case "autostart":
                            if (!bool.TryParse(value, out _autoStart))
                                _autoStart = false;
                            break;
                        case "autoupdate":
                            if (!bool.TryParse(value, out _autoUpdate))
                                _autoUpdate = false;
                            break;
                        default:
                            break;
                    }
                }
            }
            if(openSettings)
            {
                SettingsForm settingsForm = new SettingsForm();
                settingsForm.ShowDialog();
            }
        }

        public static void WritePrefs()
        {
            try
            {
                string[] lines;
                using (StreamReader reader = new StreamReader(_prefsFilePath, Encoding.UTF8))
                {
                    string all = reader.ReadToEnd();
                    lines = all.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                }

                using (StreamWriter writer = new StreamWriter(_prefsFilePath))
                {
                    foreach(string line in lines)
                    {
                        if(string.IsNullOrWhiteSpace(line) ||  line.Trim()[0] == '#')
                        {
                            writer.WriteLine(line);
                            continue;
                        }
                        string key = line.Split('=')[0].Trim().ToLowerInvariant();
                        switch (key)
                        {
                            case "updateuri":
                                writer.WriteLine(key + " = " + _updateUri.AbsoluteUri);
                                break;
                            case "autostart":
                                writer.WriteLine(key + " = " + _autoStart.ToString().ToLowerInvariant());
                                break;
                            case "autoupdate":
                                writer.WriteLine(key + " = " + _autoUpdate.ToString().ToLowerInvariant());
                                break;
                            default:
                                writer.WriteLine(line);
                                break;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }

    public static class Translator
    {
        public static List<string[]> Dictionary;
        public static bool DictionaryUpToDate = false;

        public static void ReadDictionary(string path)
        {
            Dictionary = new List<string[]>();
            try
            {
                using (TextFieldParser parser = new TextFieldParser(path))
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");
                    parser.CommentTokens = new string[] { "#" };
                    while (!parser.EndOfData)
                    {
                        string[] row = parser.ReadFields();
                        Dictionary.Add(row);
                    }
                }
            }
            catch(FileNotFoundException)
            {
                MessageBox.Show("Dictionary file not found!\nA new file has been created at:\n" + path);
                try
                {
                    using (StreamWriter w = new StreamWriter(path, false, Encoding.UTF8))
                    {
                        w.WriteLine("# This file contains dictionary entries encapsulated in double quotes (\"...\"), separated by commas. Japanese first, English second. One per line.");
                    }
                }
                catch(IOException)
                {
                    MessageBox.Show("Failed to create dictionary file. Make sure you have permission to write to the plugin folder.", "Failed to write file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            DictionaryUpToDate = true;
        }
        /*
        public static void WriteDictionary(string path)
        {
            if (Dictionary.Count <= 0)
                return;
            using 
            foreach(string[] entry in Dictionary)
            {

            }
        }
        */
        public static string EnToJp(string en)
        {
            foreach(string[] entry in Dictionary)
            {
                if(entry[1].ToLowerInvariant() == en.ToLowerInvariant())
                {
                    return entry[0].ToLowerInvariant();
                }
            }
            return "";
        }

        public static string JpToEn(string jp)
        {
            foreach (string[] entry in Dictionary)
            {
                if (entry[0].ToLowerInvariant() == jp.ToLowerInvariant())
                {
                    return entry[1].ToLowerInvariant();
                }
            }
            return "";
        }

        public static void UpdateDictionary(string path)
        {
            Uri url = Prefs.UpdateUri;
            byte[] result;
            try
            {
                using (WebClient client = new WebClient())
                {
                    result = client.DownloadData(url);
                }
                using (StreamWriter writer = new StreamWriter(path, false, Encoding.UTF8))
                {
                    string dataStr = Encoding.UTF8.GetString(result);
                    writer.Write(dataStr);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
        public static string Capitalize(string s, int mode)
        {
            switch (mode)
            {
                case 1:
                    return s.ToLowerInvariant();
                case 2:
                    return s.First().ToString().ToUpperInvariant() + s.Substring(1);
                case 3:
                    return s.ToUpperInvariant();
                default:
                    return s;
            }
        }
    }

    public class Matcher
    {
        public bool MatchEnglish { get { return _matchEnglish; } }

        private bool _useRegex;
        private string _matchString;
        private bool _matchEnglish;
        
        public Matcher(string match, bool useRegex, bool matchEnglish)
        {
            _useRegex = useRegex;
            _matchString = match;
            _matchEnglish = matchEnglish;
        }

        public bool Match(string s)
        {
            if (_useRegex)
                return s.ToLowerInvariant().Contains(_matchString.ToLowerInvariant());
            else
                return Regex.IsMatch(s, _matchString);
        }
    }
}
