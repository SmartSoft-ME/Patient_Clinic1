using Patients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.IRepositories
{
    public interface IInjuryRepository:IBaseRepository<Injury>
    {
        Task<Injury> Addasync(Injury entity);
        Task<Injury> Updateasync(Injury entity);
    }
}

