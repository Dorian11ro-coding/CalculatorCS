// See https://aka.ms/new-console-template for more information

Console.WriteLine("For additions, press 1");
Console.WriteLine("For subtractions, press 2");
Console.WriteLine("For multiplications, press 3");
Console.WriteLine("For divisions, press 4");

int choice = int.Parse(Console.ReadLine());

if (choice == 1)
{
    Console.WriteLine("Num 1: ");
    int num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Num 2: ");
    int num2 = int.Parse(Console.ReadLine());
    int sum = num1 + num2;
    Console.WriteLine("Addition is " + sum);

}

if (choice == 2)
{
    Console.WriteLine("Num 1: ");
    int num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Num 2: ");
    int num2 = int.Parse(Console.ReadLine());
    int sum = num1 - num2;
    Console.WriteLine("Subtraction is " + sum);
}

if (choice == 3)
{
    Console.WriteLine("Num 1: ");
    int num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Num 2: ");
    int num2 = int.Parse(Console.ReadLine());
    int sum = num1 * num2;
    Console.WriteLine("Multiplication is " + sum);
}

if (choice == 4)
{
    Console.WriteLine("Num 1: ");
    int num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Num 2: ");
    int num2 = int.Parse(Console.ReadLine());
    int sum = num1 / num2;
    Console.WriteLine("Division is " + sum);
}