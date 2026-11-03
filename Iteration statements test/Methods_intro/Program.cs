//Task 1 — Employee Name Analyzer
//Data:
//string[] employees =
//{
//    "Mahesh Nelavalli",
//    "John Smith",
//    "David Miller",
//    "Michael Johnson",
//    "Robert Brown",
//    "Daniel Wilson"
//};

//Questions:
//1.Print every employee name.
//2. Print every employee name in uppercase.
//3. Print employees whose first name starts with "M".
//4. Print employees whose last name ends with "son".
//5. Find the employee with the longest name.
//6. Find the employee with the shortest name.
//7. Count employees whose full name contains the letter "a".
//8. Print the first name and last name separately for every employee.
//9. Sort the names alphabetically.
//10. Print the sorted names in reverse order.



namespace Methods_intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] employees =
            {
                "Mahesh Nelavalli",
                "John Smith",
                "David Miller",
                "Michael Johnson",
                "Robert Brown",
                "Daniel Wilson"
            };
            Console.WriteLine(employees);
            task1PrintEveryEmployee(employees);
            
            task2PrintUppercaseEmployee(employees);
            task3PrintFilteredWithLetter(employees);
            task4PrintEndsWith(employees);
            task5PrintLongestName(employees);
            task6PrintSmallestName(employees);
            task7PrintCountOfLetters(employees);
            task8PrintFirstAndLastSeperately(employees);
            task9PrintSorting(employees);
            task10PrintSortingReverse(employees);
            Console.WriteLine("Hello, World!");
        }

        public static void task1PrintEveryEmployee(string[] employees)
        {
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine(i + " " + employees[i]);
                Console.WriteLine("                    ");

            }
            Console.WriteLine("end of task1-------------------------");
        }

        
        public static void task2PrintUppercaseEmployee(string[] employees)
        {
            for (int i = 0; i < employees.Length; i++)
            {
                string nameInUpperCase = employees[i].ToUpper();
                Console.WriteLine(i + " " + nameInUpperCase);
                Console.WriteLine("                        ");

            }
            Console.WriteLine("end of task2--------------------------");
        }

        public static void task3PrintFilteredWithLetter(string[] employees)
        {
            Console.WriteLine("enter a letter to filter the employee names based on letter: ");
            string? userInput = Console.ReadLine();
            for (int i = 0; i < employees.Length; i++)
            {
                bool exists = employees[i].ToLower().Contains(userInput.ToLower());
                if (exists)
                {
                    Console.WriteLine(employees[i]);
                }
                
                Console.WriteLine("                        ");

            }
            Console.WriteLine("end of task3--------------------------");
        }

        public static void task4PrintEndsWith(string[] employees)
        {
            string end = "son";
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i].ToLower().EndsWith(end))
                {
                    Console.WriteLine(employees[i]);
                }
            }
            Console.WriteLine("end of task4--------------------------");
        }

        public static void task5PrintLongestName(string[] employees)
        {
             char v = ' ';
            //int[] namesLength = new int[employees.Length];
            string biggestName = v.ToString();
            for (int i = 0; i < employees.Length; i++)
            {
                string name = employees[i].ToString();

                Console.WriteLine(biggestName + ',' + biggestName.Length + ',' + employees[i] + ',' + employees[i].Length);
                //namesLength[i] = name.Length;
                if (biggestName.Length < employees[i].Length)
                {
                    biggestName = employees[i];
                }

            }

            Console.WriteLine(biggestName);
            Console.WriteLine("end of task5--------------------------");
        }

        public static void task6PrintSmallestName(string[] employees)
        {
            char v = ' ';
            int[] namesLength = new int[employees.Length];
            string smallestname = employees[0];
            for (int i = 0; i < employees.Length; i++)
            {
                if(smallestname.Length > employees[i].Length)
                {
                    smallestname = employees[i];
                }

            }

            Console.WriteLine(smallestname);
            Console.WriteLine("end of task6--------------------------");
        }


        public static void task7PrintCountOfLetters(string[] employees)
        {
            char v = 'a';

            List<string> names = new List<string>();

            int count = 0;

            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i].ToLower().Contains(v))
                {
                    Console.WriteLine($"{employees[i]}, result");
                    names.Add(employees[i]);
                    count++;
                }
               
            }
            for (int j = 0; j < names.Count; j++)
            {
                Console.WriteLine(names[j]);
            }

            Console.WriteLine(count + "," + names.Count);
            Console.WriteLine("end of task7--------------------------");
        }

        public static void task8PrintFirstAndLastSeperately(string[] employees)
        {
            for(int i = 0; i< employees.Length; i++)
            {
                string[] nameList = employees[i].Split(' ');
                Console.WriteLine("              ");
                Console.WriteLine("first name: " + nameList[0] + ", last name : " + nameList[1]);
                Console.WriteLine("------------");
            }
            Console.WriteLine("end of task8--------------------------");
        }

        public static void task9PrintSorting(string[] employees)
        {
            Array.Sort(employees);

            foreach (string name in employees)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("task9--------------------------------");
        }

        public static void task10PrintSortingReverse(string[] employees)
        {
            Array.Sort(employees);

            for (int i = employees.Length-1; i>=0; i--)
            {
                Console.WriteLine(employees[i]);
            }
            Console.WriteLine("task10--------------------------------");
        }
    }
}
