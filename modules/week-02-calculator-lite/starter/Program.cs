namespace CalculatorLite;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Calculator Lite ===\n");

        // TODO: Declare variables for storing user input (use descriptive names)
        // Hint: You'll need variables for two numbers, user name, and calculation choice
        string name; //String variable stores users name
        bool useDecimals; //Boolean variable stores user preference for decimals
        double num1, num2; //Double variables store the two numbers input by user
        int calculationCount = 0; //Integer variable counts total calculations performed
        // TODO: Ask for user's name (string) and greet them
        // Example: "Enter your name: " then "Hello, [name]!"
        Console.WriteLine("=== Calculator Lite ===\n"); //Console Writeline outputs title
        Console.WriteLine("Enter your name:"); //Console Writeline prompts user input
        string userName = Console.ReadLine(); //Stores user input as string variable
        Console.WriteLine($"Hello, {userName}!Lets Calculate!!"); //Console Writeline outputs greeting

        // TODO: Ask if they want to use decimals (bool)
        // Example: "Use decimal precision? (yes/no): "
        // Store as boolean (true for yes, false for no)
        Console.WriteLine("Would you like to use decimal precision? (Yes/No):"); //Prompts user input
        string decimalChoice = Console.ReadLine().ToLower(); //Stores user input as string variable and converts to lowercase
        Console.WriteLine($"You selected {decimalChoice} for decimal precision."); //Verifies user selection
        if (decimalChoice == "yes") //If user input is yes
        {
            useDecimals = true; //Sets boolean variable to true
        }
        else
        {
            useDecimals = false; //Sets boolean variable to false
        }
        // TODO: Prompt user for first number (double or int based on choice)
        // If decimals: use double.Parse()
        if (useDecimals)
        {
            Console.WriteLine("Enter the first number (decimal):"); //Prompts user input for decimal number
            num1 = double.Parse(Console.ReadLine()); //Parses user input as double
        }
        else
        {
            Console.WriteLine("Enter the first number (integer):"); //Prompts user input for integer number
            num1 = (double)int.Parse(Console.ReadLine()); //Parses user input as int and casts to double
        }
        // TODO: Prompt user for second number (same type as first)
        if (useDecimals)
        {
            Console.WriteLine("Enter the second number (decimal):"); //Prompts user input for decimal number
            num2 = double.Parse(Console.ReadLine()); //Parses user input as double
        }
        else
        {
            Console.WriteLine("Enter the second number (integer):"); //Prompts user input for integer number
            num2 = (double)int.Parse(Console.ReadLine()); //Parses user input as int and casts to double
        }
        // TODO: Calculate ALL arithmetic operations:
        // - sum (addition: +)
        double sum = num1 + num2; //Calculates the sum
        // - difference (subtraction: -)
        double difference = num1 - num2; //Calculates the difference
        // - product (multiplication: *)
        double product = num1 * num2; //Calculates the product
        // - quotient (division: /)
        double quotient = 0; //Initializes quotient variable
        if (num2 != 0) //Verifies it is not 0
        {
            quotient = num1 / num2; //Calculates the quotient
        }
        // - remainder (modulus: %)
        double remainder = 0; //Remainder variable
        if (num2 != 0)
        {
            remainder = num1 % num2; //Calculates the remainder
        }
        // - average ((num1 + num2) / 2)
        double average = (num1 + num2) / 2; //Calculates the average

        // TODO: Display results with proper formatting
        // Show 2 decimal places: {value:F2}
        // Include descriptive labels for each operation
        Console.WriteLine($"\nResults for {userName}:"); //Outputs results header
        Console.WriteLine($"Sum: {sum:F2}"); //Outputs sum with 2 decimal places
        Console.WriteLine($"Difference: {difference:F2}"); //Outputs difference with 2 decimal places
        Console.WriteLine($"Product: {product:F2}"); //Outputs product with 2 decimal places
        if (num2 != 0) //Checks if second number is not 0
        {
            Console.WriteLine($"Quotient: {quotient:F2}"); //Outputs quotient with 2 decimal places
            Console.WriteLine($"Remainder: {remainder:F2}"); // Outputs remainder with 2 decimal places
        }
        else
        {
            Console.WriteLine("Quotient: Cannot divide by zero."); //Outputs error message for quotient
            Console.WriteLine("Remainder: Cannot calculate remainder."); // Outputs error message for remainder
        }
        Console.WriteLine($"Average: {average:F2}"); //Outputs average with 2 decimal places

        // TODO: Check if second number is zero BEFORE dividing
        // Use if statement: if (num2 == 0) { show error } else { calculate }
        if (num2 == 0) //Checks if second number is 0
        {
            Console.WriteLine("Cannot divide by zero for quotient and remainder calculations."); //Outputs error message
        }
        // TODO: Count total calculations performed (int)
        // Display: "Performed [count] calculations for [name]!"
        calculationCount = 6; //Total calculations performed // sum, difference, product, quotient, remainder, average
        Console.WriteLine($"\nPerformed {calculationCount} calculations for {userName}"); //Outputs total calculations performed
        // TODO: Calculate percentage difference
        // Formula: ((num1 - num2) / num1) * 100 // Display with % symbol
        double percentageDifference = ((num1 - num2) / num1) * 100; //Calculates percentage difference
        Console.WriteLine($"Percentage Difference: {percentageDifference:F2}%");
        // Display with % symbol

        Console.WriteLine("\nThank you for using Calculator Lite!");
    }
}
