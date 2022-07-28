string[] NewNames(string[] words) 
{
    string[] New = new string[words.Length/2];
    int j = 0;
    for (int i = 0; i <= words.Length-2; i=i+2)
    {   
        New[j] = words[i] + words[i+1];
        j++;
        
    }
    return New;
}    
void Show (string[] a)
{
    for (int i = 0; i < a.Length; i++)
        Console.Write(a[i]+ " ");
}


string[] names = {"qwe", "wer", "ert", "rty", "tyu", "yui"};

Show(NewNames(names));