using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Asp_Scaffolding_test_1.Models
{
	public class StoreContext : DbContext
	{
		public DbSet<Product> Products { get; set; }
		public DbSet<Category> Categories { get; set; }
		// Non utilisé, il s'agit d'un test
		public DbSet<Item> Items { get; set; }
	}
}