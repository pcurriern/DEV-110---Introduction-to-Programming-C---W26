# Week 8: Mad Libs (Structure + Debugging) - Study Notes

**Name:** Parker Currier

## Program Structure

**What helper methods did you create (and what does each one do)?**
[List your methods and briefly describe each]

Answer: I created helper methods to choose a template, collect words, validate input, and build the final story.

**Why is it helpful to move code out of `Main` and into helper methods?**
[Explain how this improves readability and reduces bugs]

Answer: It keeps the program cleaner and makes each part easier to fix and understand.

## Data Modeling

**What is the purpose of the `StoryTemplate` class in this assignment?**
[Explain what data it stores and why]

Answer: It holds the prompts and story format so every template follows the structure.

**How did using a template make it easier to support two different stories?**
[Explain how the same logic can work with different prompts/text]

Answer: Both stories plug into the same sytem, so I didnt need to seperate logic for each one.

## Testing and Debugging

**Where did you set a breakpoint while debugging this program (what line or method)?**
[Be specific - example: inside GenerateStory, at the beginning of CollectWords, etc.]

Answer: I put a breakpoint at the start of CollectWords() to watch how the input was being stored.

**What did you learn from stepping through your code line by line?**
[Describe how watching execution helped you understand flow or find bugs]

Answer: It helped me see the exact order everything was running in and where things didnt line up.

**What bug or logic mistake did you encounter (and how did you fix it)?**
[Describe a real issue you ran into and how breakpoints/stepping helped]

Answer: The most challenging part was getting comfortable with how each method connected so the program ran smoothly.

## What I Learned

**Key takeaways from this week:**
1. Breaking down the code by each todo makes it way easier to manage.

2. Debugging tools make things much easier to spot.

3. Templates let different stories share the same workflow.


**What part of this assignment helped you understand program structure the most?**
[Breaking into methods, using public/private methods, separating concerns, etc.]

Answer: Seperating the program into focused methods made the overall flow much cleaner.

## Time Spent

**Total time:** [8 hours]

**Breakdown:**

- Planning structure (methods/classes): [4 hours]
- Input validation: [1 hours]
- Story templates + formatting: [1.5 hours]
- Testing and debugging: [1 hours]
- Writing documentation: [.5 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: The most time‑consuming part was getting used to how all the helper methods worked together so the program ran smoothly.

## Reflection

**What would you improve if you had more time?**
[Ideas: more templates, better formatting, more validation, etc.]

Answer: Better formatting.

**How did breaking your program into smaller parts help you debug?**
[Explain the connection between structure and debugging]

Answer: This made it easier to debug because I could go line by line and review my code.
