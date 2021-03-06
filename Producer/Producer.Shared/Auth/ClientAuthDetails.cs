﻿namespace Producer.Auth
{
	public class ClientAuthDetails
	{
		public ClientAuthProviders ClientAuthProvider { get; set; }

		public string Name { get; set; }

		public string GivenName { get; set; }

		public string FamilyName { get; set; }

		public string Username { get; set; }

		public string Email { get; set; }

		public string Token { get; set; }

		public string AuthCode { get; set; }

		public string AvatarUrl { get; set; }

		public override string ToString ()
		{
			var sb = new System.Text.StringBuilder ("\n\nClientAuthDetails\n");
			sb.Append ("  ClientAuthProvider".PadRight (22));
			sb.Append ($"{ClientAuthProvider}\n");
			sb.Append ("  Name".PadRight (22));
			sb.Append ($"{Name}\n");
			sb.Append ("  GivenName".PadRight (22));
			sb.Append ($"{GivenName}\n");
			sb.Append ("  FamilyName".PadRight (22));
			sb.Append ($"{FamilyName}\n");
			sb.Append ("  Username".PadRight (22));
			sb.Append ($"{Username}\n");
			sb.Append ("  Email".PadRight (22));
			sb.Append ($"{Email}\n");
			sb.Append ("  Token".PadRight (22));
			sb.Append ($"{Token}\n");
			sb.Append ("  AuthCode".PadRight (22));
			sb.Append ($"{AuthCode}\n");
			sb.Append ("  AvatarUrl".PadRight (22));
			sb.Append ($"{AvatarUrl}\n");
			return sb.ToString ();
		}
	}
}
