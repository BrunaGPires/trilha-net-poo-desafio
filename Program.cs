using DesafioPOO.Models;

Nokia nokia = new Nokia("(51)988156070", "NokiaTijolao", "880088", 64);
Iphone iphone = new Iphone("(51)988156070", "IphoneSE", "880088", 128);

Console.WriteLine("Nokia");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");
Console.Write("\n");
Console.WriteLine("Iphone");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("X(Twitter)");