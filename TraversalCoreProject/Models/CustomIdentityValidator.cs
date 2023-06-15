using Microsoft.AspNetCore.Identity;

namespace TraversalCoreProject.Models
{
	public class CustomIdentityValidator : IdentityErrorDescriber
	{
		public override IdentityError PasswordTooShort(int length)=> new IdentityError()
			{
			Code = "PasswordTooShort",
			Description = $"Parola Minimum {length} karakter olmalıdır"
			};
		public override IdentityError PasswordRequiresUpper() => new IdentityError
		{
			Code = "PasswordRequiresUpper",
			Description = $"Parolanız En az Bir Büyük Karakter İçermeli"
		};
		public override IdentityError PasswordRequiresLower() => new IdentityError
		{
			Code = "PasswordRequiresLower",
			Description = $"Parolanız En az Bir Küçük Karakter İçermeli"
		};
		public override IdentityError PasswordRequiresDigit() => new IdentityError
		{
			Code = "PasswordRequiresDigit",
			Description = $"Parolanız En az Bir Rakam İçermeli"
		};
		


	}
}
