using MaskeTakip.Business.Concrete;
using MaskeTakip.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskeTakip
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program created;");
            Person person1 = new Person();

            person1.FirstName = "Nur";
            person1.LastName = "Vural";
            person1.DateOfBirthYear = 1998;
            person1.NationalIdentity =  1111;


            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
        }
    }
}
