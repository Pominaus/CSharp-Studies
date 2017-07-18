using System;

namespace Test.VsToGit
{
    public class TestClass
    {
        private readonly string _message { get; private set; } = "Hello World";

        public TestClass(string message="")
        {
            if(message)
            {
                _message = message;
            }
        }

        public void Run()
        {
            Console.WriteLine(_message);

        }
    }
}
