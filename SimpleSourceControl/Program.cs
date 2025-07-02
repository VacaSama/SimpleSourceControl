/**
 * @Author: Kourtnie M.
 * July 2025 - SUMMER 2025
 * This is a super simple source control example, 
 * That I will be using for my first homework assignment in 
 * C#/.NET(CPW 211). 
 * */

public class SimpleSourceControl
{
    static void Main(String[] args)
    {
        Console.WriteLine("Hello, Source Control!");
        Changes();
    }

    static void Changes()
    {
        Console.WriteLine("There is a change below");
        Console.WriteLine("Here are some common bugs you may encounter: ");
        String[] bugs = {
        "Praying Mantis",
        "Cockroach",
        "Stink Bug",
        "Bumble Bee"};

        foreach (String bug in bugs)
        {
            Console.Write(bug + " ");
        }
    }
}