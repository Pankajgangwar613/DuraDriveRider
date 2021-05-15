using System;
using System.Collections.Generic;
using System.Text;

namespace DuraDriveRider.Helpers
{
    public class AppConstant
    {
        public static string CheckedImage = "check.png";
        public static string UnCheckedImage = "uncheck.png";

        #region regex
        public static string EmailRegex = @"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$";
        public static string PhoneRegex = @"^(\+\d{1,2}\s)?\(?\d{3}\)?[\s.-]\d{3}[\s.-]\d{4}$";
        public static string PasswordRegex = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!% *? &])[A-Za-z\d@$!% *? &]{8,15}$";
        #endregion

        #region Colors
        public static string TabSelectedColor = "#193340";
        public static string TabUnSelectedColor = "#F6F6F6";
        public static string TabUnSelectedTextColor = "#7D807E";
        public static string WhiteColor = "#FFF";
        #endregion

        #region login 
        public static string LoginEmail = "pankajm@gmail.com";
        public static string LoginPassword = "pass@123";
        #endregion

        //Select language Culture
        public class CulturesLanguages
        {
            public static string EnglishLanguageCulture = "en-US";
            public static string ArabicLanguageCulture = "ar-Eg";
        }
    }
}