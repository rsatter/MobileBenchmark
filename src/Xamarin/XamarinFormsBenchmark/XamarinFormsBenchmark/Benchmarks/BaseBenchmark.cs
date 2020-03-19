using XamarinFormsBenchmark.Models;

namespace XamarinFormsBenchmark.Benchmarks
{
    /// <summary>
    /// Abstract class of a benchmark. This is to allow for running the
    /// benchmark multiple times.
    /// </summary>
    public abstract class BaseBenchmark
    {
        /// <summary>
        /// Name of the test.
        /// </summary>
        public string Name => GetType().Name;

        /// <summary>
        /// Number of times to execute the test.
        /// </summary>
        public int NumberOfRuns { get; private set; }

        /// <summary>
        /// The results of the test.
        /// </summary>
        public BenchmarkResults TestResult { get; protected set; }

        /// <summary>
        /// Base constructor for benchmark.
        /// </summary>
        /// <param name="numberOfRuns">
        /// Number of times to run a benchmark.
        /// </param>
        public BaseBenchmark(int numberOfRuns)
        {
            TestResult = new BenchmarkResults(numberOfRuns);
        }

        /// <summary>
        /// Execute the benchmark.
        /// </summary>
        public abstract void ExecuteBenchmark();

        /// <summary>
        /// Clean up the benchmark. HouseKeeping is run only once and not
        /// measured.
        /// </summary>
        public void HouseKeeping()
        {

        }

        /// <summary>
        /// Initialize the benchmark. The initialize is run only once and not
        /// measured.
        /// </summary>
        public void Initialize()
        {

        }

        /// <summary>
        /// Set up code prior to running each iteration. The set up code is not
        /// measured.
        /// </summary>
        public void SetupBenchmark()
        {

        }

        /// <summary>
        /// Teardown code run after each iteration. The teardown code is not
        /// measured.
        /// </summary>
        public void TeardownBenchmark()
        {

        }
    }
}
