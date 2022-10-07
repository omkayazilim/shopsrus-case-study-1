

using Microsoft.Extensions.DependencyInjection;
using Serilog;
using shopsrus.Infrastructure;

namespace shopsrus.Applications
{
    public class ServicesBase
    {
        
        protected readonly IAppDbContext _context;
        protected readonly ILogger _logger;
        public ServicesBase(IServiceProvider provider)
        {
          _context=provider.GetRequiredService<IAppDbContext>();
          _logger=Log.ForContext<ServicesBase>(); 


        }
    }

}

