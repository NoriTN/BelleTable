using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public partial class commande
{
    public int numero { get; set; }
    public int code_vendeur { get; set; }
    public int code_client { get; set; }
    public DateTime date_livraison { get; set; }
    public DateTime date_commande { get; set; }
    public float total_ht { get; set; }
    public float total_tva { get; set; }
    public int etat { get; set; }
}
