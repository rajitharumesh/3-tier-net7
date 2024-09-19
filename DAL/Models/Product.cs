﻿using System;
namespace DAL.Models
{
	public class Product
	{
		public int Id { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
		public bool IsActive { get; set; }
	}
}

