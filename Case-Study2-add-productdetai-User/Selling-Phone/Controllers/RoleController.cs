﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Selling_Phone.Models;
using Selling_Phone.ViewModels;

namespace Selling_Phone.Controllers
{
    [Authorize(Roles = "System Admin")]
    public class RoleController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;

        public RoleController(RoleManager<IdentityRole> roleManager)
        {
            this.roleManager = roleManager;
        }
        public IActionResult Index()
        {
            var roles = roleManager.Roles;
            var model = new List<Role>();
            model = roles.Select(r => new Role()
            {
                RoleId = r.Id,
                RoleName = r.Name
            }).ToList();
            return View(model);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task <IActionResult> Create(CreateRoleViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await roleManager.CreateAsync(new IdentityRole()
                {
                    Name=model.RoleName
                });
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Role");
                }
                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(model);
        }
        [HttpGet]
        public async Task <IActionResult> Edit(string id)
        {
            var role = await roleManager.FindByIdAsync(id);
            if (role != null)
            {
                var model = new EditRoleViewModel()
                {
                    RoleId = role.Id,
                    RoleName = role.Name
                };
                return View(model);
            }
            else
            {
                return View("~/Views/Error/RoleNotFound.cshtml", id);
            }

        }
        [HttpPost]
        public async Task <IActionResult> Edit(EditRoleViewModel model)
        {
            if (ModelState.IsValid)
            {
                var role = await roleManager.FindByIdAsync(model.RoleId);
                if (role != null)
                {
                    role.Name = model.RoleName;
                    var result = await roleManager.UpdateAsync(role);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Role");
                    }
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> Delete(string id)
        {
            var role = await roleManager.FindByIdAsync(id);
            if (role != null)
            {
                var model = new DeleteRoleViewModel()
                {
                    RoleId = role.Id,
                    RoleName = role.Name
                };
                return View(model);
            }
            else
            {
                return View("~/Views/Error/RoleNotFound.cshtml", id);
            }
        }
        [HttpPost]
        public async Task<IActionResult> Delete(DeleteRoleViewModel model)
        {
            var delRole = await roleManager.FindByIdAsync(model.RoleId);
            if (delRole != null)
            {
                var result = await roleManager.DeleteAsync(delRole);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Role");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View();

        }
    }
}
