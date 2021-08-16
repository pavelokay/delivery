using Delivery.Application.Models;
using Delivery.Application.Models.Account;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.API.Areas.Identity.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<ApplicationUserModel> _userManager;
        private IPasswordHasher<ApplicationUserModel> _passwordHasher;
        private readonly ILogger<AccountController> _logger;

        public AccountController(SignInManager<ApplicationUserModel> signInManager, UserManager<ApplicationUserModel> userManager, IPasswordHasher<ApplicationUserModel> passwordHasher, ILogger<AccountController> logger, IConfiguration configuration)
        {
            _userManager = userManager;
            _passwordHasher = passwordHasher;
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] RegisterUserModel registerUser)
        {
            if (registerUser == null || !ModelState.IsValid)
            {
                return BadRequest();
            }

            var userByNameFromDB = await _userManager.FindByNameAsync(registerUser.UserName);
            if (userByNameFromDB != null)
            {
                return BadRequest();
            }
            var userByEmailFromDB = await _userManager.FindByEmailAsync(registerUser.Email);
            if (userByEmailFromDB != null)
            {
                return BadRequest();
            }


            var user = new ApplicationUserModel
            {
                Email = registerUser.Email,
                UserName = registerUser.UserName,
                PhoneNumber = registerUser.Phone,
                Address = registerUser.Address,
                FirstName = registerUser.FirstName,
                LastName = registerUser.LastName,
                CreatedAt = DateTime.Now.Date
            };

            var result = await _userManager.CreateAsync(user, _passwordHasher.HashPassword(user, registerUser.Password));

            if (!result.Succeeded)
            {
                var errors = result.Errors.Select(e => e.Description);

                return Ok(new RegisterResultModel { Errors = errors, Successful = false });
            }

            return Ok(new RegisterResultModel { Successful = true });
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //[AllowAnonymous]
        //public async Task<IActionResult> Login([FromBody] LoginUserModel user)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var result = await _signInManager.PasswordSignInAsync(user.UserName, user.Password, user.RememberMe, false);

        //        if (!result.Succeeded)
        //        {
        //            return BadRequest(new LoginResultModel { Successful = false, Error = "Username and password are invalid." });
        //        }

        //        var claims = new[]
        //        {
        //            new Claim(ClaimTypes.Name, user.UserName)
        //        };

        //        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSecurityKey"]));
        //        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
        //        var expiry = DateTime.Now.AddDays(Convert.ToInt32(_configuration["JwtExpiryInDays"]));
        //        var token = new JwtSecurityToken(
        //            _configuration["JwtIssuer"],
        //            _configuration["JwtAudience"],
        //            claims,
        //            expires: expiry,
        //            signingCredentials: creds
        //        );

        //        return Ok(new LoginResultModel { Successful = true, Token = new JwtSecurityTokenHandler().WriteToken(token) });
        //     }
        //    return BadRequest(new LoginResultModel { Successful = false, Error = "Username and password are invalid." );
        //}

        //[HttpPost]
        //public async Task<IActionResult> Logout()
        //{
        //    await _signInManager.SignOutAsync();
        //    return StatusCode(201);
        //}

        [HttpPut]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateUser(EditUserModel editUser)
        {
            if (ModelState.IsValid)
            {
                var userDB = await _userManager.FindByEmailAsync(editUser.Email);
                if (userDB != null)
                {
                    var checkPass = await _userManager.CheckPasswordAsync(userDB, editUser.OldPassword);
                    if (checkPass)
                    {
                        userDB.FirstName = editUser.FirstName;
                        userDB.LastName = editUser.LastName;
                        userDB.PhoneNumber = editUser.Phone;
                        userDB.Address.City = userDB.Address.City;
                        userDB.Address.AddressLine = userDB.Address.AddressLine;
                        userDB.Address.Country = userDB.Address.Country;
                        userDB.Address.ZipCode = userDB.Address.ZipCode;
                        userDB.Address.CompanyName = userDB.Address.CompanyName;
                        
                        if (editUser.ChangePassword)
                        {
                            await _userManager.ChangePasswordAsync(userDB, editUser.OldPassword, editUser.NewPassword);
                        }

                        return StatusCode(201);
                    }
                    return BadRequest();
                }
                return BadRequest();
            }
            return BadRequest();
        }


        [HttpDelete]
        public async Task<IActionResult> Delete(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return BadRequest();
            }
            var result = await _userManager.DeleteAsync(user);
            return StatusCode(201);
        }
    }
}
