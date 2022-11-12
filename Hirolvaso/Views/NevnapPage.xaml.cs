using Hirolvaso.ViewModels;

namespace Hirolvaso.Views;

public partial class NevnapPage : ContentPage
{
    public NevnapPage(NevnapViewModel viewModel)
    {
        BindingContext = viewModel;
        InitializeComponent();
    }
}