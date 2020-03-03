using XamarinFormsBenchmark.Models;

namespace XamarinFormsBenchmark.Tests
{
    /// <summary>
    /// Abstract class of a test. This is to allow for running multiple tests.
    /// </summary>
    public abstract class Test
    {
        /// <summary>
        /// Name of the test.
        /// </summary>
        public string Name => GetType().Name;

        /// <summary>
        /// The results of the test.
        /// </summary>
        public TestResult TestResult { get; protected set; }

        public Test()
        {
            TestResult = new TestResult();
        }

        /// <summary>
        /// Execute the test.
        /// </summary>
        public abstract void ExecuteTest();
    }
}
