public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    private string _context;

    public Reference(string book, int chapter, int verse, string context)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = -1;
        _context = context;
    }

    public Reference(string book, int chapter, int verse, int endVerse, string context)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
        _context = context;
    }

    public string GetDisplayText()
    {
        if (_endVerse == -1)
        {
            return $"{_book} {_chapter}:{_verse} - context: {_context}";
        }
        else{
            return $"{_book} {_chapter}:{_verse}-{_endVerse} - context: {_context}";
        }
    }
}