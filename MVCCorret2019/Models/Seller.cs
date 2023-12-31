﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCorret2019.Models
{
    public class Seller
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} required")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0}  size should be between {2} and {1} ")]
        public String name { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [EmailAddress(ErrorMessage ="Enter a valid email")]
        [DataType(DataType.EmailAddress)]
        public String Email { get; set; }


        [Required(ErrorMessage = "{0} required")]
        [Display(Name = " Birth Date ")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [Range(100.0, 50000.0, ErrorMessage = "{0},must be from {1} to {2}")]
        [Display(Name = "Base Salary")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public Double SalaryBase { get; set; }

        public Department Department { get; set; }
        public int DepartmentId { get; set; }
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
