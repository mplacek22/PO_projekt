﻿using System.ComponentModel.DataAnnotations;

namespace PO_project.Models
{
	public class Tryb
	{
		public int Id { get; set; }

		[Required]
		[MaxLength(40)]
		public string Name { get; set; }
	}
}
