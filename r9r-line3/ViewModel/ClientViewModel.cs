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
    class ClientViewModel : INotifyPropertyChanged
    {
        Donnee db = new Donnee();
        private client _Model;
        private List<client> lesClients;
        private List<voyage> lesVoyages = new List<voyage>();
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
            //MessageBox.Show(db.clients.ToString());
        }
        public ClientViewModel()
        {
            GetLesClients();
        }
        public List<voyage> GetVoyages(client leClient)
        {
            var resultatcli = from commande in db.commandes
                           where commande.IDCLIENT== leClient.IDCLIENT
                      select commande;
            //commande lescom = resultatcli.ToList()[0];
            List<commande> lescom = resultatcli.ToList();
            foreach()
                //faire un foreach pour recuperer les details de chaque commande
            var resultatdet = from detailler in db.detaillers
                              where detailler.IDCOMMANDE== lescom.IDCOMMANDE
                              select detailler;
            List<detailler> lesdet = resultatdet.ToList();

            

            foreach(detailler det in lesdet)
            {
                var lesvoy = from voyage in db.voyages
                             where voyage.IDVOYAGE == det.IDVOYAGE
                            select voyage;
                voyage levoyage = lesvoy.ToList()[0];
                this.lesVoyages.Add(levoyage);
            }

            return this.lesVoyages;

        }
        public client getLeClient(int i)
        {
           var cli =
           from client in db.clients
           where client.IDCLIENT == i
           select client;


           /* var cli = from client in db.clients
                      select client;*/
            //this._Model = cli.ToList()[0];
            return (client) cli.ToList()[0];
        }

        public client getLeClient(string nom, string prenom)
        {
            var cli =
            from client in db.clients
            where client.NOMCLIENT == nom 
            where client.PRENOMCLIENT == prenom
            select client;


            /* var cli = from client in db.clients
                       select client;*/
            //this._Model = cli.ToList()[0];
            return (client)cli.ToList()[0];
        }
        public client getLeClient()
        {
            return this._Model;
        }
        public void setLeClient(client lecli)
        {
            this._Model = lecli;
            OnPropertyChanged();
        }
        public List<client> GetLesClients()
        {
            var cli = from client in db.clients
                      select client;
            this.lesClients = cli.ToList();
            return this.lesClients;
        }

        public void SetLesClients(List<client> lesClis)
        {
            lesClients = lesClis;
            OnPropertyChanged();
        }
        public void Update(client leClient)
        {
            MessageBox.Show(leClient.IDCLIENT + " " + leClient.NOMCLIENT + " " + leClient.PRENOMCLIENT + " " + leClient.ADRESSECLIENT);
            for (int i = 0; i < db.clients.ToList().Count; i++)
            {
                if (db.clients.ToList()[i].IDCLIENT == leClient.IDCLIENT)
                {
                    db.clients.ToList()[i] = leClient;
                }
            }
            SetLesClients(GetLesClients());
            db.SaveChanges();
        }
        public bool Delete(client leClient)
        {
            bool test = false;
            int nbre = db.clients.ToList().Count;
            foreach (client a in db.clients.ToList())
            {
                if (a.IDCLIENT == leClient.IDCLIENT)
                {
                    db.clients.Remove(leClient);
                    GetLesClients().Remove(leClient);
                    break;
                }
            }
            db.SaveChanges();
            SetLesClients(GetLesClients());
            if (db.clients.ToList().Count < nbre)
            {
                MessageBox.Show("Le client leClient.IDCLIENT" + " " + leClient.NOMCLIENT + " " + leClient.PRENOMCLIENT + " " + leClient.ADRESSECLIENT + " " + "a bien été effacé!");
                test = true;
            }
            return test;
        }
        public bool Insert(client leClient)
        {
            bool test = false;
            int nbre = db.clients.ToList().Count;
            //MessageBox.Show("avant : " + nbre);
            db.clients.Add(leClient);
            GetLesClients().Add(leClient);
            db.SaveChanges();
            //db.SaveChangesAsync();
            //MessageBox.Show("apres : " + db.clients.ToList().Count);
            SetLesClients(GetLesClients());
            if (db.clients.ToList().Count > nbre)
            {
                MessageBox.Show("Le client leClient.IDCLIENT" + " " + leClient.NOMCLIENT + " " + leClient.PRENOMCLIENT + " " + leClient.ADRESSECLIENT + " " + "a bien été enregistrer!");
                test = true;
            }
            return test;
        }
       /* public ICollection<commande> GetCommandesClient()
        {
            return this._Model.commandes;
        }
        public void SetCommandesClient(ICollection<commande> lesCom)
        {
            this._Model.commandes = lesCom;
            OnPropertyChanged();
        }
       */
    }
}   