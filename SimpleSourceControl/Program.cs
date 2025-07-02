

using System.Net;
using System.Security.Cryptography;

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
        String[] badPuns =
        {
                "Why do Java developers wear glasses? \nBecause they don’t C#.",
                "What do computers snack on during break? \nMicrochips and cookies.",
                "Why was the computer cold? \nIt left its Windows open. "
        };
        CommonBugs();
        ComputerPuns();
    }

    static void CommonBugs()
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
        Console.WriteLine();
        Console.WriteLine("\nI think you were expecting software bugs" +
            "\nJust a little play on words");
    }
    static void ComputerPuns()
    {
        Console.WriteLine();
        String[] badPuns =
        {
                "Why do Java developers wear glasses? \nBecause they don’t C#.",
                "What do computers snack on during break? \nMicrochips and cookies.",
                "Why was the computer cold? \nIt left its Windows open. "
        };
        Random random = new Random();
        // Randomly select a pun from the array 
        // shuffle array by going backwards through the array
        for (int i = badPuns.Length - 1; i > 0; i--)
        {
            // have to use integer division to get a random index
            // it's not like Java.
            int laugh = random.Next(0, badPuns.Length);
            Console.WriteLine(badPuns[laugh]);
        }
    }
}