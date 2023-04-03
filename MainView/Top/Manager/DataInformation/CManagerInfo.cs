using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagerSystem
{
    public class CManagerItemInfo
    {
        public PManagerInfo ptGetManagerInfo { get; private set; }

        public CManagerItemInfo(PManagerInfo p_oManagerInfo)
        {
            this.ptGetManagerInfo = p_oManagerInfo;    
        }
    }

    public class CManagerInfo_Update : AManagerInfo
    {
        public PManagerList ptGetManagerList                        { get; private set; }
        public Dictionary<string, CManagerItemInfo> ptGetManagerDic { get; private set; } = null; // Key : ID

        public int ptGetManagerCount                                { get; private  set; } = 0;

        public CManagerInfo_Update(PManagerList p_oManagerList)
        {
            this.ptGetManagerList   = p_oManagerList;

            if (this.ptGetManagerDic == null)
            {
                this.ptGetManagerDic = new Dictionary<string, CManagerItemInfo>();
            }
        }

        public override bool fnSetInit()
        {
            try
            {
                if(this.ptGetManagerList.ptPetManagerList.Count > 0)
                {
                    if(this.ptGetManagerCount != 0) { this.ptGetManagerCount = 0; }

                    foreach (var oItem in this.ptGetManagerList.ptPetManagerList)
                    {
                        this.ptGetManagerDic.Add(oItem.ptPetManagerItem.ptPetID, new CManagerItemInfo(oItem));
                        ptGetManagerCount++;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine($"Manager data load exception : {ex.ToString()}");
                return false;
            }

            return true;
        }

    }

    


}
