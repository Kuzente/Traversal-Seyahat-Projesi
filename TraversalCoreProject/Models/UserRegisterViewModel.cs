﻿using System.ComponentModel.DataAnnotations;

namespace TraversalCoreProject.Models
{
	public class UserRegisterViewModel
	{
		[Required(ErrorMessage ="Lütfen Adınızı Giriniz")]
        public string Name { get; set; }
		[Required(ErrorMessage = "Lütfen Soyadınızı Giriniz")]
		public string Surname { get; set; }
		[Required(ErrorMessage = "Lütfen Kullanıcı Adınızı Giriniz")]
		public string UserName { get; set; }
		[Required(ErrorMessage = "Lütfen Mailinizi Giriniz")]
		public string Mail { get; set; }
		[Required(ErrorMessage = "Lütfen Şifrenizi Giriniz")]
		public string Password { get; set; }
		[Required(ErrorMessage = "Lütfen Şifreyi Tekrar Giriniz")]
		[Compare("Password",ErrorMessage ="Şifreler Uyumlu Değil")]
		public string ConfirmPassword { get; set; }

	}
}
