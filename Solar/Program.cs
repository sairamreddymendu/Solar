﻿using System;
using System.IO;
using System.Reflection;
using log4net;
using log4net.Config;
using Microsoft.Extensions.DependencyInjection;
using Solar.Constants;
using Solar.Domain.Services;
using Solar.Domain.Services.Interfaces;
using Solar.Utilities;

namespace Solar
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            //The ConfigureServices function configures the services.
            ConfigureServices(serviceCollection);
            
            //The RunServiceOperations function executes the code that can create the outputs.
            RunServiceOperations(serviceCollection);
        }

        private static void RunServiceOperations(IServiceCollection serviceCollection)
        {
            var serviceProvider = serviceCollection.BuildServiceProvider();

            //The service provider gets the services.
            var screenOutputService = serviceProvider.GetService<IOutputService>();

            try
            {
                Console.WriteLine("OutputAllPlanetsAndTheirAverageMoonTemperatureToConsole");
                screenOutputService.OutputAllPlanetsAndTheirAverageMoonTemperatureToConsole();

                // screenOutputService.OutputAllPlanetsAndTheirAverageMoonGravityToConsole();
                
                // screenOutputService.OutputAllMoonsAndTheirMassToConsole();
                
                // screenOutputService.OutputAllPlanetsAndTheirMoonsToConsole();
            }
            catch (Exception exception)
            {
                //The users and developers can see the thrown exceptions.
                Logger.Instance.Error($"{LoggerMessage.ScreenOutputOperationFailed}{exception.Message}");
                Console.WriteLine($"{ExceptionMessage.ScreenOutputOperationFailed}{exception.Message}");
                System.Diagnostics.Debug.WriteLine($"{ExceptionMessage.ScreenOutputOperationFailed}{exception.Message}");
            }
            finally
            {
                Logger.Instance.Info("data logged Successfully");
            }

            serviceProvider.Dispose();
        }

        private static void ConfigureServices(IServiceCollection serviceCollection)
        {
            //The function configures all the services.
            XmlConfigurator.Configure(LogManager.GetRepository(Assembly.GetEntryAssembly()),
                new FileInfo(ConfigurationFileName.Logger));
            serviceCollection.AddHttpClient<HttpClientService>();
            serviceCollection.AddSingleton<IPlanetService, PlanetService>();
            serviceCollection.AddSingleton<IOutputService, OutputService>();
            serviceCollection.AddSingleton<IMoonService, MoonService>();
        }
    }
}
