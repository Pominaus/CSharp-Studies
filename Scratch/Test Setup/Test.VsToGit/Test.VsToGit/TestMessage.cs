using System;

namespace TestScript
{
    public class TestMessage : TestMessageBase, ITest 
    {
        public TestMessage(string message = "", string name = "") : base(message, name)
        {
            //pass
        }

        public override void Run()
        {
            Console.WriteLine(_message);
            EndFile.Print();

        }
    }
}
