using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordCounter
{
    class WordTab
    {
    Dictionary<string, int> _words = new Dictionary<string, int>();
       
        public void addWord(string newWord)
        {
            if (newWord == "  "|| newWord == "   "||newWord == " "||newWord=="")
                return;
            if(_words == null)
            {
                _words.Add(newWord, 1);
                return;
            }
            foreach( KeyValuePair<string, int> kvp in _words )
            {
                if(newWord == kvp.Key)
                {
                    _words[kvp.Key] = kvp.Value + 1;
                    return;
                }
            }
            _words.Add(newWord, 1);

        }
        /*
        foreach(KeyValuePair<string, string> kvp in myDictionary )
        {
            Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
        }
        */
        public string GetTab()
        {
            string temp = "Wort       Anzahl\r\n-------------------------------\r\n";
            foreach( KeyValuePair<string, int> wrd in _words )
            {
                temp += $"{wrd.Key}       {wrd.Value.ToString()}\r\n";
            }
            return temp;
            
            }

        public void PrintTab(TextBox tb)
        {
            tb.Text = GetTab();
        }
    }

}
