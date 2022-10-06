using System.Xml.Linq;

namespace Linq_Lab
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int[] nums = { 10, 2330, 112233, 10, 949, 3764, 2942 };

            //1. Find the Minimum value 
            int lowest = nums.Min();
            Console.WriteLine(lowest);
            Console.WriteLine();
            //2. Find the Maximum value
            int highest = nums.Max();
            Console.WriteLine(highest);
            Console.WriteLine();
            //3. Find the Maximum value less than 10000
            int maxLower = nums.Where(n => n < 10000).Max();
            Console.WriteLine(maxLower);
            Console.WriteLine();
            //4.Find all the values between 10 and 100
            List<int> numsBtw10a100 = nums.Where(num => num >= 10 && num < 100).ToList();
            PrintList(numsBtw10a100);
            Console.WriteLine();
            //5. Find all the Values between 100000 and 999999 inclusive
            List<int> numsBtw100k999k = nums.Where(num => num > 100000 && num <= 999999).ToList();
            PrintList(numsBtw100k999k);
            Console.WriteLine();
            //6. Count all the even numbers
            int evenCount = nums.Count(num => num % 2 == 0);
            Console.WriteLine($"Even Numbers: {evenCount}");
            Console.WriteLine();
            //7. Order the list by descending order, most to least
            List<int> mostToLeast = nums.OrderByDescending(n => n).ToList();
            PrintList(mostToLeast);
            Console.WriteLine();

            List<Student> students = new List<Student>();
            students.Add(new Student("Jimmy", 13));
            students.Add(new Student("Hannah Banana", 21));
            students.Add(new Student("Justin", 30));
            students.Add(new Student("Sarah", 53));
            students.Add(new Student("Hannibal", 15));
            students.Add(new Student("Phillip", 16));
            students.Add(new Student("Maria", 63));
            students.Add(new Student("Abe", 33));
            students.Add(new Student("Curtis", 10));

            
            //1. Find all students age of 21 and over(aka US drinking age)
            List<Student> drinkingAge = students.Where(n => n.Age >= 21).ToList();
            PrintList(drinkingAge);
            Console.WriteLine();
           
            //2. Find the oldest student
            int oldest = students.Max(n => n.Age);
            Student oldestStudent = students.First(n => n.Age == oldest);
            Console.WriteLine($"The oldest student listed is: Name: {oldestStudent.Name} Age: {oldestStudent.Age}");
            Console.WriteLine();
            
            //3. Find the youngest student
            int youngest = students.Min(n => n.Age);
            Student youngestStudent = students.First(n => n.Age == youngest);
            Console.WriteLine($"The youngest student listed is: Name: {youngestStudent.Name} Age: {youngestStudent.Age}");
            Console.WriteLine();
            
            //4. Find the oldest student under the age of 25
            List<Student> oldestUnder25 = students.Where(n => n.Age < 25).ToList();
            int oldestUnder25Student = students.Max(n => n.Age);
            Console.WriteLine($"The oldest student under 25 listed is: Name: {oldestUnder25Student}");
            Console.WriteLine();
            
            //5. Find all students over 21 and with even ages
            List<Student> evenOver21 = students.Where(n => n.Age > 21 && n.Age % 2==0).ToList();
            PrintList(evenOver21);
            Console.WriteLine();
            
            //6. Find all teenage students(13 to 19 inclusive) 
            List<Student> teens = students.Where(n => n.Age >12 && n.Age <20).ToList();
            PrintList(teens);
            Console.WriteLine();
           
            //7. Find all students whose name starts with a vowel
            char[] vowels = { 'A', 'E', 'I', 'O', 'U' };
            List<Student> startWithVowel = students.Where(n => vowels.Contains(n.Name[0])).ToList();
            PrintList(startWithVowel);


        }
        public static void PrintList(List<int> input)
        {
            for (int i = 0; i < input.Count; i++)
            {
                int num = input[i];
                Console.WriteLine($"{i}: {num}");
            }
        }
        public static void PrintList(List<Student> students)
        {
            for (int i = 0; i < students.Count; i++)
            {
                Student s = students[i];
                Console.WriteLine($"Name: {s.Name}, Age: {s.Age}");
            }
        }
    }
}