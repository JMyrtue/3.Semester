// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Menu menu = new Menu("MIN MENU!");
        menu.Add(
            new MenuItem(
                "Punkt1",
                "Indhold af punkt1"));
        menu.Add(
            new MenuItem(
                "Punkt2",
                "Indhold af punkt2"));
        menu.Add(
            new MenuItem(
                "Punkt3",
                "Indhold af punkt3"));
        Menu underMenu = new Menu("Undermenu");
            underMenu.Add(new MenuItem("TestPunkt", "Indhold"));
            underMenu.Add(new MenuItem("TestPunkt2", "indhold"));
        menu.Add(underMenu);
        InfinityMenu InfMenu = new InfinityMenu("InfMenu");
        InfMenu.Build();
        menu.Add(InfMenu);
        menu.Add(new FileSystemMenu("Browse my C-Drive", new DirectoryInfo(@"C:\")));

        menu.Start();
    }
}

