using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Booking.BL.ViewModels;
using Booking.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Booking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private RoleManager<IdentityRole> _roleManager{ get; }
        public AccountController(UserManager<ApplicationUser> userManager, 
            SignInManager<ApplicationUser> signInManager,
            RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

    
       
        // POST api/<AccountController>
       
        [HttpPost("SignIn")]

        public async Task<IActionResult> SignIn([FromBody] SignInVM signIn)
        {
        ApplicationUser user;
        if (signIn.UsernameOrEmail.Contains("@"))
        {
            user = await _userManager.FindByEmailAsync(signIn.UsernameOrEmail);
        }
        else
        {
            user = await _userManager.FindByNameAsync(signIn.UsernameOrEmail);
        }
        if (user == null)
        {
            ModelState.AddModelError("", "Login error");
                return NotFound();
        }
        var result = await
        _signInManager.PasswordSignInAsync(user, signIn.Password, signIn.RememberMe, true);
        if (result.Succeeded)
        { 
            return Ok(signIn);
            }
            else
            {
                ModelState.AddModelError("", "Login error");
                return NotFound();
            }
       
    }
        [HttpPost("Register")]
        public async Task<IActionResult> Register(RegisterVM register)
        {
            if (!ModelState.IsValid)
                return BadRequest("not valid");
            ApplicationUser newUser = new ApplicationUser
            {
                Email = register.Email,
                UserName = register.Username
            };
            IdentityResult result = await _userManager.CreateAsync(newUser, register.Password);
            if (!result.Succeeded)
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);

                }
                return BadRequest();
            }
            else
            {
                return Ok();
            }
        }

        public async Task<IActionResult> SignOut()
        {
            await _signInManager.SignOutAsync();
            return Ok();
        }
    }
}
