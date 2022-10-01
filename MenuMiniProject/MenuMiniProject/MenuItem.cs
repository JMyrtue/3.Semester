public class MenuItem : IMenuItem
{
	public string Content { get; set; }
	public string Title { get; set; }

	public MenuItem(string title, string content)
	{
		Title = title;
		Content = content;
	}

	public void Select()
	{
		Console.WriteLine(Content);
	}
}