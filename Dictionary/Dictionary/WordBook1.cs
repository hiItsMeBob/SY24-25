using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class WordBook1
    {
        List<string> words = new List<string>();
        List<string> definitions = new List<string>();

        public void add(string Word, string definition) 
        {
            words.Add(Word);
            definitions.Add(definition);
        }
        public string getDef(string Word)
        {
            for (int i = 0; i < words.LongCount(); i++)
            {
                if (words[i].Equals(Word))
                {
                    return definitions[i];
                }
            }
            return null;
        } 
    }
}
