using Entities.Account;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using WebMVC.Areas.Admin.ViewModels;

namespace ETIT.Areas.Admin.Controllers;

[Area("Admin")]
[Authorize(Roles = "Admin")]
public class UsersController : Controller
{
    private readonly UserManager<AppUser> _userManager;

    public UsersController(UserManager<AppUser> userManager)
    {
        _userManager = userManager;
    }

    // GET: UserController
    public async Task<IActionResult> Index()
    {
        List<UserVM> userVMs = new List<UserVM>();
        var users = await _userManager.Users.ToListAsync();
        if (users == null) return Problem("Not Found");
        foreach (AppUser user in users)
        {
            userVMs.Add(new UserVM
            {
                Id = user.Id,
                Address = user.Address,
                Email = user.Email,
                Phone = user.PhoneNumber,
                Roles = (await _userManager.GetRolesAsync(user))
            });
        }
        return View(userVMs);
    }

    public async Task<IActionResult> ChangeRole(string id, string role = "User")
    {
        AppUser user = await _userManager.FindByIdAsync(id);
        if (user == null) return Problem("Not Found");
        IList<string> roles = await _userManager.GetRolesAsync(user);
        if (!roles.Contains(role))
        {
            foreach (var item in roles)
                await _userManager.RemoveFromRoleAsync(user, item);
            await _userManager.AddToRoleAsync(user, role);
        }
        return RedirectToAction(nameof(Index));

    }
}
