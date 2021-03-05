using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc2.Models
{
    public class Departament
    {
        public int Id { get; set; }
        public string Nome{ get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Departament()
        {
        }

        public Departament(int id, string nome, ICollection<Seller> sellers)
        {
            Id = id;
            Nome = nome;
           
        }

        public void AddSeller (Seller seller)
        {
            Sellers.Add(seller);
        }

        public double TotalSales (DateTime initial, DateTime fnal)
        {
            return Sellers.Sum(seller => seller.TotalSales(initial, fnal));


        }


    }
}
