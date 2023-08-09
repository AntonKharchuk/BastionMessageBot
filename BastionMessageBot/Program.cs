// See https://aka.ms/new-console-template for more information
using BastionMessageBot;

Console.Write("Write API url: ");
var apiUrl = Console.ReadLine();

apiUrl = apiUrl.Trim();

Bot bot = new Bot(apiUrl);

bot.Start();

Console.ReadKey();
