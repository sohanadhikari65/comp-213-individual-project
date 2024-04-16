/*This program asks user their first name and the last two digits if their student number and determines whether its odd or ecen and prompts array count and count elements and perform a search opration in an integer array. */
{
    static void Main(string[] args)
    {
        /* Prompting for first name and last two digits of student number*/
        Console.Write("Enter your First Name: ");
        string fName = Console.ReadLine();

        Console.Write("Enter the last two digits of your Student Number: ");
        int studentNum = Convert.ToInt32(Console.ReadLine());

        /*Checking whether the studentnumber is odd or even */
        if (studentNum % 2 == 0)
        {
            Console.WriteLine($"Hi {fName}, the entered number is an even number.");
        }
        else
        {
            Console.WriteLine($"Hi {fName}, the entered number is an odd number.");
        }

        /* Searching operation in an integer array*/
        Console.WriteLine("This program will perform search operation in an Integer array:");
        /* Prompt the user for the size of the array and read the input*/
        Console.Write("Enter the array count: ");
        int count = Convert.ToInt32(Console.ReadLine());

        /* Array is declared with specified size*/ 
        int[] array = new int[count];
        Console.WriteLine($"Enter {count} values to the array :");
        for (int i = 0; i < count; i++)
        {
            Console.Write($"Enter array element {i + 1}: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        /* Performimg searches*/
        char choice;
        do
        {
            Console.Write("Enter the number to be searched: ");
            int searchNumber = Convert.ToInt32(Console.ReadLine());

            /Performing binary search/
            int bsearch = Array.BinarySearch(array, searchNumber);

            if (bsearch >= 0)
            {
                Console.WriteLine($"Number {searchNumber} is found in the array at position {bsearch + 1}.");
            }
            else
            {
                Console.WriteLine($"Number {searchNumber} is not found in the array.");
            }

            Console.Write("Do you want to do search again(Y/N): ");
            choice = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();
        } while (choice == 'Y');
        /Thank you message is displayed/
        Console.WriteLine($"Thank you, {fName}, Part 1 of Final Assignment is done, best wishes for your Part 2.");
    }
}