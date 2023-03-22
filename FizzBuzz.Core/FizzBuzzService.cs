namespace FizzBuzz.Core;
public class FizzBuzzService
{
    public string Print(int number)
    {
        if (IsDivisableByThree(number) && IsDivisableByFive(number))
        {
            return "FizzBuzz";
        }
        else if (IsDivisableByFive(number))
        {
            return "Buzz";
        }
        else if (IsDivisableByThree(number))
        {
            return "Fizz";
        }
        return number.ToString();
    }

    private bool IsDivisableByFive(int number)
    {
        return number % 5 == 0;
    }

    private bool IsDivisableByThree(int number)
    {
        return number % 3 == 0;
    }

}
