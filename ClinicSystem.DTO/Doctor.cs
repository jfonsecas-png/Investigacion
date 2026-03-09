using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicSystem.DTO
{
    public class Doctor
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Specialty { get; set; }

        public int YearsOfExperience { get; set; }
    }
}