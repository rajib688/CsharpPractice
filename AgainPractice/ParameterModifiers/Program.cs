// See https://aka.ms/new-console-template for more information
using ParameterModifiers;

Console.WriteLine("Hello, World!");


ParameterExample parameterExample = new ParameterExample();


var r = parameterExample.Sum(2, 3);
var r1 = parameterExample.Sum(2, 3,5);



parameterExample.Sum(new int[] { 1, 2, 3, 4, 5 });

Console.WriteLine(r1);

int x = 10;
parameterExample.Test(ref x);