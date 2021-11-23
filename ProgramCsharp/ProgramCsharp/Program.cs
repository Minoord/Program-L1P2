using System;
using System.Collections.Generic;

namespace ProgramCsharp
{
    class Program
    {

        static void Main(string[] args)
        {
            DataBase dataBase = new DataBase();
            Character Beidou = new Character("Beidou");
            Character Sayu = new Character("Sayu");

            dataBase.AddCharacter(Beidou);
            dataBase.AddCharacter(Sayu);

            foreach (Character c in dataBase.GetCharacter())
	        {
                Console.WriteLine(c.GetName());
	        }
        }
    }
}
