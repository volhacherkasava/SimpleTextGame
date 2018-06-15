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
    }
}
