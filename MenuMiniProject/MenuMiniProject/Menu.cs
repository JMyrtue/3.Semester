using System;

class Menu : IMenuItem
{
    public bool running = true;
    public string Title { get; set; }
    public int currentIndex = 0;

    List<IMenuItem> menuItems = new List<IMenuItem>();

    public Menu(string title)
    {
            Title = title;
    }

    public void Add(IMenuItem item)
    {
            menuItems.Add(item);
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
                Select();
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

    public void Select()
    {
        if(menuItems[currentIndex] is Menu menu) 
            {
            running = false;
            Console.Clear();
            menu.Start();
            }
        else if (menuItems[currentIndex] is MenuItem item) 
            {
            Console.Clear();
            running = false;
            item.Select();
            }
    }
}