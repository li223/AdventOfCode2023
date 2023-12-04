using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;

public class HelloWorld
{
    private static string Text = @"[...]";
    
    public static void Main(string[] args)
    {
        var runningTotal = 0;
        foreach(var line in Text.Split("\n"))
        {
            var numbers = Regex.Matches(line, @"[0-9]").Select(x => int.Parse(x.Value)).ToArray();
            
            if(numbers.Count() == 1)
                runningTotal += int.Parse($"{numbers[0]}{numbers[0]}");
            else runningTotal += int.Parse($"{numbers[0]}{numbers.Last()}");
        }
        
        Console.WriteLine($"Total: {runningTotal}");
    }
}