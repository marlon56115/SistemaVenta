using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SistemaVenta.DAL.DBContext;
using Microsoft.EntityFrameworkCore;
//using SistemaVenta.DAL.Interfaces;
//using SistemaVenta.DAL.Implementacion;
//using SistemaVenta.BILL.Interfaces;
//using SistemaVenta.BILL.Implementacion;

namespace SistemaVenta.IOC
{
    public static class Dependenciaa
    {
        public static void InyectarDependencia(this IServiceCollection services, IConfiguration configuration)
        {
           services.AddDbContext<DbventaContext>(options =>
                      options.UseSqlServer(configuration.GetConnectionString("CadenaSQL")));
        }
    }
}
