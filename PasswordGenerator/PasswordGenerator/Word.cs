using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{


    /// <summary>
    /// Base structure of a word is its usage frequency rank, its lemma (the text of the word) and its POS (part of speech) 
    /// this based on http://www.wordfrequency.info/files/entriesWithoutCollocates.txt
    /// </summary>
    public class Word
    {
        public int Rank;
        public string Lemma;
        public PartsOfSpeech PartOfSpeech;

        public Word(int rank, string lemma, PartsOfSpeech partOfSpeech)
        {
            Rank = rank;
            Lemma = lemma;
            PartOfSpeech = partOfSpeech;
        }

        
    }
}
