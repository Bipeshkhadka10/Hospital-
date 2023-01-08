using Hospital.DAL;
using Hospital.model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hospital.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly HospitalDbContext db;
        public DoctorController(HospitalDbContext _db)
        {
            this.db = _db;
        }       
        // GET: api/<DoctorController>
        [HttpGet]
       public IActionResult GetDoctors()
        {
            var doctorList = db.Doctors.ToList();
            return Ok(doctorList);
        }

        // GET api/<DoctorController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DoctorController>
        [HttpPost]
        public void AddDoctor([FromBody] Doctor doc)
        {    
            

            Doctor newDoctor = new Doctor();
            newDoctor.FirstName= doc.FirstName;
            newDoctor.LastName= doc.LastName;
            newDoctor.Address= doc.Address;
            newDoctor.PhoneNumber= doc.PhoneNumber;
            newDoctor.Specilist= doc.Specilist;
            db.Add(newDoctor);
            db.SaveChanges();
            
           

        }
        
        // PUT api/<DoctorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DoctorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
