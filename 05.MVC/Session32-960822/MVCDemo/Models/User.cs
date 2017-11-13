using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string Location { get; set; }
        public string FavoriteFood { get; set; }
        public string EyeColor { get; set; }
        public List<string> ProgrammingLanguages { get; set; }
    }
}