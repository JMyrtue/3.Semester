using System;

 class InfinityMenu : Menu
{
    public string Title { get; set; }
    public InfinityMenu(string title) : base(title)
	{
        Title = title;
    }
    
    public override void Select()
    {
        Console.Clear();
        running = false;
        InfinityMenu infMenu = new InfinityMenu("INFMENU");
        infMenu.Build();
        infMenu.Start();
    }

    public void Build()
    {
        for (int i = 0; i < 6; i++)
        {
            Add(new MenuItem("InfinityMenu!", "Content"));
        }
    }
}
