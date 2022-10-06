// See https://aka.ms/new-console-template for more information

class Menu : IMenuItem 
{
    public string Title { get; set; }
    public bool running = true;
    public int currentIndex = 0;
    public List<IMenuItem> menuList = new List<IMenuItem>();

    public Menu(string title)
    {
        Title = title;
    }

    public void Add(IMenuItem item)
    {
        menuList.Add(item);
    }

    public void Start()
    {
        do
        {
            DrawMenu();
            HandleInput();
        } while (running);
    }

    public virtual void Select()
    {
        Start();
    }

    public virtual void DrawMenu()
    {
        Console.Clear();
        Console.WriteLine(Title);
        for(int i = 0; i < menuList.Count; i++)
        {
            if (i == currentIndex)
                Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine(menuList[i].Title);
            Console.ResetColor();
        }
    }
    
    public virtual void HandleInput()
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
                menuList[currentIndex].Select();
                break;
            default:
                break;
        }
    }

    public void MoveUp()
    {
        if (currentIndex != 0)
            --currentIndex;
    }

    public void MoveDown()
    {
        if (currentIndex < menuList.Count - 1)
            ++currentIndex;
    }
}

