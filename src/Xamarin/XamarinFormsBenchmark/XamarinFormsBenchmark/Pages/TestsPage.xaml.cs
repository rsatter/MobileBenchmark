using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinFormsBenchmark.Models;

namespace XamarinFormsBenchmark.Pages
{
    public partial class TestsPage :ContentPage
    {
        public TestsPage()
        {
            InitializeComponent();
            TestResults = new List<TestResult>();
            TestResults.Add(new TestResult()
            {
                Name = "Test 1",
                CPUUsage = "80%",
                MemoryUsage = "1000 MBs",
                Performance = "999 ms"
            });
            TestResults.Add(new TestResult()
            {
                Name = "Test 2",
                CPUUsage = "30%",
                MemoryUsage = "100 MBs",
                Performance = "50 ms"
            });
            BindingContext = this;
        }

        public List<TestResult> TestResults { get; set; }
    }
}
