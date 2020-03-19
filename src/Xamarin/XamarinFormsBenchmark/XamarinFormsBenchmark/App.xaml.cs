    using Xamarin.Forms;
using XamarinFormsBenchmark.Pages;

namespace XamarinFormsBenchmark
{
    /// <summary>
    /// App for Xamarin.Forms Benchmark cross platform app.
    /// </summary>
    public partial class App :Application
    {
        /// <summary>
        /// Constructor of the App
        /// </summary>
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }
    }
}
