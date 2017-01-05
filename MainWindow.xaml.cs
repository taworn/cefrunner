using CefSharp.Wpf;
using System.Windows;

namespace cefrunner {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        public MainWindow() {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            var Browser = new ChromiumWebBrowser() {
            };
            Browser.Address = "http://github.com/";
            RootElement.Children.Add(Browser);
        }

    }
}
