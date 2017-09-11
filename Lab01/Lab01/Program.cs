using System;
using System.IO;
public class switchLearning
{
    public static void Main()
    {
        Console.Write("Input day name : ");
        string gradeString = Console.ReadLine();
        string message;
        switch (gradeString.ToUpper())
        {
            case "SUN":
                message = "sun is Sunday color Red.";
                break;
            case "MON":
                message = "mon is Monday color Yellow.";
                break;
            case "TUE":
                message = "tue is Tuesday color Pink.";
                break;
            case "WED":
                message = "wed is Wednesday color Green.";
                break;
            case "THU":
                message = "thu is Thursday color Orange.";
                break;
            case "FRI":
                message = "fri is friday color Blue.";
                break;
            case "SAT":
                message = "sat is Saturday color Purple.";
                break;
            default:
                message = "Incorrect grade";
                break;
        }
        Console.WriteLine(message);
    }
}
