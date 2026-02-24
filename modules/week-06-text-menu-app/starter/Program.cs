/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: YourName
- Assignment: Week 6: Text Menu App
-
- What does this program do?:
- Runs a text-heavy menu app that demonstrates string formatting and output patterns.
- */

namespace TextMenuApp;

public class Program
{
    public static void Main(string[] args)
    {
        // TODO 1: Build a title banner using strings
        string title = "Text Menu Studio";
        string subtitle = "Strings + Console Output Patterns";
        string divider = new string('=', 48);

        Console.WriteLine(divider);
        Console.WriteLine(title.ToUpper());
        Console.WriteLine(subtitle);
        Console.WriteLine(divider);

        int choice = 0;

        // TODO 2: Create a menu loop that repeats until user chooses 6 (Exit)
        while (choice != 6)
        {
            // TODO 3: Print the menu box
            Console.WriteLine();
            Console.WriteLine("+------------------------------------------------+");
            Console.WriteLine("| 1) Greeting Card                               |");
            Console.WriteLine("| 2) Name Tag Formatter                          |");
            Console.WriteLine("| 3) Phrase Analyzer                             |");
            Console.WriteLine("| 4) Fancy Receipt Line                          |");
            Console.WriteLine("| 5) Menu Banner Builder                         |");
            Console.WriteLine("| 6) Exit                                        |");
            Console.WriteLine("+------------------------------------------------+");

            // TODO 4: Get menu choice from user
            choice = ReadIntInRange("Choose an option (1-6): ", 1, 6);

            // TODO 5: Use a switch statement to handle each menu option
            switch (choice)
            {
                case 1:
                    // ===== OPTION 1: Greeting Card =====
                    Console.Write("Enter your name: ");
                    string name = (Console.ReadLine() ?? string.Empty).Trim();
                    Console.Write("Enter a short message: ");
                    string message = (Console.ReadLine() ?? string.Empty).Trim();

                    string nameUpper = name.ToUpper();
                    string greeting = "Hello, " + name + "!";
                    string greetingLine = string.Format("Nice to meet you, {0}.", nameUpper);
                    string messageLine = "Message: " + message;

                    string cardBorder = new string('-', 48);
                    Console.WriteLine(cardBorder);
                    Console.WriteLine($"| {greeting,-46}|");
                    Console.WriteLine($"| {greetingLine,-46}|");
                    Console.WriteLine($"| {messageLine,-46}|");
                    Console.WriteLine(cardBorder);
                    break;

                case 2:
                    // ===== OPTION 2: Name Tag Formatter =====
                    Console.Write("Enter first name: ");
                    string firstName = (Console.ReadLine() ?? string.Empty).Trim();
                    Console.Write("Enter last name: ");
                    string lastName = (Console.ReadLine() ?? string.Empty).Trim();

                    string fullName = firstName + " " + lastName;
                    string initials = ((firstName.Length > 0 ? firstName[0].ToString() : string.Empty) +
                                       (lastName.Length > 0 ? lastName[0].ToString() : string.Empty)).ToUpper();
                    string lowerName = fullName.ToLower();

                    Console.WriteLine($"Name Tag: [{fullName}]");
                    Console.WriteLine($"Initials: {initials}");
                    Console.WriteLine($"Lowercase: {lowerName}");
                    break;

                case 3:
                    // ===== OPTION 3: Phrase Analyzer =====
                    Console.Write("Enter a phrase: ");
                    string phrase = (Console.ReadLine() ?? string.Empty).Trim();

                    int phraseLength = phrase.Length;
                    bool containsA = phrase.ToLower().Contains("a");
                    string dashed = phrase.Replace(" ", "-");
                    string[] words = phrase.Split(' ');
                    string wordList = string.Join(", ", words);

                    Console.WriteLine($"Length: {phraseLength}");
                    Console.WriteLine($"Contains 'a': {containsA}");
                    Console.WriteLine($"Dashed: {dashed}");
                    Console.WriteLine($"Words: {wordList}");
                    break;

                case 4:
                    // ===== OPTION 4: Fancy Receipt Line =====
                    Console.Write("Enter item name: ");
                    string itemName = (Console.ReadLine() ?? string.Empty).Trim();
                    double price = ReadDouble("Enter price: ");
                    int quantity = ReadIntInRange("Enter quantity (1-9): ", 1, 9);

                    double total = price * quantity;

                    string totalFormatted = "$" + total.ToString("F2");
                    Console.WriteLine(string.Format("{0,-20} {1,5} {2,10}", "ITEM", "QTY", "TOTAL"));
                    Console.WriteLine(string.Format("{0,-20} {1,5} {2,10}", itemName, quantity, totalFormatted));
                    break;

                case 5:
                    // ===== OPTION 5: Menu Banner Builder =====
                    Console.Write("Enter a title: ");
                    string bannerTitle = (Console.ReadLine() ?? string.Empty).Trim();
                    Console.Write("Enter a subtitle: ");
                    string bannerSubtitle = (Console.ReadLine() ?? string.Empty).Trim();
                    int width = ReadIntInRange("Enter width (30-60): ", 30, 60);

                    string bannerBorder = new string('=', width);
                    string titleUpper = bannerTitle.ToUpper();
                    string centeredTitle = titleUpper.PadLeft((width + titleUpper.Length) / 2);
                    string centeredSubtitle = bannerSubtitle.PadLeft((width + bannerSubtitle.Length) / 2);

                    Console.WriteLine(bannerBorder);
                    Console.WriteLine(centeredTitle);
                    Console.WriteLine(centeredSubtitle);
                    Console.WriteLine(bannerBorder);
                    Console.WriteLine($"Centered: {centeredTitle.Trim()}");
                    Console.WriteLine($"Left:     {titleUpper}");
                    Console.WriteLine($"Right:    {titleUpper.PadLeft(width)}");
                    break;

                case 6:
                    // ===== OPTION 6: Exit with String Analysis =====
                    Console.Write("Enter a closing word: ");
                    string closingWord = (Console.ReadLine() ?? string.Empty).Trim();

                    bool isGoodbye = closingWord.Equals("goodbye", StringComparison.OrdinalIgnoreCase);
                    string firstThree = closingWord.Length >= 3 ? closingWord.Substring(0, 3) : closingWord;
                    bool hasExclamation = closingWord.EndsWith("!");
                    int spaceIndex = closingWord.IndexOf(' ');

                    Console.WriteLine($"Is 'goodbye': {isGoodbye} | First 3: '{firstThree}' | Has !: {hasExclamation} | Space at: {spaceIndex}");
                    Console.WriteLine("Goodbye!");
                    break;
            }

            // TODO 6: Add a blank line between menu actions (but not after Exit)
            if (choice != 6)
            {
                Console.WriteLine();
            }
        }
    }

    private static int ReadIntInRange(string prompt, int min, int max)
    {
        // TODO 7: Implement input validation using a do-while loop with int.TryParse()
        int value;
        bool isValid;

        do
        {
            Console.Write(prompt);
            isValid = int.TryParse(Console.ReadLine(), out value);

            if (!isValid || value < min || value > max)
            {
                Console.WriteLine($"Please enter a valid number between {min} and {max}.");
            }
        }
        while (!isValid || value < min || value > max);

        return value;
    }

    private static double ReadDouble(string prompt)
    {
        // TODO 8: Implement input validation using a do-while loop with double.TryParse()
        double value;
        bool isValid;

        do
        {
            Console.Write(prompt);
            isValid = double.TryParse(Console.ReadLine(), out value);

            if (!isValid)
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
        while (!isValid);

        return value;
    }
}
