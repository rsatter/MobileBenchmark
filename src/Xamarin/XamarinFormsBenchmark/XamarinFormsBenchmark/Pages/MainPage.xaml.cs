using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

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
            ContentPage page = new TestsPage()
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
            ContentPage page = new TestsPage()
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
            ContentPage page = new TestsPage()
            {
                Title = "Results - All Tests"
            };
            Navigation.PushAsync(page);
        }

        /// <summary>
        /// Run UI tests.
        /// </summary>
        /// <param name="sender">Source of event</param>
        /// <param name="e">Event arguments</param>
        void UITests(Object sender, EventArgs e)
        {
            ContentPage page = new TestsPage()
            {
                Title = "Results - All Tests"
            };
            Navigation.PushAsync(page);
        }
    }
}
