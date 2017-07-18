using System;


namespace TestScript
{
    class TestRun
    {
        static void Main(string[] args)
        {
            TestClass test = new TestClass("Hello Bobby");
            test.Run();
        }
    }
}
