
class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        List<int> indices = Enumerable.Range(0, _words.Count).ToList();

        for (int i = 0; i < numberToHide; i++)
        {
            int index = random.Next(0, indices.Count);
            _words[index].Hide();
            indices.RemoveAt(index);
        }
    }

    public string GetDisplayText()
    {
        string displayText = $"{_reference.GetDisplayText()}\n";
        foreach (var word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText;
    }
    public void DisplayScripture(Scripture scripture)
    {
        Console.Clear(); // This line here
        Console.WriteLine(scripture.GetDisplayText());
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}
