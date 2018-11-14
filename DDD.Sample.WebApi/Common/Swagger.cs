using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DDD.Sample.WebApi
{
    public class Swagger
    {
        public static string GetXmlCommentsPath()
        {
            return string.Format("{0}/bin/DDD.Sample.WebApi.XML", System.AppDomain.CurrentDomain.BaseDirectory);
        }
    }
}