using System;
using System.Collections.Generic;

namespace ProgramCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            DataBase dataBase = new DataBase();
            Character beidou = new CharElements("Beidou", "Electro");;

            dataBase.AddCharacter(beidou);

            foreach (Character c in dataBase.GetCharacter())
	        {
                Console.WriteLine(c.nameNelement);
	        }
        }
    }
}
