using System;
using System.Collections.Generic;
using SOLID.LSP.Implementation;
using SOLID.LSP.Interface;
using SOLID.DIP.BLL;
using SOLID.DIP.DataAccess.Repository;

namespace SOLID
{
    class Program
    {
        private readonly IRepositoryLayer DAL;
        static void Main(string[] args)
        {
            ///////////////DIP///////////////////////////////////////////////////


       








            ///////////////LSP///////////////////////////////////////////////////
            //List<IEmployee> employees = new List<IEmployee>();
            //employees.Add(new PermanentEmployee() { ID = 1, Name = "John" });
            //employees.Add(new TemporaryEmployee() { ID = 2, Name = "Morris" });
            //employees.Add(new ContractEmployee (){ ID = 3, Name = "Asimov" });


            //foreach(var employee in employees)
            //{
            //    Console.WriteLine("info: {0} and salary : {1}", employee.ToString(), employee.GetMinimumSalary());
            //}



            /////////////////////////OCP////////////////////////////////

            //Employee employee1 = new PermanentEmployee() { ID = 1, Name = "Jason" };
            //Employee employee2 = new TemporaryEmployee() { ID = 2, Name = "John" };


            //Console.WriteLine("Employee 1 info: {0} and bonus : {1}", employee1.ToString(), employee1.CalculateBonus(100000));
            //Console.WriteLine("Employee 2 info: {0} and bonus : {1}", employee2.ToString(), employee2.CalculateBonus(100000));

        }
    }
}
