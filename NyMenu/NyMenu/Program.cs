// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main()
    {
        Menu menu = new Menu("Main Menu:");
        menu.Add(
            new MenuItem(
                "Point1",
                "Content of first point"));
        menu.Add(
            new MenuItem(
                "Point2",
                "Content of second point"));
        menu.Add(
            new MenuItem(
                "Point3",
                "Content of third point"));
        Menu underMenu = new Menu("SubMenu:");
        underMenu.Add(
            new MenuItem("SubItem1", "Content"));
        underMenu.Add(
            new MenuItem("SubItem2", "Content"));
        menu.Add(underMenu);
        menu.Add(new InfinityMenu("Infinity Menu"));
        menu.Start();
    }
}
