

    class Program
    {
    public static void Main(string[] args)
    {
        //int[] age = { 12, 45, 11, 20, 76, 21, 30 };
        //var demo = from i in age where i > 20 select i;
        //var demo = from i in age where i > 20 orderby i select i;

        string[] name = { "vipin", "rudra", "kalpana", "Veeru", "Deepak" };
        // var demo = from a in name where a.StartsWith("v")  select a;
        var demo = from a in name where a.Contains("v") select a;

        foreach (string item in demo) 
        {
            Console.WriteLine(item); 
        }
        Console.ReadLine();
    }
    }

