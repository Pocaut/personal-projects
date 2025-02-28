//Simple practice for Method that returns a value. (i forgot)
int RandomNumber() {
    Random random = new Random();
    return random.Next(1,10);
}

Console.WriteLine(RandomNumber());