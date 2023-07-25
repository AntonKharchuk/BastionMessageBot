// See https://aka.ms/new-console-template for more information
using BastionMessageBot;

//Bot bot = new Bot();

//bot.Start();

//Console.ReadKey();

HttpRequestSender httpRequestSender = new HttpRequestSender();


var reply = httpRequestSender.SendRequest("https://simple-books-api.glitch.me", "GET").Result;


foreach (var header in reply.Headers)
{
    Console.WriteLine("{0} - {1}",header.Key, header.Value.First());
}

Console.ReadKey();
