using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.FileIO;


namespace wNameUtil
{
    public static class Translator
    {
        public static List<string[]> Dictionary;
        public static bool DictionaryUpToDate = false;

        public static void ReadTranslationFile(string path)
        {
            Dictionary = new List<string[]>();
            using (TextFieldParser parser = new TextFieldParser(path))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                while(!parser.EndOfData)
                {
                    string[] row = parser.ReadFields();
                    //MessageBox.Show(row[0] + ", " + row[1]);
                    Dictionary.Add(row);
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
    }

    public class Matcher
    {
        public enum MatcherMethod { Simple, Extended, Regex };
        public enum MatchLanguage { Japanese, English };

        public MatchLanguage Language { get { return _language; } }

        private MatcherMethod _method;
        private string _matchString;
        private MatchLanguage _language;
        
        public Matcher(string match, bool useRegex, bool matchEnglish)
        {
            _method = useRegex ? MatcherMethod.Regex : MatcherMethod.Simple;
            _matchString = match;
            _language = matchEnglish ? MatchLanguage.English : MatchLanguage.Japanese;
        }

        public bool Match(string s)
        {
            switch (_method)
            {
                case MatcherMethod.Simple:
                    return s.ToLowerInvariant().Contains(_matchString.ToLowerInvariant());
                case MatcherMethod.Extended:
                    break;
                case MatcherMethod.Regex:
                    return Regex.IsMatch(s, _matchString);
                default:
                    break;
            }
            return false;
        }
    }
}
