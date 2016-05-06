using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Core;
using Core.Utils;

namespace WebStoreWcf
{
    public class ServiceBase : IDisposable
    {
        readonly IUnitOfWork _unitOfWork;
        public ServiceBase(IUnitOfWork unitOfWork)
        {
            Check.NotNull(unitOfWork, "unitOfWork");
            _unitOfWork = unitOfWork;
        }

        public void SaveChanges()
        {
            return _unitOfWork.SaveChanges();
        }

        public void Dispose()
        {
            _unitOfWork.Dispose();
        }
    }
}