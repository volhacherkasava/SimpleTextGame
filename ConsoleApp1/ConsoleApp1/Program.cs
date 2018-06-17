using System;

namespace SimpleTextGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var ioManager = new IoManager();
            var menuWorker = new MenuWorker();
            //Hello
            ioManager.WriteStepMessage("Hello, do you want to play game?");
            ioManager.WriteStepMessage("Write:\nY - if you want play\nN - if you want close the program");

            menuWorker.MainMenu();

        }
    }
}
