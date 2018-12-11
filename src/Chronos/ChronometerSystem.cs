using System;
using System.Diagnostics;
using Chronos.Core;

namespace Chronos
{
    public sealed class ChronometerSystem : Chronometer
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