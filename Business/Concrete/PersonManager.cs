using MaskeTakip.Business.Abstract;
using MaskeTakip.Entities.Concrete;
using MernisServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskeTakip.Business.Concrete
{
    public class PersonManager : IApplicantService
    {
        public void ApplyForMask(Person person)
        {

        }
        public List<Person> GetList()
        {
            return null;
        }
        public bool CheckPerson(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody
                (person.NationalIdentity, person.FirstName, person.LastName, person.DateOfBirthYear)))
                .Result.Body.TCKimlikNoDogrulaResult;
        }
    }


}
