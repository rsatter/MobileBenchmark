The goal of the app is to test performance across multiple platforms and
cross platform frameworks. For more information see https://github.com/rsatter/MobileBenchmark/wiki/Test-Requirements.

This app is deliberately very simple and does not use dependency injection or
the latest external framework unless where needed to complete tests. External
components are
* Newtonsoft.JSON
* Sqlite

The app is designed for testing. A test is derived from the abstract class
XamarinFormsBenchmark.Tests.Test.