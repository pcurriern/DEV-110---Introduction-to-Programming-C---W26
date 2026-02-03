using System.Formats.Asn1;

namespace ProfileCard;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("╔════════════════════════════════════════════╗");
        Console.WriteLine("║         STUDENT PROFILE CARD               ║");
        Console.WriteLine("╚════════════════════════════════════════════╝\n");

        // TODO: Collect PERSONAL INFORMATION (strings)
        // - Full name
        Console.WriteLine("Enter your full name:"); //Prompt user input
        string fullName = Console.ReadLine(); //Stores user input as string variable

        // - Hometown (city, state)
        Console.WriteLine("Enter your hometown (city, state):"); 
        string hometown = Console.ReadLine(); 

        // - Favorite color
        Console.WriteLine("Enter your favorite color:");
        string favoriteColor = Console.ReadLine();

        // - Dream job
        Console.WriteLine("Enter your dream job:");
        string dreamJob = Console.ReadLine();

        // Hint: string variableName = Console.ReadLine();


        // TODO: Collect ACADEMIC INFORMATION
        // - Major (string)
        Console.WriteLine("Enter what your major is:");
        string major = Console.ReadLine();
        // - GPA (double, 0.0-4.0)
        Console.WriteLine("Enter your GPA (0.0 - 4.0):");
        double gpa = double.Parse(Console.ReadLine()); //Parses user input as double
        // - Graduation year (int)
        Console.WriteLine("Enter your graduation year:");
        int graduationYear = int.Parse(Console.ReadLine()); //Parses user input as int
        // - Is full-time student? (bool from yes/no)
        Console.WriteLine("Are you a full-time student? (yes/no):");
        string answer = Console.ReadLine();
        bool isFullTime = answer.ToLower() == "yes"; //Converts user input to boolean
        // Hint: double gpa = double.Parse(Console.ReadLine());
        // Hint: bool isFullTime = answer.ToLower() == "yes";

        // TODO: Collect ADDITIONAL DETAILS
        // - Age (int)
        Console.WriteLine("Enter your age:");
        int age = int.Parse(Console.ReadLine());
        // - Height in inches (double)
        Console.WriteLine("Enter your height in inches:");
        double heightInches = double.Parse(Console.ReadLine());
        // - Favorite number (int)
        Console.WriteLine("Enter your favorite number:");
        int favoriteNumber = int.Parse(Console.ReadLine());

        // TODO: CALCULATE derived information

        // - Birth year = 2026 - age
        int birthYear = 2026 - age;
        // - Years to graduation = graduationYear - 2026
        int yearsToGraduation = graduationYear - 2026;
        // - Height in feet and inches: feet = heightInches / 12, inches = heightInches % 12
        int heightFeet = (int)(heightInches / 12);
        double heightRemainingInches = heightInches % 12;
        // - Is honor student? = gpa >= 3.5
        bool isHonorStudent = gpa >= 3.5;
        // - Age in months = age * 12
        int ageInMonths = age * 12;

        // TODO: DISPLAY formatted profile card
        // Use sections with headers:
        Console.WriteLine("\n═══════════════════════════════════════════");
        Console.WriteLine("               STUDENT PROFILE              ");
        Console.WriteLine("═══════════════════════════════════════════");

        // - PERSONAL INFORMATION
        Console.WriteLine("\n════════════════ PERSONAL INFORMATION ════════════════");
        Console.WriteLine($"Full Name: {fullName}");
        Console.WriteLine($"Hometown: {hometown}");
        Console.WriteLine($"Favorite Color: {favoriteColor}");
        Console.WriteLine($"Dream Job: {dreamJob}");
        Console.WriteLine($"Favorite Number: {favoriteNumber}");

        // - ACADEMIC DETAILS
        Console.WriteLine("\n════════════════ ACADEMIC DETAILS ════════════════");
        Console.WriteLine($"Major: {major}");
        Console.WriteLine($"GPA: {gpa:F2}");
        Console.WriteLine($"Graduation Year: {graduationYear}");
        Console.WriteLine($"Full-Time Student: {(isFullTime ? "Yes" : "No")}");

        // - CALCULATED STATISTICS
        Console.WriteLine("\n════════════════ CALCULATED STATISTICS ════════════════");
        // Use proper alignment and formatting
        Console.WriteLine($"Birth Year: {birthYear}");
        Console.WriteLine($"Years to Graduation: {yearsToGraduation}");
        Console.WriteLine($"Height: {heightFeet} feet {heightRemainingInches:F1} inches");
        Console.WriteLine($"Honor Student: {(isHonorStudent ? "Yes" : "No")}");
        Console.WriteLine($"Age in Months: {ageInMonths}");

        Console.WriteLine("\n═══════════════════════════════════════════");
        Console.WriteLine("Profile complete! Good luck with your studies!");
        Console.WriteLine("\nPress any key to exit...");//Prompt before exit
        Console.ReadKey(); //Waits for user input before closing
    }
}
