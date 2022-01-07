using System;

namespace ChatProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Group footbal = new Group();
            User daniel = new User("Daniel");
            Observer marcus = new Observer("Marcus");
            Observer mar = new Observer("Mar");
            Observer maru = new Observer("Maru");
            User paul = new User("Paul");
            User robert = new User("Robert");

            footbal.Add(daniel);
                Console.WriteLine();
            footbal.Add(robert);
                Console.WriteLine();
            footbal.Add(marcus);
                Console.WriteLine();
            footbal.Add(paul);
                Console.WriteLine();
            footbal.Message(paul, "Ce faceti?");
            Console.WriteLine();
            footbal.Add(mar);
            Console.WriteLine();
            footbal.Add(maru);
            Console.WriteLine();
            footbal.PrintList();
        }
    }
}
