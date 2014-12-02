using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EasiPress.Models
{
    public class User
    {
        public int Id { get; set; }

        public String Username { get; set; }

        public String Email { get; set; }

        public String Password { get; set; }

        public virtual Authority Authority { get; set; }
    }
}