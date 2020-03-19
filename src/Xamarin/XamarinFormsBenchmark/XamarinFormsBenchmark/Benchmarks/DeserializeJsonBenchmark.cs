using System;
using XamarinFormsBenchmark.Models;

namespace XamarinFormsBenchmark.Benchmarks
{
    /// <summary>
    /// DeserializeTest tests the performance of deserialization of a local json file.
    /// </summary>
    public class DeserializeJsonBenchmark : BaseBenchmark
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="numberOfRuns"></param>
        public DeserializeJsonBenchmark(int numberOfRuns) : base(numberOfRuns)
        {
        }

        /// <summary>
        /// Deserialize a local json file into a collection of objects.
        /// </summary>
        public override void ExecuteBenchmark()
        {
            
        }
    }
}