using MaskeTakip.Business.Abstract;
using MaskeTakip.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskeTakip.Business.Concrete
{
    public class PttManager : ISupplierService
    {
        private IApplicantService _applicantService;
        public PttManager(IApplicantService applicantService) //CONSTRUCTOR NEW YAPILDIGINDA CALISIR
        {
            _applicantService = applicantService;

        }
        public void GiveMask(Person person)
        {
           
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " için maske verildi");
            }
            else
            {
                Console.WriteLine(person.FirstName + " için maske verilmedi");
            }
        }

       
    }
}
