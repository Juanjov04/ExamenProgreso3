using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ExamenProgreso3
{
    public partial class ListadoViewModel : ObservableObject
    {
        private readonly DatabaseService _databaseService;

        public ListadoViewModel(DatabaseService databaseService)
        {
            _databaseService = databaseService;
            Paises = new ObservableCollection<PaisModel>();
            CargarPaisesAsync();
        }

        public ObservableCollection<PaisModel> Paises { get; }

        public async void CargarPaisesAsync()
        {
            var paises = await _databaseService.GetPaisesAsync();
            Paises.Clear();
            foreach (var pais in paises)
            {
                Paises.Add(pais);
            }
        }
    }
}
