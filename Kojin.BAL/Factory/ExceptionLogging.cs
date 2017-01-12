using Kojin.DAL;
using System.Linq;
using System.Web;
using context = System.Web.HttpContext;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System;
using System.Net;
using System.Net.Sockets;

namespace Kojin.BAL.Factory
{
    public static class ExceptionLogging
    {
        private static String exepurl;
        public static void SendExcepToDB(Exception exdb)
        {
            using (KojinEntities db = new KojinEntities())
            {
                try
                {
                    exepurl = context.Current.Request.Url.ToString();
                    db.ExceptionLoggingToDataBase(exdb.Message.ToString(), exdb.GetType().Name.ToString(), exdb.StackTrace.ToString(), exepurl, GetLocalIPAddress().ToString());
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("Not Found!");
        }
    }
}