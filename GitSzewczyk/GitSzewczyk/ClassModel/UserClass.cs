using System;
using System.Collections.Generic;
using System.Text;

namespace GitSzewczyk.ClassModel
{
    public class UserClass
    {
        public UserClass(string @class, string path)
        {
            Class = @class;
            Path = path;
        }

        public string Class { get; set; }
        public string Path { get; set; }
    }
}
