using System.Collections.Generic;
using System;
using System.Linq;


namespace MVCCorret2019.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();
        public Department()
        {

        }

        public Department(int id, string name)
        {
            Id = id;
            this.name = name;
        }

        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }
        public double TotalSales(DateTime initial, DateTime final)
        {

            return Sellers.Sum(seller => seller.Totalsales(initial, final));
        }

    }
}
