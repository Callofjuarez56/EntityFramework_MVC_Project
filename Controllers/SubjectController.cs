using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication6.Managers.Subjects;

namespace WebApplication6.Controllers
{
    public class SubjectController : Controller
    {
      
        private readonly ISubjectManager _manager;

        public SubjectController(ISubjectManager manager)
        {
            _manager = manager;
        }


        [HttpGet]
        public async Task<ViewResult> ShowSubj()
        {
            var entity = await _manager.GetAll();
            return View(entity);
        }

        [HttpGet]
        public async Task<ViewResult> UpdateSubj(Guid id)
        {
            var entity = await _manager.GetById(id);
            return View(entity);
        }

        public ViewResult AddSubj()
        {
            return View();
        }


        [HttpPost]
        public async Task<ActionResult> Add(CreateOrUpdateSubjRequest request)
        {
            await _manager.AddSubj(request);
            return RedirectToAction(nameof(ShowSubj));
        }

        [HttpPost]
        public async Task<ActionResult> Update(Guid GroupId, CreateOrUpdateSubjRequest request)
        {
            await _manager.UpdateSubj(GroupId, request);
            return RedirectToAction(nameof(ShowSubj));
        }

        [HttpGet]
        public async Task<ActionResult> DeleteSubj(Guid id)
        {
            await _manager.DeleteSubj(id);
            return RedirectToAction(nameof(ShowSubj));
        }
    }
    

}
