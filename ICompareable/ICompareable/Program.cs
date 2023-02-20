using ICompareable;

namespace Program
{
    class IComExample
    {
        public static void Main()
        {

            Employee Emp1 = new Employee(1, "Pragya",30);
            Employee Emp2 = new Employee(2, "Kanak",35);
            int state = Emp1.CompareTo(Emp2);
            if (state == 1)
            {
                Console.WriteLine("Emp1 is older than Emp2");
            }
            else if (state == -1)
            {
                Console.WriteLine("Emp2 is older than Emp1");
            }
            else
            {
                Console.WriteLine("Emp1 & Emp2 are of same age");
            }
            int state1 = Emp2.CompareTo(Emp1);
            if (state1 == 1)
            {
                Console.WriteLine("Emp1 is older than Emp2");
            }
            else if (state1 == -1)
            {
                Console.WriteLine("Emp2 is older than Emp1");
            }
            else
            {
                Console.WriteLine("Emp1 & Emp2 are of same age");
            }
            int state2 = Emp1.CompareTo(Emp1);
            if (state2 == 1)
            {
                Console.WriteLine("Emp1 is older than Emp2");
            }
            else if (state2== -1)
            {
                Console.WriteLine("Emp2 is older than Emp1");
            }
            else
            {
                Console.WriteLine("Both are of same age");
            }

        }
    }
}