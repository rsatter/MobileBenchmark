using System;

namespace XamarinFormsBenchmark.Models
{
    /// <summary>
    /// Results of a benchmark.
    /// </summary>
    public class BenchmarkResults
    {
        public BenchmarkResults(int numberOfRuns)
        {
            NumberOfRuns = numberOfRuns;
            MemoryUsage = new long[numberOfRuns];
            Performance = new TimeSpan[numberOfRuns];
        }

        public string CPUUsage { get; set; }
        public long[] MemoryUsage { get; set; }
        public int NumberOfRuns{ get; private set; }
        public TimeSpan[] Performance { get; set; }
    }
}
