using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BookManagerSystem
{
    public class CMannager_Manager
    {
        public string ptGetPath                         { get; private set; } = string.Empty;
        public CManagerInfo_Update ptGetManagerData     { get; private set; } = null;

        private PManagerList m_oManagerList;

        public CMannager_Manager()
        {
            this.ptGetPath      = @"D:\JCG\BOOK_MANAGER_NEW\Database\DB_Manager00.xml";
            this.m_oManagerList = new PManagerList();
        }

        public bool fnCreateData()
        {
            try
            {
                if(File.Exists(ptGetPath))
                {
                    if((m_oManagerList = SCommonUtil.fsXMLtoObject<PManagerList>(ptGetPath)) != null)
                    {
                        if(this.ptGetManagerData == null)
                        {
                            this.ptGetManagerData = new CManagerInfo_Update(m_oManagerList);
                            return true;
                        }
                    }
                }

                return false;
            }
            catch(Exception ex)
            {
                Debug.WriteLine($"Manager xml data create error, exception : {ex.ToString()}");
                return false;
            }
        }

        public bool fnLogin_InfoCheck(string p_sID, string p_sPassWord)
        {
            if(this.ptGetManagerData.ptGetManagerDic.Count > 0)
            {
                foreach (var oItem in this.ptGetManagerData.ptGetManagerDic.Values)
                {
                    if(oItem.ptGetManagerInfo.ptPetManagerItem.ptPetID          == p_sID.Trim() &&
                       oItem.ptGetManagerInfo.ptPetManagerItem.ptPetPassword    == p_sPassWord.Trim())
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool fnGetFindDataInfo(string p_sVal, out CManagerItemInfo p_oManagerItemInfo)
        {
            p_oManagerItemInfo = null;

            if(this.ptGetManagerData.ptGetManagerDic.Count > 0)
            {
                //....
                foreach (var oItem in this.ptGetManagerData.ptGetManagerDic.Keys)
                {
                    if(p_sVal.Trim() == oItem)
                    {
                        if(this.ptGetManagerData.ptGetManagerDic.TryGetValue(oItem, out var p_oObject))
                        {
                            p_oManagerItemInfo = new CManagerItemInfo(p_oObject.ptGetManagerInfo);
                            return true;
                        }
                    }
                }

                //....Value 값으로 Key 찾기
                foreach (var oItem in this.ptGetManagerData.ptGetManagerDic.Values)
                {
                    if(oItem.ptGetManagerInfo.ptPetManagerItem.ptPetCode        == p_sVal ||
                       oItem.ptGetManagerInfo.ptPetManagerItem.ptPetID          == p_sVal ||
                       oItem.ptGetManagerInfo.ptPetManagerItem.ptPetManagerName == p_sVal ||
                       oItem.ptGetManagerInfo.ptPetManagerItem.ptPetPassword    == p_sVal ||
                       oItem.ptGetManagerInfo.ptPetManagerItem.ptPetPhone       == p_sVal)
                    {
                        p_oManagerItemInfo = new CManagerItemInfo(oItem.ptGetManagerInfo);
                        return true;
                    }
                }

            }

            return false;

        }
    }
}
