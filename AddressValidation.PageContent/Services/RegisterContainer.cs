using AddressValidation.PageContent.Controllers;
using AddressValidation.PageContent.Repository;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;

namespace AddressValidation.PageContent.Services
{
    public class RegisterContainer : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IAddressRepository, AddressRepository>();
            serviceCollection.AddTransient<AddressValidationController>();

            serviceCollection.AddTransient<IEmailRepository, EmailRepository>();
            serviceCollection.AddTransient<EmailValidationController>();
        }
    }
}