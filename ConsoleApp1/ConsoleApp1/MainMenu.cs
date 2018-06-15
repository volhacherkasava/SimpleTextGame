namespace SimpleTextGame
{
    class MenuWorker
    {
        //Main menu logic
        public void MainMenu()
        {
            var ioM = new IoManager();
            var acquantance = new AcquaintanceWorker(); 

            string menuResponse = ioM.ReadMenuStep();



            if (menuResponse == "Y")
            {
                ioM.WriteStepMessage("Great! Whats your name? My name is Isis!");
                acquantance.Acquaintance();
                //don't forget delete this readline
                ioM.Read();
            }
            else if (menuResponse == "N")
            {
                ioM.WriteStepMessage("Have a nice day! Press Enter for close program...");
                ioM.Read();
            }
        }

    }
}
