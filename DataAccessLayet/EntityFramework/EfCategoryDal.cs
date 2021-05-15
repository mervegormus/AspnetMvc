using DataAccessLayet.Abstract;
using DataAccessLayet.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayet.EntityFramework
{
   public class EfCategoryDal:GenericRepository<Category>, ICategoryDal
    {

    }
}
