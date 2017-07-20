using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestScript
{
    public class TestMessageBase
    {
   
        protected string _message { get; set; } = "Hello World";


        public TestMessageBase(string message = "", string name = "")
        {
            if (message != "")
            {
                _message = message;
            }
            else if (name != "")
            {
                _message = "Hello " + name;
            }
        }

        public virtual void Run()
        {
            Console.WriteLine(_message);
            Console.ReadLine();

        }

    }
}
