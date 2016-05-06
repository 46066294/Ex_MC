using Core;

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class ShopDbContext : DbContext, IDbBase, IUnitOfWork
    {
        public ShopDbContext() : base("DefaultConection") { }

        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return Set<TEntity>();
        }
    }
}
