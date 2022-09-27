
using ParameterModifiers;

var example = new Example();

var r = example.sum(2, 3);
var r2 = example.sum(3, 4, 5);

example.sum(new int[] { 1, 2, 3 });

int p = 10;
example.test(ref p);
Console.WriteLine(p);


