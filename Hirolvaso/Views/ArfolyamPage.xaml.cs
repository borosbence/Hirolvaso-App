using Hirolvaso.ViewModels;

namespace Hirolvaso.Views;

public partial class ArfolyamPage : ContentPage
{
    public ArfolyamPage(ArfolyamViewModel viewModel)
    {
        BindingContext = viewModel;
        InitializeComponent();
    }
}