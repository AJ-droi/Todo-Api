using System;
using Microsoft.EntityFrameworkCore;
using Todo_Api.Models;

namespace Todo_Api.Data
{
	public class ApplicationDBContext: DbContext
	{
        public ApplicationDBContext(DbContextOptions dbContextOptions)
        : base(dbContextOptions)
        {

        }

        public DbSet<Todo> Todo { get; set; }
	}
}

