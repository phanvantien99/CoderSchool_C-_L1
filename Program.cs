namespace CoderSchool_L1;

class Program
{
    static void Main(string[] args)
    {
        //Part 1 Print a string to the console
        //hint: Console.WriteLine("Hello World!");
        Console.WriteLine("Hello, World!");

        //Part 2 Get user input and print it to the console
        //hint: Console.ReadLine();
        string? s1 = Console.ReadLine();
        string? s2 = Console.ReadLine();
        
        //Part 3 Get two inputs from the user and print them on separate lines
        //hint: use \n to create a new line
        Console.WriteLine("Input 1: " + s1 + "\nInput 2: " + s2);
    }
}
