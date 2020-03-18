using System;
namespace XamarinFormsBenchmark.Models
{
    public class TestResult
    {
        public TestResult(int numberOfRuns)
        {
            NumberOfRuns = numberOfRuns;
            MemoryUsage = new long[numberOfRuns];
            Performance = new TimeSpan[numberOfRuns];
        }

        public string CPUUsage { get; set; }
        public long[] MemoryUsage { get; set; }
        public string Name { get; set; }
        public int NumberOfRuns{ get; private set; }
        public TimeSpan[] Performance { get; set; }
    }
}
