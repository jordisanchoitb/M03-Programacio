using System;

namespace OOPEx
{
    public class Identifier
    {   
        public static string Clean(string text)
        {
            bool enterFunction = false;
            int iterations = 0;
            if (text == null) return null;
            
            while (iterations < text.Length && !enterFunction)
            {
                if (text[iterations] >= 'α' && text[iterations] <= 'ω')
                {
                    enterFunction = true;
                    text = RemoveAllWhitOutGreekLetters(text);
                }
                iterations++;
            }
            iterations = 0;
            enterFunction = false;
            while (iterations < text.Length && !enterFunction)
            {
                if (char.IsControl(text[iterations]))
                {
                    enterFunction = true;
                    text = RemplaceControlChars(text);
                }
                iterations++;
            }
            if (text.Contains('-'))
            {
                text = ToCamelCase(text);
            }
            if (text.Contains(' '))
            {
                text = RemoveSpaces(text);
            }
            iterations = 0;
            enterFunction = false;
            while (iterations < text.Length && !enterFunction)
            {
                if (!char.IsLetter(text[iterations]) && text[iterations] != '_')
                {
                    enterFunction = true;
                    text = RemoveAllWhitOutLetters(text);
                }
                iterations++;
            }

            return text;
        }
        public static string RemoveSpaces(string text)
        {
            return text.Replace(" ", "_");
        }
        public static string RemplaceControlChars(string text)
        {
            string result = "";
            foreach (char c in text)
            {
                if (char.IsControl(c)) result += "CTRL";
                else result += c;
            }
            return result;
        }
        public static string ToCamelCase(string text)
        {
            string result = "";
            bool nextUpper = false;
            text = text.Replace(" ", "_");
            text = text.Replace("-", " ");
            foreach (char c in text)
            {
                if (nextUpper)
                {
                    result += char.ToUpper(c);
                    nextUpper = false;
                }
                else if (c != ' ')
                {
                    result += c; 
                }
                if (c == ' ')
                {
                    nextUpper = true;
                }
            }
            return result;
        }
        public static string RemoveAllWhitOutLetters(string text)
        {
            string result = "";
            foreach (char c in text)
            {
                if (char.IsLetter(c) || c == ' ' || c == '_') result += c;
            }
            return result;
        }
        public static string RemoveAllWhitOutGreekLetters(string text)
        {
            string result = "";
            foreach (char c in text)
            {
                if (!(c >= 'α' && c <= 'ω')) result += c;
            }
            return result;
        }
    }
}
