using System;
using Xamarin.Forms;
using XamarinFormsBenchmark.Services;

[assembly:Dependency(typeof(XamarinFormsBenchmark.iOS.Services.SetupService))]
namespace XamarinFormsBenchmark.iOS.Services
{
    public class SetupService : ISetupService
    {
        const string FILENAME = "Northwind_large.sqlite";
        const string RESOURCE_PREFIX = "XamarinFormsBenchmark.iOS";

        public void Setup()
        {
            // extract out db file from resource bundle

            // extract out json file from resource bundle
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~SetupService()
        // {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
