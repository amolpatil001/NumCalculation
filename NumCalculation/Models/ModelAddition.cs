using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NumCalculation.Models
{
	public class ModelAddition
	{
		[Required]
		public double firstValue { get; set; }

		[Required]
		public double secondValue { get; set; }
		public string total { get; set; }
	}
}