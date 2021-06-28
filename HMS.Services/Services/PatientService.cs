using HMS.DBO.Models;
using HMS.Services.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Services.Services
{
    public class PatientService : IPatient<Patient, int>
    {
        private HospitalManagementContext context;

        public PatientService(HospitalManagementContext c)
        {
           
            context = c;
        }
        public async Task<Patient> CreateAsync(Patient entity)
        {
            var res = await context.Patient.AddAsync(entity);
            await context.SaveChangesAsync();
            return res.Entity; // newly created entity object
        }

        public async Task<bool> DeleteAsync(int id)
        {
            try
            {
                var recordToDelete = await context.Patient.FindAsync(id);
                if (recordToDelete == null) return false;

                context.Patient.Remove(recordToDelete);
                await context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<IEnumerable<Patient>> GetAsync()
        {
            var result = await context.Patient.ToListAsync();
            return result;
        }

        public async Task<Patient> GetAsync(int id)
        {
            try
            {
                var result = await context.Patient.FindAsync(id);
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<Patient> UpdateAsync(int id, Patient entity)
        {
            try
            {
                var result = await context.Patient.FindAsync(id);
                if (result == null) throw new Exception($"Record not found, update operation is failed");



                result.Fname = entity.Fname;
                result.Fname = entity.Lname;
                result.Email = entity.Email;
                result.Dob = entity.Dob;
                result.ContactNumber = entity.ContactNumber;
                result.Age = entity.Age;
                result.Gender = entity.Gender;
                result.Title = entity.Title;
                result.Race = entity.Race;
                result.Ethinicity = entity.Ethinicity;
                result.LanguagesKnown = entity.LanguagesKnown;
                result.HomeAddress = entity.HomeAddress;
                result.EmergencyFname = entity.EmergencyFname;
                result.EmergencyLname = entity.EmergencyLname;
                result.Relationship = entity.Relationship;
                result.EmergencyEmail = entity.EmergencyEmail;
                result.EmergencyAddress = entity.EmergencyAddress;
                result.EmergencyMobileNo = entity.EmergencyMobileNo;
                result.TypeofAllergies = entity.TypeofAllergies;
                result.IsAllergyFatal = entity.IsAllergyFatal;

                // modify the record 
                //context.Entry(result).State = EntityState.Modified;
                await context.SaveChangesAsync();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
