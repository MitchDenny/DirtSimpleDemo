using DirtSimpleDemo.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirtSimpleDemo.ViewModels
{
    public abstract class ViewModel
    {
        public View View { get; private set; }

        public void ConnectView(View view)
        {
        }
    }
}
