using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia("12369", "1100", "123456789", 16);
nokia.Ligar();
nokia.InstalarAplicativo("Jogo da Cobrinha");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone("12369", "12 pro max", "123456789",256);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");