// See https://aka.ms/new-console-template for more information

class InfinityMenu : Menu
{

    public InfinityMenu(string title) : base(title)
    {
        Title = title;
    }

    public override void Select()
    {
        InfinityMenu infMenu = new InfinityMenu("InfinityMenu!");
        for (int i = 0; i < 6; i++)
        {
            infMenu.Add(new InfinityMenu("InfinityMenu"));
        }
        infMenu.Start();
    }
}
