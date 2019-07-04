using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.WebSockets;
using Microsoft.AspNetCore.Http;
using System.Threading;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;

namespace NightOwl
{
    public class WebSocket
    {

    
       
        private static ClientWebSocket client = new ClientWebSocket();

        async void ConnectToserver()
    {
        
        await client.ConnectAsync(new Uri("http://a2acb5c7.ngrok.io/api/token"), CancellationToken.None);
            
            await Task.Factory.StartNew(async () =>
            {
                while (true)
                {
                    await ReadMessage();
                }
            }, CancellationToken.None, TaskCreationOptions.LongRunning, TaskScheduler.Default);
        }

        async Task ReadMessage()
    {
        
        WebSocketReceiveResult result;
        var message = new ArraySegment<byte>(new byte[4096]);
        do
        {
            result = await client.ReceiveAsync(message, CancellationToken.None);
            if (result.MessageType != WebSocketMessageType.Text)
                break;
            var messageBytes = message.Skip(message.Offset).Take(result.Count).ToArray();
            string receivedMessage = Encoding.UTF8.GetString(messageBytes);
            Console.WriteLine("Received: {0}", receivedMessage);
        }
        while (!result.EndOfMessage);
    }

        async void SendMessageAsync(string message)
        {
          
            var byteMessage = Encoding.UTF8.GetBytes(message);
            var segmnet = new ArraySegment<byte>(byteMessage);

            await client.SendAsync(segmnet, WebSocketMessageType.Text, true, CancellationToken.None);
        }
    }
    
}
