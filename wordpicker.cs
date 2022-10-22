// Class to create a list with words and return a random word from it
public class WordPicker {
    List<string> wordsList = new List<string>();
    string randomWord = null!;
    int index;
    Random random = new Random();
    
    public WordPicker() {
        wordsList.Add("dog");
        wordsList.Add("cat");
        wordsList.Add("bird");
        wordsList.Add("duck");

        index = random.Next(wordsList.Count);
    }

    
    public string pickRandomWord() {
        return wordsList[index];
    }
}