using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcInfo
{
    public partial class Utilisateur
    {
        public List<string> GetRoles
        {
            get { return RoleUtilisateurs1.Where(i => i.IsDeleted == 0).Select(t => t.Nom).ToList(); }
        }

    }
}
