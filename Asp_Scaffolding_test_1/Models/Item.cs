using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Asp_Scaffolding_test_1.Models
{
	public class Item
	{
		public int ID { get; set; }
		public string Name { get; set; }

		public virtual Product Product { get; set; }
	}
}