using System.Collections.ObjectModel;

namespace SuperheroesMVVM.servicios
{
    class SuperheroeService
    {
        public ObservableCollection<Superheroe> GetSuperheroes()
        {
            ObservableCollection<Superheroe> ejemplos = new ObservableCollection<Superheroe>();

            Superheroe ironman = new Superheroe("Ironman", @"https://dossierinteractivo.com/wp-content/uploads/2021/01/Iron-Man.png", true, false, true),
                       kingpin = new Superheroe("Kingpin", @"https://www.comicbasics.com/wp-content/uploads/2017/09/Kingpin.jpg", false, false, false),
                       spiderman = new Superheroe(
                "Spiderman", @"https://wipy.tv/wp-content/uploads/2019/08/destino-de-%E2%80%98Spider-Man%E2%80%99-en-los-Comics.jpg",
                true, true, true);

            ejemplos.Add(ironman);
            ejemplos.Add(kingpin);
            ejemplos.Add(spiderman);

            return ejemplos;
        }
    }
}