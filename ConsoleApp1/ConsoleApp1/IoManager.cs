using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTextGame
{
    //it's class implemented for work with console text outputs and inputs
    // Created by Siarhei Frunchak
    public class IoManager
    {
        //line for menu step constructions
        private const string tableLine = "-------------------------------------------------------------------------";
        
        //Read line method
        public void Read()
        {
            Console.ReadLine();
        }
        //Write method
        public void Write(string msg)
        {
            Console.WriteLine(msg);
        }

        //Write method for menu steps
        public void WriteStepMessage(string msg)
        {
            //Console.WriteLine($"{tableLine}{Environment.NewLine}{msg}{Environment.NewLine}{tableLine}");
            Console.WriteLine(tableLine + Environment.NewLine + msg + Environment.NewLine + tableLine);
        }

        //Menu steps reader
        public string ReadMenuStep()
        {
            string menuResponseStep = string.Empty;
            menuResponseStep = Console.ReadLine().ToUpper();
            return menuResponseStep;
        }

        public string ReadName()
        {
            string name = Console.ReadLine();
            return name;
        }
    }
}
