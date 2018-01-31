
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodingChallenge.Classes
{
    public class Common
    {
        //Aquí iría un método genérico que utilizaría para traducir los textos dependiendo el idioma que elija el usuario
        public static string GetWord(string key)
        {
            return key;
        }

        public static bool HideContent
        {
            get
            {
                if (HttpContext.Current.Items["HideContent"] != null)
                {
                    return Convert.ToBoolean(HttpContext.Current.Items["HideContent"]);
                }
                return false;
            }
            set
            {
                HttpContext.Current.Items["HideContent"] = value;
            }
        } 
    }
}