# Week 6: Text Menu App - Study Notes

**Name:** Student

## Loop Types

**How is a `do-while` loop different from a `while` loop?**
[Explain when each loop is best used]

Answer: A `do-while` loop always executes its body at least once before checking the condition, while a `while` loop checks the condition first and may never execute. Use `do-while` when you need to prompt for input at least once, and `while` when you may need to skip the loop entirely.

**Where did you use a `do-while` loop in this assignment and why?**
[Describe how you validated the menu choice and numeric inputs]

Answer: I used `do-while` loops inside `ReadIntInRange` and `ReadDouble` helper methods. These loops guarantee that the user is prompted at least once, and then repeat if the input is invalid or out of range.

**Where did you use a `while` loop and why?**
[Describe the menu loop and why it repeats]

Answer: I used a `while` loop for the main menu. The condition `while (choice != 6)` keeps the menu running until the user picks Exit.

**Where did you use a `for` loop and why?**
[If you didn't use a for loop, explain why it wasn't needed]

Answer: I did not use a `for` loop in this assignment. The menu requires indefinite repetition based on user input rather than a fixed count, so `while` and `do-while` were better choices.

## Input Validation

**Why did you create a helper method for input validation?**
[Explain how it avoids repeating code for multiple prompts]

Answer: The helper methods `ReadIntInRange` and `ReadDouble` avoid repeating the same `do-while` validation logic every time I need a number. The menu choice, quantity, and banner width all need integer validation with range checks.

**How did you validate the menu choice (1–6)?**
[Explain your range check logic and do-while loop]

Answer: I called `ReadIntInRange("Choose an option (1-6): ", 1, 6)`. Inside the helper, a `do-while` loop uses `int.TryParse` and checks `value < min || value > max`. If either check fails, an error message is shown and the loop repeats.

**How did you handle invalid input (non-numbers)?**
[Explain how int.TryParse and double.TryParse work]

Answer: `int.TryParse(Console.ReadLine(), out value)` attempts to convert the string to an integer and returns `false` if it fails without throwing an exception, so the program can show a friendly error and try again.

## String Operations

**Which string methods did you use across the different menu options?**
[List key methods like Trim, ToUpper, ToLower, Replace, Split, Join, Contains, PadLeft, PadRight, and formatting techniques]

Answer: I used `Trim()` on all user inputs, `ToUpper()` for uppercase versions, `ToLower()` for lowercase output, `Replace()` to swap spaces with dashes, `Split()` to break a phrase into words, `string.Join()` to reassemble words as comma-separated list, `Contains()` to check for a letter, `PadLeft()` and `PadRight()` for alignment, and `string.Format()` with alignment and currency specifiers for the receipt.

**Which four string methods did you demonstrate in Option 6 (String Analysis)?**
[Explain Equals with StringComparison, Substring, EndsWith, and IndexOf]

Answer: Option 6 uses `Equals("goodbye", StringComparison.OrdinalIgnoreCase)` for case-insensitive comparison, `Substring(0, 3)` to extract the first three characters, `EndsWith("!")` to check for an exclamation mark, and `IndexOf(' ')` to find the position of the first space.

**What's the difference between string concatenation and interpolation?**
[Explain when you used each approach and which you prefer]

Answer: Concatenation joins strings with the `+` operator, for example `firstName + " " + lastName`. Interpolation uses `$"..."` syntax with `{}` expressions. I used both and prefer interpolation because it is easier to read.

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1. Using do-while loops is ideal for input validation because they always execute at least once.
2. Helper methods reduce repetition and make code easier to maintain.
3. String methods like PadLeft, PadRight, and string.Format with alignment specifiers give precise control over console layout.
4. StringComparison.OrdinalIgnoreCase makes string comparisons case-insensitive without manually converting case.
5. Always check string length before calling `Substring` to avoid out-of-range exceptions.

**Which loop felt most natural to use and why?**

Answer: The `while` loop felt most natural for the main menu because the exit condition is checked before each iteration, which mirrors how I think about the program flow.

## Time Spent

**Total time:** 3 hours

**Breakdown:**

- Planning the loops: 0.5 hours
- Input validation: 0.5 hours
- String formatting: 1 hour
- Testing and debugging: 0.5 hours
- Writing documentation: 0.5 hours

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: String formatting for the receipt and banner options took the most time because getting alignment specifiers and the currency format to display correctly required careful testing.

## Reflection

**What would you do differently next time?**

Answer: I would sketch the expected output for each menu option before writing any code, so I know exactly what strings I need to produce.

**How did using three different loop types improve your understanding of repetition?**

Answer: Comparing `while`, `do-while`, and `for` loops made it clear that each type suits a different situation. Knowing which one to pick makes code more readable and prevents common bugs.
