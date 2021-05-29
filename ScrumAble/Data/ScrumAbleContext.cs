using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ScrumAble.Models;

namespace ScrumAble.Data
{
    public class ScrumAbleContext : DbContext
    {
        public ScrumAbleContext (DbContextOptions<ScrumAbleContext> options)
            : base(options)
        {
        }

        public DbSet<ScrumAble.Models.Users> Users { get; set; }
    }
}
