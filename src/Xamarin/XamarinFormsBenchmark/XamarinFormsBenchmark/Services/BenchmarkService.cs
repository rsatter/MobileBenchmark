using System;
using System.Diagnostics;
using System.Threading;
using Xamarin.Essentials;
using XamarinFormsBenchmark.Models;
using XamarinFormsBenchmark.Benchmarks;

namespace XamarinFormsBenchmark.Services
{
    /// <summary>
    /// Servicee to run benchmarks. I am not using BenchmarkDotNet as
    /// Xamarin is currently not supported.
    /// </summary>
    public class BenchmarkService
    {
        public static void RunBenchmark(BaseBenchmark test)
        {
            Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.High;
            Thread.CurrentThread.Priority = ThreadPriority.Highest;
            Stopwatch stopwatch = Stopwatch.StartNew();

            test.Initialize();
            // iOS is AOT thus JIT only for other platforms including Android
            // and Tizen
            if (DeviceInfo.Platform != DevicePlatform.Android)
            {
                test.SetupBenchmark();
                test.ExecuteBenchmark();
                test.TeardownBenchmark();
            }

            for (int i = 0; i < test.NumberOfRuns; i++)
            {
                test.SetupBenchmark();
                stopwatch.Restart();
                test.ExecuteBenchmark();
                stopwatch.Stop();
                test.TestResult.MemoryUsage[i] = Process.GetCurrentProcess().PeakVirtualMemorySize64;
                test.TestResult.Performance[i] = stopwatch.Elapsed;
                test.TeardownBenchmark();
                ClearMemory();
            }
            
        }

        /// <summary>
        /// Clear memory by forcing a garbage collection.
        /// </summary>
        private static void ClearMemory()
        {
            GC.Collect(0);
            GC.Collect(1);
            GC.Collect(2);
            GC.WaitForFullGCComplete();
        }
    }
}
