using System;


namespace TestScript
{
    class TestRun
    {
        static void Main(string[] args)
        {
            ITest test = new TestMessage("Hello Bobby");
            test.Run();
        }
    }
}
