
using IndexerExample;

int[] age = new int[20];

age[1] = 2;

List<int>  weights = new List<int>();
weights.Add(1);
weights[0] = 5;


Storage storage = new Storage(5);

storage.Add(3);
storage.Add(4);
storage.Add(5);
storage[1] = 9;

Console.WriteLine(storage[1]);