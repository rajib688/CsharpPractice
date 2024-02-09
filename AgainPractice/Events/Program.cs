// See https://aka.ms/new-console-template for more information
using Events;

Console.WriteLine("Hello, World!");

Button button = new Button();

button.OnClick += Button_OnClick;
button.OnClick += Button_OnClick1;


void Button_OnClick(string message)
{
    Console.WriteLine(message);
}

void Button_OnClick1(string message)
{
    Console.WriteLine("From Method 1 " + message);
}

while (true)
{
    if (Console.ReadLine() == "click")
    {
        button.Click();
    }
    else
    {
        break;
    }
}