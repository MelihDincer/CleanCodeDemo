using CleanCodeDemo.Entities.Abstract;
using CleanCodeDemo.Entities.Concrete;

namespace CleanCodeDemo.Business.Abstract
{
    public abstract class BaseProcedureManager : IProductService
    {
        public virtual void Sell(Product product, Officer officer)
        {
        }
        public virtual void Sell(Product product, Student student)
        {
        }
    }
}
