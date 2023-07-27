using BastionMessageBot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BastionMessageBot
{
    internal static class BotMethods
    {
        static private readonly HttpClient _client;
        static private readonly string _url;

        static BotMethods()
        {
            _client = new HttpClient();
            _url = "https://localhost:7251/send-message";
        }
        

        public static async Task<int> SendMessage(string message)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, _url);
            var messageObj = new Message()
            {
                Text = message
            };
            var json = JsonSerializer.Serialize(messageObj);
            request.Content = new StringContent(json, Encoding.UTF8, "application/json"); // Set the content type to "application/json"
            var response = await _client.SendAsync(request);

            return (int)response.StatusCode;
        }
    }
}
