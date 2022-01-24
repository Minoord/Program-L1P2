using System;
using System.Collections.Generic;

namespace ProgramCsharp
{
    class CharElements : Character
    {

        public CharElements(string charName, string charVision):base(charName, charVision)
        {
            element = charVision;
        }

        public override void WhichElement()
        {
            throw new NotImplementedException();
        }
    }
}
