// See https://aka.ms/new-console-template for more information

using EventExample;

Button button = new Button();
button.OnClick += Button_OnClick;
button.OnClick += Button_OnClick2;



void Button_OnClick(string message)
{
    Console.WriteLine(message);
}

void Button_OnClick2(string message)
{
	Console.WriteLine("From method 2 " + message);
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