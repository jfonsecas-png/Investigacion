using ClinicSystem.AppLogic;
using ClinicSystem.DTO;
using Microsoft.AspNetCore.Mvc;

namespace ClinicSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly IDoctorsManager _doctorsManager;

        public DoctorsController(IDoctorsManager doctorsManager)
        {
            _doctorsManager = doctorsManager;
        }

        [HttpGet("GetAll")]
        public async Task<List<Doctor>> GetAll()
        {
            return await _doctorsManager.GetAllDoctorsAsync();
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] Doctor doctor)
        {
            await _doctorsManager.CreateDoctorAsync(doctor);
            return Ok("Doctor creado correctamente");
        }
    }
}