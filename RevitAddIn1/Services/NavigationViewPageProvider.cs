using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpf.Ui.Abstractions;

namespace RevitAddIn1.Services
{

    /// <summary>
    /// Service that provides pages for navigation.
    /// </summary>
    public sealed class NavigationViewPageProvider(IServiceProvider serviceProvider) : INavigationViewPageProvider
    {
        public object? GetPage(Type pageType)
        {
            return serviceProvider.GetService(pageType);
        }
    }
}
