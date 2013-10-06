using DirtSimpleDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace DirtSimpleDemo.Views
{
    public abstract class View : Page
    {
        public void ConnectViewModel(ViewModel viewModel)
        {
        }
    }
}
