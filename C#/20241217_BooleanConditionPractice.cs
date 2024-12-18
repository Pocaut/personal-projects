string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

string myValue = "a";
Console.WriteLine(myValue != "a");

string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));
Console.WriteLine(pangram.Contains("Corvo Attano"));

int saleAmount = 1001;
//int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

string word = "Corvo Attano";
string isTheWord = word == "Orvo Cattano" ? "Yes" : "No";
Console.WriteLine(word);
Console.WriteLine($"Is the word Orvo Cattano? {isTheWord}.");