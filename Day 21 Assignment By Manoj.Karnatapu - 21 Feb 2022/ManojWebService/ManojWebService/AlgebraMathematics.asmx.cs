using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

// Author : Manoj.Karnatapu
// Purpose : Creating a Web Serice For Algebra Mathematics, using ASP.NET WEB Application(using .Net FrameWork)

// For Reference,Check Manoj Web Service Project in the same Repository.

namespace ManojWebService
{
    /// <summary>
    /// Summary description for AlgebraMathematics
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class AlgebraMathematics : System.Web.Services.WebService
    {
        [WebMethod]
        public int Factorial(int n)
        {
            int fact = 1;
            for(int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            return fact;
        }
        [WebMethod]
        public int Add(int a, int b)
        {
            return a + b;
        }

        [WebMethod]
        public int Mul(int a, int b)
        {
            return a * b;
        }

        [WebMethod]
        public int Div(int a, int b)
        {
            return a / b;
        }
    }
}
