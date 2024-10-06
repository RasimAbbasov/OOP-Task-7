using System.Text.RegularExpressions;

namespace OOP_Task5.ExtensionMethods
{
    internal static partial class Extension
    {
        public static bool IsContainsDigit(this string str)
        {
            if (str == null) return false;
            foreach (char a in str)
            {
                if (char.IsDigit(a)) { return true; }
                 
            }
            return false;
        }
        public static string ToCapitalize(this string str) 
        {
            return str[0].ToString().ToUpper() + str.Substring(1);
        }
        public static int[] GetValueIndexes(this string str,char a)
        {
            string[] array;
            if (string.IsNullOrEmpty(str)) return null;
            List<int> indexes = new List<int>();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == a)
                    indexes.Add(i);
            }
            return indexes.ToArray();
        }
        public static string GetFirstSentence(this string str)
        {
            if (string.IsNullOrEmpty(str)) return null;
            int endofsentence = str.IndexOfAny(new char[] {'.'});
            return str.Substring(0, endofsentence+1);
        }
        public static string GetSecondWord(this string str) 
        {
            if (string.IsNullOrEmpty(str)) return string.Empty;
            var soz = str.Split(new char[] { ' ' });
            return soz[1];
        }
    }
}
