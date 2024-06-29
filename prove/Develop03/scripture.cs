public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        

        string[] words = text.Split(" ");
        foreach (string eachWord in words)
        {
            Word word = new Word(eachWord);
            _words.Add(word);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int hiddenCount = 0;

        while (hiddenCount < numberToHide)
        {
            int index = random.Next(_words.Count);

            if (!_words[index].isHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }
        }
    }

    public string GetDisplayText()
    {
        List<string> visibleWords = new List<string>();
        foreach(Word word in _words)
        {
            visibleWords.Add(word.GetDisplayText());
        }
        string wordsText = string.Join(" ", visibleWords);
        return $"{_reference.GetDisplayText()}: {wordsText}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.isHidden())
            {
                return false;
            }
        }
        return true;
    }
}