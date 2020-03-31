using System;
using MySql.Data.MySqlClient;
using Dapper;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connexion = new MySqlConnection("database=sucrerie; server=127.0.0.1; user id=root; pwd=");

            try
            {
                connexion.Open();
            }
            catch
            {
                MessageBox.Show("Echec de le connection");
            }
            var sql2 = "SHOW TABLES";
            var DTShow = connexion.Query<string>(sql2).ToList();
            var CBBTest = new List<ComboValue>();
            foreach (String lib in DTShow)
            {
                CBBTest.Add(new ComboValue() { Table = lib });
            }
            MaGrid.DataSource = null;
            CBBGenre.DataSource = DTShow;
            CBBGenre.DisplayMember = "Libellé";
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            MySqlConnection connexion = new MySqlConnection("database=sucrerie; server=127.0.0.1; user id=root; pwd=");
            var sql = "SELECT * FROM " + CBBGenre.Text;
            switch (CBBGenre.Text)
            {
                case "client":
                    var ContexteClient = connexion.Query<client>(sql).ToList();
                    MaGrid.DataSource = ContexteClient;
                    break;
                case "commande":
                    var ContexteCommande = connexion.Query<commande>(sql).ToList();
                    MaGrid.DataSource = ContexteCommande;
                    break;
                case "commission":
                    var ContexteCommission = connexion.Query<commission>(sql).ToList();
                    MaGrid.DataSource = ContexteCommission;
                    break;
                case "ligne_commande":
                    var ContexteLigneCommande = connexion.Query<lignecommande>(sql).ToList();
                    MaGrid.DataSource = ContexteLigneCommande;
                    break;
                case "produit":
                    var ContexteProduit = connexion.Query<produit>(sql).ToList();
                    MaGrid.DataSource = ContexteProduit;
                    break;
                case "vendeur":
                    var ContexteVendeur = connexion.Query<vendeur>(sql).ToList();
                    MaGrid.DataSource = ContexteVendeur;
                    break;
            }
        }
    }
}