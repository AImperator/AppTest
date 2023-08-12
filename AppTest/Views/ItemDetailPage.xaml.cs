using System.ComponentModel;
using Xamarin.Forms;
using AppTest.ViewModels;

namespace AppTest.Views
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