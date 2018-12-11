using System;
using Xunit;

namespace Chronos.Core.Test
{
    public class IssueViewModelTest
    {
        [Fact]
        public void KeyEqualLabel()
        {
            var vm = new IssueViewModel(new ChronometerFake());
            vm.Key = "A key";
            Assert.Equal("A key", vm.Label);
        }

        [Fact]
        public void RunningWhenChronometerIsRunning()
        {
            var vm = new IssueViewModel(new ChronometerFake { Running = true });
            Assert.True(vm.Running);
        }

        [Fact]
        public void NotRunningWhenChronometerIsNotRunning()
        {
            var vm = new IssueViewModel(new ChronometerFake { Running = false });
            Assert.False(vm.Running);
        }

        [Fact]
        public void ElapsedFromChronometer()
        {
            var vm = new IssueViewModel(new ChronometerFake { Elapsed = new TimeSpan(1, 2, 3) });
            Assert.Equal(new TimeSpan(1, 2, 3), vm.Elapsed);
        }

        [Fact]
        public void ElapsedLabelFromChronometer()
        {
            var vm = new IssueViewModel(new ChronometerFake { Elapsed = new TimeSpan(1, 2, 3) });
            Assert.Equal("01h02m03s", vm.ElapsedLabel);
        }

        [Fact]
        public void StartStopButtonOnClickWhenNotRunning()
        {
            var vm = new IssueViewModel(new ChronometerFake { Running = false });
            vm.StartStopButtonOnClick();
            Assert.True(vm.Running);
        }

        [Fact]
        public void StartStopButtonOnClickWhenRunning()
        {
            var vm = new IssueViewModel(new ChronometerFake { Running = true });
            vm.StartStopButtonOnClick();
            Assert.False(vm.Running);
        }
    }
}