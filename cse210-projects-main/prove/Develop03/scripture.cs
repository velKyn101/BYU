using System.Text;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;  


    public Scripture (Reference Reference, string text)
    {
        _reference = Reference;
        _words = new List<Word>();
        
        string[] wordsArray = text.Split(' ');
        foreach (string wordText in wordsArray)
        {
            _words.Add(new Word(wordText));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
         Random random = new Random();
        int wordsHidden = 0;
        
        while (wordsHidden < numberToHide)
        {
            int index = random.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                wordsHidden++;
            }
        }
    }

    public string GetDisplayText()
    {
        StringBuilder displayText = new StringBuilder();
        
        foreach (Word word in _words)
        {
            displayText.Append(word.GetDisplayText());
            displayText.Append(' '); // Add space between words
        }
        
        return displayText.ToString().Trim(); // Return the display text 

    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }

    public void WaitAndHideWords()
    {
        int totalWords = _words.Count;
        int wordsHidden = 0;
        
        Console.WriteLine("Press Enter to hide a random number of words or type 'quit' to exit.");
        
        while (true)
        {
            string userInput = Console.ReadLine();
            
            if (userInput.ToLower() == "quit" || (wordsHidden == totalWords && string.IsNullOrEmpty(userInput)))
            {
                Console.WriteLine("Exiting program...");
                break;
            }
            else
            {
                int randomNum = new Random().Next(1, totalWords - wordsHidden + 1);
                HideRandomWords(randomNum);
                wordsHidden += randomNum;
                
                Console.WriteLine($"Hidden {randomNum} word(s). Press Enter to continue hiding or type 'quit' to exit.");
            }
            Console.Clear();
        }
    }
}