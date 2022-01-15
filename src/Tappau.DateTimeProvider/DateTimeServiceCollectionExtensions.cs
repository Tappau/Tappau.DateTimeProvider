using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Tappau.DateTimeProvider.Abstractions;

namespace Tappau.DateTimeProvider
{
    public static class DateTimeServiceCollectionExtensions
    {
        /// <summary>
        /// Add a simple implementation of <seealso cref="IDateTimeProvider"/> to collection as <see cref="ServiceLifetime.Singleton"/>
        /// </summary>
        /// <param name="services">Collection of services</param>
        /// <exception cref="ArgumentNullException">If <param name="services"></param> is not initialised</exception>
        public static IServiceCollection AddDateTimeProvider(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            services.TryAddSingleton<IDateTimeProvider, DateTimeProvider>();

            return services;
        }

        /// <summary>
        /// Add a simple implementation of <seealso cref="IDateTimeOffsetProvider"/> to collection as <see cref="ServiceLifetime.Singleton"/>
        /// </summary>
        /// <param name="services">Collection of services</param>
        /// <exception cref="ArgumentNullException">If <param name="services"></param> is not initialised</exception>
        public static IServiceCollection AddDateTimeOffsetProvider(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            services.TryAddSingleton<IDateTimeOffsetProvider, DateTimeOffsetProvider>();

            return services;
        }
    }
}