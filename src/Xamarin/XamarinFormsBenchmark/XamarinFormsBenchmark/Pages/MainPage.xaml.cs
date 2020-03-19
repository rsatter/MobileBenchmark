using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinFormsBenchmark.Services;

namespace XamarinFormsBenchmark.Pages
{
    /// <summary>
    /// Main screen which can be used to trigger tests..
    /// </summary>
    [DesignTimeVisible(false)]
    public partial class MainPage :ContentPage
    {
        /// <summary>
        /// Constructor for MainPage.
        /// </summary>
        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Run all tests.
        /// </summary>
        /// <param name="sender">Source of event</param>
        /// <param name="e">Event arguments</param>
        void AllTests(object sender, EventArgs e)
        {
            ContentPage page = new BenchmarkPage()
            {
                Title = "Results - All Tests"
            };
            Navigation.PushAsync(page);
        }

        /// <summary>
        /// Run database tests.
        /// </summary>
        /// <param name="sender">Source of event</param>
        /// <param name="e">Event arguments</param>
        void DatabaseTests(Object sender, EventArgs e)
        {
            ContentPage page = new BenchmarkPage()
            {
                Title = "Results - All Tests"
            };
            Navigation.PushAsync(page);
        }

        /// <summary>
        /// Run serialization tests.
        /// </summary>
        /// <param name="sender">Source of event</param>
        /// <param name="e">Event arguments</param>
        void SerializationTests(Object sender, EventArgs e)
        {
            ContentPage page = new BenchmarkPage()
            {
                Title = "Results - All Tests"
            };
            Navigation.PushAsync(page);
        }

        /// <summary>
        /// Setup app on device. This only needs to be done once. It is
        /// recommended that you close and reopen the app in order to ensure a
        /// good starting state.
        /// </summary>
        /// <param name="sender">Source of event</param>
        /// <param name="e">Event arguments</param>
        async void Setup(object sender, EventArgs e)
        {
            // Extract DB and JSON file and write to local storage.
            // While technically JSON file could remain a readonly bundle
            // By moving it to local storage should remove differences in
            // how platforms manage resources. While it might be worth measuring.
            // It is more likely that the json is coming from a network call.
            using (ISetupService setupService = DependencyService.Get<ISetupService>())
            {
                setupService.Setup();
                await DisplayAlert("Recommend Restart App", "It is recommended that you exit the app and relaunch it. That way the tests are not impacted by setup code and memory usage.", "Ok");
            }

            // Clean up as much as possible by forcing GC
            GC.Collect();
        }

        /// <summary>
        /// Run UI tests.
        /// </summary>
        /// <param name="sender">Source of event</param>
        /// <param name="e">Event arguments</param>
        void UITests(Object sender, EventArgs e)
        {
            ContentPage page = new BenchmarkPage()
            {
                Title = "Results - All Tests"
            };
            Navigation.PushAsync(page);
        }
    }
}
