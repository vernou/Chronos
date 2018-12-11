using System;

namespace Chronos.Core
{
    public sealed class IssueViewModel
    {
        private readonly Chronometer _chronometer;

        public IssueViewModel(Chronometer chronometer)
        {
            _chronometer = chronometer;
        }

        public string Key { get; set; }
        public string Label => Key;
        public bool Running => _chronometer.Running;
        public TimeSpan Elapsed => _chronometer.Elapsed;
        public string ElapsedLabel => $"{Elapsed.Hours:00}h{Elapsed.Minutes:00}m{Elapsed.Seconds:00}s";

        public void StartStopButtonOnClick() => _chronometer.Running = !_chronometer.Running;
    }
}