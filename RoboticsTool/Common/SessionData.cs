using System.Web;

namespace RoboticsTool.Common
{
    public class SessionData
    { 
        public static int TimeOutLoggedUserId
        {
            get;set;
        }
        public static string LoggedUserName
        {
            get { return HttpContext.Current.Session["LoggedUserName"] != null ? (string)HttpContext.Current.Session["LoggedUserName"] : string.Empty; }
            set { HttpContext.Current.Session["LoggedUserName"] = value; }
        }

        public static int LoggedUserID
        {
            get { return HttpContext.Current.Session["LoggedUserID"] != null ? (int)HttpContext.Current.Session["LoggedUserID"] : 0; }
            set { HttpContext.Current.Session["LoggedUserID"] = value; TimeOutLoggedUserId = value;}
        }
       
        public static int LoggedUserEmployeeID
        {
            get { return HttpContext.Current.Session["LoggedUserEmployeeID"] != null ? (int)HttpContext.Current.Session["LoggedUserEmployeeID"] : 0; }
            set { HttpContext.Current.Session["LoggedUserEmployeeID"] = value; }
        }
        public static string LoggedUserRole
        {
            get { return HttpContext.Current.Session["LoggedUserRole"] != null ? (string )HttpContext.Current.Session["LoggedUserRole"] : string.Empty; }
            set { HttpContext.Current.Session["LoggedUserRole"] = value; }
        }

        public static string LoggedUserAgentType
        {
            get { return HttpContext.Current.Session["LoggedUserAgentType"] != null ? (string)HttpContext.Current.Session["LoggedUserAgentType"] : string.Empty; }
            set { HttpContext.Current.Session["LoggedUserAgentType"] = value; }
        }
        
    }
}