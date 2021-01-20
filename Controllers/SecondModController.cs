using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication6.Managers.SecondMod;

namespace WebApplication6.Controllers
{
    public class SecondModController : Controller
    {
        private readonly ISecondModManager _manager;

        public SecondModController(ISecondModManager manager)
        {
            _manager = manager;
        }


        [HttpGet]
        public async Task<ViewResult> ShowSecondMod()
        {
            var entity = await _manager.GetAll();
            return View(entity);
        }

        [HttpGet]
        public async Task<ViewResult> UpdateSecondMod(Guid id)
        {
            var entity = await _manager.GetById(id);
            return View(entity);
        }

        public ViewResult AddSecondMod()
        {
            return View();
        }


        [HttpPost]
        public async Task<ActionResult> Add(CreateOrUpdateSecondMod request)
        {
            await _manager.AddSecondMod(request);
            return RedirectToAction(nameof(ShowSecondMod));
        }

        [HttpPost]
        public async Task<ActionResult> Update(Guid GroupId, CreateOrUpdateSecondMod request)
        {
            await _manager.UpdateSecondMod(GroupId, request);
            return RedirectToAction(nameof(ShowSecondMod));
        }

        [HttpGet]
        public async Task<ActionResult> DeleteSecondMod(Guid id)
        {
            await _manager.DeleteSecondMod(id);
            return RedirectToAction(nameof(ShowSecondMod));
        }
    }
}
