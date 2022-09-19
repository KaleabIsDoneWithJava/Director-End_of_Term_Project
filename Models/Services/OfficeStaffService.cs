using Director.Models.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace Director.Models.Services
{
    public class OfficeStaffService : EntityBaseRepository<OfficeStaff>, IOfficeStaffService
    {
        private readonly SMSContext _context;
        public OfficeStaffService(SMSContext context) : base(context)
        {
            _context = context;

           
            
            
        }
                        
         


    }
}
