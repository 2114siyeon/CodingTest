using System;

public class Example
{
    public static void Main()
    {
        String s;
        String answer = "";

        Console.Clear();
        s = Console.ReadLine();
        
        foreach(char c in s)
        {
           answer += char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c);
        }
        Console.WriteLine(answer);
    }
}