using ArgHandling;
using ImageGeneration; // Not yet implemented

ArgumentParser parser = new();
parser.AddArgument("demo", "d", "demofile", help: "Path to demo file output");

Dictionary<string, string> kwargs;
try
{
    kwargs = parser.Parse(args);
}
catch (ArgumentException ex)
{
    Console.Error.WriteLine(ex.Message);
    parser.PrintHelp();
    return;
}

if (kwargs.ContainsKey("help"))
{
    parser.PrintHelp();
    return;
}

ExampleImage demo; // Not yet implemented

if (kwargs.ContainsKey("demofile"))
{
    demo = new(kwargs["demofile"]);
}
else
{
    demo = new();
}

demo.Render();
