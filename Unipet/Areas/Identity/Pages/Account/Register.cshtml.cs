using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using Unipet.Models;

namespace Unipet.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<Usuario> _signInManager;
        private readonly UserManager<Usuario> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;

        public RegisterModel(
            UserManager<Usuario> userManager,
            SignInManager<Usuario> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage = "Por favor, informe seu e-mail")]
            [Display(Name = "Email", Prompt = "E-mail")]
            public string Email { get; set; }

            [Required(ErrorMessage = "Por favor, informe sua senha")]
            [StringLength(100, ErrorMessage = "A {0} deve ter pelo menos {2} e no máximo {1} caracteres. Contendo letras e números (no mínimo 1 caracter especial e 1 letra maiúscula", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Senha", Prompt = "Senha")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirme a senha", Prompt = "Confirme a senha")]
            [Compare("Password", ErrorMessage = "As senhas não conferem!")]
            public string ConfirmPassword { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            var user = new Usuario { UserName = Input.Email, Email = Input.Email };
            var result = await _userManager.CreateAsync(user, Input.Password);
            if (ModelState.IsValid)
            {
                if (result.Succeeded)
                {
                    _logger.LogInformation("O usuário criou uma nova conta com senha.");
                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);

                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                                var callbackUrl = Url.Page(
                                    "/Account/Login",
                                    pageHandler: null,
                                    values: new { area = "Identity", userId = user.Id, code = code, returnUrl = returnUrl },
                                    protocol: Request.Scheme);
                    await _emailSender.SendEmailAsync(Input.Email, "Por favor, confirme seu email",
                    $"Para confirmar sua conta, por favor, <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clique aqui</a>.");

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("Login", new { email = Input.Email, returnUrl = returnUrl });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    }
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }

        //public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        //{
        //    returnUrl ??= Url.Content("~/");
        //    ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        //    if (ModelState.IsValid)
        //    {
        //        var user = new Usuario { UserName = Input.Email, Email = Input.Email };
        //        var result = await _userManager.CreateAsync(user, Input.Password);
        //        if (result.Succeeded)
        //        {

        //            _logger.LogInformation("O usuário criou uma nova conta com senha.");

        //            var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
        //            code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
        //            var callbackUrl = Url.Page(
        //                "/Account/Login",
        //                pageHandler: null,
        //                values: new { area = "Identity", userId = user.Id, code = code, returnUrl = returnUrl },
        //                protocol: Request.Scheme);

        //            await _emailSender.SendEmailAsync(Input.Email, "Por favor, confirme seu email",
        //                $"Para confirmar sua conta, por favor, <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clique aqui</a>.");

        //            if (_userManager.Options.SignIn.RequireConfirmedAccount)
        //            {
        //                return RedirectToPage("Login", new { email = Input.Email, returnUrl = returnUrl });
        //            }
        //            else
        //            {
        //                await _signInManager.SignInAsync(user, isPersistent: false);
        //                return LocalRedirect(returnUrl);
        //            }
        //        }
        //        foreach (var error in result.Errors)
        //        {
        //            ModelState.AddModelError(string.Empty, error.Description);
        //        }
        //    }

        //    // If we got this far, something failed, redisplay form
        //    return Page();
        //}
    }
}
