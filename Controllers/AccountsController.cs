using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using Pierre.ViewModels;
using Pierre.Models;

namespace Pierre.Controllers
{
  public class AccountController : Controller
  {
    private readonly PierreContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;
    
    public AccountController (UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, PierreContext db)
    {
      _userManager = userManager;
      _signInManager = signInManager;
      _db = db;
    }
    
    public ActionResult Index()
    {
      ViewBag.Title = "Account";
      ViewBag.Subtitle = "Home";
      return View();
    }
    
    public IActionResult Register()
    {
      ViewBag.Title = "Account";
      ViewBag.Subtitle = "Register";
      return View();
    }
    
    [HttpPost]
    public async Task<ActionResult> Register (RegisterViewModel model)
    {
      var user = new ApplicationUser { UserName = model.Email};
      IdentityResult result = await _userManager.CreateAsync(user, model.Password);
      if (result.Succeeded)
      {
        return RedirectToAction("Index");
      }
      else
      {
        return View();
      }
    }
    
    public ActionResult Login()
    {
      ViewBag.Title = "Account";
      ViewBag.Subtitle = "Log In";
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> Login(LoginViewModel model)
    {
      Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, isPersistent: true, lockoutOnFailure: false);
      if (result.Succeeded)
      {
        return RedirectToAction("Index");
      }
      else
      {
        return View();
      }
    }

    [HttpPost]
    public async Task<ActionResult> LogOff()
    {
      await _signInManager.SignOutAsync();
      return RedirectToAction("Index");
    }
    
  }
}