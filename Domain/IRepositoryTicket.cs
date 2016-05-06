using System.Data.Entity;
using System.Collections.Generic;
using System.Collections;
using Core;

namespace Domain.Ticket
{
    public interface IRepositoryTicket
    {
        Ticket Add(Ticket ticket);
        Ticket Get(int id);
        IEnumerable<Ticket> GetAll();
    }
}
