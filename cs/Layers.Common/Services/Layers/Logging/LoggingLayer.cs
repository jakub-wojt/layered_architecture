using System;
using System.Diagnostics;
using Layers.Common.Dto;
using Layers.Common.Services.Layers.Base;

namespace Layers.Common.Services.Layers.Logging
{
    public class LoggingLayer : ServicesLayer, ILoggingLayer
    {
        private readonly TraceSource _traceSource = new TraceSource("Log");

        public TraceSource TraceSource {
            get
            {
                return _traceSource;
            }
        }

        public LoggingLayer(IServicesLayer decoratedLayer) : base(decoratedLayer)
        {
            _traceSource.Listeners.Add(new ConsoleTraceListener(false));
        }

        public override void AddItem(ItemDto item)
        {
            try
            {
                _traceSource.TraceInformation("Calling: AddItemToBasket {0}", item);
                base.AddItem(item);
            }
            catch (Exception e)
            {
                _traceSource.TraceEvent(TraceEventType.Error, 0x100, "AddItemToBasket error: " + e);
                throw;
            }
        }

        //...
    }
}
