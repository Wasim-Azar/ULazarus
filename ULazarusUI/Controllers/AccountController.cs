using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using ULazarusUI.Models;
using ULazarusData.ViewModel;
using ULazarusData.Models;

public class AccountController : Controller
{
    private readonly SignInManager<ApplicationUser> _signInManager;
    private readonly UserManager<ApplicationUser> _userManager;

    public AccountController(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
    {
        _signInManager = signInManager;
        _userManager = userManager;
    }

    // -------------------------
    // GET: /Account/Login
    // Displays login form
    // -------------------------
    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    // -------------------------
    // POST: /Account/Login
    // Authenticates user
    // -------------------------
    [HttpPost]
    public async Task<IActionResult> Login(LoginViewModel model)
    {
        if (!ModelState.IsValid)
            return View(model);

        var user = await _userManager.FindByEmailAsync(model.Email);
        if (user == null)
        {
            ModelState.AddModelError("", "Invalid login attempt."); // User not found (or email incorrect)
            return View(model);
        }

        var result = await _signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false);
        if (result.Succeeded)
            return RedirectToAction("Index", "Home");

        //ModelState.AddModelError("", "Invalid login attempt.");
        //return View(model);

        if (result.IsLockedOut)
        {
            ModelState.AddModelError("", "Account locked out.");
        }
        else if (result.IsNotAllowed)
        {
            ModelState.AddModelError("", "Login not allowed (e.g., email not confirmed).");
        }
        else if (result.RequiresTwoFactor)
        {
            ModelState.AddModelError("", "Two-factor authentication required.");
        }
        else
        {
            ModelState.AddModelError("", "Invalid login attempt (incorrect password)."); // Default for other failures
        }

        return View(model);
    }

    // -------------------------
    // GET: /Account/Logout
    // Signs out user
    // -------------------------
    public async Task<IActionResult> Logout()
    {
        await _signInManager.SignOutAsync();
        await HttpContext.SignOutAsync(IdentityConstants.ApplicationScheme);

        return RedirectToAction("Index", "Home");
    }

    // -------------------------
    // GET: /Account/AccessDenied
    // Displays access denied message
    // -------------------------
    public IActionResult AccessDenied()
    {
        return View();
    }
}
