// See https://aka.ms/new-console-template for more information

int x = 5;
int[] Ages;
Ages = new int [5];
Ages[0]= 10;
Ages[1]= 20;
Ages[2]= 30;
Ages[3]= 40;
Ages[4]= 50;

int t = Ages[3];

int[] ages1 = new int[] {10,20,30,40,50};



int[,] Grid = new int[4,4];
Grid[0, 0] = 3;
Grid[0, 1] = 4;

int[,] Grid2 = new int[,]
    {
        { 2, 3},
        { 4, 4}
    };

int[][] JaggedArray = new int[4][];
JaggedArray[0] = new int[3]; 
JaggedArray[1] = new int[4]; 
JaggedArray[2] = new int[2];

Console.WriteLine(JaggedArray[2].Length);


var p = 5;

var r = "Rajib";


var p1 = sum(2,3);

int sum(int a, int b)
{
    return a + b;
}