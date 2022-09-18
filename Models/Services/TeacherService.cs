﻿using Director.Models.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace Director.Models.Services
{
    public class TeacherService : EntityBaseRepository<Teacher>, ITeacherService
    {
        private readonly SMSContext _context;
        public TeacherService(SMSContext context) : base(context)
        {
            _context = context;            
        }
                        
         


    }
}
