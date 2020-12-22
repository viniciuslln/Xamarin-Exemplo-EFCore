using Xamarin.Forms;

using XamExEF.Models;
using XamExEF.ViewModels;

namespace XamExEF.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}