namespace SpellingBeePractice.StaticApp.Models
{
    public class WordsExportViewModel
    {
        public string Text { get; set; }
        public int PositionInCollection { get; set; }
        public Entry DictionaryEntry { get; set; }

    }
    public class Entry
    {
        public string Word { get; set; }
        public string Phonetic { get; set; }
        public Meaning[] Meanings { get; set; }
        public string Origin { get; set; }
        public Phonetic[] Phonetics { get; set; }
    }
    public class Meaning
    {
        public string PartOfSpeech { get; set; }
        public DefinitionEntry[] Definitions { get; set; }
    }
    public class DefinitionEntry
    {
        public string Definition { get; set; }
        public string Example { get; set; }
        public string[] Synonyms { get; set; }
        public string[] Antonyms { get; set; }
    }
    public class Phonetic
    {
        public string Text { get; set; }
        public string Audio { get; set; }
    }
}
