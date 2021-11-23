using System;
using System.Collections.Generic;

namespace ProgramCsharp
{
    public class DataBase
    {
        private List<Character> _characters;

        public DataBase()
        {
            _characters = new List<Character>();
        }

        public void AddCharacter(Character character)
        {
            _characters.Add(character);
        }

        public List<Character>  GetCharacter()
        {
            return _characters;
        } 
    }

}
