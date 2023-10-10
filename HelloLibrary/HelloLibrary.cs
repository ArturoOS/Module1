using System;

namespace HelloLibrary
{
	public static class HelloLibrary
	{
		public static string HelloConcat(string username) 
		{
			if (string.IsNullOrEmpty(username))
				return "Invalid username.";
			else 
			{
				string currentTime = DateTime.Now.ToString("g");
				return $"{currentTime} Hello, {username}.";
			}
		}
	}
}
