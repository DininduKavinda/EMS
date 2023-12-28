using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Utility
{
    public static class Session
    {
        public static int GetUserEmployeeId(HttpContext context)
        {
            return context.Session.GetInt32("UserEmployeeId") ?? 0;
        }  

        public static void SetUserEmployeeId(HttpContext context, int userEmployeeId)
        {
            context.Session.SetInt32("UserEmployeeId", userEmployeeId);
        }
    }
}
