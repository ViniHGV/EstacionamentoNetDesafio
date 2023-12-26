using ParkModel;
using MenuModel;

internal class Program
{
    private static void Main(string[] args)
    {
        Park park = new Park();
        Menu menu = new Menu();

        menu.ListMenu(park);
    }
}