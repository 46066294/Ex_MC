using Core;
using Domain.Ticket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace WebStoreWcf
{
    public interface ITiquetService
    {
        [OperationContract]
        Ticket Add(Ticket invoice);

        [OperationContract]
        Ticket Update(int id, Ticket invoice);

        [OperationContract]
        Ticket Delete(int id);

        [OperationContract]
        IEnumerable<Ticket> GetAll();

        [OperationContract]
        TicketDetail Get(int id);


    }
}
