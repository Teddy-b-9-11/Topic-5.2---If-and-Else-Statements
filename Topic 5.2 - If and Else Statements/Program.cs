namespace Topic_5._2___If_and_Else_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int grade;

            Console.WriteLine("What was your grade?");
            int.TryParse(Console.ReadLine(), out grade);
            if (grade >= 50)
                Console.WriteLine("YOU PASSED!!");
            else
                Console.WriteLine("You failed... Better luck next time!");


        }
    }
}
