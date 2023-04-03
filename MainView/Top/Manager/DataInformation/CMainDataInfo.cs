using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagerSystem
{
    public class CMainDataInfo
    {
        public PMainInfo ptGetMainInfo { get; private set; }

        public CMainDataInfo(PMainInfo p_oMainData = null)
        {
            this.ptGetMainInfo = p_oMainData;
        }
    }

    public class CMainInfo_Update
    {
        public PMainList ptGetMainList                          { get; private set; }
        public Dictionary<string, CMainDataInfo> ptGetMainDic   { get; private set; } = null;

        public int ptGetListCount { get; private set; }

        public CMainInfo_Update(PMainList p_oMainList)
        {
            this.ptGetMainList = p_oMainList;

            if (this.ptGetMainDic == null)
            {
                this.ptGetMainDic = new Dictionary<string, CMainDataInfo>();
            }
        }

        public bool fnSetInit()
        {
            try
            {
                if (this.ptGetMainList.ptPetMainList.Count > 0)
                {
                    if (this.ptGetListCount != 0) { this.ptGetListCount = 0; }

                    foreach (var oItem in this.ptGetMainList.ptPetMainList)
                    {
                        this.ptGetMainDic.Add(oItem.PMainStore.ptPetStoreCode, new CMainDataInfo(oItem));
                        ptGetListCount++;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine($"Main data load exception : {ex.ToString()}");
                return false;
            }

            return true;
        }
    }
}
