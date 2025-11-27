# Practical Work #2
## Variant 3: Score Calculation System

### Task:
The user sequentially enters three integers (points for three game levels). Use Convert.ToInt32() to convert input strings. The program should calculate the total score and average score (real number). Demonstrate boxing of the total score (int type) into an object type and subsequent unboxing back to int before output.

### Implemented Features:

1. **Input with exception handling:**
   - Used Convert.ToInt32() for string to number conversion
   - Handled exceptions: FormatException, OverflowException
   - Implemented retry on errors

2. **Calculations:**
   - Total score calculation (sum)
   - Average score calculation (real number)

3. **Boxing and Unboxing:**
   - Boxing: int ? object
   - Unboxing: object ? int
   - InvalidCastException demonstration

4. **Exception Handling:**
   - FormatException - invalid number format
   - OverflowException - number out of int range
   - InvalidCastException - type casting error

### Key Type Conversion Aspects:

- **Convert.ToInt32()** - converts string to int with exception generation
- **Boxing** - value type to reference type conversion (int ? object)
- **Unboxing** - reference type to value type conversion (object ? int)
- **Explicit casting** - (double)totalScore for real division

### Testing Examples:

**Normal scenario:**

**Error scenario:**
