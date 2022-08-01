using System.Collections.Generic;

namespace RestWithASP_NETUdemy.Services.Implementations
{
    public interface IPersonService
    {
        IPersonService Create(IPersonService person);
        IPersonService FindByID(long id);
        List<IPersonService> FindAll();
        IPersonService Update(IPersonService person);
        void Delete(long id);
    }
}
