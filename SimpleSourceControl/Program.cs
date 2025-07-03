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
        String[] badPuns =
        {
                "Why do Java developers wear glasses? \nBecause they don’t C#.",
                "What do computers snack on during break? \nMicrochips and cookies.",
                "Why was the computer cold? \nIt left its Windows open. "
        };
        CommonBugs();
        ComputerPuns(badPuns);
        FeedBack();
    }

    // branch the methods off so that they can be tested independently?
    static void CommonBugs()
    {
        welcomeMessage();
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
    static void PestControl() { 
        // this method will tell the user how to "debug and 
        // get rid of the pests in the method above.
    }
    static void ComputerPuns(string[] badPuns)
    {
        Console.WriteLine("\nNow it's time for a computer pun :p ");
        Random random = new Random();

            // have to use integer division to get a random index
            // it's not like Java.
            int laugh = random.Next(badPuns.Length);
            Console.WriteLine(badPuns[laugh]);
    }
    static void FeedBack()
    {
        Console.WriteLine("\nDid you enjoy your randomly selected pun? (yes/no) ");
        string response = Console.ReadLine();

        if (response == "yes")
        {
            Console.WriteLine("Yay, I'm glad you liked it");
            Console.WriteLine("See ya, next time.");
        }
        else if (response == "no")
        {
            Console.WriteLine("Aww, I'm sorry to hear that. " +
                "I will try harder next time.");
            Console.WriteLine("See ya, next time.");
        }
        else
        {
            Console.WriteLine("I don't understand your response. " +
                "Please try again.");
            // Call the method again to get feedback
            FeedBack();
        }
    }
    
    static void welcomeMessage() { 
        Console.WriteLine("Welcome to my Source Control, Mini Project for CPW 211,");
        Console.WriteLine("Here you'll find bugs you'll run into.");
        Console.WriteLine("How to debug, and you will be given a randomly generated CPU pun.");
        Console.WriteLine();
    }
}
