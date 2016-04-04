using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiValidationDemo.Mvc.Lib.Models
{
public class User
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public string Username { get; set; }
}
}