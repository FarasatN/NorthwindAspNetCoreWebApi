using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Constants
{
	public static class Messages
	{

		public static string ProductAdded = "Product successfuly added";
		public static string ProductUpdated = "Product successfuly updated";
		public static string ProductDeleted = "Product successfuly deleted";

		public static string CategoryAdded = "Category successfuly added";
		public static string CategoryUpdated = "Category successfuly updated";
		public static string CategoryDeleted = "Categorry successfuly deleted";

		public static string UserNotFound = "User not found";
		public static string PasswordError = "Password error";
		public static string SuccessfulLogin = "Successfuly logon";
		public static string UserAlreadyExists = "This user already exists";
		public static string UserRegistered = "User successfuly registered";
		internal static string AccessTokenCreated = "Access token successfuly created";
	}
}
