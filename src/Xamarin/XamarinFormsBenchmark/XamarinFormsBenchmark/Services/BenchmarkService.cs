using System;
using System.Diagnostics;
using System.Threading;
using Xamarin.Essentials;
using XamarinFormsBenchmark.Models;

namespace XamarinFormsBenchmark.Services
{
    /// <summary>
    /// Servicee to run benchmarks. I am not using BenchmarkDotNet as
    /// Xamarin is currently not supported.
    /// </summary>
    public class BenchmarkService
    {
        public static TestResult RunBenchmark(Action test)
        {
            Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.High;
            Thread.CurrentThread.Priority = ThreadPriority.Highest;
            TestResult result = new TestResult(1000);
            result.Name = test.Method.Name;
            Stopwatch stopwatch = Stopwatch.StartNew();


            // iOS is AOT thus JIT only for other platforms including Android
            // and Tizen
            if (DeviceInfo.Platform != DevicePlatform.Android)
            {
                test();
            }

            for (int i = 0; i < result.NumberOfRuns; i++)
            {
                stopwatch.Restart();
                test();
                stopwatch.Stop();
                result.MemoryUsage[i] = Process.GetCurrentProcess().PeakVirtualMemorySize64;
                result.Performance[i] = stopwatch.Elapsed;
            }
            return result;
        }
    }
}
