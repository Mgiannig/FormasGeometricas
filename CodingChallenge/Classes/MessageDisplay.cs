using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodingChallenge.Classes
{
    public class MessageDisplay
    {

        public enum MessageType
        {
            Success,
            Warning,
            Error
        }

        public static void SetMessage(string Message, Exception ex, Models.MessageDisplay.MessageType type)
        {
            SetMessage(new Models.MessageDisplay(Message, ex, type));
        }

        public static void SetMessage(string Message, Exception ex, Models.MessageDisplay.MessageType type, string key)
        {
            SetMessage(new Models.MessageDisplay(Message, ex, type, key));
        }

        public static void SetMessage(Models.MessageDisplay MessageDisplay)
        {
            HttpContext.Current.Session["MessageDisplay"] = MessageDisplay;
        }

        public static string showMessage(bool showAlways = false)
        {

            if (HttpContext.Current.Session["MessageDisplay"] != null)
            {
                if (showAlways || !Common.HideContent)
                {
                    Models.MessageDisplay oMessageDisplay = (Models.MessageDisplay)HttpContext.Current.Session["MessageDisplay"];
                    HttpContext.Current.Session["MessageDisplay"] = null;
                    return oMessageDisplay.ShowMessage();
                }
            }
            return "";
        }
    }
}