﻿namespace cafe.Domain.Users.DTO
{
	public class TokenDTO
	{
		public string AccessToken { get; set; } = string.Empty;

		public string RefreshToken { get; set; } = string.Empty;
	}
}

