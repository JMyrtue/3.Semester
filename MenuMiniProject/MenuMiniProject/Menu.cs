using System;

class Menu : IMenuItem
{
    public bool running = true;
    public string Title { get; set; }
    public int currentIndex = 0;

    List<MenuItem> menuItems = new List<MenuItem>();

    public Menu(params string[] title)
    {
        foreach (var item in title)
        {
            Title = item;
        }
    }

    public void Add(params MenuItem[] item)
    {
        foreach (var i in menuItems)
        {
            menuItems.Add(i);
        }
    }

    public void Start()
    {
        do
        {
            Console.Clear();
            DrawMenu();
            HandleInput();
        } while (running);
    }

    private void DrawMenu()
    {
        Console.WriteLine(Title);
        for (int i = 0; i < menuItems.Count; i++)
        {
            if (i == currentIndex)
                Console.BackgroundColor = ConsoleColor.Magenta;
            Console.WriteLine(menuItems[i].Title);
            Console.ResetColor();
        }
    }

    private void HandleInput()
    {
        ConsoleKeyInfo cki = Console.ReadKey();
        switch (cki.Key)
        {
            case ConsoleKey.Backspace:
            case ConsoleKey.Escape:
                running = false;
                break;
            case ConsoleKey.UpArrow:
                MoveUp();
                break;
            case ConsoleKey.DownArrow:
                MoveDown();
                break;
            case ConsoleKey.Enter:
                menuItems[currentIndex].Select();
                break;
            default:
                break;
        }
    }

    private void MoveUp()
    {
        if (currentIndex > 0)
            --currentIndex;
    }

    private void MoveDown()
    {
        if (currentIndex != menuItems.Count - 1)
            ++currentIndex;
    }
}