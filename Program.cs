Console.WriteLine("Hej, vänligen ange ett ord ");

string word = Console.ReadLine().ToLower();


for (int i = (word.Length) -1; i >= 0; i--)
{
    Console.Write(word[i]);
}

