using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public partial class produit
{
    public int reference { get; set; }
    public string designation { get; set; }
    public int quantite { get; set; }
    public char descriptif { get; set; }
    public float prix_unitaire_ht { get; set; }
    public int stock { get; set; }
    public int poids_piece { get; set; }
}