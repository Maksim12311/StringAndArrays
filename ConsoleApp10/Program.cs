using System.Linq;

namespace StringsAndArrays
{
    class Program
    {
        // INSTRUCTIONS: Write you task related code answers under each specific comment/insturction
        static void Main(string[] args)
        {
            // PART 1: Strings

            // 1. Basic String Operations

            string helloWorld = "Hello, World!";

            // 1.1 Print the length of the string.

            int size = helloWorld.Length;
            Console.WriteLine(size);

            // 1.2 Print the first and the last character of the string.

            Console.WriteLine(helloWorld[0]);
            Console.WriteLine(helloWorld[helloWorld.Length - 1]);

            // 2. String Manipulation

            Console.Write("Please enter your name: ");

            // 2.1 Get the input from and assing it into new string variable called name

            string name = Console.ReadLine();

            // 2.2 Print a personalized welcome message including the name.

            Console.WriteLine($"Hello {name}");

            // 2.3 Convert name variable to uppercase and output the result

            Console.WriteLine(name.ToUpper());

            // 2.4 Convert name variable to lovercase and output the result

            Console.WriteLine(name.ToLower());

            // 3. String Searching
            // 3.1 Create new boolean variable called containsWorld

            bool contrainsWorld = true;

            // 3.2 Check that the helloWorld variable contains the word "World".
            //     Assign the result to the created constainsWorld variable

            string word = "World";
            if (helloWorld.Contains(word))
            {
                Console.WriteLine(contrainsWorld);
            }
            else
            {
                contrainsWorld = false;
                Console.WriteLine(contrainsWorld);
            }

            // 3.3 If the word is found, get the index of the word from helloWorld string

            Console.WriteLine(helloWorld.IndexOf(word));

            // PART 2: Arrays

            // 1. Basic Array Operations
            // 1.1 initialize array called numbers containing array of int values
            //     Add these values to the array -> 2 3 5 7 11 

            int[] numbers = { 2, 3, 5, 7, 11 };

            // 1.2 Output the numbers array -> hint use Join
            // Expected outcome: 2, 3, 5, 7, 11

            Console.WriteLine(string.Join(",", numbers));

            // 1.3 Output the value of the third (3th) item in the numbers array 
            // Expected outcome: 5

            Console.WriteLine(numbers[2]);

            // 2. Array Manipulation

            Console.WriteLine("Please enter five names:");

            // 2.1 Initialize new names string array variable that has room for 5 items
            //     The maximum lenght of the string array should be 5

            string[] newnames = new string[5];

            // 2.2 Ask the user to input new names 5 times
            //     and assing each name to the names string array in the given order.
            //     The first name should be at index 0
            //     Hint: you might want to use some sort of a loop here

            for (int i = 0; i < newnames.Length; i++)
            {
                newnames[i] = Console.ReadLine();
            }

            // 2.3 Output the array of given names.

            for (int j = 0; j < newnames.Length; j++)
            {
                Console.WriteLine(newnames[j]);
            }

            // 2.4 Reverse the order of the items in the names array and outpu the result

            for (int k = newnames.Length - 1; k >= 0; --k)
            {
                Console.WriteLine(newnames[k]);
            }

            // 3. Array Searching

            Console.Write("Please enter a name to search: ");
            string searchName = Console.ReadLine();

            // 3.1 Try to find out the searchName from the Task 2 names string array
            //     by finding out it's index.
            //     Assign the index value to new position integer variable

            int cond = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (newnames[i] == searchName)
                {
                    Console.WriteLine(i);
                    cond = i;
                }
            }
            if (cond != 0)
            {
                Console.WriteLine(cond);
            }
            else
            {
                Console.WriteLine("Error");
            }

            // 3.2 Check that the index position was found
            //     Hint: What is the result of IndexOf if nothing is found
            // 3.2.1 If position is found output the searchName and the found position
            // 3.2.2 Else output that the searchName was not found

            if (cond != 0)
            {
                Console.WriteLine(searchName);
                Console.WriteLine(cond);
            }
            else
            {
                Console.WriteLine("searchName was not found");
            }

            // 4. BONUS

            // 1. String to Array
            // 1.1 Create new empty words string array

            string[] z;

            // 1.2 Try to get each word from the helloWorld variable and assing the values to
            //     the created words string array
            List<string> listwords = new List<string>();
            int firstindex = 0;
            int lastindex = 0;
            string word1 = "";
            for (int i = 0; i < helloWorld.Length; i++)
            {
                if (helloWorld[i] == ' ' || i == helloWorld.Length - 1)
                {
                    lastindex = i;
                    for (int q = firstindex; q <= lastindex; q++)
                    {
                        word1 += helloWorld[q];
                    }
                    firstindex = lastindex + 1;
                    listwords.Add(word1);
                    word1 = "";
                }
            }
            z = listwords.ToArray();
            // 1.3 Output the values of the words array
            int count = 1;
            foreach (string item in z)
            {
                Console.Write($"Value {count} - ");
                Console.WriteLine(item);
                count++;
            }


            Console.ReadLine();
        }
    }
}