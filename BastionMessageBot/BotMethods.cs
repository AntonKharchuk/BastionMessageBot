﻿using BastionMessageBot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BastionMessageBot
{
    internal class BotMethods
    {
        private readonly HttpClient _client;
        private readonly string _url;

        public BotMethods(string url)
        {
            _client = new HttpClient();
            _url = url;
        }
        

        public async Task<int> SendMessage(string message)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, _url+ "/send-message");
            var messageObj = new Message()
            {
                Text = message
            };
            var json = JsonSerializer.Serialize(messageObj);
            request.Content = new StringContent(json, Encoding.UTF8, "application/json"); // Set the content type to "application/json"
            var response = await _client.SendAsync(request);
            var content = await response.Content.ReadAsStringAsync();

            return (int)response.StatusCode;
        }
    }
}
