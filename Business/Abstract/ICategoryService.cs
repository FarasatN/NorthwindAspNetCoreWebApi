using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
	public interface ICategoryService
	{
		IDataResult<Category> GetById(int productId);
		IDataResult<List<Category>> GetList();
		IResult Add(Category category);
		IResult Update(Category category);
		IResult Delete(Category category);
	}
}
