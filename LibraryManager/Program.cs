using BusinessLayer.Services;
using Database.Models;
using Manager.Helpers;
using Microsoft.Extensions.DependencyInjection;
using BusinessLayer.Interfaces;
using RepositoryLayer.Repositories;
using RepositoryLayer.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.Configuration;

namespace LibraryManager
{
    internal static class Program
    {
        private static ServiceProvider _serviceProvider;
       /// <summary>
       ///  The main entry point for the application.
       /// </summary>
       [STAThread]
        static void Main()
        {

            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            _serviceProvider = serviceCollection.BuildServiceProvider();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(_serviceProvider.GetRequiredService<Menu>());
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(DataTransferObjectProfile));
            services.AddAutoMapper(typeof(BusinessObjectsProfile), typeof(DataTransferObjectProfile));
            services.AddDbContext<ManagerDbContext>(options =>
               options.UseMySql("server=localhost;database=librarymanager;user=root;password=admin;",
              // options.UseMySql("server=192.168.1.205;database=librarymanager;user=root;password=root;",
                    new MySqlServerVersion(new Version(8, 0, 21))));
  
            services.AddScoped<IUnitOfWork>(provider =>
                new UnitOfWork(provider.GetRequiredService<ManagerDbContext>()));

            services.AddScoped<UnitOfWork>();

            services.AddScoped<IAuthorService, AuthorService>();
            services.AddScoped<IBookService, BookService>();
            services.AddScoped<IPublisherService, PublisherService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IBorrowingsService, BorrowingsService>();

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IAuthorRepository, AuthorRepository>();
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<IPublisherRepository, PublisherRepository>();
            services.AddScoped<IBorrowingsRepository, BorrowingsRepository>();

            services.AddTransient<Menu>();
            
            services.AddTransient<RegistrationForm>();
            services.AddTransient<LoginForm>();
            services.AddTransient<LoggedMenuForm>();
            services.AddTransient<BookAddForm>();
            services.AddTransient<EditBookForm>();
            services.AddTransient<BooksAll>();
            services.AddTransient<BooksBorrowed>();
            services.AddTransient<ProfileForm>();
            services.AddTransient<AuthorCreateForm>();
            services.AddTransient<PublisherCreateForm>();
            services.AddTransient<DetailBookForm>();
            services.AddTransient<DetailBorrowedBookForm>();
        }
    }
}