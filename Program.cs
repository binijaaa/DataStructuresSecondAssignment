using System.Runtime.InteropServices;
using System.Collections;

namespace DataStructuresSecondAssignment
{
    internal class Program
    {
        static bool IsPalindrome(string names)
        {
            // Convert string to lowercase
            names = names.ToLower();

            // Remove all non-alphanumeric characters
            names = System.Text.RegularExpressions.Regex.Replace(names, "[^a-z0-9]", "");

            // Compare first and last characters, second and second-to-last characters, etc.
            for (int i = 0; i < names.Length / 2; i++)
            {
                if (names[i] != names[names.Length - i - 1])
                {
                    return false;
                }
            }

            return true;
        }

        static void Main()
        {
            //1. string[] values = { "Mom", "Was it a car or a cat I saw?", "Madam, in Eden, I’m Adam.", "Yo, banana boy!" };

            //2. Stack values = new Stack();

            //values.Push("Mom");
            //values.Push("Was it a car or a cat I saw?");
            //values.Push("Madam, in Eden, I’m Adam.");
            //values.Push("Yo, banana boy!");

            Queue values = new Queue();

            values.Enqueue("Mom");
            values.Enqueue("Was it a car or a cat I saw?");
            values.Enqueue("Madam, in Eden, I’m Adam.");
            values.Enqueue("Yo, banana boy!");



            foreach (string value in values)
            {
                if (IsPalindrome(value))
                {
                    Console.WriteLine("{0} is a palindrome.", value);
                }
                else
                {
                    Console.WriteLine("{0} is not a palindrome.", value);
                }
            }
        }

    }

}