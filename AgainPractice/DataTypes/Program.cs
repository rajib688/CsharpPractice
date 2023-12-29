


namespace AgainPractice
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Start your Program, ALhamdullam !.\n\n");

            //Byte
            Console.WriteLine("The Min value" + " Of Byte : {0}", Byte.MinValue);
            Console.WriteLine("The Max value" + " Of Byte : {0}", Byte.MaxValue);
            byte val = (byte)int.Parse(Console.ReadLine());
            byte val1 = 40;
            Console.WriteLine("Comparion 1: {0}", val.CompareTo(val1));

            //Sbyte
            sbyte num = 109;
            Console.WriteLine("Type of num :" + num.GetType());
            Console.WriteLine("This is Num: ", num);
            Console.WriteLine("Size of sbyte of variable : " + sizeof(sbyte));

            //short
            short variable_name = 45;
            Console.WriteLine("Variable Name: " + variable_name.GetType());
        }
    }
}

