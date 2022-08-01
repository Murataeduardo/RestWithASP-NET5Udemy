using RestWithASP_NETUdemy.Model;
using System.Collections.Generic;

namespace RestWithASP_NETUdemy.Services.Implementations
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindByID(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);
    }
}
