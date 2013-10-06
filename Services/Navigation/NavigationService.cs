using DirtSimpleDemo.Services.Container;
using DirtSimpleDemo.ViewModels;
using DirtSimpleDemo.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace DirtSimpleDemo.Services.Navigation
{
    public class NavigationService : INavigationService
    {
        public NavigationService(Frame frame, IContainerService containerService)
        {
            Frame = frame;
            ContainerService = containerService;
        }

        public Frame Frame { get; private set; }

        public IContainerService ContainerService { get; private set; }

        public void NavigateTo<TViewModel, TView>() where TViewModel: ViewModel where TView: View
        {
            if (Frame.Navigate(typeof(TView)))
            {
                var view = Frame.Content as View;
                var viewModel = ContainerService.Resolve<TViewModel>();

                view.ConnectViewModel(viewModel);
                viewModel.ConnectView(view);
            }
        }
    }
}
