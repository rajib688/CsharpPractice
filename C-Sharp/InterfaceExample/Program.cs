// See https://aka.ms/new-console-template for more information


using InterfaceExample;

IEngine engine = new TurboEngine(200);
Console.WriteLine(engine.GetSpeed());


TurboEngine t = new TurboEngine(200);
t.Start();
FifthGenEngine f = new FifthGenEngine();
f.Start();
