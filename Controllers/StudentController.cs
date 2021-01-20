using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication6.Managers.numbers;

namespace WebApplication6.Controllers
{
    public class StudentController : Controller
    {
        private readonly Number_sys _student;

        public StudentController(Number_sys student)
        {
            _student = student;
        }


        [HttpGet]
        public async Task<ViewResult> ShowStudent()
        {
            var entity = await _student.GetAll();

            return View(entity);
        }

        [HttpGet]
        public async Task<ViewResult> UpdateStudents(Guid id)
        {
            var entity = await _student.GetById(id);
            return View(entity);
        }

        public ViewResult AddNumbers()
        {
            return View();
        }


        [HttpPost]
        public async Task<ActionResult> Add(CreateDrUpdateNumber request)
        {
            await _student.AddNumbers(request);
            return RedirectToAction(nameof(ShowStudent));
        }

        [HttpPost]
        public async Task<ActionResult> Update(Guid GroupId, CreateDrUpdateNumber request)
        {
           await _student.UpdateStudents(GroupId, request);
          
            return RedirectToAction(nameof(ShowStudent));
        }

        public async Task<ActionResult> DeleteStudent(Guid id)
        {
            await _student.DeleteStudents(id);
            return RedirectToAction(nameof(ShowStudent));
        }
    }
}
