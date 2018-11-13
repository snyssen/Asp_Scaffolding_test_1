using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Asp_Scaffolding_test_1.Models
{
	public class Category
	{
		public int CategoryID { get; set; }
		public string Name { get; set; }

		public virtual ICollection<Product> Products { get; set; }
	}
}