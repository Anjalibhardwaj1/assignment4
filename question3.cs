using System;
using System.IO;

static class TextFileProcessor
{

    //delegate (something that points to a function that has a string as a parameter)
    //checks to see if curr message matches signature 
    public delegate void eventDelegate(string current);
    //creating an event
    public static event eventDelegate LineRead;

    //event trigger
    public static void RaiseEvent(string current)
    {
        if (LineRead != null) 
        { 
            LineRead(current); 
        }
            
 
    }

    //what the trigger does.
    public static void Read(string path)
    {
        string readText = File.ReadAllText(path);
        string[] lines = readText.Split('\n');
        foreach (string l in lines)
        {
            RaiseEvent(l);

        }
    }

    //this is the event handler
    static void current_(string current)
    {
        Console.WriteLine(current);
    }

    static void Main(string[] args)
    {
        //in class text.. the delegate is equal to the delegate witht the parameters of the method.
        //subscriber1, this code is just to instantiate
        LineRead += new eventDelegate(current_);
        //this will trigger the event
        Read(@"C:\Users\anjal\source\repos\assignment4\assignment4\hello.txt");
    }
}
