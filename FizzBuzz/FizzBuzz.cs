using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FizzBuzzService;

//I worked with one class but it can be interface and we can have 3 classes which can be in contract with our interface
public class FizzBuzz
{
    //In our class we have 3 functions for Fizz, Muzz, Dog
    public List<string> FuncFizzBuzz(List<int> numbers)
    {
        List<string> result = new List<string>();

        foreach (int number in numbers)
        {
            if (number % 3 == 0 && number % 5 == 0)
                result.Add("fizz-buzz");
            else if (number % 3 == 0)
                result.Add("fizz");
            else if (number % 5 == 0)
                result.Add("buzz");
            else
                result.Add(number.ToString());
        }

        return result;
    }

    public List<string> FuncMuzzGuzz(List<int> numbers)
    {
        List<string> result = new List<string>();

        foreach (int number in numbers) 
        {
            if (number % 4 == 0 && number % 7 == 0)
                result.Add("muzz-guzz");
            else if (number % 4 == 0)
                result.Add("muzz");
            else if (number % 7 == 0)
                result.Add("guzz");
            else
                result.Add(number.ToString()); 
        }
        return result;
    }

    public List<string> FuncDogCat(List<int> numbers)
    {
        List<string> result = new List<string>();

        foreach (int number in numbers)
        {
            if (number % 4 == 0 && number % 7 == 0)
                result.Add("good-boy");
            else if (number % 3 == 0)
                result.Add("dog");
            else if (number % 5 == 0)
                result.Add("cat");
            else
                result.Add(number.ToString());
        }
        return result;
    }
}
