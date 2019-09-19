using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eng_words.data
{
    class Word
    {

        public string Name { get; set; }
        public string Prefix { get; set; }
        public string Partialness { get; set; }
        public string Description { get; set; }


        public Word(string dummy)
        {
            Name = "";
            Prefix = "";
            Partialness = "";
            Description = "";
        }
    }
}
