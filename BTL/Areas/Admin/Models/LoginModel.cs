using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BTL.Areas.Admin.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Please type user name")]
        public string UserName
        {
            set; get;
        }
        [Required(ErrorMessage = "Please type password")]
        public string Password
        {
            set; get;
        }
        public string RememberMe
        {
            set; get;
        }
    }
}