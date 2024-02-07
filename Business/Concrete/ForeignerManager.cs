using MaskeTakip.Business.Abstract;
using MaskeTakip.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskeTakip.Business.Concrete
{
    internal class ForeignerManager : IApplicantService
    {
        //sonar cube
        public void ApplyForMask(Person person)
        {
            throw new NotImplementedException();
        }

        public bool CheckPerson(Person person)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
