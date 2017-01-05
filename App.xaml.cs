using CefSharp;
using System.Windows;

namespace cefrunner {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application {

        public App() {
            Cef.Initialize(new CefSettings());
        }

    }
}
