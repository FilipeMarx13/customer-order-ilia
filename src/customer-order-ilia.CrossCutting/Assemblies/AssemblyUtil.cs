using System.Collections.Generic;
using System.Reflection;

namespace customer_order_ilia.CrossCutting.Assemblies
{
    public static class AssemblyUtil
    {
        public static IEnumerable<Assembly> GetCurrentAssemblies()
        {
            return new Assembly[]
            {
                Assembly.Load("customer-order-ilia.Api"),
                Assembly.Load("customer-order-ilia.Application"),
                Assembly.Load("customer-order-ilia.Domain"),
                Assembly.Load("customer-order-ilia.Infrastructure"),
                Assembly.Load("customer-order-ilia.CrossCutting")
            };
        }
    }
}
