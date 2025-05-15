using System.Net.Http;
using Wpf.Ui.Appearance;
using Wpf.Ui.Controls;

namespace RevitAddIn1.ViewModels
{
    public partial class Page1ViewModel() : ObservableObject
    {
        [RelayCommand]
        public async Task Confirm()
        {
            //ApplicationThemeManager.Apply(this);
            var msgBox = new MessageBox
            {
                Title = "WPF UI Message Box",
                Content = "Never gonna give you up, never gonna let you down Never gonna run around and desert you Never gonna make you cry, never gonna say goodbye",
            };
            ApplicationThemeManager.Apply(msgBox);
            await msgBox.ShowDialogAsync();
        }
    }
}
