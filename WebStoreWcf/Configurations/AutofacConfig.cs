using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using Domain.Product;
using Domain.Ticket;
using Core;

namespace WebStoreWcf.Configurations
{
    public class AutofacConfig
    {

        public static IContainer GetContainer()
        {
            var builder = new ContainerBuilder();

            // Register your service implementations.
            builder.RegisterType<TiquetService>().As<ITiquetService>();
            builder.RegisterType<ProductService>().As<IProductService>();
            builder.RegisterType<ShopDbContext>().As<IRepositoryTicket>().As<IRepositoryProduct>();

            // Set the dependency resolver.
            return builder.Build();
        }
    }
}