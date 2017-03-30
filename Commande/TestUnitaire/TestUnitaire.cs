using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionCommande.controleur;
using System.Linq;
using GestionCommande.model;

namespace GestionCommande.TestUnitaire
{
    [TestClass]
    public class TestFichier
    {

        [TestMethod]

        public void TestAddClient()
        {
            Controleur controleur = new CommandeControleur();
            controleur.CreerClient("Langer", "Bebel", "Vinsbel@gmail.com");
            Assert.AreEqual("Langer", controleur.GetClients().Last().Nom);
            Assert.AreEqual("Bebel", controleur.GetClients().Last().Prenom);
            Assert.AreEqual("vinsbel@gmail.com", controleur.GetClients().Last().Mail);

        }

        [TestMethod]

        public void TestAddCommande()
        {
            Controleur controleur = new CommandeControleur();
            Client j = new Client();
            j.Id = 666;
                j.Nom = "Castor"; j.Prenom = "Janounours"; j.Mail= "Janounours@gmail.com";
            
            List<LigneCommande> lgCmd = new List<LigneCommande>();
            Commande c = new Commande();
            c.Client = j; c.LignesCommande = lgCmd; c.Id = 666;

            controleur.CreerCommande(j, lgCmd);
            Assert.AreEqual(j, controleur.GetCommandes().Last().Client);
            Assert.AreEqual(lgCmd, controleur.GetCommandes().Last().LignesCommande);


        }

        [TestMethod]

        public void TestAddProduit()
        {
            Controleur controleur = new CommandeControleur();
            controleur.CreerProduit("Téléphone portable de type bien", 666);
            Assert.AreEqual("Téléphone portable de type bien", controleur.GetProduits().Last().Designation);
            Assert.AreEqual(666, controleur.GetProduits().Last().Prix);
        }



    }
}
