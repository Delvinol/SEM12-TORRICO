using Microsoft.AspNetCore.Mvc;

namespace APISemana11A.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        public readonly InvoiceContext _context;

        public StudentsController(InvoiceContext context)
        {
            _context = context; 
        }

        [HttpGet]
        public List<Student> GetAll()
        {
            return _context.Students;
        }

        [HttpPost]
        public void Insert(Student product)
        {
            _context.Students.Add(product); 
            _context.SaveChanges();
        }



        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var student = _context.Students.Find(id);
            _context.Students.Remove(student);
            _context.SaveChanges();
        }

        [HttpPut("{id}")]
        public void Edit(int id, Student updatedStudent)
        {
            var student = _context.Students.Find(id);

            student.FirstName = updatedStudent.FirstName;
            student.LastName = updatedStudent.LastName;
            student.Phone = updatedStudent.Phone;
            student.Email = updatedStudent.Email;

        _context.Students.Update(student);
            _context.SaveChanges();
        }


    }
}
