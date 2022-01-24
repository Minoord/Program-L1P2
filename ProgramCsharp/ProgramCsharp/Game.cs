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

            if (_playerInput == "ADD" || _playerInput == "add" || _playerInput == "Add")
            {
                Console.WriteLine("What is it's name?");
                string _newCharName = Console.ReadLine();
                Console.WriteLine("What is it's vision (No caps)");
                string _newCharVision = Console.ReadLine();

                Character newChar = new CharElements(_newCharName, _newCharVision);
                dataBase.AddCharacter(newChar);


            }
            else if (_playerInput == "Search" || _playerInput == "SEARCH" || _playerInput == "search")
            {
                Console.WriteLine("From which vision do you wanna see the characters off?");
                Console.WriteLine("Pyro \nHydro \nAnemo \nElectro \nDendro \nCryo \nGeo");
                Console.WriteLine("Type which element you want down below.(Write the elements with no caps)");
                _playerInput = Console.ReadLine();
                dataBase.visionClass = _playerInput;

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
