using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace live_coding
{
    internal class live_coading
    {
      
        public struct langs
        {
            public string HTML;
            public string CSS;
            public string Python;
        }
        class ABC
        {
            static void Main(string[] args)
            {
                langs H1=new langs();
                H1.HTML= "design";
                H1.CSS = "Styling";
                Console.WriteLine("Name of the language:" + H1.HTML + "   use:" + H1.CSS);
                    }
        }
    }
}
