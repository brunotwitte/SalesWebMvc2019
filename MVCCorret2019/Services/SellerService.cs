﻿using MVCCorret2019.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCCorret2019.Models;
namespace MVCCorret2019.Services

{
    public class SellerService
    {
        private readonly MVCCorret2019Context _context;

        public  SellerService(MVCCorret2019Context context)
        {
            _context = context;
        }

        public  List<Seller> FindAll ()
        {
            return _context.Seller.ToList();
        }
        public void Insert (Seller obj) {

           
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Seller  FindById (int id)
        {
            return _context.Seller.FirstOrDefault(obj => obj.Id == id);
        }
        public void Remove (int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        } 
    }
}
