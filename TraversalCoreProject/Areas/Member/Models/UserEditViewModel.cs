using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace TraversalCoreProject.Areas.Member.Models
{
	public class UserEditViewModel
	{
        [Required(ErrorMessage = "Bu Kısım Boş Bırakılamaz!!!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Bu Kısım Boş Bırakılamaz!!!")]
        public string Surname { get; set; }
		public string Username { get; set; }
        [Required(ErrorMessage = "Bu Kısım Boş Bırakılamaz!!!")]
        public string Email { get; set; }
		public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Bu Kısım Boş Bırakılamaz!!!")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Bu Kısım Boş Bırakılamaz!!!")]
        [Compare("Password", ErrorMessage = "Şifreler Uyumlu Değil")]
		public string ConfirmPassword { get; set; }
		public string ImageUrl { get; set; }
        [Required(ErrorMessage = "Bu Kısım Boş Bırakılamaz!!!")]
        public IFormFile Image{ get; set; }
	}
}
