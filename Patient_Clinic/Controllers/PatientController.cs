using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Patient_Clinic1;
using Patients;


namespace Patient_Clinic1
{
    public class PatientController : ControllerBase
    {
        private readonly PatientDbcontext _context;
        public PatientController(PatientDbcontext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<Patient> AddPatient(string name, string addresse, int age)
        {
            var newpatient = await _context.Patient.AddAsync(new Patient(name, addresse, age));
            await _context.SaveChangesAsync();
            return newpatient.Entity;
        }
        [HttpPut]
        public async Task<Patient> UpdatePatient(int id, string name, string address, int age, string injury)
        {
            var patient = await _context.Patient.FirstOrDefaultAsync(x => x.Id == id) ?? throw new Exception("not found");
            patient.update(name, address, age);
            _context.Update(patient);
            await _context.SaveChangesAsync();
            return patient;
        }
        [HttpGet]
        public async Task<List<Patient>> GetPatientsAsync()
        {
            return await _context.Patient.ToListAsync();
        }
        [HttpGet("by id")]
        public async Task<Patient> GetPatientById(int id)
        {
            return await _context.Patient.FirstOrDefaultAsync(x => x.Id == id);
        }
        [HttpDelete]
        public async Task DeletePatient(int id)
        {
            var Patient_Done_Treatement = await _context.Patient.FirstOrDefaultAsync(x => x.Id == id)
                ?? throw new Exception("doesnt exist");
            _context.Remove(Patient_Done_Treatement);
            await _context.SaveChangesAsync();

        }
    }
}