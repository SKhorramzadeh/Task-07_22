namespace Task_7_22
{
    internal class Program
    {
        //Task 1: Summation of two numbers.
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Dear!");
            Console.WriteLine("Enter two numbers to sum them!");
            string a1 = Console.ReadLine();
            string a2 = Console.ReadLine();
            int i1 = int.Parse(a1);
            int i2 = int.Parse(a2);
            int i3 = i1 + i2;
            string a3 = i3.ToString();
            Console.WriteLine($"The sum of {a1}  and {a2}  is {a3} .");



            //Task 2: Summation of three numbers.
            Console.WriteLine("Enter three numbers to sum them!");
            string b1 = Console.ReadLine();
            string b2 = Console.ReadLine();
            string b3 = Console.ReadLine();
            int j1 = int.Parse(b1);
            int j2 = int.Parse(b2);
            int j3 = int.Parse(b3);
            int j4 = j1 + j2 + j3;
            string b4 = j4.ToString();
            Console.WriteLine($"The sum of {b1}  and {b2}  and {b3}  is {b4} .");



            //Task 3: Check if two numbers are divisible or not.
            Console.WriteLine("Enter two numbers to check if they are divisible or not!");
            string c1 = Console.ReadLine();
            string c2 = Console.ReadLine();
            j1 = int.Parse(c1);
            j2 = int.Parse(c2);
            float r3 = j1 % j2;
            if (r3 == 0)
            {
                Console.WriteLine($" {c1}  and {c2}  are divisible.");
            }
            else
            {
                Console.WriteLine($" {c1}  and {c2}  are not divisible.");
            }




            //Task 4: Check if entered number is even or odd.
            Console.WriteLine("Enter a number to check if it is even or odd!");
            string d1 = Console.ReadLine();
            j1 = int.Parse(d1);
            r3 = j1 % 2;
            if (r3 == 0)
            {
                Console.WriteLine($" {d1} is even.");
            }
            else
            {
                Console.WriteLine($" {d1} is odd.");
            }





            //Task 5: Find smaller number from 2 numbers.
            Console.WriteLine("Enter two numbers to find smaller of them!");
            string e1 = Console.ReadLine();
            string e2 = Console.ReadLine();
            j1 = int.Parse(e1);
            j2 = int.Parse(e2);
            r3 = j1 - j2;
            if (r3 >= 0)
            {
                Console.WriteLine($" {e1} is bigger than {e2}.");
            }
            else
            {
                Console.WriteLine($" {e2} is bigger than {e1}.");
            }



            //Task 6: Find smaller number from 5 numbers.
            Console.WriteLine("Enter five numbers to check if they are divisible or not!");
            string f1 = Console.ReadLine();
            string f2 = Console.ReadLine();
            string f3 = Console.ReadLine();
            string f4 = Console.ReadLine();
            string f5 = Console.ReadLine();
            int k1 = int.Parse(f1);
            int k2 = int.Parse(f2);
            int k3 = int.Parse(f2);
            int k4 = int.Parse(f2);
            int k5 = int.Parse(f2);

            if (k1 <= k2 && k1 <= k3 && k1 <= k4 && k1 <= k5)
            {
                Console.WriteLine($" {f1} is smallest number.");
            }

            if (k2 <= k1 && k2 <= k3 && k2 <= k4 && k2 <= k5)
            {
                Console.WriteLine($" {f2} is smallest number.");
            }

            if (k3 <= k1 && k3 <= k2 && k3 <= k4 && k3 <= k5)
            {
                Console.WriteLine($" {f2} is smallest number.");
            }

            if (k4 <= k1 && k4 <= k2 && k4 <= k3 && k4 <= k5)
            {
                Console.WriteLine($" {f4} is smallest number.");
            }
            if (k5 <= k1 && k5 <= k2 && k5 <= k3 && k5 <= k4)
            {
                Console.WriteLine($" {f5} is smallest number.");
            }




            //Task 7: Make a series.
            Console.WriteLine("Enter begining, count and the step!");
            string beg = Console.ReadLine();
            string cnt = Console.ReadLine();
            string stp = Console.ReadLine();
            int m1 = int.Parse(beg);
            int m2 = int.Parse(cnt);
            int m3 = int.Parse(stp);

            int s=m1+(m2*m3);
            string series = s.ToString();
            Console.WriteLine($" The {cnt}th of series is {series}.");





         

        }

    }
}
