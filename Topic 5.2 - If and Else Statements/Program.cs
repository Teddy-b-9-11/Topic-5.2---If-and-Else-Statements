namespace Topic_5._2___If_and_Else_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            double grade, temperature;
            /*
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
            */
            Console.WriteLine("What was your grade?");
            double.TryParse(Console.ReadLine(), out grade);
            
            if (grade < 50)
                Console.WriteLine("That is an F");
            else if (grade <= 65)
                Console.WriteLine("That is a D");
            else if (grade <= 75)
                Console.WriteLine("That is a C");
            else if (grade <= 85)
                Console.WriteLine("That is a B");
            else if (grade > 85)
                Console.WriteLine("That is a A");

            //Task 1

            //Task 2
            Console.WriteLine("what is the temperature of this water in celsius");
            double.TryParse(Console.ReadLine(), out temperature);



        }
    }
}
