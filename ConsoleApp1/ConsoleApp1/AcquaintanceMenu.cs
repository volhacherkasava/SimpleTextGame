namespace SimpleTextGame
{
    public class AcquaintanceWorker
    {
        public void Acquaintance()
        {
            var ioM = new IoManager();

            string playerName = ioM.ReadName();
            ioM.WriteStepMessage("Are you ready? =^.^= Have a nice adventure =^.^=, " + playerName +"!");
            ioM.WriteStepMessage(TextContainer.earthText);
        }
    }
}
