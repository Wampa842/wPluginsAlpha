using System;
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

        public static Uri UpdateUri { get { return _updateUri; } }

        private static Uri _updateUri;

        public static void ReadPrefs()
        {
            using (StreamReader read = new StreamReader(_prefsFilePath))
            {
                while(!read.EndOfStream)
                {
                    string[] line = read.ReadLine().Split('=');
                    string key = line[0].Trim().ToLowerInvariant();
                    string value = line[1].Trim().ToLowerInvariant();

                    switch (key)
                    {
                        case "updateuri":
                            _updateUri = new Uri(Uri.EscapeUriString(value));
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }

    public static class Translator
    {
        public static List<string[]> Dictionary;
        public static bool DictionaryUpToDate = false;

        public static void ReadTranslationFile(string path)
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
