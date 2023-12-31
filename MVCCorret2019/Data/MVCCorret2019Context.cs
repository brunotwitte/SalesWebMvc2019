﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCCorret2019.Models;

namespace MVCCorret2019.Data
{
    public class MVCCorret2019Context : DbContext
    {
        public MVCCorret2019Context (DbContextOptions<MVCCorret2019Context> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller  { get; set; }
        public DbSet<SalesRecord> SalesRecords { get; set; }
    }
}
