﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAppUnitTest.Models
{
	public class EmployeeModel
	{	
		public int ID { get; set; }

		[StringLength(70, MinimumLength = 3)]

		public string Name { get; set; }
		[Display(Name = "Joining Date")]
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",

		ApplyFormatInEditMode = true)]
		public DateTime JoiningDate { get; set; }
		[Range(22, 60)]
		public int Age { get; set; }
	}

	public class EmpDBContext: DbContext {
		public EmpDBContext()
		{

		}

		public DbSet<EmployeeModel> Employees { get; set; }

	}
}