using MiniBeer.Application.UseCases;
using MiniBeer.Application.Validators;

namespace MiniBeer.Api.IoC
{
	public static class DependencyInjection
	{
		public static IServiceCollection AddUseCases(this IServiceCollection services)
		{
			services.AddScoped<CreateBeerUseCase>();
			return services;
		}

        public static IServiceCollection AddValidators(this IServiceCollection services)
        {
            services.AddSingleton<CreateBeerValidator>();
            return services;
        }
    }
}

