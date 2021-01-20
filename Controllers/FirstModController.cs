using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication6.Managers.FirstMod;

namespace WebApplication6.Controllers
{
    public class FirstModController : Controller
    {
        private readonly IFirstModManager _manager;

        public FirstModController(IFirstModManager manager)
        {
            _manager = manager;
        }


        [HttpGet]
        public async Task<ViewResult> ShowFirstMod()
        {
            var entity = await _manager.GetAll();
            return View(entity);
        }

        [HttpGet]
        public async Task<ViewResult> UpdateFirstMod(Guid id)
        {
            var entity = await _manager.GetById(id);
            return View(entity);
        }

        public ViewResult AddFirstMod()
        {
            return View();
        }


        [HttpPost]
        public async Task<ActionResult> Add(CreateOrUpdateFirstMod request)
        {
            await _manager.AddFirstMod(request);
            return RedirectToAction(nameof(ShowFirstMod));
        }

        [HttpPost]
        public async Task<ActionResult> Update(Guid GroupId, CreateOrUpdateFirstMod request)
        {
            await _manager.UpdateFirstMod(GroupId, request);
            return RedirectToAction(nameof(ShowFirstMod));
        }

        [HttpGet]
        public async Task<ActionResult> DeleteFirstMod(Guid id)
        {
            await _manager.DeleteFirstMod(id);
            return RedirectToAction(nameof(ShowFirstMod));
        }
    }
}
