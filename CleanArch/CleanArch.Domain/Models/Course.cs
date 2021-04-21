﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Models
{
	public class Course
	{
		public Int32 Id { get; set; }
		public String Name { get; set; }

		public String Description { get; set; }
		public String Image { get; set; }

	}
}
