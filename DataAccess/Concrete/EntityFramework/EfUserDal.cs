using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
	public class EfUserDal : EfEntityRepositoryBase<User, NorthwindContext>, IUserDal
	{
		public List<OperationClaim> GetClaims(User user)
		{
			using(var context = new NorthwindContext())
			{
				var result = from operationClaim in context.OperationClaims
							 join userOperationCLaim in context.UserOperationClaims
							 on operationClaim.Id equals userOperationCLaim.OperationClaimId
							 where userOperationCLaim.UserId == user.Id
							 select new OperationClaim
							 {
								 Id = operationClaim.Id,
								 Name = operationClaim.Name
							 };
				return result.ToList();
			}
		}
	}
}
