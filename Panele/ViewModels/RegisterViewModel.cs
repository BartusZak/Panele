using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Panele.Models
{
	public class RegisterViewModel
	{
		[Required]
		[Display(Name = "Nazwa użytkownika")]
		[DataType(DataType.Text)]
		public string UserName { get; set; }

		[Required]
		[Display(Name = "Hasło")]
		[DataType(DataType.Password)]
		public string Password { get; set; }

		[Required]
		[Display(Name = "Potwierdź hasło")]
		[Compare("Password")]
		public string ConfirmPassword { get; set; }
	}
}