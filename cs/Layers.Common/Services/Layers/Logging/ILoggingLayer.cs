using System.Diagnostics;

namespace Layers.Common.Services.Layers.Logging
{
    public interface ILoggingLayer
    {
        TraceSource TraceSource { get; }
    }
}