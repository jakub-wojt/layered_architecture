using System;
using System.IO;
using System.Net;
using System.Text;
using Layers.Common.Services;
using Layers.Common.Services.Layers.Base;

namespace Layers.Server.Services.Layers.Transport
{
    /// <summary>
    /// Class responsible for handling requests (reading socket, deserializing data, etc ...) 
    /// and sending responses (data serialization, sending data to stream)
    /// </summary>
    public class TransportLayer : ServicesLayer, ITransportLayer
    {
        private readonly HttpListener _httpListener = new HttpListener();
        public TransportLayer(IServicesLayer decoratedLayer) : base(decoratedLayer)
        {
            
        }

        public void StartListener()
        {
            _httpListener.Prefixes.Add("http://localhost:8080/index/");
            _httpListener.Start();
            _httpListener.BeginGetContext(ListenerCallback, _httpListener);
        }

        private static void ListenerCallback(IAsyncResult result)
        {
            HttpListener listener = (HttpListener) result.AsyncState;
            //deserialize request + params
            //call base.RequestedFunction
            //serialize + send result / response

            listener.BeginGetContext(new AsyncCallback(ListenerCallback), listener);
            Console.WriteLine("New request.");

            HttpListenerContext context = listener.EndGetContext(result);
            HttpListenerRequest request = context.Request;
            HttpListenerResponse response = context.Response;

            var textBytes = Encoding.ASCII.GetBytes("To jest response!!!!");
            response.ContentLength64 = textBytes.Length;
            response.OutputStream.Write(textBytes, 0, textBytes.Length);
            response.OutputStream.Flush();
            response.Close();

        }
    }
}
