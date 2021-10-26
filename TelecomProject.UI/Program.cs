using System;
using TelecomProject.Data;
using TelecomProject.Domain;

namespace TelecomProject.UI
{
    class Program
    {
        private static UserContext _context = new UserContext();
        static void Main(string[] args)
        {
            AddData();
        }

        
        static void AddData()
        {
        //    _context.People.Add(new Person
        //    {
        //        Name = "Testing2",
        //        Password = "Pass2"                
        //    });
        //    _context.SaveChanges();
        //    _context.Plans.Add(new Plan
        //    {
        //        Device_limit = 5,
        //        Cost = 22.99,
        //        Name = "Dual plan",
        //        PersonId = 1
        //    });
        //    _context.SaveChanges();
        //    _context.Devices.Add(new Device
        //    {
        //        Phone_type = "Samsung",
        //        Phone_number = 1234567899,
        //        PersonId = 1,
        //        PlanId = 1
        //    }); 

        //    _context.SaveChanges();
        //}
        
    }
}
