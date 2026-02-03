# Week 3: Personal Profile Card - Study Notes

**Name:** Parker Currier

## Understanding Variables and Data Types

**What are the four main data types you used in this assignment?**
[List string, int, double, and bool - explain what each stores and give examples from your profile card]

Answer:
String - stores text such as names and city.
Int - Stores whole numbers such as ages and graduation years.
Double - Stores decimals such as GPA.
Bool - Stores True or False such as if you are a full time student or not.

**Why did you use `double` for GPA instead of `int`?**
[Explain the difference and why decimal precision matters for GPA]

Answer: I used double for GPA as decimal points a cruital in calculating grade point average.

**How did you convert the yes/no input into a boolean?**
[Explain the comparison operation you used]

Answer: I used an equality operator to compare the answer to the string if true or false it allows the result to be stored into a boolean
 Console.WriteLine("Are you a full-time student? (yes/no):");
        string answer = Console.ReadLine();
        bool isFullTime = answer.ToLower() == "yes";

## Data Modeling Decisions

**How did you organize the information into logical groups?**
[Explain why you grouped certain pieces of information together (personal, academic, etc.)]

Answer: I grouped certain information together to keep the profile card structured and easily readable by user.

**Which pieces of information did you calculate rather than ask for?**
[List the derived data: birth year, years to graduation, height conversion, honor status, age in months]

Answer:
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
**Why is it better to calculate birth year from age rather than ask for both?**
[Explain data consistency and reducing redundant input]

Answer: It is easier to just calculate the birth year by subtracting it from current year as it requires less code. This could become an issue if the year changes which someone is using the program.

## Challenges and Solutions

**Biggest challenge with this assignment:**
[What was the hardest part? Type conversion, calculations, formatting, choosing data types?]

Answer: I had a hard time formatting my code at the end and getting it to produce the profile card. My solution was to group everything together in sections as you had presented in the starter code. I realized I was missing my int age line and that was flagging errors.

**How you solved it:**
[Explain your approach to overcoming the challenge]

Answer: I did a little bit of research and also asked ai

**Most confusing concept:**
[What was hardest to understand? Type casting, modulus for height, boolean logic, or formatting?]

Answer: Boolean logic has been difficult but it becomes more simple when you take a step back and look at its overall function.

## Type Conversion and Calculations

**How do you convert string input to a number?**
[Explain Parse methods: int.Parse(), double.Parse()]

Answer:  int.Parse() would convert into whole numbers and double.parse() would convert into decimals.

**What calculation did you use to convert height from inches to feet and inches?**
[Explain: feet = inches / 12, remaining = inches % 12]

Answer:   int heightFeet = (int)(heightInches / 12);
        double heightRemainingInches = heightInches % 12;

**How did you determine if someone is an honor student?**
[Explain the boolean comparison: gpa >= 3.5]

Answer:  // - Is honor student? = gpa >= 3.5
        bool isHonorStudent = gpa >= 3.5;
        To determine if someone is an honor student I used bool and if the gpa was greater than 3.5

## Output Formatting

**How did you format the GPA to show exactly 2 decimal places?**
[Explain the :F2 format specifier]

Answer:The F stands for Fixed number and the 2 tells the computer to round the number and display two decimal points
 Console.WriteLine("Enter your GPA (0.0 - 4.0):");
        double gpa = double.Parse(Console.ReadLine());
           Console.WriteLine($"GPA: {gpa:F2}");

**How did you display different text based on whether someone is full-time or part-time?**
[Explain the conditional/ternary operator you used]

Answer:
        Console.WriteLine("Are you a full-time student? (yes/no):");
        string answer = Console.ReadLine(); //Stores user input as string variable
        bool isFullTime = answer.ToLower() == "yes"; //Converts user input to boolean
  Console.WriteLine($"Full-Time Student: {(isFullTime ? "Yes" : "No")}");

**What techniques did you use to make the output look organized?**
[Discuss alignment, spacing, section headers, borders]

Answer: I used your same spacing from the top of the starter code.
  Console.WriteLine("\n════════════════ PERSONAL INFORMATION ════════════════")

## Real-World Data Modeling

**What other calculated fields could you add to a profile?**
[Think of other derived data: BMI from height/weight, time to birthday, etc.]

Answer: Time to birthday would be cool as mine is approaching and it thought I was born in 2002 instead of 2001.

**Why is choosing the right data type important in real applications?**
[Explain memory, precision, and type safety]

Answer: This is very important especially when using numbers in instances such as gpa you could throw of the entire
result using int instead of double.

**How does this profile card relate to real-world applications?**
[Think about social media profiles, job applications, student records systems]

Answer: I think of this almost like a linkedin or facebook profile and how its structured.

## What I Learned

**Key takeaways from this week:**
[What are the 3-5 most important things you learned about variables and data modeling?]

1. Learned Int and how it is important when using whole numbers
2. Learned how crucial double is when working with decimals
3. Learned how to use bool statements when working with yes or no
4. How to take a step back to overcome when errors might be happening
5. How to format data to produce an output

**Which data type was most challenging to work with and why?**
[Reflect on your experience with string, int, double, or bool]

Answer: Bool was probably the most challenging for me especially when converting from a string.

**How does understanding data types help you write better programs?**
[Explain the benefits of type safety and appropriate data representation]

Answer: This helps me work effectively as I know which each data type does resulting in me not having to go back and
correct errors.

## Testing and Debugging

**What test cases did you use to verify your calculations?**
[List different inputs you tested - edge cases, typical values, etc.]

Answer: I used different ages even put text where numbers belonged.

**What bugs or errors did you encounter and fix?**
[Describe any type conversion errors, calculation mistakes, or formatting issues]

Answer: I was having an error with my age not showing up correctly.

**How did you validate that your data types were correct?**
[Explain how you checked that GPA, heights, ages worked correctly]

Answer: I verfied by checking both higher and lower GPAS to see if it would result in honorary student or not.

## Time Spent

**Total time:** 7 hours

**Breakdown:**

-   Understanding data types and planning variables: [2 hours]
-   Collecting user input with correct types: [.5 hours]
-   Implementing calculations: [2 hours]
-   Formatting output: [.5 hours]
-   Testing and debugging: [.5 hours]
-   Writing documentation: [1 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: Most time consuming part was planning variables and inplementing calculations.

## Reflection

**What would you do differently if you started over?**
[Consider variable names, calculation order, organization, etc.]

Answer: I would write down on a piece of paper all the variable names.

**How does proper data modeling make programs easier to maintain?**
[Think about readability, consistency, and reducing errors]

Answer: Readability is a big takeaway here it enables you to work more effectively and go back to correct errors.

**What real-world system would you like to model next?**
[Shopping cart, game character, recipe calculator, etc.]

Answer: I would like to model a game character I find that very fascinating
