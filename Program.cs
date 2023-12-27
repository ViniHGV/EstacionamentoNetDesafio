using Parking.Models;

namespace Parking
{
    internal class Program{
        private static void Main(string[] args)
        {
            Park park = new Park();
            Menu menu = new Menu(park);

            menu.ListMenu();
        }
    }
}