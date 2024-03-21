
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
        List<int> indices = Enumerable.Range(0, _words.Count).Where(i => !_words[i].IsHidden()).ToList();

        for (int i = 0; i < Math.Min(numberToHide, indices.Count); i++)
        {
            int index = random.Next(0, indices.Count);
            _words[indices[index]].Hide();
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

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}
