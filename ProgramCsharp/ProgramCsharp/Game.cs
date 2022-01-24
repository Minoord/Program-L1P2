using System;
using System.Collections.Generic;

namespace ProgramCsharp
{
    class Game
    {
        DataBase dataBase = new DataBase();

        public void StartGame()
        {
            Console.WriteLine("Genshin Impact Character List \n");
            Console.WriteLine("Would you like to ADD or do you want to SEARCH for characters?");
            string _playerInput = Console.ReadLine();

            if (_playerInput.ToUpper() == "ADD")
            {
                Console.WriteLine("What is it's name?");
                string _newCharName = Console.ReadLine();
                Console.WriteLine("What is it's vision?");
                string _newCharVision = Console.ReadLine();

                Character newChar = new CharElements(_newCharName, _newCharVision.ToLower());
                dataBase.AddCharacter(newChar);


            }
            else if (_playerInput.ToUpper() == "SEARCH")
            {
                Console.WriteLine("From which vision do you wanna see the characters of?");
                Console.WriteLine("Pyro \nHydro \nAnemo \nElectro \nDendro \nCryo \nGeo");
                Console.WriteLine("Type which element you want down below.");
                _playerInput = Console.ReadLine();
                dataBase.visionClass = _playerInput.ToLower();

                foreach (Character c in dataBase.GetCharacter())
                {
                    Console.WriteLine("Name: " + c.name + ". Vision: " + c.element + ".");
                }
            }
            else
            {
                Console.WriteLine("Sorry couldn't find wat you where looking for");
            }

            StartGame();
        }
    }
}
