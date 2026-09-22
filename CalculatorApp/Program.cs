Console.WriteLine("Type in the first number followed by the Enter key");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Type in the second");
int secondNumber = Convert.ToInt32(Console.ReadLine());



int result = firstNumber + secondNumber;

Console.WriteLine("Adding {0} and {1} gives you {2}", firstNumber, secondNumber, result);
Console.ReadKey();
