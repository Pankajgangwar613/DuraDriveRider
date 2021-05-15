using System;
using System.Collections.Generic;
using System.Text;

namespace DuraDriveRider.Helpers
{
   public class Urls
    {
        public static string BASE_URL = "https://162.241.87.160/adventure/api/";
        public static string Auth_BASE_URL = BASE_URL + "users/";

        //Auth Urls
        public static string SignUpUrl = "register";
        public static string Sign_In_Url = "login";
        public static string Get_Country_list_Url = "countries";
        public static string Forgot_Password_Url = "forgot-password";
    }
}
