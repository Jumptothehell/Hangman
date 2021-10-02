using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Word
    {
        public string word;
        public int count_char;
        public char[] character;

        public Word(string word, int count_char, char[] character) {
            this.word = word;
            this.count_char = count_char;
            this.character = character;
        }

    }
}
