using System;

namespace XamarinFormsBenchmark.Services
{
    /// <summary>
    /// Interface to be implemented by platform specific executable.
    /// </summary>
    public interface ISetupService : IDisposable
    {
        /// <summary>
        /// Extract DB and write to local storage.
        /// </summary>
        void Setup();
    }
}