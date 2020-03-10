using System;
namespace XamarinFormsBenchmark.Services
{
    /// <summary>
    /// An enum that defines if the datasource is database or json source.
    /// </summary>
    public enum DataSource
    {
        /// <summary>
        /// The source of data is from a database.
        /// </summary>
        Database,
        /// <summary>
        /// The source of the data is from a source that returnss JSON.
        /// </summary>
        JSON
    }
}
