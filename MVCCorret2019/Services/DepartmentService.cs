using MVCCorret2019.Data;
using MVCCorret2019.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVCCorret2019.Services
{
    public class DepartmentService
    {
        private readonly MVCCorret2019Context _context;

        public DepartmentService(MVCCorret2019Context context)
        {
            _context = context;
        }
        public async  Task<List<Department>> FindAllAsync()
        {
            return await  _context.Department.OrderBy (x=> x.name).ToListAsync(); 

        }

    }
}
