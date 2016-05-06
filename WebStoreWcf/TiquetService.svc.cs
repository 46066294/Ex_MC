using Domain.Ticket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Core;
using Core.Utils;
using Domain.Ticket;

namespace WebStoreWcf
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service2" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service2.svc o Service2.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class TiquetService : ServiceBase, ITiquetService
    {
        readonly IRepositoryTicket _repository;
        readonly IUnitOfWork _unitOfWork;
        public TiquetService(IRepositoryTicket repository, IUnitOfWork unitOfWork) : base(unitOfWork) 
        {
            Check.NotNull(repository, "repository");
            Check.NotNull(unitOfWork, "unitOfWork");
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public Ticket Add(Ticket ticket)
        {
            foreach(var item in ticket.TicketDetails)
            {
                item.Price = item.Product.Price;
            }

            var customerNew = _repository.Add(ticket);
            SaveChanges();
            return customerNew;
        }

        public Ticket Update(int id, TicketDetail invoice) 
        {
            var oldInvoice = Get(id);
            if (oldInvoice == null) 
            {
                throw new NullReferenceException("invoice es nulo");
            }
            oldInvoice.TicketDetails = invoice.TicketDetails;
            SaveChanges();
            return oldInvoice;

        }

        public Ticket Delete(int id)
        {
            var invoice = Get(id);
            _repository.Remove(invoice);
            SaveChanges();
            return invoice;
        }

        public IEnumerable<Ticket> GetAll() 
        {
            return _repository.GetAll().ToList();
        }

        public Ticket Get(int id) 
        {
            return _repository.Get(id);
        }

    }
        
}
