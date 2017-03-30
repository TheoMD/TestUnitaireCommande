using GestionCommande.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommande.controleur
{
    public interface Controleur
    {
        void CreerProduit(string Designation, int Prix);
        void CreerClient(string Nom, string Prenom, string Mail);
        void CreerCommande(Client client, ICollection<LigneCommande> ligneCmd);

        ICollection<Client> GetClients();

        ICollection<Produit> GetProduits();

        ICollection<Commande> GetCommandes();
    }
}
