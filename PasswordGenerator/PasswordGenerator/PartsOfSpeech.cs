using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    /// <summary>
    /// <para> Parts of speech codes used to the classification of a word</para>
    /// <para>The format is a simplified version of the claw7tags</para>
    /// <para>http://ucrel.lancs.ac.uk/claws7tags.html</para>
    /// <para>These are to be used with the word list from </para>
    /// <para>For more information:</para>
    /// <para>http://www.wordfrequency.info : Word frequency lists</para>
    /// <para>http://corpus.byu.edu/coca/ : Corpus of Contemporary American English (COCA)</para>
    /// <para>http://davies-linguistics.byu.edu/ : Mark Davies </para>
    /// </summary>
    public enum PartsOfSpeech
    {
        /// <summary>Article</summary>
        a,
        /// <summary>Conjunction</summary>
        c,
        /// <summary>Determiner</summary>
        d,
        /// <summary>Preposition</summary>
        i,
        /// <summary>Adjective</summary>
        j,
        /// <summary>Numeric</summary>
        m,
        /// <summary>Noun</summary>
        n,
        /// <summary>Pronoun</summary>
        p,
        /// <summary>Adverb</summary>
        r,
        /// <summary>Infinitive Marker</summary>
        t,
        /// <summary>Interjection</summary>
        u,
        /// <summary>Verb</summary>
        v,
        /// <summary>No</summary>
        x,
        /// <summary>Default value</summary>
        None = 0
    }
}
