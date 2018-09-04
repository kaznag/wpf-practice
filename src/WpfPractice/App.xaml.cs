namespace Kaznag.WpfPractice
{
    using System;
    using System.IO;
    using System.Threading;
    using System.Windows;

    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private Mutex mutex;

        private void OnApplicationStartup(object sender, StartupEventArgs e)
        {
            var createdNew = false;
            var name = string.Format(@"Global\{0}", typeof(App).Assembly.GetName().Name);

            try
            {
                this.mutex = new Mutex(true, name, out createdNew);

                if (!createdNew)
                {
                    this.mutex.Close();
                    this.mutex = null;
                    this.Shutdown();
                }
            }
            catch (Exception)
            {
                this.Shutdown();
            }
        }

        private void OnApplicationExit(object sender, ExitEventArgs e)
        {
            if (this.mutex != null)
            {
                this.mutex.ReleaseMutex();
                this.mutex.Close();
                this.mutex = null;
            }
        }
    }
}
