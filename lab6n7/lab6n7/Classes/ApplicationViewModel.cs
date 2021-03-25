using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace lab6n7.Classes
{
    class ApplicationViewModel
    {
        private Advert inputAdvert;

        public List<Advert> Adverts { get; set; }
        public Advert InputAdvert
        {
            get { return inputAdvert; }
            set
            {
                inputAdvert = value;
                OnPropertyChanged("InputAdvert");
            }
        }

        public ApplicationViewModel()
        {
            Adverts = Serialization.Deserialize();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

    }
}
