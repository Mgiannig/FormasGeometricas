using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace CodingChallenge.Models
{
    public class MessageDisplay
    {

        public enum MessageType
        {
            Success,
            Warning,
            Error
        }

        public string message { get; set; }

        public Exception ex { get; set; }

        public MessageType messageType { get; set; }

        public string Key { get; set; } = "";

        public MessageDisplay() { }

        public MessageDisplay(string _message, Exception _ex, MessageType _messageType)
        {
            this.message = _message;
            this.ex = _ex;
            this.messageType = _messageType;
        }

        public MessageDisplay(string _message, Exception _ex, MessageType _messageType, string _Key)
        {
            this.message = _message;
            this.ex = _ex;
            this.messageType = _messageType;
            this.Key = _Key;
        }


        public string ShowMessage()
        {
            if (string.IsNullOrEmpty(this.message))
            {
                return string.Empty;
            }
            StringBuilder sb = new StringBuilder();
            string headerDiv = "<div id=\"alert-message\" role=\"alert\" class=\"alert alert-{0} alert-dismissible fade in\">";

            switch (this.messageType)
            {
                case MessageType.Error:
                    headerDiv = String.Format(headerDiv, "danger");
                    break;
                case MessageType.Success:
                    headerDiv = String.Format(headerDiv, "success");
                    break;
                case MessageType.Warning:
                    headerDiv = String.Format(headerDiv, "warning");
                    break;
            }

            sb.Append(headerDiv);
            sb.Append("<button aria-label=\"Close\" data-dismiss=\"alert\" class=\"close\" type=\"button\"><span aria-hidden=\"true\">×</span></button>");
            sb.Append("<p>" + this.message + "</p>");
            sb.Append("</div>");
            if (this.ex != null)
            {
                sb.Append("<!-- " + this.ex.Message);
                if (this.ex.InnerException != null)
                {
                    sb.Append("<br>Inner exception: " + this.ex.InnerException.Message);
                }

                if (!string.IsNullOrEmpty(this.ex.StackTrace))
                {
                    sb.Append("<br>Stack trace: " + this.ex.StackTrace);
                }

                sb.Append("-->");
            }
            return sb.ToString();
        }
    }
}