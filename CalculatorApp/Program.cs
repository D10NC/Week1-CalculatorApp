using System.Xml.Serialization;

CalculatorApp();

void CalculatorApp()
{

    // Declare the variables and initialise them to 0.
    int firstNumber = 0;
    int secondNumber = 0;
    int choice = 0;
    int result = 0;

    // Ask the user to type the first number.
    Console.WriteLine("Type in the first number followed by the Enter key");
    firstNumber = Convert.ToInt32(Console.ReadLine());


    // Ask the user to type the second number.
    Console.WriteLine("Type in the second");
    secondNumber = Convert.ToInt32(Console.ReadLine());

    // Use a loop to make the relevant decision based on the user input.
    // Perform the relevant calculation based on the user input.

    Console.WriteLine("Choose an option from the following list:");
    Console.WriteLine("1. Add");
    Console.WriteLine("2. Subtract");
    Console.WriteLine("3. Multiply");
    Console.WriteLine("4. Divide");

    choice = Convert.ToInt32(Console.ReadLine());

    if (choice == 1)
    {
        result = firstNumber + secondNumber;
        Console.WriteLine($"Adding {firstNumber} and {secondNumber} equals {result}");
    }

    else if (choice == 2)
    {
        result = firstNumber + secondNumber;
        Console.WriteLine($"Dividing {firstNumber} and {secondNumber} equals {result}");
    }

    else if (choice == 4)
    {
        result = firstNumber + secondNumber;
        Console.WriteLine($"Multiplying {firstNumber} and {secondNumber} equals {result}");
    }

    else
    {
        Console.WriteLine("You did not select a valid number between 1-4");
    }




    // Output the answer to the console
    Console.WriteLine("The result is: {result}", result);
    Console.ReadKey();
}
