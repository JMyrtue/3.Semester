// See https://aka.ms/new-console-template for more information

internal interface IMenuItem
{
    string Title { get; set; }
    void Select();
}