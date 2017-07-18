using System;

namespace TestScript
{
    public class TestClass : ITest
    {
        private const string _exitMessage = "Press Return to Quit:";
        private  string _message { get; set; } = "Hello World";


        public TestClass(string message="", string name="")
        {
            if(message != "")
            {
                _message = message;
            }
            else if(name != "")
            {
                _message = "Hello " + name;
            }
        }

        public void Run()
        {
            Console.WriteLine(_message);
            Console.Write(_exitMessage);
            Console.ReadLine();

        }
    }
}
