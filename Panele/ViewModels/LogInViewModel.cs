using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Panele.Models
{
	public class LogInViewModel
	{
		[Required]
		[Display(Name = "Nazwa użytkownika")]
		[DataType(DataType.Text)]
		public string Login { get; set; }

		[Required]
		[Display(Name = "Hasło")]
		[DataType(DataType.Password)]
		public string Password { get; set; }
	}
}