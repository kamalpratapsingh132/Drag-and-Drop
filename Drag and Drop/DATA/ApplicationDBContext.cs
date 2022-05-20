using Drag_and_Drop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drag_and_Drop.DATA
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) :base(options)
        { }

        public DbSet<Add_Pateint> Add_Pateint { get; set; }
    }
}
