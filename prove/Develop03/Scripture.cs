using System;
using System.Collections.Generic;



public class Scripture

{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    // public Scripture ()
    // {
    //     _reference = new Reference ();
    //     //_words = new List<Word>();

    // }
    
    public Scripture (Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] wordsArray = text.Split(' ');
        foreach (string word in wordsArray)
        {
            _words.Add(new Word(word)); 
        }
    }

    

    public void HideRandomWords(int number)
    {
        Random random = new Random();
        int hiddenCount = 0;
        number = Math.Min(number, _words.Count);

        while (hiddenCount < number)
        {

            int aleatoryX = random.Next (0, _words.Count);
            

            if (!_words[aleatoryX].IsHidden()) 
            {
                _words[aleatoryX].Hide();
                hiddenCount++;
            }
        }
    }

    public string GetDisplayText()
    {
        // List<string> displayWords = new List<string> ();
        string scriptureText = "";
        foreach (Word word in _words)
        {
            scriptureText += word.GetDisplayText() + " ";
        }
        return scriptureText;
        
    }

    public bool IsCompletelyHidden()
{
    
    foreach (Word word in _words)
    {
        if (!word.IsHidden()) 
        {
            return false;
        }
    }
    
    
    return true;
}


}