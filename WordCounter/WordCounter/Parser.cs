using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounter
{
    class Parser
    {
        private WordTab _wordTab;
        public Parser(WordTab wrdTb)
        {
            _wordTab = wrdTb;
        }
        public void Parse(string inPutString)
        {
            if(inPutString == "")
            {
                return;
            }
            string[] words = inPutString.Split(' ');

            foreach (var word in words)
            {
                    _wordTab.addWord(word);
            }
        }
    }
}
