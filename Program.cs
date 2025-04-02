using System;
using System.Media;
internal class Program
{
    private static void Main(string[] args)
    {


        //ASCII Art
        Console.WriteLine("" +
            "   ______      __              ______                     __\r\n  / ____/_  __/ /_  ___  _____/ ____/_  ______ __________/ /\r\n / /   / / / / __ \\/ _ \\/ ___/ / __/ / / / __ `/ ___/ __  / \r\n/ /___/ /_/ / /_/ /  __/ /  / /_/ / /_/ / /_/ / /  / /_/ /  \r\n\\____/\\__, /_.___/\\___/_/   \\____/\\__,_/\\__,_/_/   \\__,_/   \r\n     /____/                                                 ");

        //Greeting message 
        SoundPlayer sp = new SoundPlayer("Greeting message2.wav");
        sp.Load();
        sp.Play();
        int S = int.Parse(Console.ReadLine());


        


        
        
    }


}