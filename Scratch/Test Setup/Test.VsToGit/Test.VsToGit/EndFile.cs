using System;


namespace TestScript
{
    abstract class EndFile
    {
        private static readonly string _message = "Press Return to Quit:";

        public static void Print()
        {
            Console.Write(_message);
            Console.ReadLine();

        }
    }
}
