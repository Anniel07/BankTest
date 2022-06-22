
using Microsoft.Extensions.DependencyInjection;
using BankTest.UoW;

namespace Advice_API.IoC
{
    public static class BankDependecyInjection
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>(); // added unit of work
        }
    }
}
