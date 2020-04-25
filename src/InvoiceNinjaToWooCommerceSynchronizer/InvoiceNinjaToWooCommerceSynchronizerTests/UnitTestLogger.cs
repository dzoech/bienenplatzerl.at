using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Logging;

namespace InvoiceNinjaToWooCommerceSynchronizerTests
{
    class UnitTestLogger : ILogger
    {
        public IDisposable BeginScope<TState>(TState state) => NullScope.Instance;

        public bool IsEnabled(LogLevel logLevel) => false;

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            string message = formatter(state, exception);
            Console.WriteLine($"{logLevel}: {message}");
        }
    }
}
