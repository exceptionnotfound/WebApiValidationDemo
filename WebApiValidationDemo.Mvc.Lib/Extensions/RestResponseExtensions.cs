using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiValidationDemo.Mvc.Lib.Extensions
{
public static class RestResponseExtensions
{
    private static string ResultPropertyName = "Result";

    public static T Extract<T>(this IRestResponse response) where T : new()
    {
        var parsedObj = JObject.Parse(response.Content);
        return JsonConvert.DeserializeObject<T>(parsedObj[ResultPropertyName].ToString());
    }
}
}
