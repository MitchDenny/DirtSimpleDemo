using DirtSimpleDemo.ViewModels;
using DirtSimpleDemo.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirtSimpleDemo.Services.Navigation
{
    public interface INavigationService
    {
        void NavigateTo<TViewModel, TView>()
            where TViewModel : ViewModel
            where TView : View;
    }
}
