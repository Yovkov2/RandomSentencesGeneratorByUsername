string[] names = { "Peter", "Michell", "Jane", "Steve" };
string[] places = { "Sofia", "Plovdiv", "Varna", "Burgas" };
string[] verbs = { "eats", "holds", "sees", "plays with", "brings" };
string[] nouns = { "stones", "cake", "apple", "laptop", "bikes" };
string[] adverbs = { "slowly", "diligently", "warmly", "sadly", "rapidly" };
string[] details = { "near the river", "at home", "in the park" };
Console.WriteLine("Hello, this is your first random-generated sentence: ");
string GetRandomWord(string[] words)
{
    Random random = new Random();
    int randomIndex = random.Next(words.Length);
    string word = words[randomIndex];
    return word;
}
while (true)
{
    string randomName = GetRandomWord(names);
    string randomPlace = GetRandomWord(places);
    string randomAdverb = GetRandomWord(adverbs);
    string randomVerb = GetRandomWord(verbs);
    string randomNoun = GetRandomWord(nouns);
    string randomDetail = GetRandomWord(details);

    string whoFromWhere = $"{randomName} from {randomPlace}";
    string action = $"{randomAdverb} {randomVerb} {randomNoun}";
    string sentence = $"{whoFromWhere} {action} {randomDetail}";

    Console.WriteLine(sentence);
    Console.WriteLine("Press [Enter] to generate a new sentence...");
    Console.ReadLine();
}
