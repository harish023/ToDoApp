using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Todo.Infrastructure.Entities
{
    public class ToDoAppDbContext : DbContext
    {

        public ToDoAppDbContext(DbContextOptions<ToDoAppDbContext> options): base(options)
        {            
        }

        public DbSet<User> Users { get; set; } 
    }
}
