﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WpfApp1
{
    internal class AppContext : DbContext
    {
        public DbSet<Classroom> Classrooms { get; set; }
        public AppContext() : base("DefaultConnection") { }
    }
}
