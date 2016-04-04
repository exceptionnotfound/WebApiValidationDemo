using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApiValidationDemo.Mvc.Attributes;
using WebApiValidationDemo.Mvc.Lib.Clients;
using WebApiValidationDemo.Mvc.Lib.Models;

namespace WebApiValidationDemo.Mvc.Controllers
{
[RoutePrefix("users")]
public class UserController : Controller
{
    [HttpGet]
    [Route("all")]
    [Route("")]
    [Route("~/")]
    public ActionResult Index()
    {
        UserClient client = new UserClient(ModelState);
        var users = client.GetAll();
        return View(users);
    }

    [HttpGet]
    [Route("add")]
    [ImportModelState]
    public ActionResult Add()
    {
        var user = new User();
        return View(user);
    }

    [HttpPost]
    [Route("add")]
    [ExportModelState]
    public ActionResult Add(User user)
    {
        UserClient client = new UserClient(ModelState);
        client.Add(user);
        if(!ModelState.IsValid)
        {
            return RedirectToAction("Add");
        }
        return RedirectToAction("Index");
    }
}
}