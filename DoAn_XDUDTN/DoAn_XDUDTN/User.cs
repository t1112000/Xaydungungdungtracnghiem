using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_XDUDTN
{
    static class User
    {
        public static string id { get; set; }
        public static string username { get; set; }

        public static void create(string user, string name)
        {
            id = user;
            username = name;
        }
    }
}
