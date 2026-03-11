using ClinicSystem.DTO;
using Microsoft.EntityFrameworkCore;

namespace ClinicSystem.DataAccess.Crud
{
    public class DoctorCrud
    {
        private readonly ClinicDbContext _context;

        public DoctorCrud(ClinicDbContext context)
        {
            _context = context;
        }

        public async Task<List<Doctor>> GetAllAsync()
        {
            return await _context.Doctors.ToListAsync();
        }

        public async Task CreateAsync(Doctor doctor)
        {
            _context.Doctors.Add(doctor);
            await _context.SaveChangesAsync();
        }
    }
}