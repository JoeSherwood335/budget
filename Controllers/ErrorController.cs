using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using budget.Models;
using Microsoft.AspNetCore.Diagnostics;
using System.Collections.Generic;

namespace budget.Controllers
{

  [AllowAnonymous]
  public class ErrorController : Controller
  {


    

    public ErrorController()
    {
      
    }

    public IActionResult Index()
    {
      var exception = HttpContext.Features.Get<IExceptionHandlerFeature>();

      ViewData["statusCode"] = HttpContext.Response.StatusCode;
      ViewData["message"] = exception.Error.Message;
      ViewData["stackTrace"] = exception.Error.StackTrace; 

      
      return View();
    }

      
  } //end name Controller
} //end name Namespace.


