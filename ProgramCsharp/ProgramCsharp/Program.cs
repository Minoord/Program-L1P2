using System;
using System.Collections.Generic;

namespace ProgramCsharp
{
    class Program
    {

        static void Main(string[] args)
        {
            DataBase dataBase = new DataBase();
            Character bennett = new CharElements("Bennett", "pyro");
            Character barbara = new CharElements("Barbara","hydro");
            Character sayu = new CharElements("Sayu", "anemo");
            Character beidou = new CharElements("Beidou", "electro");
            Character rosaria = new CharElements("Rosaria", "cryo");
            Character zhongli = new CharElements("Zhongli", "geo");

            dataBase.AddCharacter(bennett);
            dataBase.AddCharacter(barbara);
            dataBase.AddCharacter(sayu);
            dataBase.AddCharacter(beidou);
            dataBase.AddCharacter(rosaria);
            dataBase.AddCharacter(zhongli);


            Console.WriteLine("Which elements do you wanna see the characters off?");
            Console.WriteLine("Pyro");
            Console.WriteLine("Hydro");
            Console.WriteLine("Anemo");
            Console.WriteLine("Electro");
            Console.WriteLine("Dendro");
            Console.WriteLine("Cryo");
            Console.WriteLine("Geo");
            Console.WriteLine("Type which element you want down below.(Write the elements with no caps)");
            string _playerInput = Console.ReadLine();
            dataBase.visionClass = _playerInput;



            foreach (Character c in dataBase.GetCharacter())
	        {
                Console.WriteLine("Name: " + c.name + " Vision: " + c.elements);
	        }
        }
    }
}
