using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcInfo.ucClient
{
    public static class selectedUsers
    {
        private static int id;

        public static int Id
        {
            get { return id; }
            set { id = value; }
        }

        private static string name;

        public static string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
