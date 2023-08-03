using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patients;

namespace Application.IRepositories
{
    public interface IPatientRepository:IBaseRepository<Patient>
    {
        Task<Patient> Addasync(Patient entity);
        Task<Patient> Updateasync(Patient entity);
    }
}
