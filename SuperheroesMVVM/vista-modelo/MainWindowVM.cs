using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SuperheroesMVVM.servicios;
using System.Collections.ObjectModel;

namespace SuperheroesMVVM
{
    class MainWindowVM : ObservableObject
    {
        private readonly ObservableCollection<Superheroe> heroes;
        private readonly SuperheroeService servicio;

        public RelayCommand SiguienteCommand { get; }
        public RelayCommand AnteriorCommand { get; }

        private Superheroe heroeActual;
        public Superheroe HeroeActual
        {
            get => heroeActual;
            set => SetProperty(ref heroeActual, value);
        }

        private int total;
        public int Total
        {
            get => total;
            set => SetProperty(ref total, value);
        }

        private int actual;
        public int Actual
        {
            get => actual;
            set => SetProperty(ref actual, value);
        }

        public MainWindowVM()
        {
            servicio = new SuperheroeService();
            SiguienteCommand = new RelayCommand(Siguiente);
            AnteriorCommand = new RelayCommand(Anterior);

            heroes = servicio.GetSuperheroes();
            HeroeActual = heroes[0];
            Total = heroes.Count;
            Actual = 1;
        }

        public void Siguiente()
        { 
            if (Actual < Total)
            {
                Actual++;
                HeroeActual = heroes[Actual - 1];
            }
        }

        public void Anterior()
        {
            if (Actual > 1)
            {
                Actual--;
                HeroeActual = heroes[Actual - 1];
            }
        }
    }
}