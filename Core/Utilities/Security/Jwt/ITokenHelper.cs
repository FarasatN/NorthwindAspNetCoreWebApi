using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Core.Utilities.Security.Jwt
{
	public interface ITokenHelper
	{
		AccessToken CreateToken (User token, List<OperationClaim> operationClaims);
	}
}
