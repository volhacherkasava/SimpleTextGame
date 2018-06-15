using System;

namespace SimpleTextGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var ioManager = new IoManager();

            ioManager.WriteStepMessage("Hello!");

            ioManager.Read();
        }
    }
}
