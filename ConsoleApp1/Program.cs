while (true)
{
    string? str = "", newSentence = "";

    Console.WriteLine("Enter Text");

    while (str == "" || str == null)
    {
        string getValue = Console.ReadLine() ?? "";

        if (getValue != "" || getValue != null)
        {
            str = getValue.Trim();
        }
        else
        {
            Console.WriteLine("Please Enter A Value");
        }
    }

    foreach (string word in str.Split(" "))
    {
        string thisWord = word;
        char firstLitter = word[0];
        char firstLetterUppercased = Convert.ToChar((Convert.ToString(firstLitter)).ToUpperInvariant());

        thisWord = word.Substring(0, 1).Replace(firstLitter, firstLetterUppercased) + word.Substring(1);

        newSentence += (newSentence.Length > 0 ? " " : "") + thisWord;
    }

    Console.WriteLine("\n\n{0}\n\n", newSentence);
}