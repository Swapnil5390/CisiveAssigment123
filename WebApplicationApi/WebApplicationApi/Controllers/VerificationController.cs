using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationApi.Model;
using System.Collections.Generic;
using System.Linq;

namespace WebApplicationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class VerificationController : ControllerBase
    {
        private static List<Employee> employees = new List<Employee>
    {
        new Employee { EmployeeId = 1, CompanyName = "Cisive", VerificationCode = "ABC123" },
        new Employee { EmployeeId = 2, CompanyName = "Star", VerificationCode = "DEF456" },
        new Employee { EmployeeId = 3, CompanyName = "TCS", VerificationCode = "GHI789" },
        new Employee { EmployeeId = 4, CompanyName = "Google", VerificationCode = "CBA321" }

    };

        [HttpPost("verify-employment")]
        public IActionResult VerifyEmployment([FromBody] Employee input)
        {
            var employee = employees.FirstOrDefault(e => e.EmployeeId == input.EmployeeId &&
                                                         e.CompanyName == input.CompanyName &&
                                                         e.VerificationCode == input.VerificationCode);

            return Ok(new { verified = employee != null });
        }
    }
}