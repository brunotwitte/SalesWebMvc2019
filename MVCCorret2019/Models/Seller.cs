using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCorret2019.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public String name { get; set; }
        public String Email { get; set; }
        public DateTime BirthDate { get; set; }
        public Double SalaryBase { get; set; }
        public Department Department { get; set; }
        public int DepartmentId  { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller()
        {


        }

        public Seller(int id, string name, string email, DateTime birthDate, double salaryBase, Department department)
        {
            Id = id;
            this.name = name;
            Email = email;
            BirthDate = birthDate;
            SalaryBase = salaryBase;
            Department = department;
        }

        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);

        }
        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }
        public double Totalsales(DateTime initial, DateTime final)
        {
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);

        }

    }
}
