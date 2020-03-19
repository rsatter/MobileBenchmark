using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinFormsBenchmark.Models;

namespace XamarinFormsBenchmark.Pages
{
    public partial class BenchmarkPage :ContentPage
    {
        public BenchmarkPage()
        {
            InitializeComponent();
            TestResults = new List<BenchmarkResults>();
            }

        public List<BenchmarkResults> TestResults { get; set; }
    }
}
