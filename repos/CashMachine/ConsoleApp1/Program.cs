using CashMachine.Domain.Models;
using CashMachine.Domain.Services;
using CashMachine.EntityFramework;
using CashMachine.EntityFramework.Services;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IDataService<User> userService = new GenericDataService<User>(new CashMachineDbContextFactory());
            //userService.Create(new User {Name="Dmytro", Email="dmitriygorov@gmail.com", NameInUkrainianLanguage="Дмитро", Password="1" }).Wait();
            //Console.WriteLine(userService.Update(2,new User {Id=1, Name = "Dmytro", Email = "dmitriygorov@gmail.com", NameInUkrainianLanguage = "Дмитро", Password ="111" }).Result);
            //Console.WriteLine(userService.Get(2).ToString());
        }
    }
}
