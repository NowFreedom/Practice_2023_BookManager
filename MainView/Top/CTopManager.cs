using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagerSystem
{
    public class CTop_ManagerCare
    {
        public CMannager_Manager ptPetManager_Manager { get; set; } = null;

        public CTop_ManagerCare()
        {

        }

        public bool fnCreatManager_Manager()
        {
            if(this.ptPetManager_Manager == null)
            {
                this.ptPetManager_Manager = new CMannager_Manager();
                if(!this.ptPetManager_Manager.fnCreateData())
                {
                    return false;
                }
            }

            return true;
        }
    }
}
