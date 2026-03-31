using deduplicator.Views;
using deduplicator.ViewModels;

using System.Configuration;
using System.Data;
using System.Windows;

namespace deduplicator
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        { 

        }
    }

}
