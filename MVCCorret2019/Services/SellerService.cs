﻿using MVCCorret2019.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCCorret2019.Models;
using Microsoft.EntityFrameworkCore;
using MVCCorret2019.Services.Excepctions;

namespace MVCCorret2019.Services

{
    public class SellerService
    {
        private readonly MVCCorret2019Context _context;

        public SellerService(MVCCorret2019Context context)
        {
            _context = context;
        }

        public async Task<List<Seller>> FindAllAsync()
        {
            return await _context.Seller.ToListAsync();
        }
        public async Task InsertAsync(Seller obj)
        {


            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<Seller> FindByIdAsync(int id)
        {
            return await _context.Seller.Include(obj => obj.Department).FirstOrDefaultAsync(obj => obj.Id == id);
        }
        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.Seller.FindAsync(id);
                _context.Seller.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException  )
            {
                throw new IntegrityException("You can´t Delete the Seller Because He/She has  Sales ");
            }
        }
        public async Task UpdateAsync(Seller obj)
        {
            bool hasAny = await _context.Seller.AnyAsync(x => x.Id == obj.Id);
            if (!hasAny)
            {
                throw new NotFoundException("Id Not Found");
            }
            try
            {
                _context.Update(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}
