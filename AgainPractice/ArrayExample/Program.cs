/*
int Count = 0;
int[] ArrayList = new int [] { 10, 15, 14, 12, 20, 18, 20, 25, 100};
Console.WriteLine("Index number :" + ArrayList[5]);
for (int i=0; i< ArrayList.Length; i++)
{

    Console.WriteLine($"{ Count++ } {ArrayList[i]}");
    
}


foreach (int item in ArrayList)
{

    Console.WriteLine();
    Console.WriteLine($"{Count++}  {item}");
}
*/

//int[,] twoDimensionalArray = new int[,] {
//            { 1, 2, 3 },
//            { 4, 5, 6 },
//            { 7, 8, 9 }
//        };
//int row = twoDimensionalArray.GetLength(0);
//int colums = twoDimensionalArray.GetLength(1);

//for (int i = 0; i < row; i++)
//{
//    for (int j = 0; j < colums; j++)
//    {
//        Console.Write(twoDimensionalArray[i,j]+" ");
//    }
//    Console.WriteLine();
//}



//int[] InitialArray = { 12, 14, 14, 1414, 232, 32, 3, 23, 2, 3, 2, 32, 3, 23, 23 };
//int[] destinationArray = new int[InitialArray.Length];


//Array.Copy(InitialArray, destinationArray, InitialArray.Length);

//Console.WriteLine("Source Array:");
//PrintArray(InitialArray);


//Console.WriteLine("\nCopied Array:");
//PrintArray(destinationArray);

//static void PrintArray(int[] Array)
//{
//    foreach (var item in Array)
//    {
//        Console.WriteLine(item + " ");
//    }
//    Console.WriteLine();
//}



//        Console.WriteLine("Enter the size of the array:");
//        if (!int.TryParse(Console.ReadLine(), out int size) || size <= 0)
//        {
//            Console.WriteLine("Please enter a valid size (a positive integer).");
//            return;
//        }

//        int[] userArray = new int[size];

//        // Taking input values for the array
//        Console.WriteLine($"Enter {size} integer values for the array:");

//        for (int i = 0; i < size; i++)
//        {
//            Console.Write($"Enter value {i + 1}: ");
//            if (!int.TryParse(Console.ReadLine(), out userArray[i]))
//            {
//                Console.WriteLine("Invalid input. Please enter an integer.");
//                i--; // Decrement i to re-enter the current index
//            }
//        }

//        // Displaying the entered array
//        Console.WriteLine("\nEntered Array:");
//PrintArray(userArray);

//// Method to print the contents of an array
//static void PrintArray(int[] array)
//    {
//        foreach (var item in array)
//        {
//            Console.Write(item + " ");
//        }
//        Console.WriteLine();
//    }


int[] sourceArray = { 1, 2, 3, 4, 5 };
int[] destinationArray = new int[sourceArray.Length];

// Copy values from sourceArray to destinationArray using a for loop
for (int i = 0; i < sourceArray.Length; i++)
{
    destinationArray[i] = sourceArray[i];
}




var Veriable = destinationArray;
// Print sourceArray and destinationArray
Console.WriteLine("Source Array:");
PrintArray(sourceArray);

Console.WriteLine("\nCopied Array:");
PrintArray(destinationArray);


static void PrintArray(int[] array)
{
    foreach (var item in array)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}

int[][] JaggArray = new int[3][];
JaggArray[0] = new int[3];
JaggArray[1] = new int[4];
JaggArray[2] = new int[2];
Console.WriteLine(JaggArray.GetLength(0));
Console.WriteLine(JaggArray[1].GetLength(0));
