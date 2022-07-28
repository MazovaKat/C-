int FindWordCount(string[] words, string[] letter) 
{
    int count = 0;
    for (int i = 0; i < words.Length; i++)
    {   for (int j = 0; j < letter.Length; j++)
        if(words[i][0] == letter[j][0]) 
        count = count + 1;
    }
    return count;
}

string[] names = {"qwe", "wer", "ert", "rty", "tyu"};
string[] letters = {"a", "e", "i", "o", "u", "y"};

Console.WriteLine(FindWordCount(names, letters));


