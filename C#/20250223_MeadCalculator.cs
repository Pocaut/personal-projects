//Simple Mead calculator i made for personal use.
float total = 0;
Console.WriteLine("Total mL amount:");
total = float.Parse(Console.ReadLine());
float water = total*0.75f;
float honey = total*0.25f;
float yeast = total/750;
Console.WriteLine($"Water amount:: {water}mL.");
Console.WriteLine($"Honey amount: {honey}mL.");
Console.WriteLine($"Yeast amount: {yeast}g.");
