using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiValidationDemo.Mvc.Lib.Models
{
public class ResponsePackage
{
    public List<string> Errors { get; set; }

    public object Result { get; set; }

    public bool HasErrors
    {
        get
        {
            if (Errors != null)
            {
                return Errors.Any();
            }
            return false;
        }
    }
    public ResponsePackage(object result, List<string> errors)
    {
        Errors = errors;
        Result = result;
    }
}
}