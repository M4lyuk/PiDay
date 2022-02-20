ConsoleKeyInfo cki;
int score = 0, fails = 0, index = 2;
string path = null, text = null;
bool goodpath = false, failsisnumber = false;
Console.WriteLine("█▀▀ █▀▀█ █▀▀▄ █▀▀ ░▀░ █▀▀▀ █░░█ █▀▀█ █▀▀ ");
Console.WriteLine("█░░ █░░█ █░░█ █▀▀ ▀█▀ █░▀█ █░░█ █▄▄▀ █▀▀ ");
Console.WriteLine("▀▀▀ ▀▀▀▀ ▀░░▀ ▀░░ ▀▀▀ ▀▀▀▀ ░▀▀▀ ▀░▀▀ ▀▀▀");
while (goodpath == false)
{
    Console.Write("path (defult = pi.txt): ");
    path = Console.ReadLine();
    if (path == "")
        try
        {
            text = System.IO.File.ReadAllText("pi.txt");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File was not found");
            Console.WriteLine("");
        }
    else
        try
        {
            text = System.IO.File.ReadAllText(path);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File was not found");
            Console.WriteLine("");
        }
    if (text != null)
        goodpath = true;
}
while (failsisnumber == false)
{
    Console.Write("fails (1 or more): ");
    try
    {
        fails = int.Parse(Console.ReadLine());
        if (fails > 0)
            failsisnumber = true;
        else
            Console.WriteLine("The number should be bigger than 0");
    }
    catch (System.FormatException)
    {
        Console.WriteLine("");
        Console.WriteLine("Please enter a number");
    }
}
Console.Clear();
Console.WriteLine("██████╗░██╗  ██████╗░░█████╗░██╗░░░██╗");
Console.WriteLine("██╔══██╗██║  ██╔══██╗██╔══██╗╚██╗░██╔╝");
Console.WriteLine("██████╔╝██║  ██║░░██║███████║░╚████╔╝░");
Console.WriteLine("██╔═══╝░██║  ██║░░██║██╔══██║░░╚██╔╝░░");
Console.WriteLine("██║░░░░░██║  ██████╔╝██║░░██║░░░██║░░░");
Console.WriteLine("╚═╝░░░░░╚═╝  ╚═════╝░╚═╝░░╚═╝░░░╚═╝░░░ Made by: LNIR947");
Console.WriteLine("");
Console.Write("\x1b[1m3.\x1b[0m");

while (fails > 0)
{
    cki = Console.ReadKey();
    if (cki.KeyChar == text[index])
        score++;
    else
    {
        Console.WriteLine("");
        Console.WriteLine("Wrong :O");
        fails--;
        if (fails != 0)
        {
            Console.Write("..." + text[index - 2] + text[index - 1]);
        }
    }
    index++;
}

Console.Clear();
Console.WriteLine("█▀▀▄ █▀▀█ █▀▀▄ █▀▀ ");
Console.WriteLine("█░░█ █░░█ █░░█ █▀▀ ");
Console.WriteLine("▀▀▀░ ▀▀▀▀ ▀░░▀ ▀▀▀");
Console.WriteLine("");
Console.WriteLine("Your score: " + score);