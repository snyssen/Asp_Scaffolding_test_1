using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Asp_Scaffolding_test_1.Models
{
	public class Product
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public int CategoryID { get; set; }
		public Decimal? UnitPrice { get; set; }
		public int UnitsInStock { get; set; }

		public virtual Category Category { get; set; }
	}
}