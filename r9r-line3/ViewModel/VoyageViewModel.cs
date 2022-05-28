using r9r_line3.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace r9r_line3.ViewModel
{
    class VoyageViewModel : INotifyPropertyChanged
    {
        Donnee db = new Donnee();
        private voyage _Model;
        private List<voyage> lesVoyages;
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
            //MessageBox.Show(db.clients.ToString());
        }

        public voyage GetLeVoyage()
        {
            return this._Model;
        }

        public voyage getLeVoyage(int i)
        {
            var voy =
            from voyage in db.voyages
            where voyage.IDVOYAGE == i
            select voyage;


            /* var cli = from client in db.clients
                       select client;*/
            //this._Model = cli.ToList()[0];
            return (voyage)voy.ToList()[0];
        }

    }
}
