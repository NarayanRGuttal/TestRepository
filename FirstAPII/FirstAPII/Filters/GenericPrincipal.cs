using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Principal;

namespace FirstAPII.Filters
{
    public class GenericPrincipal : IPrincipal 
    {
        IIdentity identityGlobal;
        public GenericPrincipal(IIdentity identity, string nu)
        {
            identityGlobal = identity;
        }

       public IIdentity Identity { get
            {
                return identityGlobal;
            }
        }

        //
        // Summary:
        //     Determines whether the current principal belongs to the specified role.
        //
        // Parameters:
        //   role:
        //     The name of the role for which to check membership.
        //
        // Returns:
        //     true if the current principal is a member of the specified role; otherwise, false.
       public bool IsInRole(string role)
        {
            return true;
        }
    }
}