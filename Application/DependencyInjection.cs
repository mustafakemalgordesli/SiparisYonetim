using Application.Features.FirmaFeatures.Commands.CreateFirma;
using Application.Features.FirmaFeatures.Queries.GetAll;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public static class DependencyInjection
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            //services.AddScoped(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
            //services.AddScoped<IPipelineBehavior<CreateProductCommand, ServiceResponse<ProductViewDto>>, ValidateCreateProductCommandBehavior>();
            //services.AddScoped<IPipelineBehavior<UpdateProductCommand, ServiceResponse<ProductViewDto>>, ValidateUpdateProductCommandBehavior>();
            //services.AddScoped<IPipelineBehavior<CreateCategoryCommand, ServiceResponse<Category>>, ValidateCreateCategoryCommandBehavior>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            //services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
