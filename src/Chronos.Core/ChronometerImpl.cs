using System;
using System.Diagnostics;

namespace Chronos.Core
{
    public sealed class ChronometerImpl : Chronometer
    {
        private readonly Stopwatch _stopwatch = new Stopwatch();

        public bool Running
        {
            get => _stopwatch.IsRunning;
            set
            {
                if(_stopwatch.IsRunning)
                    _stopwatch.Stop();
                else
                    _stopwatch.Start();
            }
        }

        public TimeSpan Elapsed => _stopwatch.Elapsed;
    }
}