using Hirolvaso.ViewModels;

namespace Hirolvaso.Views;

public partial class IdojarasPage : ContentPage
{
    public IdojarasPage(IdojarasViewModel viewModel)
    {
        BindingContext = viewModel;
        InitializeComponent();
    }
}