namespace ExamenProgreso3;

public partial class ListadoView : ContentPage
{
	public ListadoView()
	{
		InitializeComponent();
		BindingContext = new ListadoViewModel();
	}
}