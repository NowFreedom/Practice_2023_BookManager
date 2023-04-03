using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BookManagerSystem
{
    public class CMannager_Manager : AManager
    {
        public string ptGetPath                         { get; private set; } = string.Empty;
        public CManagerInfo_Update ptGetManagerData     { get; private set; } = null;

        private PManagerList m_oManagerList;

        public CMannager_Manager()
        {
            this.ptGetPath      = @"D:\JCG\BOOK_MANAGER_NEW\Database\DB_Manager00.xml";
            this.m_oManagerList = new PManagerList();
        }

        public override bool fnCreateData()
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

                            if(this.ptGetManagerData.fnSetInit())
                            {
                                return true;
                            }
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

        public override bool fnGetFindByKey(string p_sKey, out object p_oGetData)
        {
            p_oGetData = null;
                
            if(!this.ptGetManagerData.ptGetManagerDic.ContainsKey(p_sKey)) { return false; }

            if(this.ptGetManagerData.ptGetManagerDic.Count > 0)
            {
                //....
                foreach (var sItem in this.ptGetManagerData.ptGetManagerDic.Keys)
                {
                    if(sItem == p_sKey)
                    {
                        p_oGetData = ptGetManagerData.ptGetManagerDic[p_sKey].ptGetManagerInfo;
                        return true;
                    }
                }
            }

            return false;
        }

        public override bool fnGetFindByValue(string p_sVal, out object p_oGetData)
        {
            p_oGetData = null;

            foreach (var oitem in this.ptGetManagerData.ptGetManagerDic.Values)
            {
                if(oitem.ptGetManagerInfo.ptPetManagerItem.ptPetCode        == p_sVal ||
                   oitem.ptGetManagerInfo.ptPetManagerItem.ptPetEndDate     == p_sVal ||
                   oitem.ptGetManagerInfo.ptPetManagerItem.ptPetID          == p_sVal ||
                   oitem.ptGetManagerInfo.ptPetManagerItem.ptPetLevel       == p_sVal ||
                   oitem.ptGetManagerInfo.ptPetManagerItem.ptPetManagerName == p_sVal ||
                   oitem.ptGetManagerInfo.ptPetManagerItem.ptPetPassword    == p_sVal ||
                   oitem.ptGetManagerInfo.ptPetManagerItem.ptPetPhone       == p_sVal ||
                   oitem.ptGetManagerInfo.ptPetManagerItem.ptPetStartDate   == p_sVal)
                {
                    p_oGetData = oitem.ptGetManagerInfo;
                    return true;
                }
            }

            return false;
        }

        public bool fnLogin_InfoCheck(string p_sID, string p_sPassWord)
        {
            if (this.ptGetManagerData.ptGetManagerDic.Count > 0)
            {
                foreach (var oItem in this.ptGetManagerData.ptGetManagerDic.Values)
                {
                    if (oItem.ptGetManagerInfo.ptPetManagerItem.ptPetID         == p_sID.Trim() &&
                        oItem.ptGetManagerInfo.ptPetManagerItem.ptPetPassword   == p_sPassWord.Trim())
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        
    }
}
