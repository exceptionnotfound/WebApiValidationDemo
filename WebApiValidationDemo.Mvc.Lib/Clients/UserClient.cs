using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using WebApiValidationDemo.Mvc.Lib.Models;

namespace WebApiValidationDemo.Mvc.Lib.Clients
{
public class UserClient : ClientBase
{
    public UserClient(ModelStateDictionary modelstate) : base(modelstate)
    {
    }

    public List<User> GetAll()
    {
        RestRequest request = new RestRequest("users/all");

        return Execute<List<User>>(request);
    }

    public void Add(User user)
    {
        RestRequest request = new RestRequest("users/add", Method.POST);
        request.AddJsonBody(user);
        Execute(request);
    }
}
}
