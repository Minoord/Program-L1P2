using System;
using System.Collections.Generic;

namespace ProgramCsharp
{
    public class DataBase
    {
        private List<Character> _pyroChar;
        private List<Character> _hydroChar;
        private List<Character> _anemoChar;
        private List<Character> _electroChar;
        private List<Character> _dendroChar;
        private List<Character> _cryoChar;
        private List<Character> _geoChar;
        public string visionClass;

        public DataBase()
        {
           _pyroChar = new List<Character>();
           _hydroChar = new List<Character>();
           _anemoChar = new List<Character>();
           _electroChar = new List<Character>();
           _dendroChar = new List<Character>();
           _cryoChar = new List<Character>();
           _geoChar = new List<Character>();
        }

        public void AddCharacter(Character character)
        {
            switch (character.element)
            {
                case "pyro":
                    _pyroChar.Add(character);
                    Console.WriteLine(character.name + " has been added to Pyro");
                    break;
                case "hydro":
                    _hydroChar.Add(character);
                    Console.WriteLine(character.name + " has been added to Hydro");
                    break;
                case "anemo":
                    _anemoChar.Add(character);
                    Console.WriteLine(character.name + " has been added to Anemo");
                    break;
                case "electro":
                    _electroChar.Add(character);
                    Console.WriteLine(character.name + " has been added to Electro");
                    break;
                case "dendro":
                    _dendroChar.Add(character);
                    Console.WriteLine(character.name + " has been added to Dendro");
                    break;
                case "cryo":
                    _cryoChar.Add(character);
                    Console.WriteLine(character.name + " has been added to Cryo");
                    break;
                case "geo":
                    _geoChar.Add(character);
                    Console.WriteLine(character.name + " has been added to Geo");
                    break;
                default :
                    Console.WriteLine("character element doesn't exist");
                    break;

            }
        }

        public List<Character>  GetCharacter()
        {
            switch (visionClass)
            {
                case "pyro":
                    return _pyroChar;
                    break;
                case "hydro":
                    return _hydroChar;
                    break;
                case "anemo":
                    return _anemoChar;
                    break;
                case "electro":
                    return _electroChar;
                    break;
                case "dendro":
                    return _dendroChar;
                    break;
                case "cryo":
                    return _cryoChar;
                    break;
                case "geo":
                    return _geoChar;
                    break;
                default:
                    Console.WriteLine("element doesn't exist");
                    return null;
                    break;

            }
            return null;
        } 
    }

}
