using appPoke.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace appPoke.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}