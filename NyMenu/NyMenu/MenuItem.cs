// See https://aka.ms/new-console-template for more information


class MenuItem : IMenuItem 
{
    public string Title { get; set; }
    public string Content { get; set; }

    public MenuItem(string title, string content)
    {
        Title = title;
        Content = content;
    }

    public void Select()
    {
        Console.Clear();
        Console.WriteLine(Content);
        Console.ReadKey();
    }
}