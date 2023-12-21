using ParkModel;
using MenuModel;

internal class Program
{
    private static void Main(string[] args)
    {
        Park park = new Park(new List<string>(), 1, 1);
        Menu menu = new Menu("4");

        menu.ListMenu(park);
    }
}