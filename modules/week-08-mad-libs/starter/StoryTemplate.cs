/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: YourName
- Assignment: Week 8: Mad Libs (Structure + Debugging)
-
- What does this program do?:
- Represents a Mad Libs story template with prompts and story text.
- */

namespace MadLibs;

public class StoryTemplate
{
    public StoryTemplate(string title, string[] prompts, string templateText)
    {
        Title = title;
        Prompts = prompts;
        TemplateText = templateText;
    }

    public string Title { get; }

    public string[] Prompts { get; }

    public string TemplateText { get; }

    public string GenerateStory(string[] words)
    {
        if (words.Length != Prompts.Length)
        {
            throw new ArgumentException("Word count does not match prompts.");
        }

        return FormatStory(words);
    }

    private string FormatStory(string[] words)
    {
        object[] values = new object[words.Length];
        for (int i = 0; i < words.Length; i++)
        {
            values[i] = words[i];
        }

        return string.Format(TemplateText, values);
    }
}

public class DebuggingAtTheZooTemplate : StoryTemplate
{
    public DebuggingAtTheZooTemplate()
        : base(
            "Debugging at the Zoo",
            new[]
            {
                "Enter an adjective: ",
                "Enter an animal (plural): ",
                "Enter a verb ending in -ing: ",
                "Enter a programming language: ",
                "Enter a debugging tool (example: breakpoint): ",
                "Enter a number: ",
                "Enter an emotion: ",
                "Enter an exclamation: ",
            },
            "Today I visited the {0} zoo. I saw {1} {2} while writing {3}. I used a {4} {5} times until the bug disappeared. I felt {6} and yelled, \"{7}!\"")
    {
    }
}

public class StandupMeetingTemplate : StoryTemplate
{
    public StandupMeetingTemplate()
        : base(
            "The Standup Meeting",
            new[]
            {
                "Enter a name: ",
                "Enter an adjective: ",
                "Enter a noun: ",
                "Enter a verb (past tense): ",
                "Enter a number: ",
                "Enter a plural noun: ",
                "Enter a type of bug (example: null reference): ",
                "Enter a snack: ",
            },
            "At standup, {0} gave a {1} update about a {2} that {3} {4} times. The team tracked down {6}, closed {5}, and celebrated with {7}.")
    {
    }
}
