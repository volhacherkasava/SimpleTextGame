using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
