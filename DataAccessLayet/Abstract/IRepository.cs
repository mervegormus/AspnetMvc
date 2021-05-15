using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayet.Abstract
{
    public interface IRepository<T>
    {//Doğru kullanım
        List<T> List();

        void Insert(T p);

        //silinecek ögeyi bulduruyoruz
        T Get(Expression<Func<T, bool>> filter);

        void Delete(T p);

        void Update(T p);

        //Şartlı listeleme için aşağıdaki fonk yazıldı
        List<T> List(Expression<Func<T, bool>> filter);

    }
}
