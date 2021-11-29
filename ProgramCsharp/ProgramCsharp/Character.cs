using System;
using System.Collections.Generic;

namespace ProgramCsharp
{
    public abstract class Character
    {
        public string nameNelement { get; private set; }

        public Character(string aName, string charElement)
        {
            nameNelement = "Name: " + aName + ", Vision: " + charElement;
        }

        public abstract void UseChar();
    }
}
