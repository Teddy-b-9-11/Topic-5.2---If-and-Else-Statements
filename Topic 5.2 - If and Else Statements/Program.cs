namespace Topic_5._2___If_and_Else_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            double grade;

            Console.WriteLine("What was your grade?");
            double.TryParse(Console.ReadLine(), out grade);
            if (grade >= 50)
                Console.WriteLine("YOU PASSED!!");
            else
                Console.WriteLine("You failed... Better luck next time!");

            Console.WriteLine("How old are you?");
            int.TryParse(Console.ReadLine(), out age);
            Console.WriteLine("You are " + age);
            if (age >= 16)
                Console.WriteLine("The roads aren't safe");
            else
                Console.WriteLine("I can drive with out fear");
            












        }
    }
}
