using System;

namespace Chronos.Core
{
    public interface Chronometer
    {
        bool Running { get; set; }
        TimeSpan Elapsed { get; }
    }
}