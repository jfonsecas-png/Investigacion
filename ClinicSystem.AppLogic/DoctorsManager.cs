using ClinicSystem.DataAccess.Crud;
using ClinicSystem.DTO;

namespace ClinicSystem.AppLogic
{
    public class DoctorsManager : IDoctorsManager
    {
        private readonly DoctorCrud _doctorCrud;

        public DoctorsManager(DoctorCrud doctorCrud)
        {
            _doctorCrud = doctorCrud;
        }

        public async Task<List<Doctor>> GetAllDoctorsAsync()
        {
            return await _doctorCrud.GetAllAsync();
        }

        public async Task CreateDoctorAsync(Doctor doctor)
        {
            await _doctorCrud.CreateAsync(doctor);
        }
    }
}