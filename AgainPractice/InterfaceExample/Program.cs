// See https://aka.ms/new-console-template for more information
using InterfaceExample;

Console.WriteLine("Hello, World!");

IEngine turboEngine = new TurboEngine(200);
Console.WriteLine(turboEngine.GetSpeed());

TurboEngine turbo = new TurboEngine(200);
turbo.Start();

FifthGenEngine fifthGen = new FifthGenEngine();
fifthGen.Start();