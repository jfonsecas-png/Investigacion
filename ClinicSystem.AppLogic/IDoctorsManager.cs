using ClinicSystem.DTO;

namespace ClinicSystem.AppLogic
{
    public interface IDoctorsManager
    {
        Task<List<Doctor>> GetAllDoctorsAsync();
        Task CreateDoctorAsync(Doctor doctor);
    }
}