using System;

namespace Chronos.Core.Test
{
    public sealed class ChronometerFake : Chronometer
    {
        public bool Running { get; set; }
        public TimeSpan Elapsed { get; set; }
    }
}