using System;
using System.Collections.Generic;

namespace ProgramCsharp
{
    public class Character
    {
        private string name;

        public Character(string aName)
        {
            name = aName;
        }
        public string GetName()
        {
            return name;
        }
    }
}
