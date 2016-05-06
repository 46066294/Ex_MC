using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Core;
using Core.Utils;
using Domain.Product;

namespace WebStoreWcf
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ProductService : ServiceBase, IProductService
    {
        readonly IRepositoryProduct _repository;
        readonly IUnitOfWork _unitOfWork;
        public ProductService (IRepositoryProduct repository, IUnitOfWork unitOfWork) : base(unitOfWork)
	    {
            Check.NotNull(repository, "repository");
            Check.NotNull(unitOfWork, "unitOfWork");
            _repository = _repository;
            _unitOfWork = _unitOfWork;
	    }

        public IEnumerable<Product> GetAll()
        {
            return _repository.GetAll();
        }
        

    }
}
