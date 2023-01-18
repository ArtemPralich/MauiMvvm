using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiMvvm.Model
{
	public class Employee
	{
		public string Name { get; set; }
		public string Image { get; set; }

		public Company Company { get; set; }
	}
}
