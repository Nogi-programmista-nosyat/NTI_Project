using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace window3
{
    public struct user
    {
        public int id;
        public string name;
        public int sex;
        public string position;
        public int experience;
        public string password;
        public string login;
        public int perm_level;
        public void nul() { id = 0; name = ""; sex = 0; position = ""; experience = 0; password = ""; login = ""; perm_level = 0; }
    };
}
