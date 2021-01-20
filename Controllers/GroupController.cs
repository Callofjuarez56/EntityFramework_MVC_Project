using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication6.Managers.Groups;

namespace WebApplication6.Controllers
{
    public class GroupController : Controller
    {
        private readonly IGroupManager _manager;

        public GroupController(IGroupManager manager)
        {
            _manager = manager;
        }

        public ViewResult HomePage()
        {
            return View();
        }

        [HttpGet]
        public async Task<ViewResult> ShowGroups()
        {
            var entity = await _manager.GetAll();

            return View(entity);
        }

        [HttpGet]
        public async Task<ViewResult> UpdateGroup(Guid id)
        {
            var entity = await _manager.GetById(id);
            return View(entity);
        }

        public ViewResult AddGroup()
        {
            return View();
        }


      [HttpPost]
      public async Task<ActionResult> Add(CreateOrUpdateGroupRequest request)
      {
            await _manager.AddGroup(request);
            return RedirectToAction(nameof(ShowGroups));
      }

      [HttpPost]
      public async Task<ActionResult> Update(Guid GroupId, CreateOrUpdateGroupRequest request)
        {
            await _manager.UpdateGroup(GroupId, request);
           // await _manager.DeleteGroup(GroupId);
            return RedirectToAction(nameof(ShowGroups));
        }

        [HttpGet]
        public async Task<ActionResult> DeleteGroup(Guid id)
        {
            await _manager.DeleteGroup(id);
            return RedirectToAction(nameof(ShowGroups));
        }

    }
}
