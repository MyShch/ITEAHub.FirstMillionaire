using ITEAHub.FirstMillionaire.Contractor.Interfaces;
using System;

namespace ITEAHub.FirstMillionaire.Menu.MenuItems
{
    public class ExitApp : IMenu
    {
        public string Name => "Exit";

        public void Action()
        {
            Environment.Exit(0);
        }
    }
}
