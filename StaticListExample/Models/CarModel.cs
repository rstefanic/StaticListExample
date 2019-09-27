using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StaticListExample.Models
{
	public class CarModel
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int id { get; set; }
		public string name { get; set; }

		[Required,DatabaseGenerated(DatabaseGeneratedOption.Computed)]
		public DateTime DateAdded { get; set; }
	}
}
