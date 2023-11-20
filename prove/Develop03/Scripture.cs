class Scripture
{
    private List<Word> words;

    public Reference Reference { get; }
    public IReadOnlyList<Word> Words => words;

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        words = text.Split(' ').Select(wordText => new Word(wordText)).ToList();
    }

    public void HideRandomWord()
    {
        var visibleWords = words.Where(word => !word.Hidden).ToList();
        if (visibleWords.Any())
        {
            var wordToHide = visibleWords[new Random().Next(visibleWords.Count)];
            wordToHide.Hide();
        }
    }

    public bool IsCompletelyHidden()
    {
        return words.All(word => word.Hidden) && words.Count > 1;
    }

    public string GetRenderedText()
    {
        return string.Join(" ", words);
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine(Reference);
        Console.WriteLine(GetRenderedText());
    }
}