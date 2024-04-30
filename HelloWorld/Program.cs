Console.WriteLine("What is your name?");
var name = Console.ReadLine();
var currentDate = DateTime.Now;
Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!{Environment.NewLine}");
Console.WriteLine($"{Environment.NewLine}Press any key to exit...");
Console.ReadKey(true);
