
// FUNDAMENTALS PRACTICE ASSIGNMENT 

// 1. Create a loop that prints all values from 1-255.
for (int i = 0; i <= 255; i++)
{
    Console.WriteLine(i);
}

// 2. Create a new loop that generates 5 random numbers between 10 and 20.
Random arbitraree = new Random();
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(arbitraree.Next(2, 8));
}

// 3. Modify the previous loop to add the random values together and print the sum after the loop finishes.
Random arbitrary = new Random();
int totalSum = 0;
for (int i = 0; i < 5; i++)
{
    totalSum += arbitrary.Next(5, 10);
}
Console.WriteLine($"The total sum of the loop is {totalSum}");


// 4. Create a new loop that prints all values from 1 to 100 that are divisible by 3 OR 5, but NOT both.

for (int i = 0; i <= 100; i++)
{
    bool isDivisibleBy3 = i % 3 == 0;
    bool isDivisibleBy5 = i % 5 == 0;
    if( isDivisibleBy3 || isDivisibleBy5)
    {
        Console.WriteLine($"{i} is divisible by 3 or 5.");
    }
}

// 5. Modify the previous loop to print "Fizz" for multiples of 3 and "Buzz" for multiples of 5.
for (int i = 0; i <= 100; i++)
{
    bool isDivisibleBy3 = i % 3 == 0;
    bool isDivisibleBy5 = i % 5 == 0;
    if ( isDivisibleBy3 )
    {
        Console.WriteLine("Fizz");
    }
    else if (isDivisibleBy5)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}
// 6. Modify the previous loop once more to now also print "FizzBuzz" for numbers that are multiples of both 3 and 5.
for (int i = 0; i <= 100; i++)
{
    bool isDivisibleBy3 = i % 3 == 0;
    bool isDivisibleBy5 = i % 5 == 0;
    if ( isDivisibleBy3 && isDivisibleBy5)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (isDivisibleBy3)
    {
        Console.WriteLine("Fizz");
    }
    else if (isDivisibleBy5)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}