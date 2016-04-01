using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiValidationDemo.Mvc.Lib.Models;

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

        public static T Extract<T>(this ResponsePackage response) where T : new()
        {
            var parsedObj = JObject.Parse(response.Result.ToString());
            return JsonConvert.DeserializeObject<T>(parsedObj.ToString());
        }

        public static T Extract<T>(this IRestResponse response, string propertyName) where T : new()
        {
            var parsedObj = JObject.Parse(response.Content);
            return JsonConvert.DeserializeObject<T>(parsedObj[propertyName].ToString());
        }

        public static string ExtractValue(this IRestResponse response, string propertyName)
        {
            var parsedString = JObject.Parse(response.Content);
            return parsedString[propertyName].ToString();
        }
    }
}
