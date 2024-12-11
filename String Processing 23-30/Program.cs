// Exercise 23:

Console.WriteLine("Enter some text. I will repeat the first 10 characters back to you");
string userInput1 = Console.ReadLine();
string userResult1 = userInput1.Substring(0, 10);
Console.WriteLine(userResult1);

// Exercise 24:

Console.WriteLine("Enter some text. I will repeat the last 10 characters back to you");
string userInput2 = Console.ReadLine();
string userResult2 = userInput2.Substring(userInput2.Length - 10);
Console.WriteLine(userResult2);

// Exercise 25:

Console.WriteLine("Enter a sentence and I will split the sentence into individual words and display each word on its own line");
string userInput3 = Console.ReadLine();
string[] words = userInput3.Split(' ');
foreach (string word in words)
{
    Console.WriteLine(word);
}

// Exercise 26:

Console.WriteLine("Enter some text and I will count and output how many vowels are in the string");
string userInput4 = Console.ReadLine();
int vowelCount = 0;
string vowels = "aeiouAEIOU";
{
    foreach (char vowel in userInput4)
    {
        if (vowels.Contains(vowel))
        {
            vowelCount++;
        }
    }
    Console.WriteLine($"The number of vowels is: {vowelCount}");
}

// Exercise 27:

Console.WriteLine("Enter some text and I will count and output how many consonants are in the string");
string userInput5 = Console.ReadLine();
int consonantCount = 0;
string consonants = "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ";
{
    foreach (char consonant in userInput5)
    {
        if (consonants.Contains(consonant))
        {
            consonantCount++;
        }
    }
    Console.WriteLine($"The number of consonants is: {consonantCount}");
}

// Exercise 28:

Console.WriteLine("Enter some text and I will remove all of the vowels and output the text");
string userInput6 = Console.ReadLine();
string vowels2 = "aeiouAEIOU";
string outputText1 = "";
{
    foreach (char vowel in userInput6)
    {
        if (!vowels2.Contains(vowel))
        {
            outputText1 += vowel;
        }
    }
    Console.WriteLine(outputText1);
}

// Exercise 29:

bool continueProcessing = true;
while (continueProcessing == true)
{
    Console.Write("Enter some text");
    string input = Console.ReadLine();
    string processedText = ProcessText(input);
    Console.WriteLine(processedText);

    Console.Write("Would you like to continue? (y/n)");
    string response = Console.ReadLine().ToLower();
    if (response == "y")
    {
        continueProcessing = true;
    }
    else
    {
        Console.WriteLine("Goodbye!");
        break;
    }
}
static string ProcessText(string text)
{
    string vowels = "aeiouAEIOU";
    string[] words = text.Split(' ');
    for (int i = 0; i < words.Length; i++)
    {
        words[i] = ProcessWord(words[i], vowels);
    }
    return string.Join(" ", words);
}
static string ProcessWord(string word, string vowels)
{
    char[] chars = word.ToCharArray();
    for (int i = 1; i < word.Length - 1; i++)
    {
        if (vowels.Contains(chars[i]))
        {
            chars[i] = '\0';
        }
    }
    return new string(chars).Replace("\0", "");
}

// Exercise 30:

Console.WriteLine("Enter some text and I will reverse it");
string userText = Console.ReadLine();
string reversedText = ReverseText(userText);
Console.WriteLine($"{reversedText}");
static string ReverseText (string text)
{
    char[] charArray = text.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}

