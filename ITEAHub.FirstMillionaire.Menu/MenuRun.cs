using ITEAHub.FirstMillionaire.Contractor.Interfaces;
using ITEAHub.FirstMillionaire.Menu.MenuItems;
using System;
using System.Collections.Generic;

namespace ITEAHub.FirstMillionaire.Menu
{
    public class MenuRun
    {
        private List<IMenu> _menus;

        public MenuRun()
        {
            _menus = new List<IMenu>
            {
                new GetAllQuestions(),
                new ExitApp()
            };
        }


        public void Run()
        {
            while(true)
            {
                Console.Clear();

                int i = 1;
                foreach (var item in _menus)
                {
                    Console.WriteLine($"{i}. {item.Name}");
                    i++;
                }
                Console.WriteLine("Your choice: ");

                var input = Console.ReadLine();

                var choise = int.Parse(input);
                // validatation for coun

                _menus[choise - 1].Action();

                Console.ReadLine();

            }
        }

    }
}
