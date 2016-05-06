using Domain.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WebStoreWcf
{
    interface IProductService
    {
        [ServiceContract]
        public interface IProductService
        {
            [OperationContract]
            IEnumerable<Product> GetAll();
        }
    }
}
