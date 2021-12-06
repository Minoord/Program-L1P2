using System;
using System.Collections.Generic;

namespace ProgramCsharp
{
    public abstract class Character
    {
        public string name{ get; private set; }
        public string elements;

        public Character(string aName, string charElement)
        {
            name = aName;
        }

        public abstract void WhichElement();
    }
}
