public partial class BuscadorView : ContentPage
{
    public BuscadorView(BuscadorViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
