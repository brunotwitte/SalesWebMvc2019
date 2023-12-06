using MVCCorret2019.Data;
using MVCCorret2019.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace MVCCorret2019.Services
{
    public class SalesRecordService
    {
        private readonly MVCCorret2019Context _context;

        public SalesRecordService(MVCCorret2019Context context)
        {
            _context = context;
        }
        public async  Task <List<SalesRecord>> FindByDateAsync(DateTime? minDate, DateTime? maxdate)
        {
            var result = from obj in _context.SalesRecords select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }
            if (maxdate.HasValue)
            {
                result = result.Where(x => x.Date <= maxdate.Value);
            }
            return  await result
                .Include(x => x.Seller)
                .Include(x => x.Seller.Department)
                 .OrderByDescending(x => x.Date)
                .ToListAsync();
        }

    }
}
