using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
	public interface IUserService
	{
		List<OperationClaim> GetClaims(User user);
		void Add(User user);
		User GetByMail(string mail);

	}
}
