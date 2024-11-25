// See https://aka.ms/new-console-template for more information
using System;
class Book
{
string title;
string author;
double prise;
    public  void PrintDetails() { 
        title = "title1";
        author = "author1";
        prise = 1.1;

    }}
 class Program
{
    
    public static void IsEven(int number){

if(number % 1 == 1){
    Console.WriteLine($"number is odd{number}");

}else{
    Console.WriteLine($"number is even{number}");
}}
public static void PrintDetails(string title, string author, double prise) { }
    public static void Main(string[] args)
    {


        IsEven(1);





        //----------------------------------------------------------
        //the forth
        Console.WriteLine("enter your age: ");
        int agee = int.Parse(Console.ReadLine());
        if (agee <= 12)
        {
            Console.WriteLine("You are a child");
        }
        else if (agee >= 13 && agee <= 17)
        {
            Console.WriteLine("You are a teenager");
        }
        else
        {
            Console.WriteLine("You are an adult");

        }










        //---------------------------------------------------------------------
        //the fifth
        Console.WriteLine("enter a number : ");
        int m = int.Parse(Console.ReadLine());
        switch (m)
        {
            case 1:
                Console.WriteLine($"{m} = jANUARY");
                break;
            case 2:
                Console.WriteLine($"{m} = FEBRUARY");
                break;
            case 3:
                Console.WriteLine($"{m} = MARCH");
                break;
            case 4:
                Console.WriteLine($"{m} = MAY");
                break;
            case 5:
                Console.WriteLine($"{m} = APRILE");
                break;
            case 6:
                Console.WriteLine($"{m} = JUNE");
                break;
            case 7:
                Console.WriteLine($"{m} = jULY");
                break;
            case 8:
                Console.WriteLine($"{m} = AUGUST");
                break;
            case 9:
                Console.WriteLine($"{m} = SEPTEBER");
                break;
            case 10:
                Console.WriteLine($"{m} = ACTOPER");
                break;
            case 11:
                Console.WriteLine($"{m} = NOVEMBER");
                break;
            case 12:
                Console.WriteLine($"{m} = DESEMBER");
                break;


        }







        //-----------------------------------------------------------------
        // the first
        string name = "Najla";
        int age = 19;
        double FNum = 1.1;

        Console.WriteLine($"hello my name is {name}. I am {age} years old and my favorite number is {FNum}");









        //-----------------------------------------------------------------------------
        // the second
        int[] array = new int[5] ;



        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("enter number :");
            int num = int.Parse(Console.ReadLine());
            array[i] = num;
            Console.WriteLine(array);
            

        }
        
        
    }
}









