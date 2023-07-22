Console.WriteLine(InvertPhrase("Good afternoon"));
Console.WriteLine(InvertPhrase("Hello, how are you?"));
Console.WriteLine(InvertPhrase("Are you twenty-one years old?"));

string InvertPhrase(string phrase)
{
    var words = phrase.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

    var invertedWords = new string[words.Length];

    for (int i = 0; i < words.Length; i++)
    {
        var word = words[i];

        if (char.IsPunctuation(word[word.Length - 1]))
        {
            var punctuation = word.Last();

            word = word.Substring(0, word.Length - 1);

            if ((i + 1) >= words.Length)
            {
                invertedWords[i] = $"{punctuation}{word}{invertedWords[i]}";
            }
            else
            {
                invertedWords[i + 1] = $"{punctuation}";
                invertedWords[i] = $"{word}";
            }

        }
        else
        {
            invertedWords[i] = $"{word}{invertedWords[i]}";
        }
    }

    Array.Reverse(invertedWords);

    return string.Join(" ", invertedWords);
}