int num = 1;

while (num <=100)
{
    if(!(num % 3 == 0) && !(num % 5 == 0))
    {
        Console.WriteLine($"Num: {num}");
        num++;
    }

    else if((num % 3 == 0) && (num % 5 == 0))
        {
            Console.WriteLine($"Num: {num} FizzBuzz");
            num++;
        }
    else if(num % 3 == 0)
        {
            Console.WriteLine($"Num: {num} Fizz");
            num++;
        }
    else if(num % 5 == 0)
        {
            Console.WriteLine($"Num: {num} Buzz");
            num++;
        }
}
