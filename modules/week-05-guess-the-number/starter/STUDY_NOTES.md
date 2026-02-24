# Week 5: Guess the Number - Study Notes

**Name:** Parker Currier

## Loop Types

**How is a `do-while` loop different from a `while` loop?**
[Explain when each loop is best used]

Answer: while loop the condition is test before the code inside the loop runs. do-while runs the code before the
condition is checked.

**Where did you use a `do-while` loop in this assignment and why?**
[Describe the input validation use]

Answer:I used it in the ReadIntInRange method to keep prompting the user for input until they provided a valid number within the allowed range.

**Where did you use a `while` loop and why?**
[Describe the guessing loop]

Answer: I used it for the guessing phase because I didn't know how many tries it would take the player to find the secret number.

**Where did you use a `for` loop and why?**
[Describe the rounds loop]

Answer: I used it to control the number of rounds, as that was a fixed count the user decided at the start.

## Input Validation

**Why did you create a helper method for input validation?**
[Explain how it avoids repeating code for max value and rounds]

Answer: It let me reuse the same logic for both the max value and the round count

**How did you make sure the max value was between 10 and 100?**
[Explain your range check logic]

Answer: I checked the input against the min and max parameters in the loop condition, forcing a retry if the number was less than 10 or greater than 100.

**How did you make sure the number of rounds was between 1 and 3?**
[Explain your range check logic]

Answer:I passed 1 and 3 into the helper method, which blocked any numbers outside that specific window.

**How did you handle invalid input (non-numbers)?**
[Explain how int.TryParse works]

Answer: I used int.TryParse, which returns a true/false value so I could catch letters or symbols without the program crashing.

## Guessing Logic

**How did you compare the guess to the secret number?**
[Explain the if/else logic for too low, too high, and correct]

Answer:I used an if/else block to check if the guess was higher or lower than the secret, providing the specific feedback for each.

**How did you count the number of guesses?**
[Explain where you incremented the counter]

Answer:I initialized a counter to zero at the start of each round and incremented it by one every time the player made a valid guess.

## Random Numbers

**How did you generate the secret number?**
[Explain Random and Next(min, max)]

Answer: I used the Random.Next method, providing 1 as the minimum and the user's max value as the upper limit.

**Why does `Random.Next(1, max + 1)` include the max value?**
[Explain why +1 is needed]

Answer:Because the second number in Next() is exclusive, so you have to add+1 to make the actual maximum value a possible result.

## Testing and Debugging

**What inputs did you test to confirm your loops worked correctly?**
[List several test cases]

Answer: I tested numbers outside the boundaries.

**What bugs or errors did you encounter and fix?**
[Describe any logic or loop errors]

Answer:I originally forgot to reset the guess count at the start of each round, so the total kept carrying over from the previous game.

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1. How to use int.TryParse to build "crash-proof" code.
2. When to pick a for loop over a while loop.
3. The difference between exclusive and inclusive bounds in randomizing.
4.
5.

**Which loop felt most natural to use and why?**

Answer:The for loop felt best because it keeps the counter and condition all in one clean line.

## Time Spent

**Total time:** 7 hours

**Breakdown:**

- Planning the loops: [1 hours]
- Input validation: [1 hours]
- Guessing logic: [2 hours]
- Testing and debugging: [1 hours]
- Writing documentation: [2 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer:Writing the documentation properly took the most time because I kept running into errors.

## Reflection

**What would you do differently next time?**

Answer:I would try to add a "play again" feature at the end so the user doesn't have to restart the whole program.

**How did using three different loop types improve your understanding of repetition?**

Answer:It forced me to see that while all loops can technically do the same things, certain ones make the code much easier to read for specific tasks.
