using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba9
{
    internal class ShowData
    {
        static public void Menu(Menu menu)
        {
            for(int i = 0; i < menu.QuantityOfTasks; i++)
            {
                Console.WriteLine(menu.Tasks[i]);
            }
        }

        static public void Pokemon(Pokemon pokemon)
        {
            Console.WriteLine($"Значение атаки: {pokemon.Attack}");
            Console.WriteLine($"Значение защиты: {pokemon.Defense}");
            Console.WriteLine($"Значение стамины: {pokemon.Stamina}");
        }
    }
}
