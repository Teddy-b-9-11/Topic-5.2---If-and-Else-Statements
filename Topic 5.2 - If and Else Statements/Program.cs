namespace Topic_5._2___If_and_Else_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer;
            int age;
            double grade, temperature;
            
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
            Console.WriteLine("Answer this multiple choice question:");
            Console.WriteLine("Whats the capital of France?");
            Console.WriteLine("A) Rome   B) Paris   C) London   D) Ottawa");
            answer = Console.ReadLine();
            if (answer == "Paris")
                Console.WriteLine("Correct it is Paris");
            else if (answer == "B")
                Console.WriteLine("Correct it is Paris");
            else
                Console.WriteLine("Incorrect " + answer + " is not the capital of France");

            //Task 2
            Console.WriteLine("what is the temperature of this water in celsius?");
            double.TryParse(Console.ReadLine(), out temperature);
            if (temperature <= 0)
                Console.WriteLine("The water is in it's solid state so it's ice.");
            else if (temperature > 0) 
                Console.WriteLine("The water is in it's liquid state so it's water.");
            else if (temperature >= 100)
                Console.WriteLine("The water is in it's gaz state so it's steam.");
            
            //Task 3
            Console.WriteLine("How old are you again?");
            int.TryParse(Console.ReadLine(), out age);
            if (age >= 25)
                Console.WriteLine("Your childhood is gone now, you can now do pretty much anything that's legal.");
            else if (age >= 18)
                Console.WriteLine("You can drive and vote but not rent a car.");
            else if (age >= 16)
                Console.WriteLine("You can drive but not much else.");
            else if (age < 16)
                Console.WriteLine("You're too young too do adult stuff.");
        }
    }
}
