/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: Parker Currier
- Assignment: Week 8: Mad Libs (Structure + Debugging)
-
- What does this program do?:
- Runs a two-template Mad Libs app that practices structure and debugging.
- */

namespace MadLibs;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Mad Libs: Structure + Debugging ===");
        Console.WriteLine();

        // TODO 1: Implement the main game loop
        // The loop should:
        // - Let player choose a template
        // - Collect words for the template
        // - Generate and display the story using template.GenerateStory()
        // - Ask if the player wants to play again
        // - Repeat if they answer 'y'
        bool playAgain;
        do
        {
            StoryTemplate template = ChooseTemplate();
            Console.WriteLine();

            string[] words = CollectWords(template);

            string story = template.GenerateStory(words);
            Console.WriteLine(story);
            Console.WriteLine();

            playAgain = ReadYesNo("Play again? (y/n): ");
            Console.WriteLine();
        }
        while (playAgain);
    }

    // TODO 2: Implement ChooseTemplate
    // This method should:
    // - Print the two template options:
    private static StoryTemplate ChooseTemplate()
    {
        Console.WriteLine("Choose a template:"); // - Print the two template options:
        Console.WriteLine("1) Debugging at the Zoo"); //   1) Debugging at the Zoo
        Console.WriteLine("2) The Standup Meeting");//   2) The Standup Meeting

        int choice = ReadIntInRange("Choose a template (1-2): ", 1, 2); // - Use ReadIntInRange to get user's choice (1-2)

        if (choice == 1)
        {
            return new DebuggingAtTheZooTemplate(); // - Return the appropriate StoryTemplate (see template details in README)
        }
        else
        {
            return new StandupMeetingTemplate();
        }
    }

    // TODO 3: Implement CollectWords
    // This method should:
    private static string[] CollectWords(StoryTemplate template)
    {
        Logger.Info("Starting word collection..."); // - Use Logger.Info to log that word collection is starting

        string[] words = new string[template.Prompts.Length]; // - Create a string array the same length as template.Prompts

        for (int i = 0; i < template.Prompts.Length; i++)
        {
            words[i] = ReadNonEmptyString(template.Prompts[i]); // - Loop through each prompt and use ReadNonEmptyString
        }

        Console.WriteLine();// - Print a blank line after collection

        return words; // - Return the array of collected words
    }

    // TODO 4: Implement ReadYesNo
    // This method should:
    private static bool ReadYesNo(string prompt)
    {
        while (true)
        {
            Console.Write(prompt); // - Show the prompt
            string input = (Console.ReadLine() ?? string.Empty).Trim().ToLower(); // - Read input (handle null with ?? string.Empty)

            if (input == "y") // - Accept "y" or "n" (case-insensitive)
            {
                return true;
            }
            else if (input == "n") // - Keep asking until valid input is provided
            {
                return false;
            }
            Console.WriteLine("Please enter 'y' or 'n'."); // - Return true for "y", false for "n"
        }
    }

    // TODO 5: Implement ReadIntInRange
    // This method should:
    private static int ReadIntInRange(string prompt, int min, int max)
    {
        int value;
        bool isValid;

        do// - Use a do-while loop
        {
            Console.Write(prompt);// - Show the prompt
            string input = Console.ReadLine() ?? string.Empty;

            isValid = int.TryParse(input, out value) && value >= min && value <= max; // - Read input and use int.TryParse // - Validate the number is between min and max (inclusive)
        }
        while (!isValid);  // - Keep asking until valid

        return value; // - Return the valid integer
    }

    // TODO 6: Implement ReadNonEmptyString
    // This method should:
    private static string ReadNonEmptyString(string prompt)
    {
        while (true)
        {
            Console.Write(prompt); // - Show the prompt
            string input = (Console.ReadLine() ?? string.Empty).Trim(); // - Read input (handle null with ?? string.Empty) - Trim the input

            if (!string.IsNullOrEmpty(input))  // - Keep asking if input is empty or whitespace
            {
                return input; // - Return the valid non-empty string
            }
            Console.WriteLine("Input cannot be empty. Please try again.");
        }
    }
}
