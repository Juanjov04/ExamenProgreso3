namespace ExamenProgreso3;

public partial class BuscadorView : ContentPage
{
	public BuscadorView()
	{
		InitializeComponent();
        BindingContext = new BuscadorViewModel();
    }
}