using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Patient_Clinic1;
using Patients;


namespace Patient_Clinic1
{
    public class InjuryController : ControllerBase
    {
        private readonly PatientDbcontext _context;
        public InjuryController(PatientDbcontext context)
        {
            _context = context;
        }
    }
       
    
}